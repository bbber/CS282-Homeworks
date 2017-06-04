using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples03
{
    class Program
    {
        static void Main(string[] args)
        {
            Student someone = new Student();
            someone.name = "林千雅";
            Console.WriteLine("學生姓名:{0}", someone.name);
        }
    }
}
