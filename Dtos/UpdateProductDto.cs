using System.ComponentModel.DataAnnotations;

public class UpdateProductDto
{
    [Required(ErrorMessage = "กรุณาระบุชื่อสินค้า"), StringLength(100, ErrorMessage = "ชื่อต้องไม่เกิน 100 ตัวอักษร")]
    public string Name {get; set;} = string.Empty;

    [Range(typeof(decimal), "0.01", "1000000", ErrorMessage = "ราคาต้องอยู่ระหว่า 0.01 ถึง 10000000")]
    public decimal Price {get; set;}

    [StringLength(500, ErrorMessage = "ข้อความยาวเกินไป")]
    public string? Description {get; set;}
}