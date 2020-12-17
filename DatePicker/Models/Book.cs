using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity; //Install EntityFramework by using NuGet packages
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Models
{
    public class Book
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }


    public class BookDBContext : DbContext
    {
        public DbSet<Book> BookDB { get; set; }
    }
}