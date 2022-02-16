using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private readonly ILogger<BooksController> _logger;
    private readonly IBookService _bookService;

    public BooksController(ILogger<BooksController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
    public ActionResult<Book> Get()
    {
        return Ok(_bookService.GetAll());
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Book> Get(Guid Id)
    {
        Book result = _bookService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
    public ActionResult<Book> Post([FromBody] BaseBook baseBook)
    {

        return Ok(_bookService.Add(baseBook));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
    public ActionResult<Book> Put([FromBody] BaseBook baseBook, Guid Id)
    {

        return Ok(_bookService.Modify(baseBook, Id));
    }

    [HttpPatch("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Book))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Book> Patch([FromBody] JsonPatchDocument<Book> baseBook, Guid Id)
    {
        Book result = _bookService.Patch(baseBook, Id);

        if (result == null)
            return NotFound();

        return Ok(result);
    }
}
