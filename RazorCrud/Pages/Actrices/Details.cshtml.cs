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
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudActriceContext _context;

        public DetailsModel(RazorCrudActriceContext context)
        {
            _context = context;
        }

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
    }
}
