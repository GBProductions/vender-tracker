using System.Collections.Generic;

namespace VendorTracker.Models
  {
    public class Vendor
    {
        public string Business { get; set; }
        public string Description { get; set; }

        public Vendor(string business, string description)
        {
            Business = business;
            Description = description;
        }
    }
}