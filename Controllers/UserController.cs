using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;
    private readonly IUserService _userService;

    public UsersController(ILogger<UsersController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
    public ActionResult<UserDTO> Get()
    {
        return Ok(_userService.GetAll());
    }

    [HttpGet("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UserDTO> Get(int Id)
    {
        UserDTO result = _userService.GetByID(Id);

        if (result == null)
            return NotFound();

        return Ok(result);

    }

    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UserDTO> Delete(int Id)
    {
        UserDTO result = _userService.GetByID(Id);

        if (result == null)
            return NotFound();

        _userService.Delete(Id);

        return Ok(result);

    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
    public ActionResult<UserDTO> Post([FromBody] BaseUserDTO baseUser)
    {

        return Ok(_userService.Add(baseUser));
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserDTO))]
    public ActionResult<UserDTO> Put([FromBody] BaseUserDTO baseUser, int Id)
    {

        return Ok(_userService.Modify(baseUser, Id));
    }

}
