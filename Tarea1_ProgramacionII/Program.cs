using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_ProgramacionII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;


    namespace Tarea1_ProgramacionII
    {
        class Program
        {


            // Aumento segun tipo de empleado
            static double Aumento(double salarioOrdinario, byte tipoEmpleado)
            {
                switch (tipoEmpleado)
                {
                    case 1: return salarioOrdinario * 0.15; // Operario
                    case 2: return salarioOrdinario * 0.10; // Tecnico
                    case 3: return salarioOrdinario * 0.05; // Profesional
                    default: return 0;
                }
            }

            // Salario bruto 
            static double SalarioBruto(double salarioOrdinario, byte tipoEmpleado)
            {
                return salarioOrdinario + Aumento(salarioOrdinario, tipoEmpleado);
            }

            // Deduccion de la ley
            static double Deduccion(double salarioBruto)
            {
                return salarioBruto * 0.0917;
            }

            // Salario neto 
            static double SalarioNeto(double salarioOrdinario, byte tipoEmpleado)
            {
                double bruto = SalarioBruto(salarioOrdinario, tipoEmpleado);
                double deduccion = Deduccion(bruto);
                return bruto - deduccion;
            }

            // funcion principal
            static void Main()
            {
                Menu();
            }

            // 
            static void Menu()
            {
                byte opcion;
                do
                {
                    Console.WriteLine("Que opcion te gustaria realizar?");
                    Console.WriteLine("1: Ingresar empleados y ver calculos");
                    Console.WriteLine("2: Salir del sistema");

                    opcion = byte.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            datos_empleado();
                            break;

                        case 2:
                            Console.WriteLine("Has salido del sistema de empleados.");
                            return;

                        default:
                            Console.WriteLine("Opcion no valida.");
                            break;
                    }

                } while (opcion != 2);
            }

            // funciones
            static void datos_empleado()
            {
                int i = 0;

                int Cantidad_operarios = 0;
                double SalarioNetoOperarios = 0;

                int Cantidad_tecnicos = 0;
                double SalarioNetoTecnicos = 0;

                int Cantidad_profesionales = 0;
                double SalarioNetoProfesionales = 0;

                do
                {
                    Console.WriteLine("Ingrese su numero de cedula: ");
                    string cedula = Console.ReadLine();

                    Console.WriteLine("Ingrese su nombre: ");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Cuantas fueron sus horas laboradas? ");
                    double horas_laboradas = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el precio por hora laborada: ");
                    double precio_hora = double.Parse(Console.ReadLine());

                    double salario_ordinario = (horas_laboradas * precio_hora);

                    Console.WriteLine("Digite el numero de empleado que labora actualmente:  \n 1 - Operario \n 2 - Tecnico \n 3 - Profesional");
                    byte tipo_empleado = byte.Parse(Console.ReadLine());


                    double aumento = Aumento(salario_ordinario, tipo_empleado);
                    double salario_bruto = SalarioBruto(salario_ordinario, tipo_empleado);
                    double deducciones = Deduccion(salario_bruto);
                    double salario_neto = SalarioNeto(salario_ordinario, tipo_empleado);


                    switch (tipo_empleado)
                    {
                        case 1:
                            Cantidad_operarios++;
                            SalarioNetoOperarios += salario_neto;
                            break;
                        case 2:
                            Cantidad_tecnicos++;
                            SalarioNetoTecnicos += salario_neto;
                            break;
                        case 3:
                            Cantidad_profesionales++;
                            SalarioNetoProfesionales += salario_neto;
                            break;
                    }

                    Console.WriteLine($"\nResumen del empleado:");
                    Console.WriteLine($"\nCédula: {cedula} \n Nombre: {nombre} \n Tipo de empleado: {tipo_empleado} \n Salario por hora: {precio_hora} \n Salario ordinario:{salario_ordinario} \n Aumento: {aumento} \n Salario bruto: {salario_bruto}\n Deducciones CCSS: {deducciones} \n Salario Neto: {salario_neto}");

                    Console.WriteLine("\nTe gustaria ingresar otro empleado? (Si/No)");
                    string respuesta = Console.ReadLine().ToLower();
                    if (respuesta == "no")
                    {
                        i = 1;
                    }

                } while (i != 1);


                Console.WriteLine(" ___ RESULTADOS FINALES ___ ");

                if (Cantidad_operarios > 0)
                    Console.WriteLine($"Operarios: Cantidad: {Cantidad_operarios}, Promedio Neto: {SalarioNetoOperarios / Cantidad_operarios}");
                if (Cantidad_tecnicos > 0)
                    Console.WriteLine($"Tecnicos: Cantidad: {Cantidad_tecnicos}, Promedio Neto: {SalarioNetoTecnicos / Cantidad_tecnicos}");
                if (Cantidad_profesionales > 0)
                    Console.WriteLine($"Profesionales: Cantidad: {Cantidad_profesionales}, Promedio Neto: {SalarioNetoProfesionales / Cantidad_profesionales}");
            }
        }
    }


}

       
