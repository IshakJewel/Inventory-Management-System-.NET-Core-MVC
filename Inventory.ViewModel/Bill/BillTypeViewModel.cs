﻿using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Bill
{
    public class BillTypeViewModel
    {
        public int BillTypeId { get; set; }
        public string BillTypeName { get; set; }
        public string Description { get; set; }
        public BillTypeViewModel(BillType model)
        {
           BillTypeId = BillTypeId;
           BillTypeName = BillTypeName;
           Description = Description;
        }
    }
}
