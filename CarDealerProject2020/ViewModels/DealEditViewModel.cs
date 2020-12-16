using CarDealerProject2020.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class DealEditViewModel
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }

        public int SellerId { get; set; }

        public int VehicleId { get; set; }

        public DateTime Date { get; set; }
        public decimal Discount { get; set; }
        public PaymentType PaymentType { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Sellers { get; set; }
        public IEnumerable<KeyValuePair<string, string>> Buyers { get; set; }
        public IEnumerable<KeyValuePair<string, string>> Cars { get; set; }
    }
}
