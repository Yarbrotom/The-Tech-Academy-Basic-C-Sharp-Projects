using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee<T> : Person//, IQuittable
    {
        public int id { get; set; }
        public List<T> things { get; set; }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        //public static bool operator== (Employee employeeOne, Employee employeeTwo)
        //{
        //    bool check = employeeOne.id == employeeTwo.id;
        //    return check;
        //}

        //public static bool operator!= (Employee employeeOne, Employee employeeTwo)
        //{
        //    bool check = !(employeeOne.id == employeeTwo.id);
        //    return check;
        //}
    }
}
