using System;
/*  
    Nombre: Miguel Angel Parada
    Grupo 213022_26
    Programa Académico Ingeniería de Sistemas
    Problema Seleccionado: <Escribir número>
    Código Fuente: autoría propia
    creación de Entidad ProgramaAcademico con sus getter y setter
*/
namespace Entities
{
    public class ProgramaAcademico
    {
        const double valorCredito = 200000;
        private String nombrePrograma;
        private int numeroCreditos;
        private double descuento;

        public ProgramaAcademico(string nombrePrograma, int numeroCreditos, double descuento)
        {
            this.nombrePrograma = nombrePrograma;
            this.numeroCreditos = numeroCreditos;
            this.descuento = descuento;
        }

        public double ValorCredito => valorCredito;
        public string NombrePrograma { get => nombrePrograma; set => nombrePrograma = value; }
        public int NumeroCreditos { get => numeroCreditos; set => numeroCreditos = value; }
        public double Descuento { get => descuento; set => descuento = value; }
    }
}