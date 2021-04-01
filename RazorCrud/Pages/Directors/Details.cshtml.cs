using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages_Directors
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudDirectorContext _context;

        public DetailsModel(RazorCrudDirectorContext context)
        {
            _context = context;
        }

        public Director Director { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Director = await _context.Director.FirstOrDefaultAsync(m => m.Id == id);

            if (Director == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
