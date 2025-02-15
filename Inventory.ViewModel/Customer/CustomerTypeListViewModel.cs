﻿using Inventory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Customer
{
    public class CustomerTypeListViewModel
    {
        public int CustomerTypeId { get; set; }
        public string CustomerTypeName { get; set; }
        public string Description { get; set; }
        public CustomerTypeListViewModel()
        {
            
        }
        public CustomerType ConvertModelToViewModelList(CustomerTypeListViewModel model)
        {
            return new CustomerType
            {
                CustomerTypeName = model.CustomerTypeName,
                Description = model.Description
            };
        }

    }
}
