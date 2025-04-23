using TallerClaseAPI.Interfaces;
using TallerClaseAPI.Modelos;

namespace TallerClaseAPI.Repositorios
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public Estudiante DevuelveInformacionEstudiante(string BannerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estudiante> DevuleveListadoEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Estudiante estudiante1 = new Estudiante
            {
                BannerId = "12345",
                Nombre = "Santiago",
                Edad = 30,
                TieneBeca = false,
            };
            Estudiante estudiante2 = new Estudiante
            {
                BannerId = "98765",
                Nombre = "Juliana",
                Edad = 25,
                TieneBeca = true,
            };
            estudiantes.Add(estudiante1);
            estudiantes.Add (estudiante2);
            return estudiantes;
        }

        public bool EliminarEstudiante(string BannerId)
        {
            //logica del negocio
            return true;
        }

        public bool GuardarEstudiante(Estudiante estudiante)
        {
            return true;
        }
    }
}
