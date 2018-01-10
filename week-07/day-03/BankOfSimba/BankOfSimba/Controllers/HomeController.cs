using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("simba")]
        public IActionResult Index(BankAccount bankAccount)
        {
            bankAccount.Name = "Simba";
            bankAccount.Balance = 2000;
            bankAccount.AnimalType = "Animal.Lion";

            return View(bankAccount);
        }
    }
}
