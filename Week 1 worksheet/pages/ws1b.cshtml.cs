using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week_1_worksheet.pages
{
    public class ws1bModel : PageModel
    {
        public string Message { get; set; } = "";
        public void OnGet()
        {

        }
        public void OnPost(int number1, int number2)
        {
            Message = ($"{number1} plus {number2} equal {number1 + number2}");
        }
    }
}