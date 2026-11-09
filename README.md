# API_Product
WebApi ระบบจัดการสินค้า ทำงานแบบ CRUD โดย .NET SDK (version 10.0) ประกอบด้วย
- EF Core, Migrations, Database, async/await, CancellationToken
- Data Transfer Object (DTO)
- แยกชั้น Interface, Class, Controller

## Run
ติดตั้ง EF Core และ สร้างฐานข้อมูล
```bash
dotnet tool install --global dotnet-ef
dotnet ef database update
```
รัน webapi
```bash
dotnet run
```
แสดงหน้าเว็บ Api ไปที่ Url `http://localhost:5078/scalar/v1`
## Endpoints
|Method|URL|Output|
|----|----|----|
|GET|`api/Products`|แสดงรายการสินค้าทั้งหมด|
|GET|`api/Products/{id}`|แสดงรายการสินค้าตามรหัสสินค้า|
|GET|`api/Products/search?name=`|แสดงรายการสินค้าตามชื่อสินค้า|
|GET|`api/Products/expensive?=`|แสดงรายการสินค้าตามราคาหรือแพงกว่า|
|POST|`api/Products`|เพิ่มสินค้า|
|PUT|`api/Products/{id}`|แก้ไขสินค้า|
|DELETE|`api/Products/{id}`|ลบสินค้าตามรหัสสินค้า|
|DELETE|`api/Products`|ลบสินค้าทั้งหมด|
 