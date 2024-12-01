using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Persistencia
{
    public class UniversidadDAO
    {
        private Conexion conn = new Conexion();
        MySqlCommand command = new MySqlCommand();
        DataTable table = new DataTable();

        // Mostrar todas las facultades
        public DataTable ObtenerFacultades()
        {
            DataTable table = new DataTable();  // Asegúrate de crear una nueva instancia de DataTable

            // Abrir conexión y ejecutar el procedimiento almacenado
            command.Connection = conn.AbrirConexion();
            command.CommandText = "MostrarFacultades";
            command.CommandType = CommandType.StoredProcedure;

            using (var reader = command.ExecuteReader())
            {
                table.Load(reader);  // Cargar los datos en el DataTable
            }

            conn.CerrarConexion();  // Cerrar la conexión

            return table;  // Retornar el DataTable con los datos más recientes
        }

        // Insertar una nueva facultad
        public void InsertarFacultad(string nombre, string ubicacion)
        {
            try
            {
                using (var command = new MySqlCommand())
                {
                    command.Connection = conn.AbrirConexion();
                    command.CommandText = "InsertarFacultad";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@p_nombre", nombre);
                    command.Parameters.AddWithValue("@p_ubicacion", ubicacion);

                    command.ExecuteNonQuery();
                }
                conn.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1644) // Código para excepciones generadas por SIGNAL
                {
                    throw new Exception("Error: " + ex.Message); // Mostrar el mensaje personalizado
                }
                else
                {
                    throw; // Re-lanzar otras excepciones no manejadas
                }
            }
        }


        // Editar una facultad existente
        public void EditarFacultad(int idFacultad, string nombre, string ubicacion)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EditarFacultad";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_id", idFacultad);
            command.Parameters.AddWithValue("@p_nombre", nombre);
            command.Parameters.AddWithValue("@p_ubicacion", ubicacion);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Eliminar una facultad
        public void EliminarFacultad(int idFacultad)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "EliminarFacultad";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_id", idFacultad);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Obtener todas las materias
        public DataTable ObtenerMaterias()
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "`ObtenerMaterias`";
            command.CommandType = CommandType.StoredProcedure;

            using (var reader = command.ExecuteReader())
            {
                table.Load(reader);
            }
            conn.CerrarConexion();
            return table;
        }

        public DataTable ObtenerFacultadesCB()
        {
            DataTable table = new DataTable();
            using (var command = new MySqlCommand())
            {
                command.Connection = conn.AbrirConexion();
                command.CommandText = "ObtenerFacultades";
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            conn.CerrarConexion();
            return table;
        }


        // Insertar una nueva materia
        public void InsertarMateria(int idFacultad, string nombre, string codigo, int semestre)
        {
            command.Connection = conn.AbrirConexion();
            command.CommandText = "InsertarMateria";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_ID_Facultad", idFacultad);
            command.Parameters.AddWithValue("@p_Nombre", nombre);
            command.Parameters.AddWithValue("@p_Codigo", codigo);
            command.Parameters.AddWithValue("@p_Semestre", semestre);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            conn.CerrarConexion();
        }

        // Editar una materia existente
        public void EditarMateria(int idMateria, int idFacultad, string nombre, string codigo, int semestre)
        {
            try
            {
                command.Connection = conn.AbrirConexion();
                command.CommandText = "EditarMateria";
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@p_idMateria", idMateria);
                command.Parameters.AddWithValue("@p_idFacultad", idFacultad);
                command.Parameters.AddWithValue("@p_nombre", nombre);
                command.Parameters.AddWithValue("@p_codigo", codigo);
                command.Parameters.AddWithValue("@p_semestre", semestre);

                // Ejecutar el procedimiento almacenado
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar errores (log, mensaje, etc.)
                throw new Exception("Error al editar la materia: " + ex.Message);
            }
            finally
            {
                // Limpiar los parámetros y cerrar la conexión
                command.Parameters.Clear();
                conn.CerrarConexion();
            }
        }


        // Eliminar una materia
        public void EliminarMateria(int id)
        {
            try
            {
                command.Connection = conn.AbrirConexion();
                command.CommandText = "EliminarMateria";
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro
                command.Parameters.AddWithValue("@p_idMateria", id);

                // Ejecutar procedimiento almacenado
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la materia: " + ex.Message);
            }
            finally
            {
                // Limpiar parámetros y cerrar conexión
                command.Parameters.Clear();
                conn.CerrarConexion();
            }
        }
        public DataTable ObtenerMateriasCB()
        {
            DataTable table = new DataTable();

            try
            {
                using (var command = new MySqlCommand())
                {
                    command.Connection = conn.AbrirConexion();
                    command.CommandText = "ObtenerMaterias"; // Nombre del procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        table.Load(reader); // Carga el resultado en un DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las materias: " + ex.Message);
            }
            finally
            {
                conn.CerrarConexion();
            }

            return table;
        }

        public DataTable ObtenerPracticas()
        {
            DataTable table = new DataTable();  // Crear instancia del DataTable

            try
            {
                // Abrir conexión y configurar el comando
                command.Connection = conn.AbrirConexion();
                command.CommandText = "MostrarPracticas";  // Nombre del procedimiento almacenado
                command.CommandType = CommandType.StoredProcedure;

                // Ejecutar el comando y cargar los datos en el DataTable
                using (var reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener prácticas: " + ex.Message);
            }
            finally
            {
                conn.CerrarConexion();  // Asegurar el cierre de la conexión
            }

            return table;  // Retornar el DataTable con los datos de prácticas
        }

        public void InsertarPractica(int idPractica, int idMateria, string titulo, string descripcion, DateTime fechaAsignacion, DateTime fechaLimite)
        {
            try
            {
                command.Connection = conn.AbrirConexion(); // Abre la conexión
                command.CommandText = "InsertarPractica"; // Nombre del procedimiento almacenado
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                command.Parameters.AddWithValue("@p_ID_Practica", idPractica);
                command.Parameters.AddWithValue("@p_ID_Materia", idMateria);
                command.Parameters.AddWithValue("@p_Titulo", titulo);
                command.Parameters.AddWithValue("@p_Descripcion", descripcion);
                command.Parameters.AddWithValue("@p_Fecha_Asignacion", fechaAsignacion);
                command.Parameters.AddWithValue("@p_Fecha_Limite", fechaLimite);

                command.ExecuteNonQuery(); // Ejecuta la inserción

                command.Parameters.Clear(); // Limpia los parámetros
            }
            catch (Exception ex)
            {
                // Manejar errores (log, mensaje, etc.)
                throw new Exception("Error al insertar la práctica: " + ex.Message);
            }
            finally
            {
                conn.CerrarConexion(); // Cierra la conexión
            }
        }

        public void EliminarPractica(int idPractica)
        {
            
                // Preparar el comando para ejecutar el procedimiento almacenado
                command.Connection = conn.AbrirConexion();
                command.CommandText = "EliminarPractica";
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro para el ID_Practica
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@p_ID_Practica", idPractica);

                // Ejecutar el procedimiento almacenado
                command.ExecuteNonQuery();

                conn.CerrarConexion();  // Cerrar la conexión

                
           
        }
        public void ModificarPractica(int idPractica, int idMateria, string titulo, string descripcion, DateTime fechaAsignacion, DateTime fechaLimite)
        {
            try
            {
                // Preparar el comando para ejecutar el procedimiento almacenado
                command.Connection = conn.AbrirConexion();
                command.CommandText = "ModificarPractica";
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros para la modificación
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@p_ID_Practica", idPractica);
                command.Parameters.AddWithValue("@p_ID_Materia", idMateria);
                command.Parameters.AddWithValue("@p_Titulo", titulo);
                command.Parameters.AddWithValue("@p_Descripcion", descripcion);
                command.Parameters.AddWithValue("@p_Fecha_Asignacion", fechaAsignacion);
                command.Parameters.AddWithValue("@p_Fecha_Limite", fechaLimite);

                // Ejecutar el procedimiento almacenado
                command.ExecuteNonQuery();

                conn.CerrarConexion();  // Cerrar la conexión

             
            }
            catch (Exception ex)
            {
                
            }
        }



        // Login de usuario
        public bool LoginCheck(string username, string password)
        {
            bool isAuthenticated = false;

            command.Connection = conn.AbrirConexion();
            command.CommandText = "LoginUsuario";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@p_username", username);
            command.Parameters.AddWithValue("@p_password", password);

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)  // Si el lector tiene filas, las credenciales son válidas
                {
                    isAuthenticated = true;
                }
            }

            command.Parameters.Clear();
            conn.CerrarConexion();
            return isAuthenticated;
        }
    }
}
