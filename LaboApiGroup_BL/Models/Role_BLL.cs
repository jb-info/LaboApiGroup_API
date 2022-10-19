using LaboApiGroup_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Models
{
    public class Role_BLL : IEntity<int>
    {
        public int Password { get; set; }
        public string Name { get; set; }
    }
}
