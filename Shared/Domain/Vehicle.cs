using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
		[Required]
		[RegularExpression(@"[0-9]{4}$", ErrorMessage = "Year should be a four digit number")]
		public int Year { get; set; }

        [Required]
		[RegularExpression(@"^[A-Za-z]{3}\d{4}[A-Za-z]", ErrorMessage = "License Plate Number does not meet requirements")]
		public string? LicensePlateNumber { get; set; }
        public int? MakeId { get; set; }
        public virtual Make? Make { get; set; }
        public int? ModelId { get; set; }
        public virtual Model? Model { get; set;}
        public int? ColorId { get; set; }
        public virtual Color? Color { get; set;}
        public virtual List<Booking>? Bookings { get; set; }

        [Required]
		[DataType(DataType.Currency, ErrorMessage = "Daily Rate must be a valid number")]
		[RegularExpression(@"^[+]?\d+([.]\d+)?$", ErrorMessage = "Daily Rate cannot be a negative number")]
		public double RentalRate { get; set; }
    }
}
