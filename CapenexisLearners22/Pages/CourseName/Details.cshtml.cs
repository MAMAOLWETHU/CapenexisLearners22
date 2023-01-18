using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners22;
using CapenexisLearners22.Data;

namespace CapenexisLearners22.Pages.CourseName
{
    public class DetailsModel : PageModel
    {
        private readonly CapenexisLearners22.Data.CapenexisLearners22Context _context;

        public DetailsModel(CapenexisLearners22.Data.CapenexisLearners22Context context)
        {
            _context = context;
        }

      public Course Course { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            else 
            {
                Course = course;
            }
            return Page();
        }
    }
}
