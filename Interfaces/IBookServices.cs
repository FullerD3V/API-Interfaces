using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IBookService
{
    public IEnumerable<Book> GetAll();

    public Book GetByID(Guid guid);

    public Book Add(BaseBook guid);

    public Book Delete(Guid guid);

    public Book Modify(BaseBook book, Guid guid);
    public Book Patch(JsonPatchDocument<Book> baseBook, Guid guid);
}