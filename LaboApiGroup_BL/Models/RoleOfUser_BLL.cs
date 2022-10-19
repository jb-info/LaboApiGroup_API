using LaboApiGroup_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Models
{
    public class RoleOfUser_BLL : IEntity<int> 
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Role { get; set; }
    }
}
