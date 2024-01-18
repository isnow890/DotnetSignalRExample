using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApiWithSIgnalRExample.SignalR;

namespace WebApiWithSIgnalRExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public MessageController(IHubContext<ChatHub> hubContext)
        {
            // SignalR Hub 컨텍스트를 주입
            _hubContext = hubContext;

        }

        [HttpGet(Name = "sendMessage")]
        public async Task<ActionResult<bool>> SendMessageee()
        {

            await _hubContext.Clients.All.SendAsync("ReceiveMessage", "Web API", "Hello from Web API!");

            return Ok(true);
        }
    }
}