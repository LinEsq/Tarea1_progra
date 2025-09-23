using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_ProgramacionII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            datos_empleado();

        }
        static void datos_empleado()
        {
            int i = 0;

            int Cantidad_operarios = 0;
            double SalarioNetoOperarios = 0;
            double PromedioSalarioOperarios = 0;

            int Cantidad_tecnicos = 0;
            double SalarioNetoTecnicos = 0;
            double PromedioSalarioTecnicos = 0;

            int Cantidad_profesionales = 0;
            double SalarioNetoProfesionales = 0;
            double PromedioSalarioProfesionales = 0;


            do
            {
                Console.WriteLine("Ingrese su numero de cedula ");
                string cedula = Console.ReadLine();

                Console.WriteLine("Ingrese su nombre ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Cuantas fueron sus horas laboradas? ");
                double horas_laboradas = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el precio por hora laborada ");
                double precio_hora = double.Parse(Console.ReadLine());

                double salario_ordinario = (horas_laboradas * precio_hora);


                Console.WriteLine("Digite el numero del tipo de empleado que usted labora:  \n 1 - Operario. \n 2 - Tecnico. \n 3 - Profesional");
                byte tipo_empleado = byte.Parse(Console.ReadLine());

                switch (tipo_empleado)
                {
                    case 1:
                        Cantidad_operarios+=1;
                        double aumento1 = (salario_ordinario * 0.15);
                        double salario_bruto1 = (salario_ordinario + aumento1);
                        double DeduccionesLey1 = (salario_bruto1*0.0917);
                        double salario_neto1 = salario_bruto1 - DeduccionesLey1;
                        SalarioNetoOperarios = SalarioNetoOperarios + salario_neto1;

                        Console.WriteLine($" Cedula:{cedula} \n Nombre del empleado:{nombre} \n Tipo de empleado:{tipo_empleado} \n Salario por hora:{precio_hora} \n Cantidad de horas:{horas_laboradas} \n Salario ordinario:{precio_hora*horas_laboradas} \n Aumento por 15%:{aumento1} \n Salario bruto:{salario_bruto1} \n Deduccion CCSS:{DeduccionesLey1} \n Salario Neto: {salario_neto1}");

                        Console.WriteLine("Desea ingresar otro empleado? Si/No");
                        string respuesta = Console.ReadLine();
                        if (respuesta.ToLower() == "si")
                        {
                            break;
                        }
                        else
                        {
                            if (respuesta.ToLower() == "no")
                            {
                                i = 1;

                            }
                        }
                        break;

                    case 2:
                        Cantidad_tecnicos += 1;
                        double aumento2 = (salario_ordinario * 0.10);
                        double salario_bruto2 = (salario_ordinario + aumento2);
                        double DeduccionesLey2 = (salario_bruto2 * 0.0917);
                        double salario_neto2 = salario_bruto2 - DeduccionesLey2;
                        SalarioNetoTecnicos = SalarioNetoOperarios + salario_neto2;

                        Console.WriteLine($" Cedula:{cedula} \n Nombre del empleado:{nombre} \n Tipo de empleado:{tipo_empleado} \n Salario por hora:{precio_hora} \n Cantidad de horas:{horas_laboradas} \n Salario ordinario:{precio_hora * horas_laboradas} \n Aumento por 10%:{aumento2} \n Salario bruto:{salario_bruto2} \n Deduccion CCSS:{DeduccionesLey2} \n Salario Neto: {salario_neto2}");

                        Console.WriteLine("Desea ingresar otro empleado? Si/No");
                        string respuesta2 = Console.ReadLine();
                        if (respuesta2.ToLower() == "si")
                        {
                            break;
                        }
                        else
                        {
                            if (respuesta2.ToLower() == "no")
                            {
                                i = 1;

                            }
                        }
                        break;

                    case 3:
                        Cantidad_profesionales += 1;
                        double aumento3 = (salario_ordinario * 0.05);
                        double salario_bruto3 = (salario_ordinario + aumento3);
                        double DeduccionesLey3 = (salario_bruto3 * 0.0917);
                        double salario_neto3 = salario_bruto3 - DeduccionesLey3;
                        SalarioNetoProfesionales = SalarioNetoOperarios + salario_neto3;

                        Console.WriteLine($" Cedula:{cedula} \n Nombre del empleado:{nombre} \n Tipo de empleado:{tipo_empleado} \n Salario por hora:{precio_hora} \n Cantidad de horas:{horas_laboradas} \n Salario ordinario:{precio_hora * horas_laboradas} \n Aumento por 5%:{aumento3} \n Salario bruto:{salario_bruto3} \n Deduccion CCSS:{DeduccionesLey3} \n Salario Neto: {salario_neto3}");

                        Console.WriteLine("Desea ingresar otro empleado? Si/No");
                        string respuesta3 = Console.ReadLine();
                        if (respuesta3.ToLower() == "si")
                        {
                            break;
                        }
                        else
                        {
                            if (respuesta3.ToLower() == "no")
                            {
                                i = 1;

                            }
                        }
                        break;
                }

            } while (i != 1);

            Console.WriteLine($"Cantidad de empleados tipo operarios: {Cantidad_operarios}");
            Console.WriteLine($"Acomulado de salarios netos de operarios: {SalarioNetoOperarios}");
            PromedioSalarioOperarios = SalarioNetoOperarios/Cantidad_operarios;
            Console.WriteLine($"Promedio de salario para Operarios: {PromedioSalarioOperarios}");

            Console.WriteLine($"Cantidad de empleados tipo tecnicos: {Cantidad_tecnicos}");
            Console.WriteLine($"Acomulado de salarios netos de tecnicos: {SalarioNetoTecnicos}");
            PromedioSalarioTecnicos = SalarioNetoTecnicos / Cantidad_tecnicos;
            Console.WriteLine($"Promedio de salario para tecnicos: {PromedioSalarioTecnicos}");

            Console.WriteLine($"Cantidad de empleados tipo profesionales: {Cantidad_profesionales}");
            Console.WriteLine($"Acomulado de salarios netos de profesionales: {SalarioNetoProfesionales}");
            PromedioSalarioProfesionales = SalarioNetoProfesionales / Cantidad_profesionales;
            Console.WriteLine($"Promedio de salario para profesionales: {PromedioSalarioProfesionales}");
        }
       
    }
}
