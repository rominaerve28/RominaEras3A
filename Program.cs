using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoslosprogramas
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            do
            {
                Console.WriteLine("-------------------------------.-------------------------------");
                Console.WriteLine("1.- Numero mayor");
                Console.WriteLine("2.- Cuadro de asteriscos");
                Console.WriteLine("3.- Total de una factura");
                Console.WriteLine("4.- Salario semanal de un empleado");
                Console.WriteLine("5.- Triangulo con asteriscos");
                Console.WriteLine("6.- Rombo con asteriscos");
                Console.WriteLine("7.- Numeros del 1 al 100 y del 100 al 1");
                Console.WriteLine("8.- Numero de 1 en 1, 2 en 2 y 3 en 3");
                Console.WriteLine("9.- Tablas de multiplicar del 1 al 15");
                Console.WriteLine("10.- Sumatoria, Factorial y Salida ");
                Console.WriteLine("11.- Salir ");
                Console.WriteLine("-------------------------------.-------------------------------");
                
                Console.WriteLine("Escriba su opcion");
                String opcion1 = Console.ReadLine();
                if (opcion1 == "1")
                {
                    //programa uno
                    int nmayor = 0;
                    Console.WriteLine("Cantidad de numeros a ingresar");
                    String ci = Console.ReadLine();
                    int cin = Convert.ToInt32(ci);
                    for (int i = 1; i <= cin; i++)
                    {
                        Console.WriteLine("ingrese numero");
                        String numero = Console.ReadLine();
                        int numeronu = Convert.ToInt16(numero);

                        if (nmayor < numeronu)
                        {
                            nmayor = numeronu;
                        }
                    }
                    Console.WriteLine("el numero mayor de la serie es: {0}", nmayor);
                }

                if (opcion1 == "2")
                {
                    //programa dos
                    Console.WriteLine("Ingrese un numero entero");
                    string numero = Console.ReadLine();
                    int numeroent = Convert.ToInt32(numero);
                    for (int i = 0; i < numeroent; i++)
                    {
                        for (int j = 0; j < numeroent; j++)
                        {
                            if ((j > 0 && j < numeroent - 1) && (i > 0 && i < numeroent - 1))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }

                        }
                        Console.WriteLine(" ");
                    }
                }

                if (opcion1=="3")
                {
                    // programa tres 
                    double preciotot = 0, totalapagar = 0;
                    Console.Write("nombre del producto");
                    string nomaux = Console.ReadLine();
                    int auxi = 0;                    
                    do
                    {
                        Console.Write("cantidad vendida");
                        string cantaux = Console.ReadLine();
                        int cant = Convert.ToInt32(cantaux);
                        if (cant == 0)
                        {
                            Console.WriteLine("el total a pagar de la factura es:" + totalapagar);
                            auxi = 1;
                        }
                        else
                        {
                            Console.Write("precio del producto");
                            string precioaux = Console.ReadLine();
                            Double precio = Convert.ToDouble(precioaux);
                            preciotot = cant * precio;
                            totalapagar = totalapagar + preciotot;
                        }
                    } while (auxi == 0);
                }

                if (opcion1 == "4")
                {
                    // programa 4

                    int quince = 0, veinti = 0, n = 0, resta = 0, horasn = 0, total = 0;
                    do
                    {
                        Console.WriteLine("Ingresar la cantidad de empleados");
                        String empleadoaux = Console.ReadLine();
                        int empleado = Convert.ToInt32(empleadoaux);
                        for (int i = 1; i <= empleado; i++)
                        {
                            Console.WriteLine("Ingresar horas trabajadas");
                            String htaux = Console.ReadLine();
                            int ht = Convert.ToInt32(htaux);

                            if (ht <= 35)
                            {
                                quince = ht * 15;
                                Console.WriteLine("No tiene horas extras. Su sueldo es:" + quince);
                            }
                            else if (ht > 35)
                            {
                                resta = ht - 35;
                                horasn = ht - resta;
                                veinti = resta * 22;
                                quince = horasn * 15;
                                total = veinti + quince;
                                Console.WriteLine("Tiene horas extras. Su sueldo es:" + total);
                            }
                        }
                        Console.WriteLine("¿Desea calcular otro salario?");
                        String respuesta = Console.ReadLine();
                        if (respuesta == "si")
                        {
                            n = 0;
                        }
                        else
                        {
                            n = 1;
                        }
                    } while (n == 0);
                }

                if (opcion1 == "5")
                {
                    //programa 5

                    Console.WriteLine("ingrese numero entero");
                    string numaux = Console.ReadLine();
                    int num = Convert.ToInt32(numaux);
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(" ");
                        }
                        for (int j = 0; j < num - i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < 2 * i + 1; j++)
                        {
                            Console.Write("*");
                        }
                    }
                }

                if (opcion1 == "6")
                {
                    //programa 6
                    Console.WriteLine("ingrese numero entero");
                    string numaux = Console.ReadLine();
                    int num = Convert.ToInt32(numaux);

                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(" ");
                        }
                        for (int j = 0; j < num - i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < 2 * i + 1; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    for (int i = num - 2; i >= 0; i--)
                    {

                        for (int j = 0; j < 1; j++)
                        {
                            Console.WriteLine(" ");
                        }
                        for (int j = 0; j < num - i - 1; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < 2 * i + 1; j++)
                        {
                            Console.Write("*");
                        }

                    }
                }

                if (opcion1 == "7")
                {
                    //programa siete
                    int res = 101, i = 0;
                    Console.Write("Los numeros del 1 al 100       ");
                    Console.WriteLine("Los numeros del 100 al 1 ");
                    for (i = 1; i <= 100; i++)
                    {
                        res = res - 1;

                        Console.WriteLine("|   {0}                 |                    {1}   |", i, res);
                    }
                }

                if (opcion1 == "8")
                {
                    //programa ocho

                    Console.WriteLine("Ingrese un número");
                    String numeroa = Console.ReadLine();
                    int numero = Convert.ToInt32(numeroa);

                    Console.Write("Numeros de uno en uno       ");
                    Console.Write("Numeros de dos en dos       ");
                    Console.WriteLine("Numeros de tres en tres  ");

                    int i = 0;

                    for (i = 1; i <= numero || i * 2 < numero || i * 3 < numero; i++)
                    {

                        Console.WriteLine("            {0}   ", i);
                        if (i * 2 < numero)
                        {
                            Console.WriteLine("                                        {0}    ", i * 2);

                            if (i * 3 < numero)
                            {
                                Console.WriteLine("                                                                    {0}     ", i * 3);
                            }

                        }                        
                    }
                }

                if (opcion1 == "9")
                {
                    //programa nueve

                    int resultado = 0, cuanta = 15;
                    /* Console.WriteLine("Cuantas tablas desea visualizar");
                      String cuantaux = Console.ReadLine();
                      int cuanta = Convert.ToInt32(cuantaux);
                      */
                    Console.WriteLine("                                                 ");
                    Console.WriteLine("                           Tablas de multiplicar                       ");
                    Console.WriteLine("                                                 ");
                    for (int i = 1; i <= cuanta; i++)

                    {

                        for (int j = 0; j <= 15; j++)
                        {
                            resultado = i * j;
                            Console.WriteLine("                               {0} * {1} = {2}                         ", i, j, resultado);
                        }
                        Console.WriteLine("                                                 ");
                        Console.WriteLine("                   *************************************                                         ");
                        Console.WriteLine("                                                 ");
                    }
                }

                if (opcion1 == "10")
                {
                    //programa diez

                    int n = 0;
                    do
                    {
                        int sum = 0, resultado = 1;
                        Console.WriteLine("Escriba su opcion");
                        Console.WriteLine("1.- Salir");
                        Console.WriteLine("2.- Sumatoria");
                        Console.WriteLine("3.- Factorial");

                        String opcion = Console.ReadLine();


                        if (opcion == "1")
                        {

                            n = 1;

                        }

                        if (opcion == "2")
                        {

                            Console.WriteLine("Ingrese numero");

                            String numeaux = Console.ReadLine();
                            int nume = Convert.ToInt32(numeaux);

                            for (int i = 1; i <= nume; i++)
                            {


                                sum = sum + i;

                            }
                            Console.WriteLine("La suma es:" + sum);

                        }

                        if (opcion == "3")
                        {
                            Console.WriteLine("Ingrese numero");
                            String numeraux = Console.ReadLine();
                            int numer = Convert.ToInt32(numeraux);

                            for (int i = 1; i <= numer; i++)
                            {
                                resultado = resultado * i;
                            }
                            Console.WriteLine("El factorial del numero es:" + resultado);
                        }                 
                    } while (n == 0);
                }

                if (opcion1 == "11")
                {
                    no = 1;
                }

            } while (no==0);
            Console.Clear();
            
        }
    }
}
