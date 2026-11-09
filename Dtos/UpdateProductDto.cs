using System.ComponentModel.DataAnnotations;

public class UpdateProductDto
{
    private const string MinPrice = "0.01";
    private const string MaxPrice = "1000000";
    private const int setIntName = 100;
    private const string setStringName = "100";
    private const int setIntDescription = 500;
    private const string setStringDescription = "500";

    [Required(ErrorMessage = "กรุณาใส่ชื่อสินค้า")]
    [StringLength(setIntName, ErrorMessage = $"ชื่อสินค้าไม่เกิน {setStringName} ตัวอักษร")]
    public string Name {get; set;} = string.Empty;

    [Range(typeof(decimal), MinPrice, MaxPrice, ErrorMessage = $"กรุณาระบุราคาระหว่าง {MinPrice} ถึง {MaxPrice}")]
    public decimal Price {get; set;}

    [StringLength(setIntDescription, ErrorMessage = $"ข้อความไม่เกิน {setStringDescription} ตัวอักษร")]
    public string? Description {get; set;}
}