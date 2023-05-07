using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Bartendroid.Data;
using Bartendroid.Models;

namespace Bartendroid.Pages_Cocktails
{
    public class CreateModel : PageModel
    {
        private readonly Bartendroid.Data.Context _context;

        public CreateModel(Bartendroid.Data.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cocktail Cocktail { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Cocktail == null || Cocktail == null)
            {
                return Page();
            }

            _context.Cocktail.Add(Cocktail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
