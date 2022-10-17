﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboApiGroup_BL.Models
{
    public class Transactions_BLL : IEntity<int>
    {
        public int Id { get; set; }
        public int Id_Project { get; set; }
        public int Id_User { get; set; }
        public int Amount { get; set; }
        public DateTime Date_Transaction { get; set; }
    }
}