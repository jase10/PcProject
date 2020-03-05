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
                    from cpu in db.Cpu
                    select cpu;
               
                foreach (var cpu in query1)
                { 
                Console.WriteLine(cpu);
                }

            }



            
            


        }
    } 
}
