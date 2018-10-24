using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_system.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        // [Required, MaxLength(25)]
        public int Appointment_Id { get; set; }
        [ForeignKey("Appointment_Id ")]
        // [Required, MaxLength(25)]
        public int prescription_Id { get; set; }
        [ForeignKey(" prescription_Id ")]
        //  [Required, MaxLength(25)]


        public DateTime date { get; set; }

        public decimal Total_Amount { get; set; }

        public decimal Cash_Amount { get; set; }

        public decimal Credit_Amount { get; set; }
        public int CreditCard_Num { get; set; }
    }
}
