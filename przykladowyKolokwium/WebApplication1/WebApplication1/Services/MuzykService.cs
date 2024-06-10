using WebApplication1.DTO;
using WebApplication1.Entities;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class MuzykService : IMuzykService
{
    private readonly IMuzykRepository _muzykRepository;

    public MuzykService(IMuzykRepository muzykRepository)
    {
        _muzykRepository = muzykRepository;
    }

    public async Task<MuzykDTO> GetMuzyk(int id)
    {
        return await _muzykRepository.GetMuzyk(id);
    }

    public async Task<AddMuzykDTO> AddMuzyk(AddMuzykDTO addMuzykDto)
    {
        return await _muzykRepository.AddMuzyk(addMuzykDto);
    }
}