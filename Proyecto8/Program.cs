using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto8
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            char opcion;
            Util util = new Util(); // Class Util
            MostrarMensaje mensaje;

            do
            {
                Console.Clear();
                Console.WriteLine("********************************************");
                Console.WriteLine("\t 1- CALCULAR FIBONACCI");
                Console.WriteLine("\t 2- DIVIDIR");
                Console.WriteLine("\t 3- MOSTRAR MENSAJE");
                Console.WriteLine("\t 4- TAMAÑO DEL VECTOR");
                Console.WriteLine("\t 0- SALIR");
                Console.WriteLine("********************************************");
                Console.Write("Opcion: ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar; //Capturar lo que se recoge por pantalla 
                    //Console.WriteLine("CAPTURO ESTO");
                } while (opcion < '0' || opcion > '4'); // guarda si es entre entre 0 o 3

                Console.WriteLine(opcion + "\n");

                switch (opcion)
                {
                    case '1':
                        try
                        {
                            Console.WriteLine("CALCULAR SERIE FIBONACCI...");
                            Console.WriteLine("Introduzca el Valor a Calcular Fibonacci:");
                            string valor = Console.ReadLine();
                            int numero = 0;
                            int a = 0;
                            int b = 1;
                            FIbonacci fib = new FIbonacci(a, b); //Instanciar CLASE con constructor que tiene parametros
                            numero = util.ValidarNumero(valor); // instanciamos el objeto de la clase util
                            string mostrarPantalla = String.Empty;
                            mostrarPantalla = "0";
                            mostrarPantalla += fib.calcular(numero);
                            Console.WriteLine(mostrarPantalla);

                            Console.ReadLine();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }

                        break;

                    case '2':
                        try
                        {
                            Console.WriteLine("DIVIDE DOS NUMEROS...");
                            Console.WriteLine("Introdusca el Dividenco:");
                            string valor = Console.ReadLine();
                            int divisor = util.ValidarNumero(valor);
                            Console.WriteLine("Instroduzca el Divisor:");
                            valor = Console.ReadLine();
                            int dividendo = util.ValidarNumero(valor);
                            Dividir dividir = new Dividir(divisor, dividendo); //Instanciar CLASE
                            Console.WriteLine("EL RESULTADO DE LA DIVICION ES: " + dividir.ResultadoDividir().ToString());

                            Console.ReadLine();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        
                    break;

                    case '3':
                        try
                        {
                            Console.WriteLine("ESCRIBA SU MENSAJE...");
                            string texto = Console.ReadLine();
                            mensaje = new MostrarMensaje(texto); //Instanciar CLASE
                            Console.WriteLine(mensaje.dameMensaje()); //Instanciar el elemento de la CLASE

                            Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        
                    break;

                    case '4':
                        try
                        {
                            Console.WriteLine("DIGITE EL TAMAÑO DEL VECTOR...");
                            String valor = Console.ReadLine();
                            int capacidad = util.ValidarNumero(valor);
                            Vector v = new Vector(capacidad);
                            v.llenarVectorNumero();
                            v.llenarVectorCadena();
                            string texto2 = v.dibujarDatosVector();
                            mensaje = new MostrarMensaje("EL VECTOR ES --> " + texto2);
                            Console.WriteLine(mensaje.dameMensaje());

                            Console.WriteLine("DIGITE POSICION...");
                            string posicion = Console.ReadLine();
                            string texto = v.dameDatosPosicionVectorCadenas(Convert.ToInt32(posicion));
                            mensaje = new MostrarMensaje(texto);
                            Console.WriteLine(mensaje.dameMensaje());

                            Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            Console.ReadLine();
                        }
                        
                    break;
                };

            } while (opcion != '0');
            //Console.Read();
        }
    }
}
