using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Factory.Abstract_Product;
using static Web.Factory.Abstract_Factory.Enumerations;

namespace Web.Factory.Concrete_Product
{
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brands.DELL.ToString();
        }
    }
}