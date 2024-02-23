using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto.User;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    
    [Route("api/[controller]")]
    [ApiController]
    public class ChiNhanhController : ControllerBase
    {
        private readonly IChiNhanhService _cnService;
        public ChiNhanhController(IChiNhanhService cnService)
        {
            _cnService = cnService;
        }
        [HttpGet]
        public IActionResult GetCNs()
        {

            return Ok(_cnService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetCN(Guid id)
        {
            var nccs = _cnService.Get(id);
            if (nccs == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(nccs);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddCN(ChiNhanhDto cnDto)
        {
            cnDto.IdChiNhanh = Guid.NewGuid();
            if (_cnService.Add(cnDto) == false)
            {

                return CreatedAtAction(nameof(GetCN), new { id = cnDto.IdChiNhanh }, cnDto);

            }


            return Conflict("Chi Nhánh này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateCN(ChiNhanhDto cnDto)
        {
            if (_cnService.Update(cnDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCN(Guid id)
        {
            if (_cnService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì chi nhánh không tồn tại");
        }
    }
}
