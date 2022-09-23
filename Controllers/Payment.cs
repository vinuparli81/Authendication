using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Payment.paymentmodel;

namespace Payment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Payment : ControllerBase
    {
        [HttpPost]
        [Route("Payments")]
        public IActionResult Payments(creditcarddetails _CreditcardDetails)
        {
            if (ModelState.IsValid)
            {
               
                return Ok("Payment Successfully!");
            }
            else
            {
                return BadRequest();
            }
        }

       
    }
}
