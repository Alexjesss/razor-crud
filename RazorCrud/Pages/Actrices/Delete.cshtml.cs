using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages_Actrices
{
    public class DeleteModel : PageModel
    {
        private readonly RazorCrudActriceContext _context;

        public DeleteModel(RazorCrudActriceContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Actrice Actrice { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Actrice = await _context.Actrice.FirstOrDefaultAsync(m => m.Id == id);

            if (Actrice == null)
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

            Actrice = await _context.Actrice.FindAsync(id);

            if (Actrice != null)
            {
                _context.Actrice.Remove(Actrice);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
