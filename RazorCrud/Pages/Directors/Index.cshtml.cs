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
    public class IndexModel : PageModel
    {
        private readonly RazorCrudDirectorContext _context;

        public IndexModel(RazorCrudDirectorContext context)
        {
            _context = context;
        }

        public IList<Director> Director { get;set; }

        public async Task OnGetAsync()
        {
            Director = await _context.Director.ToListAsync();
        }
    }
}
