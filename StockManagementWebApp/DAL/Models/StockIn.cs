using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementWebApp.DAL.Models
{
    public class StockIn
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ItemName { get; set; }
        //public int AvailableQuantity { get; set; }
        public int StockInQuantity { get; set; }
    }
}