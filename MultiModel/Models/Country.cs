using System.Data.Entity;

namespace MultiModel.Models
{
    public class Country
    {
        public int ID { get; set; }

        public string CountryName { get; set; }

        public string PhoneCode { get; set; }
    }

    public class PersonInfoDBContext : DbContext
    {
        public DbSet<Country> CountriesDB { get; set; }
        public DbSet<Person> PeopleDB { get; set; }
    }
}