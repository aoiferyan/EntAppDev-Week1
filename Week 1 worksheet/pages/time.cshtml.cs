using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Week_1_worksheet.pages
{
    public class timeModel : PageModel
    {
        public string[] Days { get; set; } = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        [BindProperty]
        public bool[] IsChecked { get; set; } = new bool[7];

        [BindProperty]
        public string[] MonthsChosen { get; set; } = {};

        public List <SelectListItem> MonthList { get; set; } =
             new List<SelectListItem>
             { new SelectListItem ("Jan", "Jan"),
                 new SelectListItem ("Feb", "Feb"),
                 new SelectListItem ("March", "March"),
                 new SelectListItem ("April", "April"),
                 new SelectListItem ("May", "May"),
                 new SelectListItem ("June", "June"),
                 new SelectListItem ("July", "July"),
                 new SelectListItem ("August", "August"),
                 new SelectListItem ("September", "September"),
                 new SelectListItem ("October", "October"),
                 new SelectListItem ("November", "November"),
                 new SelectListItem ("December", "December")
             };

        public void OnGet()
        {

        }
    }
}