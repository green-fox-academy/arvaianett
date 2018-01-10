using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public static BankAccountViewModel BankAccountViewModel = new BankAccountViewModel();
        // GET: /<controller>/
        [Route("simba")]
        public IActionResult Index(BankAccount bankAccount)
        {
            bankAccount.Name = "Simba";
            bankAccount.Balance = 2000.00;
            bankAccount.Currency = "Zebra";
            bankAccount.AnimalType = "Animal.Lion";

            return View(bankAccount);
        }

        [Route("lionking")]
        public IActionResult Characters()
        {
            return View(BankAccountViewModel);
        }
    }
}
