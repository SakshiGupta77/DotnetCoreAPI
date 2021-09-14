using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCorePractice
{
    public class Product
    {
        [Key]
        public int id{get; set;}
        public string name{get; set;}
    }
    public class ProductContext : DbContext
    {
        private const string cs = "Host=localhost;Port=5432;User ID=postgres;Password=3238;Database=practicedb;Pooling=true";
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseNpgsql(cs);
        }

        public DbSet<Product> products{get; set;} //tablename will be in database products
    }
    public class ProductOperation
    {   
        ProductContext productContext = new ProductContext();
        public void FetchProduct(int str)
        {
            /* var find = productContext.products.Find(101);
            if (find != null)
                {
                    Console.WriteLine(find.name);
                } */

                //using (var ctx = new ProductContext())
            /* {    
                var productt = (from s in productContext.products
                where s.id == Id
                select s).FirstOrDefault<Product>();
                Console.WriteLine(productt.name);
            } */
            
                var temp = productContext.products.Where(s => s.id == str).FirstOrDefault();
                Console.WriteLine(temp.name);
        }
    }

    class Program
    {
        public static void Main()
        {
            ProductOperation product = new ProductOperation();
            product.FetchProduct(101);
        }
    }
}
