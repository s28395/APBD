using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/visits")]
[ApiController]


public class VisitsController : ControllerBase
{
    private static readonly List<Visit> _visits = new()
    {
        new Visit { Date = "02.01.2024", Description = "opis", Price = 140, Id_Animal = 1},
        new Visit { Date = "14.02.2024", Description = "opis2", Price = 111, Id_Animal = 2 },
        new Visit { Date = "07.03.2024", Description = "opis3", Price = 76, Id_Animal = 3 },
        new Visit { Date = "18.03.2024", Description = "opis4", Price = 432, Id_Animal = 4 },
        new Visit { Date = "26.03.2024", Description = "opis5", Price = 200, Id_Animal = 5 },
    };

    [HttpGet]
    public IActionResult GetVisit()
    {
        return Ok(_visits);
    }
    
    
    [HttpGet("animals/{animalId:int}")]
    public IActionResult GetVisitsForAnimal(int animalId)
    {
        var visitsForAnimal = _visits.Where(v => v.Id_Animal == animalId).ToList();
        if (visitsForAnimal.Count == 0)
            return NotFound($"No visits found for animal with id {animalId}");
        Console.WriteLine(visitsForAnimal);
        return Ok(visitsForAnimal);
    }
    
    
    [HttpPost]
    public IActionResult CreateVisit(Visit visit)
    {
        _visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }

    

    
    
}