using System;
using System.Collections.Generic;
/*  
    Nombre: Miguel Angel Parada
    Grupo 213022_26
    Programa Académico Ingeniería de Sistemas
    Problema Seleccionado: <Escribir número>
    Código Fuente: autoría propia
    creación de Entidad ProgramaAcademico con sus getter y setter
    constructor de clase vacio para incializar lista de programas academicos
    metodos de clase y ciclos forEach
*/
namespace Entities
{
    public class Reporte
    {
        private List<string> programas = new List<string>();
        private List<Matricula> matriculas = new List<Matricula>();

        public List<Matricula> Matriculas { get => matriculas; set => matriculas = value; }

        public Reporte()
        {
            programas.Add("Ingeniería de Sistemas");
            programas.Add("Psicología");
            programas.Add("Economía");
            programas.Add("Comunicación Social");
            programas.Add("Administración de Empresas");
        }

        public void imprimirReporte()
        {
            if (this.Matriculas != null)
            {
                Console.WriteLine("-------------REPORTE-----------");
                programas.ForEach((programa) =>
                {
                    int cantidadInscritos = this.getCantidadInscritosPorPrograma(programa);
                    int cantidadCreditosInscritos = this.getCreditosInscritosPorPrograma(programa);
                    Console.WriteLine("\tLa cantidad de inscritos del Programa Academico " + programa +
                    " son: " + cantidadInscritos);
                    Console.WriteLine("\tLa cantidad de créditos inscritos del Programa Academico " + programa +
                    " son: " + cantidadCreditosInscritos);
                });

                int totalCreditos = getTotalCreditosInscritos();
                Console.WriteLine("\tTotal de créditos inscritos en el tercer período académico del 2020 son: " + totalCreditos);

                double valorMatriculasSinDescuento = getValorMatriculasSinDescuento();
                Console.WriteLine("\tValor total pagado por los estudiantes sin tener en cuenta el descuento: " + valorMatriculasSinDescuento);

                double valorDescuentos = getDescuentosRealizados();
                Console.WriteLine("\tValor total de descuentos aplicados por la universidad a los estudiantes.: " + valorDescuentos);

                double valorNetoMatriculas = getValorNetoMatriculas();
                Console.WriteLine("\tValor neto de las inscripciones del primer semestre del 2020. es: " + valorNetoMatriculas);
            }
            else
            {
                Console.WriteLine("\tNo se han realizado matriculas");
            }

        }

        public double getDescuentosRealizados()
        {
            double descuentosRealizados = 0;
            this.matriculas.ForEach(matricula => descuentosRealizados += matricula.Descuento);

            return descuentosRealizados;
        }

        public double getValorMatriculasSinDescuento()
        {
            double valorTotalMatriculas = 0;
            this.matriculas.ForEach(matricula => valorTotalMatriculas += matricula.ValorTotal);

            return valorTotalMatriculas;
        }

        public double getValorNetoMatriculas()
        {
            return this.getValorMatriculasSinDescuento() - this.getDescuentosRealizados();
        }

        public int getTotalCreditosInscritos()
        {
            int creditosInscritos = 0;
            this.matriculas.ForEach(matricula => creditosInscritos += matricula.CreditosInscritos);
            return creditosInscritos;
        }

        public int getCreditosInscritosPorPrograma(string programa)
        {
            int creditosPorPrograma = 0;
            List<Matricula> matriculasPorPrograma = this.matriculas.FindAll(matricula => matricula.ProgramaAcademico.NombrePrograma == programa);
            matriculasPorPrograma.ForEach(matricula => creditosPorPrograma += matricula.CreditosInscritos);
            return creditosPorPrograma;

        }

        public int getCantidadInscritosPorPrograma(string programa)
        {
            List<Matricula> matriculasPorPrograma = this.matriculas.FindAll(matricula => matricula.ProgramaAcademico.NombrePrograma == programa);
            return matriculasPorPrograma.Count;
        }

        public void añadirMatricula(Matricula matricula)
        {
            List<Matricula> matriculasEstudiantes = this.Matriculas;
            matriculasEstudiantes.Add(matricula);

            this.Matriculas = matriculasEstudiantes;
        }
    }
}