/*  
    Nombre: Miguel Angel Parada
    Grupo 213022_26
    Programa Académico Ingeniería de Sistemas
    Problema Seleccionado: <Escribir número>
    Código Fuente: autoría propia
    creación de Entidad Matricula con sus getter y setter
*/
namespace Entities
{
    public class Matricula
    {
        private Estudiante estudiante;
        private ProgramaAcademico programaAcademico;
        private int creditosInscritos;
        private double valorTotal;
        private double descuento;
        private double valorConDescuento;
        private string tipoPago;
        public Estudiante Estudiante { get => estudiante; set => estudiante = value; }
        public ProgramaAcademico ProgramaAcademico { get => programaAcademico; set => programaAcademico = value; }
        public int CreditosInscritos { get => creditosInscritos; set => creditosInscritos = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double ValorConDescuento { get => valorConDescuento; set => valorConDescuento = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }

        public override string ToString()
        {
            return ("\n\tNombre: " + this.Estudiante.Nombre +
             "\n\tDocumento: " + this.Estudiante.Identificacion +
             "\n\tPrograma Academico: " + this.ProgramaAcademico.NombrePrograma +
             "\n\tCreditos Inscritos: " + this.CreditosInscritos +
             "\n\tTipo de pago: " + this.TipoPago +
             "\n\tValor a pagar sin descuento: " + this.ValorTotal +
             "\n\tValor a pagar si existe descuento: " + this.ValorConDescuento
             );

        }
    }
}