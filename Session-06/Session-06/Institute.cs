using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Institute
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int YearsInService { get; set; }

        public Institute() { }

        public Institute(Guid id)
        {
            ID = id;
        }

        public Institute(Guid id, string name)
        {
            ID = id;
            Name = name;
        }

        public Institute(Guid id, string name, int yearsInService)
        {
            ID = id;
            Name = name;
            YearsInService = yearsInService;
        }

        public void GetName()
        {

        }

        public void SetName(string name)
        {


        }
    }
}
