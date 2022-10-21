﻿using LaboApiGroup_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_Repo.Entities
{
    public class RoleOfUser : IEntity<int>
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Role { get; set; }

    }
}
