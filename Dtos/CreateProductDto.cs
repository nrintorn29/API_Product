using System.ComponentModel.DataAnnotations;

public class CreateProductDto
{
    private const string MaxPrice = "1000000";

    [Required(ErrorMessage = "กรุณาระบุชื่อสินค้า")]
    [StringLength(100, ErrorMessage = "ชื่อต้องไม่เกิน 100 ตัวอักษร")]
    public string Name {get; set;} = string.Empty;

    [Range(typeof(decimal), "0.01", MaxPrice, ErrorMessage = $"ราคาต้องอยู่ระหว่าง 0.01 ถึง {MaxPrice}")]
    public decimal Price {get; set;}

    [StringLength(500, ErrorMessage = "ข้อความยาวเกินไป")]
    public string? Description {get; set;}
}
