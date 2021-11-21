using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagementWebApp.DAL.Models
{
    public class ItemSetup
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string CompanyName { get; set; }
        public string ItemName { get; set; }
        public int ReorderLevel { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
    }
}