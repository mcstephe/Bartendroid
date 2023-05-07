using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bartendroid.Data;
using Bartendroid.Models;

namespace Bartendroid.Pages.Ingredients
{
    public class IndexModel : PageModel
    {
        private readonly Bartendroid.Data.Context _context;

        public IndexModel(Bartendroid.Data.Context context)
        {
            _context = context;
        }

        public IList<Ingredient> Ingredients { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ingredients != null)
            {
                Ingredients = await _context.Ingredients.ToListAsync();
            }
        }
    }
}
