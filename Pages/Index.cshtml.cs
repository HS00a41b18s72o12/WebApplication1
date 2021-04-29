using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int X { get; set; }

        [BindProperty]
        public int Y { get; set; }

        public int Answer { get; set; }

        public void OnGet()
        {
        }

        public void OnPostAdd()
        {
            Answer = X + Y;
        }

        public void OnPostSubtract()
        {
            Answer = X - Y;
        }
    }
}
