using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.Services;

namespace Test.Api.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class DMKhoController : ControllerBase
    {
        private readonly IDMKhoService _dmkService;
        public DMKhoController(IDMKhoService dmkService)
        {
            _dmkService = dmkService;
        }
        [HttpGet]
        public IActionResult GetDMKhos()
        {

            return Ok(_dmkService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetDMK(Guid id)
        {
            var dmk = _dmkService.Get(id);
            if (dmk == null)
            {
                return NotFound();//trả về mã 404
            }
            return Ok(dmk);//trả về mã 200 cho product
        }

        [HttpPost]
        public IActionResult AddDMK(DMKhoDto dmkDto)
        {
            dmkDto.IdDMKho = Guid.NewGuid();
            if (_dmkService.Add(dmkDto) == false)
            {

                return CreatedAtAction(nameof(GetDMK), new { id = dmkDto.IdDMKho }, dmkDto);

            }


            return Conflict("DM kho này đã tồn tại");
        }


        [HttpPut("{id}")]
        public IActionResult UpdateDMK(DMKhoDto dmkDto)
        {
            if (_dmkService.Update(dmkDto))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDMK(Guid id)
        {
            if (_dmkService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không thể xóa vì dm kho không tồn tại");
        }
    }
}
