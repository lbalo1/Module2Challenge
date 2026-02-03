using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module2Challenge.Pages
{
    public class IndexModel : PageModel
    {
        // miles driven 
        [BindProperty]
        public double MilesDriven { get; set; }

        // gallons used
        [BindProperty]
        public double GallonsUsed { get; set; }

        // the calculated MPG
        public double MPG { get; set; }

        // Runs when the page is first loaded
        public void OnGet()
        {
        }

        // Runs when the form is submitted
        public void OnPost()
        {
            // Prevent division by zero
            if (GallonsUsed > 0)
            {
                // Calculate miles per gallon
                MPG = MilesDriven / GallonsUsed;
            }
        }
    }
}