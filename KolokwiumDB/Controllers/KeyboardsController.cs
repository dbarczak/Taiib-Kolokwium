using KolokwiumDB.DTOs;
using KolokwiumDB.Models;
using KolokwiumDB.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumDB.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KeyboardsController : Controller
    {
        readonly IKeyboardService _service;
        public KeyboardsController(IKeyboardService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<KeyboardResponse> Get()
        {
            return this._service.GetKeyboards();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._service.DeleteKeyboard(id);
        }

        [HttpPost]
        public void Post([FromBody] KeyboardRequest keyboardRequest )
        {
            if (keyboardRequest == null || !Enum.IsDefined(typeof(Rodzaj), keyboardRequest.Rodzaj))
            {
               
            }
            this._service.AddKeyboard(keyboardRequest);
        }

    }
}
