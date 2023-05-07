using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bartendroid.Data;
using Bartendroid.Models;

namespace Bartendroid.Pages.OnTap
{
    public class IndexModel : PageModel
    {
        private readonly Bartendroid.Data.Context _context;

        public IndexModel(Bartendroid.Data.Context context)
        {
            _context = context;
        }

        public IList<Cocktail> Cocktail { get;set; } = default!;
        public IList<Container> Containers { get; set; } = default!;

        public async Task OnGetAsync()
        {
            //Lets find the actual list of drinks we can make from our ingredient pool
            //TODO: Check if containers is null, therefore no list
            
            Containers = await _context.Containers.ToListAsync();
            Cocktail = await _context.Cocktail.ToListAsync();

            //List<CocktailIngredient> cocktailIngredients = _con
            List<Cocktail> availableCocktails = new List<Cocktail>(); 

            foreach (Cocktail c in Cocktail) {

                // First, we need to get the list of ingredients required for the cocktail
                List<Ingredient> requiredIngredients = _context.CocktailIngredients
                    .Where(ci => ci.CocktailId == c.Id)
                    .Select(ci => ci.Ingredient)//
                    .ToList();

                bool hasAllIngredients = true; 

                foreach (var i in requiredIngredients) {
                    // Find the bottle that contains the ingredient
                    var container = Containers.FirstOrDefault(b => b.IngredientId == i.Id);

                    // If the ingredient is not available, return false
                    //TODO: Comeback and add quantity checks
                    //if (container == null || container.Volume < cocktailIngredient.Quantity)
                    if (container == null)
                    {
                        
                        hasAllIngredients = false;
                        //Break cause no need to continue checking  
                        break;
                    }
                }

                if (hasAllIngredients == true) 
                {
                    availableCocktails.Add(c); 
                }


            }

            //If ccanMake is true then add it to a list of Cocktails to display
            if (availableCocktails != null)
            {
                Cocktail = availableCocktails;
            }
            
            //Cocktail = await _context.Cocktail.ToListAsync();
        }



    }
}
