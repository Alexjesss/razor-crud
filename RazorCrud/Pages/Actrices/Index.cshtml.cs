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
    public class IndexModel : PageModel
    {
        private readonly RazorCrudActriceContext _context;

        public IndexModel(RazorCrudActriceContext context)
        {
            _context = context;
        }

        public IList<Actrice> Actrice { get;set; }

        public async Task OnGetAsync()
        {
            Actrice = await _context.Actrice.ToListAsync();
        }
    }
}
