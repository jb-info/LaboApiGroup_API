﻿using LaboApiGroup_Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Models
{
    public class GiftOfProject_BLL : IEntity<int> 
    {
        public int Password { get; set; }
        public int Id_Project { get; set; }
        public int Id_Gift { get; set; }
    }
}
