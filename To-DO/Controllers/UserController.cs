using Microsoft.AspNetCore.Mvc;
using To_DO.BLL;
using To_DO.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace To_DO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserBLL _userBLL;

        public UserController(IUserBLL userBLL)
        {
            _userBLL = userBLL;
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            try
            {
                await _userBLL.Add(user);

                if (user.UserId>0)
                {
                    return Ok(user);
                }

                return BadRequest("User not created!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> PutAsync(int id, [FromBody] User user)
        {
            try
            {
                if (user.UserId != id)
                {
                    return BadRequest();
                }
                var updatedUser = await _userBLL.Update(user);
                return BadRequest(updatedUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
    }
}
