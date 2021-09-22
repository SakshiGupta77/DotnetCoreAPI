using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ContactRepository.Models;
namespace ContactRepository.Context
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> contacts{get;set;}
        public ContactDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
    }
}