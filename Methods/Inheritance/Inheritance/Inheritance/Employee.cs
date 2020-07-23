using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
