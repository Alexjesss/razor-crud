using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

namespace RazorCrud.Pages_Actors
{
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudActorContext _context;

        public DetailsModel(RazorCrudActorContext context)
        {
            _context = context;
        }

        public Actor Actor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Actor = await _context.Actor.FirstOrDefaultAsync(m => m.Id == id);

            if (Actor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
