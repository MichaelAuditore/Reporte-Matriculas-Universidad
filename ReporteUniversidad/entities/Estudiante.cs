using System;

/*  
    Nombre: Miguel Angel Parada
    Grupo 213022_26
    Programa Académico Ingeniería de Sistemas
    Problema Seleccionado: <Escribir número>
    Código Fuente: autoría propia
    creación de Entidad Estudiante con sus getter y setter
*/
namespace Entities
{
    public class Estudiante
    {
        private String nombre;
        private String identificacion;

        public Estudiante(string nombre, string identificacion)
        {
            this.nombre = nombre;
            this.identificacion = identificacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
    }
}