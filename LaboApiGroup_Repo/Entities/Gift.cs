using LaboApiGroup_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Entities
{
    internal class Gift : IEntity<int>
    {
        public int Id { get; set; } 
        public string Gift_Type { get; set; }
        public int landing { get; set; }
    }
}
