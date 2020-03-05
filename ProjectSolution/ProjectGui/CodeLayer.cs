using System.Collections.Generic;
using System.Linq;



namespace ProjectGui
{
    public class CodeLayer
    {
        private Cpu _cpu;
        public List<Cpu> GetList()
        {
            using (var db = new PartDatabaseContext())
            {
                return db.Cpu.ToList();


            }
        }

        public List<Cpu> GetCpus()
        {
            using (var db = new PartDatabaseContext())
            {
                return db.Cpu.ToList();


            }




        }


    }
}

