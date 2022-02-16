public class Book : BaseBook
{
    public Book()
    {

    }

    public Book(BaseBook baseBook)
    {
        this.Id = Guid.NewGuid();
        this.ISBN = baseBook.ISBN;
        this.Name = baseBook.Name;
        this.Pages = baseBook.Pages;
        this.PublishDate = DateTime.Now;
    }
    public Book(BaseBook baseBook, Guid guid)
    {
        this.Id = guid;
        this.ISBN = baseBook.ISBN;
        this.Name = baseBook.Name;
        this.Pages = baseBook.Pages;
        this.PublishDate = DateTime.Now;
    }
    public Guid Id { get; set; }
}