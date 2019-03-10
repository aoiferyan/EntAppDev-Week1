using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week_1_worksheet.pages
{
    public class ws1Model : PageModel
    {
        public void OnGet()
        {

        }

        public String[] MyTestArray { get; set; }
            = { "England", "Ireland", "Scotland", "Wales" };


        public String Message { get; set; } = "";

        public void OnPost(string firstname)
        {
            Message = $"Hello {firstname}";
        }
    }
}