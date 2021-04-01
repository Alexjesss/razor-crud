using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorCrud.Models;

namespace RazorCrud.Pages_Actrices
{
    public class CreateModel : PageModel
    {
        private readonly RazorCrudActriceContext _context;

        public CreateModel(RazorCrudActriceContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Actrice Actrice { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Actrice.Add(Actrice);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
