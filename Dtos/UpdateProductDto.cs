using System.ComponentModel.DataAnnotations;

public class UpdateProductDto
{
    [Required, StringLength(100)]
    public string Name {get; set;} = string.Empty;

    [Range(typeof(decimal), "0.01", "1000000")]
    public decimal Price {get; set;}

    [StringLength(500)]
    public string? Description {get; set;}
}