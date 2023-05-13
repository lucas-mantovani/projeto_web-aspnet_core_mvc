using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using mvc_project.Models.Enums;

namespace mvc_project.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [Display(Name = "Data sale")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} required")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "{0} required")]
        [Range(10.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int? id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = (int)id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
