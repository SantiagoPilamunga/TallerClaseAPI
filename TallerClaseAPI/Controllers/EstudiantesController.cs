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
        [Route("InfoEstudiante")]
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
    }
}