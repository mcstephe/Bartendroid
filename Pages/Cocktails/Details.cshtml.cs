using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bartendroid.Data;
using Bartendroid.Models;

namespace Bartendroid.Pages_Cocktails
{
    public class DetailsModel : PageModel
    {
        private readonly Bartendroid.Data.Context _context;

        public DetailsModel(Bartendroid.Data.Context context)
        {
            _context = context;
        }

      public Cocktail Cocktail { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cocktail == null)
            {
                return NotFound();
            }





            var cocktail = await _context.Cocktail.Include(m => m.CocktailIngredients)
        .Where(m => m.Id == id).FirstOrDefaultAsync();
            if (cocktail == null)
            {
                return NotFound();
            }
            else 
            {
                Cocktail = cocktail;
            }
            return Page();
        }
    }
}
