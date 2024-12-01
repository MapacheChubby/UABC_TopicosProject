using System;
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
        public DataTable ObtenerMaterias()
        {
            return universidadDAO.ObtenerMaterias();
        }

        public void InsertarFacultad(string nombre, string ubicacion)
        {
            universidadDAO.InsertarFacultad(nombre, ubicacion);
        }

        public DataTable ObtenerFacultades()
        {
            return universidadDAO.ObtenerFacultades();
        }

        public void EditarFacultad(int id, string nombre, string ubicacion)
        {
            universidadDAO.EditarFacultad(id, nombre, ubicacion);
        }

        public void EliminarFacultad(int id)
        {
            universidadDAO.EliminarFacultad(id);
        }

        public DataTable MostrarPracticas()
        {
            return universidadDAO.ObtenerPracticas();  // Llamar al DAO para obtener los datos
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
            if (id <= 0)
            {
                throw new ArgumentException("El ID de la materia debe ser mayor a cero.", nameof(id));
            }

            // Llamar al DAO
            universidadDAO.EliminarMateria(id);
        }

        public void InsertarPractica(int idPractica, int idMateria, string titulo, string descripcion, DateTime fechaAsignacion, DateTime fechaLimite)
        {
            universidadDAO.InsertarPractica(idPractica, idMateria, titulo, descripcion, fechaAsignacion, fechaLimite);
        }
        public void EliminarPractica(int idPractica)
        {
            try
            {
                // Llamar al DAO para eliminar la práctica
                universidadDAO.EliminarPractica(idPractica);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la práctica: " + ex.Message);
            }
        }
        public void ModificarPractica(int idPractica, int idMateria, string titulo, string descripcion, DateTime fechaAsignacion, DateTime fechaLimite)
        {
            try
            {
                // Llamar al DAO para modificar la práctica
                universidadDAO.ModificarPractica(idPractica, idMateria, titulo, descripcion, fechaAsignacion, fechaLimite);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la práctica: " + ex.Message);
            }
        }


        // Método para autenticación de usuario
        public bool AutenticarUsuario(string username, string password)
        {
            return universidadDAO.LoginCheck(username, password);
        }
    }

}
