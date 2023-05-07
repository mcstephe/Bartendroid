using System.ComponentModel.DataAnnotations;

namespace Bartendroid.Models;

public class Cocktail
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

    public string? Photo { get; set; }

    public string? Instructions { get; set; }

    //public ICollection<CocktailIngredient>? CocktailIngredients { get; set; }
    //public List<Ingredient> Ingredients { get; } = new();
    public List<CocktailIngredient>? CocktailIngredients { get; set; }
}