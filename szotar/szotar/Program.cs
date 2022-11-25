using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int > list = new List<int>(4);
            list.Add(1);
            list.Add(6);
            list.Add(15);
            list.Add(13);

           
            Dictionary<string, string> szotar = new Dictionary<string, string>();
            szotar.Add("apple","alma");
            szotar.Add("grape","soloo");
            szotar.Add("pear","korte");
            szotar.Add("applee","zsalma");
            foreach (var item in szotar)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Dictionary<string, int> allatkert = new Dictionary<string, int>();
            allatkert.Add("kutya", 12);
            allatkert.Add("tyúk", 20);
            allatkert.Add("nyuszi", 6);
            allatkert.Add("applee", 10);
            foreach (var item in allatkert)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.WriteLine("adjon allatott :");
            string ujallat = Console.ReadLine();
            Console.WriteLine("adjon allatott :");
            int szam =Convert.ToInt32( Console.ReadLine());
            if (allatkert.ContainsKey(ujallat))
            {
                allatkert[ujallat] +=  szam;

            }
            else 
            {
                allatkert.Add(ujallat, szam);
            }
            foreach (var item in allatkert)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            Console.ReadKey();
          
           







        }
    }
}
