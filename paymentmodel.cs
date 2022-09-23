using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment
{
    public class paymentmodel
    {
        public class creditcarddetails
        {
            public string CardholderName { get; set; }
            public string CardNumber { get; set; }
            public decimal Amount { get; set; }
        }
    }
}
