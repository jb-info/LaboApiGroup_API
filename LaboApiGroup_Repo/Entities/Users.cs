using LaboApiGroup_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Entities
{
    public class Users : IEntity<int>
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
