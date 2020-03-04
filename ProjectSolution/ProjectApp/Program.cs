using ProjectGui;
using System;

namespace ProjectApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new PartDatabaseContext())
            {
                var orderQuery = from Cpu in db.Cpu
                                 select row => row;





            }
        }
    } 
}
