using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ProjectGui
{
    public class Method
    {
        private List<Cpu> ItemsSource = new List<Cpu>();

        public string PopulateListBox()
        {
            using (var db = new PartDatabaseContext())
            {
                return db.Cpu.ToList().ToString();


            }
        }

    }
}
