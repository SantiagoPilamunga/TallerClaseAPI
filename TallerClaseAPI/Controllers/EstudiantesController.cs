using System.Net.WebSockets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerClaseAPI.Modelos;
using TallerClaseAPI.Repositorios;

namespace TallerClaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        EstudianteRepository _estudianteRepository;
        public EstudiantesController()
        {
            _estudianteRepository = new EstudianteRepository();
        }
        [HttpGet]
        public IActionResult DevuelveListadoEstudiantes()
        {
            var estudiantes = _estudianteRepository.DevuleveListadoEstudiantes();
            return Ok(estudiantes);
        }
        [Route("{BannerID}")]
        [HttpGet]
        public IActionResult DevuelveInformacionEstudiante(string BannerId)
        {
            try
            {
                var InfoEstudiante = _estudianteRepository.DevuelveInformacionEstudiante(BannerId);
                return Ok(InfoEstudiante);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult GuardarEstudiante([FromBody] Estudiante estudiante)
        {
            try
            {
                var guardar = _estudianteRepository.GuardarEstudiante(estudiante);
                if (guardar)
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult ActualizarEstudiante([FromBody] Estudiante estudiante, string nombre="")
        {
            try
            {
                var guardar = _estudianteRepository.GuardarEstudiante(estudiante);
                if (guardar)
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public IActionResult EliminarEstudiante(string BannerId)
        {
            try
            {
                var eliminar = _estudianteRepository.EliminarEstudiante(BannerId);
                if (eliminar)
                {
                    return Ok("Eliminado correctamente");
                }
                else
                {
                    return StatusCode(500, "No se pudo eliminar"); 
                }
            }
            catch(Exception e)
            {
                return NotFound();
            }
        }
    }
}
