using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("api/animals")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private static readonly List<Animal> _animals = new()
    {
        new Animal{Category = "dog",Color = "grey",Id = 1,Name = "gron",Weight = 20},
        new Animal{Category = "cat",Color = "black",Id = 2,Name = "puszok",Weight = 5},
        new Animal{Category = "mouse",Color = "grey",Id = 3,Name = "ratatuj",Weight = 2},
        new Animal{Category = "goat",Color = "white",Id = 4,Name = "molka",Weight = 40},
        new Animal{Category = "bear",Color = "brown",Id = 5,Name = "misza",Weight = 100}
    };


    [HttpGet]
    public IActionResult GetAnimal()
    {
        return Ok(_animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(s => s.Id == id);
        if (animal == null) return NotFound($"Animal with id {id} was not found");
        return Ok(animal);
    }
    
    //Add new Animal
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }


    [HttpPut("{id:int})")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        var animalToEdit = _animals.FirstOrDefault(s => s.Id == id);
        if (animalToEdit == null) return NotFound($"Animal with id {id} was not found");
        _animals.Remove(animalToEdit);
        _animals.Add(animal);
        return NoContent();
    }


    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animaToDelete = _animals.FirstOrDefault(s => s.Id == id);
        if (animaToDelete == null) return NoContent();
        _animals.Remove(animaToDelete);
        return NoContent();
    }
}