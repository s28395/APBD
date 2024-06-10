using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Services;

public interface IMuzykService
{
    Task<MuzykDTO> GetMuzyk(int id);

    Task<AddMuzykDTO> AddMuzyk(AddMuzykDTO addMuzykDto);
}