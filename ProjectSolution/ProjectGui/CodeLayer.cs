using System.Collections.Generic;
using System.Linq;



namespace ProjectGui
{
    public class CodeLayer
    {
      
        //public List<Cpu> GetList()
        //{
        //    using (var db = new PartDatabaseContext())
        //    {
        //        return db.Cpu.ToList();


        //    }
        //}

        public List<Users> GetUsers() 
        {
            using (var db = new PartDatabaseContext())
            {
                return db.Users.ToList();


            }
        }
        


    }
}

