using ProjectGui;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new PartDatabaseContext())
            {
                var query1 =
                    from Cpu in db.Cpu
                    select Cpu;
                

                List<Cpu> n = query1.ToList<Cpu>();
                foreach (var a in n)
                { 
                Console.WriteLine(n.ToString());
                }

            }
            
           
        }
    } 
}
