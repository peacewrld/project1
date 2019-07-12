using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project1_4.Data;
using project1_4.ListOfAccount;
using project1_4.Models.Account;

namespace project1_4.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public static Random random = new Random();

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Accounts
        [Authorize]
        public async Task<IActionResult> MyAccount()
        {
            string Current_UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Account.Include(a => a.ApplicationUser)
                .Where(m => m.UserId == Current_UserId && m.isActive); 

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accounts
        [Authorize]
        public async Task<IActionResult> OperationsCheckingAccount()
        {
            string Current_UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Account.Include(a => a.ApplicationUser)
                .Where(m => m.UserId == Current_UserId && m.AccountType == "Checking Account" && m.isActive);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accounts
        [Authorize]
        public async Task<IActionResult> OperationsBusinessAccount()
        {
            string Current_UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Account.Include(a => a.ApplicationUser)
                .Where(m => m.UserId == Current_UserId && m.AccountType == "Business Account" && m.isActive);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accounts
        [Authorize]
        public async Task<IActionResult> OperationsLoanAccount()
        {
            string Current_UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Account.Include(a => a.ApplicationUser)
                .Where(m => m.UserId == Current_UserId && m.AccountType == "Loan Account" && m.isActive);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accounts
        [Authorize]
        public async Task<IActionResult> OperationsTermDepositAccount()
        {
            string Current_UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            var applicationDbContext = _context.Account.Include(a => a.ApplicationUser)
                .Where(m => m.UserId == Current_UserId && m.AccountType == "Term Deposit Account" && m.isActive);

            return View(await applicationDbContext.ToListAsync());
        }


        [Authorize]
        public IActionResult Operations()
        {
            return View();
        }


        // GET: Accounts/Edit/5
        [Authorize]
        public async Task<IActionResult> Deposit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost, ActionName("Deposit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DepositConfirmed(int id, double amount)
        {
            var account = await _context.Account.FindAsync(id);
            if (account.isActive)
            {
                switch (account.AccountType)
                {
                    case "Checking Account":
                    case "Business Account":
                        account.Balance += amount;
                        Transaction transaction = new Transaction()
                        {
                            Amount = amount,
                            TransactionType = "Deposit",
                            TransactionTime = DateTime.Now,
                            AccountId = account.Id
                        };
                        _context.Add(transaction);
                        break;
                    case "Loan Account":
                        break;
                    case "Term Deposit Account":
                        break;
                    default:
                        break;
                }
                _context.Update(account);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Content("The account is not active!");
            }

            return RedirectToAction(nameof(MyAccount));
        }

        // GET: Accounts/Edit/5
        [Authorize]
        public async Task<IActionResult> Withdraw(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost, ActionName("Withdraw")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WithdrawConfirmed(int id, double amount)
        {
            var account = await _context.Account.FindAsync(id);
            Transaction transaction;

            if (account.isActive)
            {
                switch (account.AccountType)
                {
                    case "Checking Account":
                        if (amount <= account.Balance)
                        {
                            account.Balance -= amount;
                            transaction = new Transaction()
                            {
                                Amount = amount,
                                TransactionType = "Withdraw",
                                TransactionTime = DateTime.Now,
                                AccountId = account.Id
                            };
                            _context.Add(transaction);
                        }
                        else
                        {
                            return Content("Insufficient balance!");
                        }
                        break;
                    case "Business Account":
                        if (amount > account.Balance)
                        {
                            if(account.Balance < 0)
                            {
                                account.Balance -= amount * 0.035 + amount;
                            }
                            else
                            {
                                account.Balance -= (amount - account.Balance) * 0.035 + amount;
                            }
                        }
                        else
                        {
                            account.Balance -= amount;
                        }
                        transaction = new Transaction()
                        {
                            Amount = amount,
                            TransactionType = "Withdraw",
                            TransactionTime = DateTime.Now,
                            AccountId = account.Id
                        };
                        _context.Add(transaction);
                        break;
                    case "Loan Account":
                        break;
                    case "Term Deposit Account":
                        if (DateTime.Now > account.CloseDate)
                        {
                            if (amount <= account.Balance)
                            {
                                account.Balance -= amount;
                                transaction = new Transaction()
                                {
                                    Amount = amount,
                                    TransactionType = "Withdraw",
                                    TransactionTime = DateTime.Now,
                                    AccountId = account.Id
                                };
                                _context.Add(transaction);
                            }
                            else
                            {
                                return Content("Insufficient balance!");
                            }
                        }
                        else
                        {
                            return Content("Not reached the term end date!");
                        }
                        break;
                    default:
                        break;
                }
                _context.Update(account);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Content("The account is not active!");
            }

            return RedirectToAction(nameof(MyAccount));
        }

        // GET: Accounts/Edit/5
        [Authorize]
        public async Task<IActionResult> Transfer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (account == null)
            {
                return NotFound();
            }

    
            string Current_UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            var accountList = await _context.Account.Where(u => u.UserId == Current_UserId && u.isActive).ToListAsync();

            ListAccount listAccount = new ListAccount()
            {
                currentAccount = account,
                listAccount = accountList
            };
           
            return View(listAccount);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost, ActionName("Transfer")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TransferConfirmed(int id, int to_id, double amount)
        {
            bool Check1 = false;
            bool Check2 = false;

            var account = await _context.Account.FindAsync(id);
            var to_account = await _context.Account.FindAsync(to_id);

            Transaction transaction1;
            Transaction transaction2;
            
            if (account.isActive && to_account.isActive)
            {

                switch (account.AccountType)
                {
                    case "Checking Account":
                        if(amount <= account.Balance)
                        {
                            Check1 = true;
                        }
                        else
                        {
                            return Content("Insufficient balance!");
                        }
                        break;
                    case "Business Account":
                        Check1 = true;
                        break;
                    case "Term Deposit Account":
                        if(DateTime.Now >= account.CloseDate)
                        {
                            if(amount <= account.Balance)
                            {
                                Check1 = true;
                            }
                            else
                            {
                                return Content("Insufficient balance!");
                            }
                        }
                        else
                        {
                            return Content("Not reached the term end date!");
                        }
                        break;
                    case "Loan Account":
                        break;
                }

                switch (to_account.AccountType)
                {
                    case "Checking Account":
                    case "Business Account":
                        Check2 = true;
                        break;
                    case "Term Deposit Amount":
                        break;
                    case "Loan Account":
                        break;
                }

                if(Check1 && Check2)
                {
                    if(account.AccountType == "Business Account")
                    {
                        if(amount > account.Balance)
                        {
                            if(account.Balance < 0)
                            {
                                account.Balance -= amount * 0.035 + amount;
                            }
                            else
                            {
                                account.Balance -= (amount - account.Balance) * 0.035 + amount;
                            }
                        }
                        else
                        {
                            account.Balance -= amount;
                        }
                    }
                    else
                    {
                        account.Balance -= amount;
                    }

                    transaction1 = new Transaction()
                    {
                        Amount = amount,
                        TransactionType = "Transfer out",
                        TransactionTime = DateTime.Now,
                        GoalAccount = to_account.AccountNumber,
                        AccountId = account.Id
                    };

                    to_account.Balance += amount;

                    transaction2 = new Transaction()
                    {
                        Amount = amount,
                        TransactionType = "Transfer in",
                        TransactionTime = DateTime.Now,
                        GoalAccount = account.AccountNumber,
                        AccountId = to_account.Id
                    };

                    _context.Add(transaction1);
                    _context.Add(transaction2);

                    _context.Update(account);
                    _context.Update(to_account);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                return Content("The account is not active!");
            }

            return RedirectToAction(nameof(MyAccount));
        }

        // GET: Accounts/Edit/5
        [Authorize]
        public async Task<IActionResult> Payloan(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (account == null)
            {
                return NotFound();
            }


            string Current_UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
            var accountList = await _context.Account.Where(u => u.UserId == Current_UserId && u.isActive).ToListAsync();

            ListAccount listAccount = new ListAccount()
            {
                currentAccount = account,
                listAccount = accountList
            };

            return View(listAccount);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost, ActionName("Payloan")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PayloanConfirmed(int id, int from_id, double amount)
        {
            bool Check1 = false;
            bool Check2 = false;

            var account = await _context.Account.FindAsync(id);
            var from_account = await _context.Account.FindAsync(from_id);

            Transaction transaction1;
            Transaction transaction2;

            if (account.isActive && from_account.isActive)
            {

                switch (account.AccountType)
                {
                    case "Checking Account":
                        break;
                    case "Business Account":
                        break;
                    case "Term Deposit Amount":
                        break;
                    case "Loan Account":
                        if(amount <= account.Balance)
                        {
                            Check1 = true;
                        }
                        else
                        {
                            return Content("The amount is larger than the loan!");
                        }
                        break;
                }

                switch (from_account.AccountType)
                {
                    case "Checking Account":
                        if (amount <= from_account.Balance)
                        {
                            Check2 = true;
                        }
                        else
                        {
                            return Content("Insufficient balance!");
                        }
                        break;
                    case "Business Account":
                        Check2 = true;
                        break;
                    case "Term Deposit Account":
                        if (DateTime.Now >= from_account.CloseDate)
                        {
                            if (amount <= from_account.Balance)
                            {
                                Check2 = true;
                            }
                            else
                            {
                                return Content("Insufficient balance!");
                            }
                        }
                        else
                        {
                            return Content("Not reached the term end date!");
                        }
                        break;
                    case "Loan Account":
                        break;
                }

                if (Check1 && Check2)
                {
                    account.Balance -= amount;
                    transaction1 = new Transaction()
                    {
                        Amount = amount,
                        TransactionType = "Loan Paid",
                        TransactionTime = DateTime.Now,
                        GoalAccount = from_account.AccountNumber,
                        AccountId = account.Id
                    };

                    if (from_account.AccountType == "Business Account")
                    {
                        if(amount > from_account.Balance)
                        {
                            if(from_account.Balance > 0)
                            {
                                from_account.Balance -= (amount - from_account.Balance) * 0.035 + amount;
                            }
                            else
                            {
                                from_account.Balance -= (amount * 0.035) + amount;
                            }
                        }
                        else
                        {
                            from_account.Balance -= amount;
                        }
                    }
                    else
                    {
                        from_account.Balance -= amount;
                    }

                    transaction2 = new Transaction()
                    {
                        Amount = amount,
                        TransactionType = "Pay Loan",
                        TransactionTime = DateTime.Now,
                        GoalAccount = account.AccountNumber,
                        AccountId = from_account.Id
                    };

                    _context.Add(transaction1);
                    _context.Add(transaction2);

                    _context.Update(account);
                    _context.Update(from_account);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                return Content("The account is not active!");
            }

            return RedirectToAction(nameof(MyAccount));
        }



        // GET: Accounts/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }


        // GET: Accounts/Create
        [Authorize]
        public IActionResult CreateCheckingAccount()
        {
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateCheckingAccount([Bind("Id,Balance,CloseDate,UserId")] CheckingAccount account)
        {
            account.AccountNumber = random.Next(100000000, 599999999);
            account.RoutingNumber = random.Next(600000000, 999999999);
            account.Interest = 0.015;
            account.isActive = true;
            account.AccountType = "Checking Account";
            account.CreateDate = DateTime.Now;
            account.UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;
  
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyAccount));
            }
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.UserId);
            return View(account);
        }

        // GET: Accounts/Create
        [Authorize]
        public IActionResult CreateBusinessAccount()
        {
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateBusinessAccount([Bind("Id,Balance,CloseDate,UserId")] BusinessAccount account)
        {
            account.AccountNumber = random.Next(100000000, 599999999);
            account.RoutingNumber = random.Next(600000000, 999999999);
            account.Interest = 0.035;
            account.isActive = true;
            account.AccountType = "Business Account";
            account.CreateDate = DateTime.Now;
            account.UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyAccount));
            }
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.UserId);
            return View(account);
        }

        // GET: Accounts/Create
        [Authorize]
        public IActionResult CreateLoanAccount()
        {
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateLoanAccount([Bind("Id,Balance,CloseDate,UserId")] LoanAccount account)
        {
            account.AccountNumber = random.Next(100000000, 599999999);
            account.Interest = 0.12;
            account.isActive = true;
            account.AccountType = "Loan Account";
            account.CreateDate = DateTime.Now;
            account.UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyAccount));
            }
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.UserId);
            return View(account);
        }

        // GET: Accounts/Create
        [Authorize]
        public IActionResult CreateTermDepositAccount()
        {
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id");
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateTermDepositAccount([Bind("Id,Balance,CloseDate,UserId")] TermDepositAccount account)
        {
            account.AccountNumber = random.Next(100000000, 599999999);
            account.Interest = 0.05;
            account.isActive = true;
            account.AccountType = "Term Deposit Account";
            account.CreateDate = DateTime.Now;
            account.UserId = _context.Users.Where(x => x.Email == User.Identity.Name).FirstOrDefault().Id;

            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyAccount));
            }
            ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", account.UserId);
            return View(account);
        }





        // GET: Accounts/Edit/5
        [Authorize]
        public async Task<IActionResult> Transaction(int? id, DateTime? StartDay, DateTime? EndDay)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (account == null)
            {
                return NotFound();
            }

            var transactionList = await _context.Transactions.Where(u => u.AccountId == account.Id && u.TransactionTime >= StartDay && u.TransactionTime <= EndDay).ToListAsync();
            transactionList.Reverse();

            return View(transactionList);
        }


        // GET: Accounts/Details/5
        [Authorize]
        public async Task<IActionResult> AccountDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Close/5
        [Authorize]
        public async Task<IActionResult> Close(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .Include(a => a.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Close/5
        [Authorize]
        [HttpPost, ActionName("Close")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CloseConfirmed(int id)
        {
            var account = await _context.Account.FindAsync(id);
            switch (account.AccountType)
            {
                case "Checking Account":
                case "Business Account":
                    if (account.Balance == 0)
                    {
                        account.isActive = false;
                    }
                    else
                    {
                        return Content("The balance is not 0!");
                    }
                    break;
                case "Loan Account":
                case "Term Deposit Account":
                    if (account.Balance == 0)
                    {
                        if(DateTime.Now < account.CloseDate)
                        {
                            account.isActive = false;
                        }
                        else
                        {
                            return Content("Not reached the term/payoff date!");
                        }
                    }
                    else
                    {
                        return Content("The balance is not 0!");
                    }
                    break;
                default:
                    break;
            }
            _context.Update(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyAccount));
        }

        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.Id == id);
        }
    }
}
