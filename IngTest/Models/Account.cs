using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngTest.Models
{
    public class Account
    {
        public string resourceId { get; set; }
        public string product { get; set; }
        public string iban { get; set; }
        public string name { get; set; }
        public string currency { get; set; }
    }
}
