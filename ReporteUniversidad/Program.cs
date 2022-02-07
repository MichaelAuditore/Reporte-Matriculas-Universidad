using System;
using System.Collections.Generic;
using Entities;

/*  
    Nombre: Miguel Angel Parada
    Grupo 213022_26
    Programa Académico Ingeniería de Sistemas
    Problema Seleccionado: <Escribir número>
    Código Fuente: autoría propia
    Se ha hecho uso de ciclo while, condicionales if else y ternarios,
    llamado de metodos de entidades y creación de entidades 
*/
namespace ReporteUniversidad
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Reporte nuevoReporte = new Reporte();
                ProgramaAcademico programaAcademico = null;
                Estudiante estudiante = null;
                String seleccion;
                while (true)
                {

                    Console.WriteLine("------INSCRIPCIONES UNIVERSIDAD ------");
                    Console.WriteLine("Seleccione una de estas opciones\n" +
                    "\n1. Inscribir Estudiante" +
                    "\n2. Imprimir Reporte" +
                    "\n3. Salir");

                    seleccion = Console.ReadLine();

                    if (seleccion == "1")
                    {
                        Console.WriteLine("Ingrese nombre de Estudiante");
                        String nombreEstudiante = Console.ReadLine();
                        Console.WriteLine("Ingrese numero de Documento");
                        String identificacion = Console.ReadLine();
                        estudiante = new Estudiante(nombreEstudiante, identificacion);
                        Console.WriteLine("Seleccione el programa de su interes\n" +
                        "\n1. Ingeniería de sistemas\n" +
                        "\n2. Psicología\n" +
                        "\n3. Economía\n" +
                        "\n4. Comunicación Social\n" +
                        "\n5. Administración de Empresas");
                        seleccion = Console.ReadLine();

                        switch (seleccion)
                        {
                            case "1":
                                programaAcademico = new ProgramaAcademico("Ingeniería de Sistemas", 20, 0.18);
                                break;
                            case "2":
                                programaAcademico = new ProgramaAcademico("Psicología", 16, 0.12);
                                break;
                            case "3":
                                programaAcademico = new ProgramaAcademico("Economía", 18, 0.1);
                                break;
                            case "4":
                                programaAcademico = new ProgramaAcademico("Comunicación Social", 18, 0.5);
                                break;
                            case "5":
                                programaAcademico = new ProgramaAcademico("Administración de Empresas", 20, 0.15);
                                break;
                            default:
                                Console.WriteLine("No ha seleccionado una opción correcta");
                                break;
                        }

                        Matricula matriculaEstudiante = new Matricula();
                        matriculaEstudiante.ProgramaAcademico = programaAcademico;
                        matriculaEstudiante.Estudiante = estudiante;

                        int creditosAInscribir = 0;
                        while (creditosAInscribir <= 0 || creditosAInscribir > programaAcademico.NumeroCreditos)
                        {
                            Console.WriteLine("Cuantos creditos desea inscribir el minimo permitido es 1 y el máximo son " +
                             programaAcademico.NumeroCreditos + "\nSe repetirá esta pregunta si ingresa un valor no valido");
                            creditosAInscribir = int.Parse(Console.ReadLine());
                        }

                        matriculaEstudiante.CreditosInscritos = creditosAInscribir;
                        double valorMatricula = creditosAInscribir * programaAcademico.ValorCredito;
                        matriculaEstudiante.ValorTotal = valorMatricula;

                        Console.WriteLine("Seleccione un tipo de pago\n" +
                        "\n1. Efectivo" +
                        "\n2. Pago en Linea");
                        seleccion = Console.ReadLine();

                        matriculaEstudiante.TipoPago = seleccion == "1" ? "Efectivo" : "Pago en Linea";
                        matriculaEstudiante.Descuento = seleccion == "1" ? (valorMatricula * programaAcademico.Descuento) : 0;
                        matriculaEstudiante.ValorConDescuento = valorMatricula - matriculaEstudiante.Descuento;

                        nuevoReporte.añadirMatricula(matriculaEstudiante);

                        Console.WriteLine("--------Estudiante inscrito correctamente------" + matriculaEstudiante);
                    }
                    else if (seleccion == "2")
                    {
                        nuevoReporte.imprimirReporte();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e);
            }


        }
    }
}
