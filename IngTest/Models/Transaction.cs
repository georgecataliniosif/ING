using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngTest.Models
{
    public class Transaction
    {
        public string iban { get; set; }
        public int transactionId { get; set; }
        public decimal amount { get; set; }
        public int categoryId { get; set; }
        public DateTime transactionDate { get; set; }
    }
}