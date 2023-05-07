using System.ComponentModel.DataAnnotations;

namespace Bartendroid.Models;

public class Batch
{
    public int Id { get; set; }
    public string? name { get; set; }
    
    public List<Container>? Containers { get; set; }



}