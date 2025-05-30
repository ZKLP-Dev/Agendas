using Agendas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

public class ServiciosController : Controller
{
    public IActionResult Seleccionar()
    {
        return View();
    }

    public IActionResult SelectProfessional()
    {
        var professionals = new List<Professional>
    {
        new Professional { Id = 1, Name = "Luis Pérez", Role = "Barbero", Rating = "5.0", Avatar = "LP" },
        new Professional { Id = 2, Name = "Ana Gómez", Role = "Estilista", Rating = "4.8", Avatar = "AG" },
        new Professional { Id = 3, Name = "Carlos Ruiz", Role = "Colorista", Rating = "4.9", Avatar = "CR" },
        new Professional { Id = 4, Name = "Sofía Díaz", Role = "Manicurista", Rating = "4.7", Avatar = "SD" },
        new Professional { Id = 5, Name = "María Torres", Role = "Estética facial", Rating = "5.0", Avatar = "MT" }
    };

        return View(professionals);
    }

    public IActionResult Agenda(int? professionalId)
    {
        if (!professionalId.HasValue)
        {
            return RedirectToAction("SelectProfessional");
        }

        // Aquí podrías también obtener el profesional desde la base de datos para validar su existencia
        return View();
    }

    public IActionResult Confirm()
    {
        return View("Confirm");
    }
    public IActionResult ConfirmarTemporal([FromBody] object reservaData)
    {
        // Log temporal - puedes ver los datos en consola
        Console.WriteLine($"Reserva recibida: {JsonSerializer.Serialize(reservaData)}");

        // Solo devolver éxito por ahora
        return Ok(new { mensaje = "Reserva confirmada temporalmente" });
    }
}
