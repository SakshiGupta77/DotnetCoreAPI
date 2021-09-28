using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Custom_MiddelWare_Contacts.Models;
namespace Custom_MiddelWare_Contacts.Context
{
    public class ContactsDBContext :DbContext
    {
        public DbSet<Contacts> Contacts { get; set; }
        public ContactsDBContext(DbContextOptions<ContactsDBContext> options):base(options) 
        {

        }
        public ContactsDBContext()
        {

        }
    }
}