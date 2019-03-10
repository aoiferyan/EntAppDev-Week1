using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week_1_worksheet.pages
{
    public class taghelpplayModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public string Firstname { get; set; }

        [BindProperty]
        public DateTime DateTime { get; set; }

        [BindProperty]
        public bool IsContactAllowed { get; set; }


        public string Message { get; set; } = "";

        public void OnPost(String Operation)
        {
          switch (Operation)
            {
                case "Red":
                    Message = $"You have chosen Red";
                    break;
                case "Yellow":
                    Message = $"You have chosen Yellow";
                    break;
                case "Black":
                    Message = $"You have chosen Black";
                    break;
               
            }
        }
    }
}