using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Vendor
{
    public class CreateVendorTypeListViewModel
    {
        public string VendorTypeName { get; set; }
        public string Description { get; set; }
        public CreateVendorTypeListViewModel()
        {
            
        }
        public CreateVendorTypeListViewModel(VendorType model)
        {
            VendorTypeName = model.VendorTypeName;
            Description = model.Description;
        }
        public VendorType  Convert(CreateVendorTypeListViewModel vm)
        {
            VendorType model =new VendorType();
            VendorTypeName = model.VendorTypeName;
            Description = model.Description;
            return model;
        }
    }
}
