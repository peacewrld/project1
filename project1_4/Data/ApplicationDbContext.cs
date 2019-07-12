using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using project1_4.Models.Account;

namespace project1_4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<CheckingAccount> CheckingAccount { get; set; }
        public DbSet<BusinessAccount> BusinessAccount { get; set; }
        public DbSet<LoanAccount> LoanAccount { get; set; }
        public DbSet<TermDepositAccount> TermDepositAccount { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Account>()
                .HasOne(u => u.ApplicationUser)
                .WithMany(a => a.Accounts)
                .HasForeignKey(k => k.UserId)
                .HasConstraintName("UserId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.Entity<Transaction>()
                .HasOne(u => u.Account)
                .WithMany(a => a.Transactions)
                .HasForeignKey(k => k.AccountId)
                .HasConstraintName("AccountId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }

    }
}
