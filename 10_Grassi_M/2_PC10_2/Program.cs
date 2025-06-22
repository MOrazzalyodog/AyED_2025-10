using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadTPs, cantidadExamenes, tpsAprobados;
            double porcentajeTPsAprobados, promedioExamenes;
            bool apruebaExamenes = false, apruebaTPs = false;

            Console.Write("Ingrese la cantidad de Trabajos Practicos: ");
            cantidadTPs = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de Exámenes: ");
            cantidadExamenes = int.Parse(Console.ReadLine());

            double[] notasTPs = new double[cantidadTPs];
            double[] notasExamenes = new double[cantidadExamenes];

            tpsAprobados = 0;
            for (int i = 0; i < cantidadTPs; i++)
            {
                Console.Write("Ingrese la nota del TP #{0}: ", (i + 1));
                notasTPs[i] = double.Parse(Console.ReadLine());

                if (notasTPs[i] >= 6)
                {
                    tpsAprobados++;
                }
            }

            double sumaNotasExamenes = 0;
            for (int i = 0; i < cantidadExamenes; i++)
            {
                Console.Write("Ingrese la nota del Examen #{0}: ", (i + 1));
                notasExamenes[i] = double.Parse(Console.ReadLine());

                sumaNotasExamenes += notasExamenes[i];
            }


            if (cantidadExamenes > 0)
            {
                promedioExamenes = sumaNotasExamenes / cantidadExamenes;
            }
            else
            {
                promedioExamenes = 0;
            }


            if (cantidadTPs > 0)
            {
                porcentajeTPsAprobados = (double)tpsAprobados / cantidadTPs * 100;
            }
            else
            {
                porcentajeTPsAprobados = 0;
            }

            if (promedioExamenes >= 6)
            {
                apruebaExamenes = true;
            }
            if (porcentajeTPsAprobados >= 75)
            {
                apruebaTPs = true;
            }

            if (apruebaExamenes && apruebaTPs)
            {
                Console.WriteLine("Phineas y Ferb pueden aprobar la materia");
            }
            else
            {
                Console.WriteLine("Phineas y Ferb no cumplen los requisitos para aprobar la materia");
            }
        }
    }
}
