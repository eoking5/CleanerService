using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CleaningServices.Utilities
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string City {get; set;}
        public string Couontry {get; set;}
    }
}