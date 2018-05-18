using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAss_1.Models
{
    public class PartialPerson
    {
        public List<People> peoples;

        public PartialPerson(List<People> peoples)
        {
            this.peoples = peoples;
        }
    }
}