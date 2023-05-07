using System.ComponentModel.DataAnnotations;

namespace Bartendroid.Models;

public class CocktailIngredient
{
    //public int Id {get; set; }
    public int CocktailId { get; set; } 
    public Cocktail Cocktail { get; set; } = default!;
    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; } = default!;

    public decimal Quantity { get; set; }

    //public Cocktail Cocktail { get; set; } = null!;
    //public Ingredient Ingredient { get; set; } = default!;
}