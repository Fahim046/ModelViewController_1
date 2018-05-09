using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAss_1.Models
{
    public class People
    {
        static int idCount = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public static List<People> DbPeople = new List<People>
        {
            new People() { Name = "Erik", City = "Karlshamn", PhoneNumber = "0707046474" },
            new People() { Name = "Pontus", City = "tingsryd", PhoneNumber = "070702374" },
            new People() { Name = "John", City = "London", PhoneNumber = "070734574" },
            new People() { Name = "Robin", City = "Växjö", PhoneNumber = "0707046474" },
            new People() { Name = "William", City = "Olofström", PhoneNumber = "0707046474" },
            new People() { Name = "Fahim", City = "Karlshamn", PhoneNumber = "0707046474" },
            new People() { Name = "Khan", City = "Peshawar", PhoneNumber = "0707046474" },
            new People() { Name = "Ali", City = "Karachi", PhoneNumber = "0707046474" },
            new People() { Name = "Martin", City = "Karlshamn", PhoneNumber = "0707046474" },
            new People() { Name = "Javed", City = "London", PhoneNumber = "0707046474" },
            new People() { Name = "Fahad", City = "Karlshamn", PhoneNumber = "0707046474" },
            new People() { Name = "Shakeel", City = "Karlshamn", PhoneNumber = "0707046474" },
        };

        public People()
        {
            Id = idCount++;
        }

    }
}
