using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample

{
    public class Parent
    {
        public string name;
    }

    public class Father : Parent
    {
        public Father()
        {
            name = "Gary";
        } 
    }

    public class Mother : Parent
    {
        public Mother()
        {
            name = "Anna";
        }
    }
    public class Program  
    {
        static void Main(string[] args)
        {
            Father f = new Father();
            Mother m = new Mother();
            Console.WriteLine(f.name);
            Console.WriteLine(m.name);
            Console.ReadKey();
        }
    }
}
