using Microsoft.AspNetCore.JsonPatch;

public class BookService : IBookService
{
    public Book Add(BaseBook baseBook)
    {
        var result = new Book(baseBook);
        Constants.BOOKS.Add(result);
        return result;
    }

    public Book Delete(Guid guid)
    {
        Book listBook = Constants.BOOKS.FirstOrDefault(x => x.Id == guid);

        if (listBook == null)
            return null;

        return listBook;
    }

    public IEnumerable<Book> GetAll()
    {
        return Constants.BOOKS;
    }

    public Book GetByID(Guid guid)
    {
        return Constants.BOOKS.FirstOrDefault(x => x.Id == guid);
    }

    public Book Modify(BaseBook book, Guid guid)
    {
        Book listBook = Constants.BOOKS.FirstOrDefault(x => x.Id == guid);

        if (listBook == null)
            return null;

        var newBook = new Book(book, guid);
        Constants.BOOKS.Remove(listBook);
        Constants.BOOKS.Add(newBook);
        return newBook;
    }

    public Book Patch(JsonPatchDocument<Book> patchBook, Guid guid)
    {
        var book = Constants.BOOKS.FirstOrDefault(x => x.Id == guid);
        if (book == null)
            return null;

        Constants.BOOKS.Remove(book);
        patchBook.ApplyTo(book);
        Constants.BOOKS.Add(book);

        return book;

    }
}