using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch;

public interface IUserService
{
    public IEnumerable<UserDTO> GetAll();

    public UserDTO GetByID(int guid);

    public UserDTO Add(BaseUserDTO guid);

    public void Delete(int guid);

    public UserDTO Modify(BaseUserDTO book, int guid);
}