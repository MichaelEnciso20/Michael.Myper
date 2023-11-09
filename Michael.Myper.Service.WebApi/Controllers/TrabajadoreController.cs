using Michael.Myper.Application.DTO;
using Michael.Myper.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Michael.Myper.Service.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Produces("application/json")]
    public class TrabajadoreController : Controller
    {
        private readonly ITrabajadoreApplication _trabajadoreApplication;
        public TrabajadoreController(ITrabajadoreApplication trabajadoreApplication)
        {
            _trabajadoreApplication = trabajadoreApplication;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _trabajadoreApplication.GetAll();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(string Id)
        {
            if (string.IsNullOrEmpty(Id))
                return BadRequest();
            var response = _trabajadoreApplication.Get(Id);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] TrabajadoreDto trabajadoreDto)
        {
            if (trabajadoreDto == null)
                return BadRequest();
            var response = _trabajadoreApplication.Insert(trabajadoreDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public IActionResult Update([FromBody] TrabajadoreDto trabajadoreDto)
        {
            if (trabajadoreDto == null)
                return BadRequest();
            var response = _trabajadoreApplication.Update(trabajadoreDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id))
                return BadRequest();
            var response = _trabajadoreApplication.Delete(Id);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

      

    }
}
