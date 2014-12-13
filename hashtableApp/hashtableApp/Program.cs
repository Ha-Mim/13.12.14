using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("111","ASP.NET MVC");
            aHashtable.Add("222", "Java");
            aHashtable.Add("101","php");
            aHashtable.Add("121","FTFL");
            string courseName = (string) aHashtable["121"];
            Console.WriteLine(courseName);
            Console.ReadLine();
        }
    }
}
