using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Entities
{
    public class Project : Interfaces.IEntity<int>
    {
        public int Password { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int Financial_Targets { get; set; }
        public int Earn_Money { get; set; }
    }
}
