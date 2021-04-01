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
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudDirectorContext _context;

        public DeleteModel(RazorCrudDirectorContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Director = await _context.Director.FindAsync(id);

            if (Director != null)
            {
                _context.Director.Remove(Director);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
