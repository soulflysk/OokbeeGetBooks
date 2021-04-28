# OokbeeGetBooks

Question


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


Assume that in the project Ookbee have web page that list all books and specification assume that fetch the data from database pass Entity Framework Which has a brief class as follows

From the above terms Design and write the method in C # called GetBooks with the following properties 

• Obtain the parameters as OokbeeEntities and other necessary parameters. 

• Let the parameter get the range of the desired result data By specifying the starting place And the number of rows needed 

• Return type is List 

• Ordered according to the published date from new to old 

• Not allowed to retrieve more than 50 rows 

• There are validate parameters
