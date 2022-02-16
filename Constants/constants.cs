public class Constants
{
    public static readonly List<Book> BOOKS= new List<Book>()
    {
        new Book
        {
            Id=Guid.NewGuid(),
            Name="1",
            ISBN="1",
            Pages=1,
            PublishDate= DateTime.Now
        },
        new Book
        {
            Id=Guid.NewGuid(),
            Name="2",
            ISBN="2",
            Pages=2,
            PublishDate= DateTime.Now.AddDays(-100)
        },
        new Book
        {
            Id=Guid.NewGuid(),
            Name="3",
            ISBN="4",
            Pages=5,
            PublishDate= DateTime.Now.AddMonths(-100)
        }
    };
}