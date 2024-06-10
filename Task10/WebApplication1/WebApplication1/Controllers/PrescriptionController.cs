using Microsoft.AspNetCore.Mvc;
using WebApplication1.Context;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PrescriptionController : ControllerBase
{
    private readonly HospitalDbContext _context;

    public PrescriptionController(HospitalDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewPrescription(PrescriptionRequestDTO requestDto)
    {
        var existingPatient = await _context.Patients.FindAsync(requestDto.patient.IdPatient);
        if (existingPatient == null)
        {
            await _context.Patients.AddAsync(requestDto.patient);
            await _context.SaveChangesAsync();
        }

        var existingDoctor = await _context.Doctors.FindAsync(requestDto.doctor.IdDoctor);
        if (existingDoctor == null) return BadRequest("Doctor is not exist");
        
        if (requestDto.medicaments.Count > 10) return BadRequest("A prescription can't contain bigger then 10 medicaments");

        if (requestDto.prescription.DueDate < requestDto.prescription.Date) return BadRequest("DueDate can't be bigger than Date");
        
        
        requestDto.prescription.IdPatient = requestDto.patient.IdPatient;
        requestDto.prescription.IdDoctor = requestDto.doctor.IdDoctor;

        await _context.Prescriptions.AddAsync(requestDto.prescription);
        await _context.SaveChangesAsync();
        
        foreach (var medicament in requestDto.medicaments)
        {
            var existingMedicament = await _context.Medicaments.FindAsync(medicament.IdMedicament);
            if (existingMedicament == null) return BadRequest($"Medicament with ID {medicament.IdMedicament} not found");


            var prescriptionMedicament = new PrescriptionMedicament
            {
                IdMedicament = medicament.IdMedicament,
                IdPrescription = requestDto.prescription.IdPrescription,
                Dose = medicament.Dose,
                Details = medicament.Details
            };

            await _context.PrescriptionMedicaments.AddAsync(prescriptionMedicament);
        }


        await _context.SaveChangesAsync();
        

        return Ok("Prescription was created successfully");
    }
}