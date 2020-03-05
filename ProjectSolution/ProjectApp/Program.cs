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
            CodeLayer cl = new CodeLayer();
            using (var db = new PartDatabaseContext())
            {
                var query1 =
                    from co in db.Cpu
                    select co.CpuName;

                foreach (var cpu in query1)
                {
                    Console.WriteLine(cpu);
                }

                

            }






        }
    } 
}
