using TallerClaseAPI.Modelos;

namespace TallerClaseAPI.Interfaces
{
    public interface IEstudianteRepository
    {
        IEnumerable<Estudiante> DevuleveListadoEstudiantes();
        Estudiante DevuelveInformacionEstudiante(string BannerId);
        Boolean GuardarEstudiante(Estudiante estudiante);
        Boolean EliminarEstudiante(string BannerId);
    }
}
