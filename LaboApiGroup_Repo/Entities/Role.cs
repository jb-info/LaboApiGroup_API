using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Entities
{
    public class Role : Interfaces.IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
