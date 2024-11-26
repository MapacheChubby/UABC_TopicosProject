using System.Data;
using Persistencia;

namespace Negocio
{
    public class UniversidadService
    {
        private UniversidadDAO universidadDAO = new UniversidadDAO();

        // Métodos para la entidad Facultad
        public DataTable MostrarFacultades()
        {
            return universidadDAO.ObtenerFacultades();
        }

        public void InsertarFacultad(string nombre, string ubicacion)
        {
            universidadDAO.InsertarFacultad(nombre, ubicacion);
        }

        public void EditarFacultad(int id, string nombre, string ubicacion)
        {
            universidadDAO.EditarFacultad(id, nombre, ubicacion);
        }

        public void EliminarFacultad(int id)
        {
            universidadDAO.EliminarFacultad(id);
        }

        // Métodos para la entidad Materia
        public DataTable MostrarMaterias()
        {
            return universidadDAO.ObtenerMaterias();
        }

        public void InsertarMateria(int idFacultad, string nombre, string codigo, int semestre)
        {
            universidadDAO.InsertarMateria(idFacultad, nombre, codigo, semestre);
        }

        public void EditarMateria(int id, int idFacultad, string nombre, string codigo, int semestre)
        {
            universidadDAO.EditarMateria(id, idFacultad, nombre, codigo, semestre);
        }

        public void EliminarMateria(int id)
        {
            universidadDAO.EliminarMateria(id);
        }

        // Método para autenticación de usuario
        public bool AutenticarUsuario(string username, string password)
        {
            return universidadDAO.LoginCheck(username, password);
        }
    }

}
