using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.DTO;
using WebApplication1.Entities;


namespace WebApplication1.Repositories;



public class MuzykRepository : IMuzykRepository
{
    private readonly MusicDbContext _musicDbContext;

    public MuzykRepository(MusicDbContext musicDbContext)
    {
        _musicDbContext = musicDbContext;
    }
    
    public async Task<MuzykDTO> GetMuzyk(int id)
    {
        var muzyk = await _musicDbContext.Muzyks
            .Include(x => x.Utworus)
            .ThenInclude(x => x.Utwor)
            .FirstOrDefaultAsync(m => m.IdMuzyk == id);

        if (muzyk == null) return null;

        var result = new MuzykDTO
        {
            IdMuzyk = muzyk.IdMuzyk,
            Imie = muzyk.Imie,
            Nazwisko = muzyk.Nazwisko,
            Pseudonim = muzyk.Pseudonim,
            Utwory = muzyk.Utworus.Select(w=> new UtworDTO
                {
                    IdUtwor = w.Utwor.IdUtwor,
                    NazwaUtworu = w.Utwor.NazwaUtworu,
                    CzasTrwania = w.Utwor.CzasTrwania
                }).ToList()
        };
        return result;
    }

    public async Task<AddMuzykDTO> AddMuzyk(AddMuzykDTO addMuzykDto)
    {
        var exsistingUtwor = await _musicDbContext.Utwors.FindAsync(addMuzykDto.IdUtwor);
        if (exsistingUtwor == null)
        {
            exsistingUtwor = new Utwor
            {
                IdUtwor = addMuzykDto.IdUtwor,
                NazwaUtworu = addMuzykDto.NazwaUtworu,
                CzasTrwania = addMuzykDto.CzasTrawnia,
                //IdAlbum = addMuzykDto.IdAlbum
            };

            await _musicDbContext.Utwors.AddAsync(exsistingUtwor);
            await _musicDbContext.SaveChangesAsync();
        }

        var finalCreatedMuzyk = new Muzyk
        {
            IdMuzyk = addMuzykDto.IdMuzyk,
            Imie = addMuzykDto.Imie,
            Nazwisko = addMuzykDto.Nazwisko,
            Pseudonim = addMuzykDto.Pseudonim
        };
        
        await _musicDbContext.Muzyks.AddAsync(finalCreatedMuzyk);
        await _musicDbContext.SaveChangesAsync();


        var addToWykonawcaUtworu = new WykonawcaUtworu
        {
            IdMuzyk = finalCreatedMuzyk.IdMuzyk,
            IdUtwor = exsistingUtwor.IdUtwor
        };
        
        await _musicDbContext.WykonawcaUtworus.AddAsync(addToWykonawcaUtworu);
        await _musicDbContext.SaveChangesAsync();


        var toReturn = new AddMuzykDTO
        {
            IdMuzyk = finalCreatedMuzyk.IdMuzyk,
            Imie = finalCreatedMuzyk.Imie,
            Nazwisko = finalCreatedMuzyk.Nazwisko,
            Pseudonim = finalCreatedMuzyk.Pseudonim,
            IdUtwor = exsistingUtwor.IdUtwor,
            NazwaUtworu = exsistingUtwor.NazwaUtworu,
            CzasTrawnia = exsistingUtwor.CzasTrwania,
            //IdAlbum = exsistingUtwor.IdAlbum
        };

        return toReturn;
    }
}