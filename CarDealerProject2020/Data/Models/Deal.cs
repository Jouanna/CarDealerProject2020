﻿using CarDealerProject2020.Data.Enumerations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealerProject2020.Data.Models
{
    public class Deal
    {
        public int Id { get; set; }

        [ForeignKey("BuyerInfo")]
        public int BuyerId { get; set; }
        public BuyerInfo BuyerInfo { get; set; }

        [ForeignKey("SellerInfo")]
        public int SellerId { get; set; }
        public SellerInfo SellerInfo { get; set; }

        [ForeignKey("VehicleDetails")]
        public int VehicleId { get; set; }
        public VehicleDetail VehicleDetails { get; set; }

        public DateTime Date { get; set; }
        public decimal Discount { get; set; }
        public PaymentType PaymentType { get; set; }

    }
}
