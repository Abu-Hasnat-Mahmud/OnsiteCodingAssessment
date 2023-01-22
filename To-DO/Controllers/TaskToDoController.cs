using Microsoft.AspNetCore.Mvc;
using To_DO.BLL;
using To_DO.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace To_DO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskToDoController : ControllerBase
    {
        private readonly ITaskBLL _taskBLL;

        public TaskToDoController(ITaskBLL taskBLL)
        {
            _taskBLL = taskBLL;
        }

       
        [HttpGet("GetUserTask/{userId}")]
        public async Task<ActionResult<List<ToDoTask>>> GetUserTask(int userId)
        {
            return Ok (await _taskBLL.UserTask(userId));
        }



         // GET api/<TaskToDo>/5
        [HttpGet("FilterToItem")]
        public async Task<ActionResult<List<ToDoTask>>> FilterToItem(int userId,bool complete)
        {
            return Ok (await _taskBLL.FilterTask(userId, complete));
        }



        // POST api/<TaskToDo>
        [HttpPost]
        public async Task<ActionResult<ToDoTask>> Post([FromBody] ToDoTask task)
        {
            try
            {
                await _taskBLL.Add(task);
                return Ok(task);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

         // POST api/<TaskToDo>
        [HttpPost("UpdateToDoItemAsDone")]
        public async Task<ActionResult<ToDoItem>> UpdateToDoItemAsDone([FromBody] ToDoItem item)
        {
            try
            {
                var updateItem = await _taskBLL.ToDoItemsAsDone(item);
                return Ok(updateItem);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

      
    }
}
