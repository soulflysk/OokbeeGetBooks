# OokbeeGetBooks

Question

สมมติว่าในโปรเจค Ookbee มีหน้าเว็บที่แสดงรายการของหนังสือทั้งหมด และ specification กำหนดให้ดึงข้อมูลนี้จากฐานข้อมูล ผ่าน Entity Framework โดยมี class โดยสังเขปดังต่อไปนี้

public class OokbeeEntities : DbContext 
{
	public DbSet<Book> Books { get; set; }
}

public class Book
{
	public int Id { get; set; }
	public string Title { get; set; }
	public DateTime PublishedDateUtc { get; set; }
}

จากข้อกำหนดดังกล่าว จงออกแบบและเขียน method ในภาษา C# ชื่อ GetBooks โดยให้มีคุณสมบัติดังนี้
    • รับ parameter เป็น OokbeeEntities และ parameter อื่น ๆ ที่จำเป็น
    • ให้ parameter รับค่าช่วงของข้อมูลผลลัพธ์ที่ต้องการ โดยระบุตำแหน่งที่เริ่ม และจำนวนแถวที่ต้องการ
    • Return type เป็น List<Book>
    • ให้เรียงลำดับตาม Published Date จากใหม่ไปเก่า
    • ไม่อนุญาตให้ดึงข้อมูลเกินกว่า 50 แถว
    • มีการ validate parameter

Assume that in the project Ookbee have web page that list all books and specification assume that fetch the data from database pass Entity Framework 
Which has a brief class as follows


From the above terms Design and write the method in C # called GetBooks with the following properties
     • Obtain the parameters as OokbeeEntities and other necessary parameters.
     • Let the parameter get the range of the desired result data By specifying the starting position And the number of rows needed
     • Return type is List <Book>
     • Ordered according to the published date from new to old
     • Not allowed to retrieve more than 50 rows
     • There are validate parameters
