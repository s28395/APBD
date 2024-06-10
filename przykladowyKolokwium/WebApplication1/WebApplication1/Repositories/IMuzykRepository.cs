using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Repositories;

public interface IMuzykRepository
{
    Task<MuzykDTO> GetMuzyk(int id);
    Task<AddMuzykDTO> AddMuzyk(AddMuzykDTO addMuzykDto);
}