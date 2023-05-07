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
    public class DeleteModel : PageModel
    {
        private readonly Bartendroid.Data.Context _context;

        public DeleteModel(Bartendroid.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Cocktail Cocktail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cocktail == null)
            {
                return NotFound();
            }

            var cocktail = await _context.Cocktail.FirstOrDefaultAsync(m => m.Id == id);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Cocktail == null)
            {
                return NotFound();
            }
            var cocktail = await _context.Cocktail.FindAsync(id);

            if (cocktail != null)
            {
                Cocktail = cocktail;
                _context.Cocktail.Remove(Cocktail);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
