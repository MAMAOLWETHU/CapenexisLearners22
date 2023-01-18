using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CapenexisLearners22;
using CapenexisLearners22.Data;

namespace CapenexisLearners22.Pages.CourseName
{
    public class CreateModel : PageModel
    {
        private readonly CapenexisLearners22.Data.CapenexisLearners22Context _context;

        public CreateModel(CapenexisLearners22.Data.CapenexisLearners22Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Course == null || Course == null)
            {
                return Page();
            }

            _context.Course.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
