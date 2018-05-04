using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAss_1.Models
{
    public class GuessGame
    {
        
        public int dice { get; set;}

        public string st1 { get; set; }
        public int num { get; set; }

        public int generate() {

            Random rnd = new Random();
            dice = rnd.Next(1, 101);
            return dice;

        }
    }
}