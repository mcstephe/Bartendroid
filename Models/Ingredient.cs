using System.ComponentModel.DataAnnotations;

namespace Bartendroid.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string? Name { get; set; }

    //public ICollection<CocktailIngredient> CocktailIngredients { get; } = default!;

    //public List<Cocktail> Cocktails { get; } = new();
    public IList<CocktailIngredient>? CocktailIngredients { get; set; }
    public IList<Container>? Containers { get; set; }
    //public int CocktailIngredientId {get; set; }
    //public CocktailIngredient CocktailIngredient { get; set; } = default!;

}