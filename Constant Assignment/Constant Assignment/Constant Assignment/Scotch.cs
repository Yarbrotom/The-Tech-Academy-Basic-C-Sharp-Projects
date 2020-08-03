using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Assignment
{
    public class Scotch
    {
        public Scotch(string distilery) : this(distilery, "12")
        {
            Distilery = distilery;
        }
        public Scotch(string distilery, string age)
        {
            Distilery = distilery;
            Age = age;
        }

        public string Distilery { get; set; }
        public string Age { get; set; }

    }
}
