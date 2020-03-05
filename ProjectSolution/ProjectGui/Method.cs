using System.Collections.Generic;
using System.Linq;



namespace ProjectGui
{
    public class Method
    {

        public List<Cpu> Name() 
        {
            List<Cpu> c = new List<Cpu>();
            foreach (var p in c) 
            {
                c.Add(p);

               
            }
            return c;
        }
        
        public string PopulateListBox()
        {
            using (var db = new PartDatabaseContext())
            {
                return db.Cpu.ToList().ToString();


            }
        }

    }
}

