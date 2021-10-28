using Microsoft.AspNetCore.Mvc;
using Palindrome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome.Controllers
{
    public class PalindromeController : Controller
    {


        public IActionResult PalindromeView()
        {
            var model = new PalindromeModel();
            return View(model);

        }

        [HttpPost]
        public IActionResult PalindromeView(PalindromeModel model)
        {

            var startValue = model.UserInput.Length - 1;

            var endValue = 0;

            var revString = "";



            for (var i = startValue; i >= endValue; i--)
            {
                revString += model.UserInput[i];

            }
            if (model.UserInput == revString)
                {
                    model.Output =  "That's a Palindrome!";
                }
                else
                {
                    model.Output =  "That's not a Palindrome";
                }
            
            return View(model);
        }

    }
}
