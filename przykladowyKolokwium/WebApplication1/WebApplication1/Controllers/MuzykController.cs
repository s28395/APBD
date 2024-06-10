using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Services;

namespace WebApplication1.Controllers;


[Route("api/[controller]")]
[ApiController]
public class MuzykController : ControllerBase
{
    private readonly IMuzykService _muzykService;

    public MuzykController(IMuzykService muzykService)
    {
        _muzykService = muzykService;
    }

    [HttpGet("int:{id}")]
    public async Task<IActionResult> GetMuzyk(int id)
    {
        var muzyk  = await _muzykService.GetMuzyk(id);
        if (muzyk == null) return NotFound("The muzyk is excepted");
        return Ok(muzyk);
    }

    [HttpPost]
    public async Task<IActionResult> AddMuzyk(AddMuzykDTO addMuzykDto)
    {
        await _muzykService.AddMuzyk(addMuzykDto);
        return Ok();
    }
}


