using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W
{
    public class student
    {
        private string name;
        private string address;
        private double mark;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Address
        {
            get { return address; }
            set { address = value; }

        }
        public double Mark
        {
            get { return mark; }
            set { mark = value; }

        }
        static void Main(string[] args)
        {
            student Y = new student();
            Y.Name = "YASER";
            Y.Address = "iraq";
            Y.Mark = 75.14;
            Console.WriteLine("The name is : " + Y.Name);
            Console.WriteLine("frome : " + Y.Address);
            Console.WriteLine("avareg : " + Y.Mark);
            Console.ReadKey();
        }
    }
}
