using System.Data.Entity;

namespace ViewToController.Models
{
    public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }

    public class PersonDBContext : DbContext
    {
        public DbSet<Person> PersonsDB { get; set; }
    }
}