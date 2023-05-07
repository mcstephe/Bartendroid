using System.ComponentModel.DataAnnotations;

namespace Bartendroid.Models;

public class Container
{
    public int Id { get; set; }
    public int? Position { get; set; }
    public int Volume {get; set; }
    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; } = default!;   
    


}