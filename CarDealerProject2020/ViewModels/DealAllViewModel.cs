using CarDealerProject2020.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class DealAllViewModel
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }

        public int SellerId { get; set; }

        public int VehicleId { get; set; }

        public DateTime Date { get; set; }
        public decimal Discount { get; set; }
        public PaymentType PaymentType { get; set; }

    }
}
