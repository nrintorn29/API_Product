using System.ComponentModel.DataAnnotations;

public class CreateProductDto
{
    private const string MinPrice = "0.01";
    private const string MaxPrice = "1000000";
    private const int SetIntName = 100;
    private const string SetStringName = "100";
    private const int SetIntDescription = 500;
    private const string SetStringDescription = "500";

    [Required(ErrorMessage = "กรุณาใส่ชื่อสินค้า")]
    [StringLength(SetIntName, ErrorMessage = $"ชื่อสินค้าไม่เกิน {SetStringName} ตัวอักษร")]
    public string Name {get; set;} = string.Empty;

    [Range(typeof(decimal), MinPrice, MaxPrice, ErrorMessage = $"กรุณาระบุราคาระหว่าง {MinPrice} ถึง {MaxPrice}")]
    public decimal Price {get; set;}

    [StringLength(SetIntDescription, ErrorMessage = $"ข้อความไม่เกิน {SetStringDescription} ตัวอักษร")]
    public string? Description {get; set;}
}