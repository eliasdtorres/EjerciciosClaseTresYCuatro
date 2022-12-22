using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//1. Crear una clase para la guía anterior de ejercicios, donde cada ejercicio debe ser un método de la clase.

namespace EjerciciosClaseTresYCuatro.Ejercicio1
{
    internal class EjercicioUno
    {

        public EjercicioUno() { }
        //1. Dado un valor, devolver un mensaje que diga “El valor es mayor que 100” sólo cuando se cumpla dicha condición.
        public void mayorQue100()
        {
            int value = 0;
            Console.WriteLine("Ingrese un valor mayor que 100");

            try
            {
                value = Int32.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("El valor ingresado ( '" + value + "' ) No es un dato numérico, Reinicie el programa");
                ;
            }

            if (value > 100)
            {
                Console.WriteLine("El valor es mayor que 100");
            }
            else if (value < 100)
            {
                Console.WriteLine("El valor no es mayor que 100");
            }
            else
            {
                Console.WriteLine("El valor es igual a 100");
            }
        }
        //2.Pedir un número entero por teclado y calcular si es par o impar.

        public void parOImpar()
        {
            int num = 0;
            bool flag = true;
            Console.WriteLine("Ingrese un numero");
            try
            {
                num = Int32.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                flag = false;
                Console.WriteLine("Debe ingresar un número, reintente");

            }

            if (flag)
            {
                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("El número es par");
                    }
                    else
                    {
                        Console.WriteLine("El número es impar");
                    }

                }
                else
                {
                    Console.WriteLine("No se puede dividir por 0 (cero)");
                }
            }
        }

        //3. Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble de un impar.Por ejemplo, 14 cumple con esta condición.
        public void dobleDeImpar()
        {
            try
            {
                int value;
                Console.WriteLine("Ingrese valor");
                value = Int32.Parse(Console.ReadLine());
                if ((value / 2) % 2 == 1)
                {
                    Console.WriteLine("El valor ingresado: " + value + " es el doble de un impar: " + value / 2 + ".");
                }
                else
                {
                    Console.WriteLine("El valor no es el doble de un impar.");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Ingrese un tipo de dato correcto, reintente");

            }
        }


        //4. Dada un número del 1 al 10, devolver su “versión” en números romanos

        public void enNumerosRomanos()
        {
            Console.WriteLine("Imgresa un número entre 1 y 10.");

            try
            {
                int num = Int32.Parse(Console.ReadLine());
                if (num >= 1 && num <= 10)
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("I");
                            break;
                        case 2:
                            Console.WriteLine("II");
                            break;
                        case 3:
                            Console.WriteLine("III");
                            break;
                        case 4:
                            Console.WriteLine("V");
                            break;
                        case 5:
                            Console.WriteLine("V");
                            break;
                        case 6:
                            Console.WriteLine("VI");
                            break;
                        case 7:
                            Console.WriteLine("VII");
                            break;
                        case 8:
                            Console.WriteLine("VIII");
                            break;
                        case 9:
                            Console.WriteLine("IX");
                            break;
                        case 10:
                            Console.WriteLine("X");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El número ingresado está fuera de rango, reintente.");
                }


            }
            catch (FormatException)
            {

                Console.WriteLine("Ingrese un tipo de dato correcto, reintente.");
            }
        }


        //5. Leer el nombre y las edades de dos personas y devolver el nombre del menor.En caso de que tengan la misma edad también debe indicarse.
        //Devolver también la diferencia de edad en caso de corresponder.
        public void menorMayor()
        {
            string name = "", name2 = "", minor;
            int age = 0, age2 = 0, dif;
            bool isOk = true;

            try
            {
                Console.WriteLine("Ingrese el primer nombre: ");
                do
                {
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese la edad: ");

                } while (name == "");

                age = Int32.Parse(Console.ReadLine());

                do
                {

                    Console.WriteLine("Ingrese el segundo nombre: ");
                    name2 = Console.ReadLine();
                } while (name2 == "");

                Console.WriteLine("Ingrese la edad: ");
                age2 = Int32.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                isOk = false;
                Console.WriteLine("La edad debe ser un número válido. Reintente");
            }

            if (isOk)
            {
                Console.WriteLine("Primer nombre cargado: " + name + "\nPrimer edad cargada: " + age +
                    "\nSegundo nombre cargado: " + name2 + "\nSegunda edad cargada: " + age2);

                if (age - age2 != 0)
                {
                    dif = age - age2;
                    if (dif < 0)
                    {
                        minor = name;
                        dif = age2 - age;
                    }
                    else
                    {
                        minor = name2;
                    }

                    Console.WriteLine("La diferencia de edad es de: " + dif + " años.\n" +
                        "El menor es: " + minor);
                }
                else
                {
                    Console.WriteLine("No tienen diferencia de edad.");
                }
            }

        }
        //6. Escribir un programa que calcule el tipo de un triángulo conociendo la
        // longitud de sus 3 lados.También que calcule su perímetro y su área.

        public void tipoTriangulo()
        {
            int l = 0, l2 = 0, l3 = 0;
            bool isOk = true;

            try
            {

                Console.WriteLine("Ingrese la longitud de cada lado.");
                Console.WriteLine("Longitud 1: ");
                l = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Longitud 2: ");
                l2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Longitud 3: ");
                l3 = Int32.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                isOk = false;
                Console.WriteLine("Los datos deben ser numéricos.");
            }

            if (isOk)
            {
                int per = l + l2 + l3;
                double h = (Math.Sqrt(3) / 2) * l;
                double area = (l * h) / 2;


                if (l - l2 + l3 == l)
                {
                    Console.WriteLine("El triángulo es equilatero: " +
                       "Tiene los tres lados de igual longitud.\nSu perímetro es de: " + per + "cm y su área es de: " + area + "cm.\nLa altura calculada es: " + h + "cm.");

                }
                else if ((l == l2 && l != l3) || (l == l3 && l != l2))
                {

                    int b = 0;

                    if (l == l2)
                    {
                        b = l3;
                    }
                    else if (l == l3)
                    {
                        b = l2;
                    }
                    else if (l2 == l3)
                    {
                        b = l;
                    }

                    area = (b * h) / 2;

                    Console.WriteLine("El triángulo es isósceles: " +
                        "Tiene sólo dos lados de igual longitud.\nSu perímetro es de: " + per + "cm y su área es de: " + area + "cm.\nLa altura calculada es: " + h + "cm.");
                }
                else if (l != l2 && l != l3 && l2 != l3)
                {
                    Console.WriteLine("El triángulo es escaleno: " +
                        "Ninguno de sus lados coinciden en longitud.\nSu perímetro es de: " + per + "cm y su área es de: " + area + "cm.\nLa altura calculada es: " + h + "cm.");
                }







            }
            else
            {
                Console.WriteLine("Ocurrió un error, reintente.");
            }



        }


        //7. Desarrolle un programa que calcule el desglose de una cantidad dada, en
        //billetes y monedas tal que se minimice la cantidad de monedas y billetes.
        //Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,
        //donde los últimos tres son monedas. (Por ejemplo, para $1,723 se debe
        //imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
        //$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete($) y
        //tratar todos los valores como números, para los cálculos.


        public void desglose()
        {
            int cMil = 0, cQuinientos = 0, cCien = 0, cCincuenta = 0, cVeinte = 0, cDiez = 0, cCinco = 0, cDos = 0, cUno = 0;
            int cantidad = 0;
            int cantidad2 = 0;
            bool isOk = true;

            try
            {

                Console.WriteLine("Ingrese un valor.");
                cantidad = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                isOk = false;
                Console.WriteLine("Debe ingresar un valor numérico.");
            }

            if (isOk)
            {
                while (cantidad >= 1)
                {

                    switch (cantidad)
                    {

                        case >= 1000:
                            cMil += 1;
                            cantidad -= 1000;
                            break;
                        case >= 500:
                            ; cQuinientos += 1;
                            cantidad -= 500;
                            break;
                        case >= 100:
                            cCien += 1;
                            cantidad -= 100;
                            break;
                        case >= 50:
                            cCincuenta += 1;
                            cantidad -= 50;
                            break;
                        case >= 20:
                            cVeinte += 1;
                            cantidad -= 20;
                            break;
                        case >= 10:
                            cDiez += 1;
                            cantidad -= 10;
                            break;
                        case >= 5:
                            cCinco += 1;
                            cantidad -= 5;
                            break;
                        case >= 2:
                            cDos += 1;
                            cantidad -= 2;
                            break;
                        case 1:
                            cUno += 1;
                            cantidad -= 1;
                            break;
                    }

                }

                Console.WriteLine("Billetes de $1000 entregados: " + cMil + ".\n" +
                    "Billetes de $500 entregados: " + cQuinientos + ".\nBilletes de $100 entregados: " + cCien + ".\n" +
                    "Billetes de $50 entregados: " + cCincuenta + ".\nBilletes de $20 entregados: " + cVeinte + ".\n" +
                    "Billetes de $10 entregados: " + cDiez + ".\nBilletes de $5 entregados: " + cCinco + ".\n" +
                    "Monedas de $2 entregadas: " + cDos + ".\nMonedas de $1 entregadas: " + cUno + ".");
            }

        }

        //8. Pide un número N, y muestra todos los números del 1 al N.
        public void consecutivo()
        {
            Console.WriteLine("Ingrese un número");

            try
            {
                int num = Int32.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {

                    Console.WriteLine(i);
                    Console.WriteLine("------");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor numérico");
            }

        }

        // 9. Pedir 15 números y escribir la suma total.

        public void suma()
        {
            int count = 1;
            int ac = 0;
            while (count <= 15)
            {
                Console.WriteLine("Ingrese un número (" + (count) + ")");
                try
                {
                    ac += Int32.Parse(Console.ReadLine());
                    count++;
                }
                catch (FormatException)
                {

                    Console.WriteLine("Ingrese un tipo de dato numérico");
                }

            }
            Console.WriteLine("La suma total de los números ingresados es: " + ac);

        }

        //10.Pide 5 números e indica si alguno es múltiplo de 3.
        public void multiploDeTres()
        {
            int[] arr = new int[5];
            int i = 0;

            while (i < 5)
            {
                try
                {
                    Console.WriteLine("Ingrese un número");
                    arr[i] = Int32.Parse(Console.ReadLine());
                    i++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Tipo de dato incorrecto");
                }
            }

            for (int j = 0; j < (arr.Length); j++)
            {
                if (arr[j] % 3 == 0)
                {
                    Console.WriteLine("El número ingresado: {" + arr[j] + "} en la posición: [" + j + "] es múltiplo de 3.");
                }
                else
                {
                    Console.WriteLine("El número ingresado: {" + arr[j] + "} en la posición: [" + j + "] no es múltiplo de 3.");
                }
            }
        }

        //  11.Escriba un programa que solicite una contraseña(el texto de la contraseña no es importante)
        //  y la vuelva a solicitar hasta que las dos contraseñas coincidan.

        public void contraseña()
        {
            string pass = "", pass2 = "";
            bool isOk = true;

            do
            {
                if (!pass.Equals(pass2))
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Las contraseñas no coinciden. Reintente");
                    Console.WriteLine("---------------------------------------");
                }

                Console.WriteLine("Ingrese la contraseña.");
                pass = Console.ReadLine();

                Console.WriteLine("Repita la contraseña.");
                pass2 = Console.ReadLine();

            } while (!pass.Equals(pass2));

            Console.WriteLine("Contraseña correcta");
        }

        //12.Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres
        // peticiones no debe solicitar más la contraseña y terminar el programa.
        public void contraseña2()
        {
            string pass = "", pass2 = "";
            int appends = 3;
            bool isOk = true;

            do
            {

                Console.WriteLine("Ingrese la contraseña.");
                pass = Console.ReadLine();

                Console.WriteLine("Repita la contraseña.");
                pass2 = Console.ReadLine();

                if (!pass.Equals(pass2))
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Las contraseñas no coinciden. Reintente");
                    Console.WriteLine("---------------------------------------");
                    appends -= 1;
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Intentos disponibles: " + appends);
                    Console.WriteLine("------------------------------");
                }



            } while (!pass.Equals(pass2) && appends > 0);


            if (appends > 0)
            {
                Console.WriteLine("Contraseña correcta");
            }
            else
            {
                Console.WriteLine("Se quedó sin intentos. Reintente.");
            }

        }


        //13.Proponer al usuario que adivine un número a base de intentarlo.
        public void adivinaNumero()
        {
            int min = 0, max = 0, numUsuario = 0;
            bool isOk = true;

            Console.WriteLine("Elija un numero minimo y uno máximo");
            try
            {

                Console.WriteLine("Ingrese el numero mínimo: ");
                min = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero máximo: ");
                max = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                isOk = false;
                Console.WriteLine("Ingrese un valor numérico");
            }

            if (isOk)
            {
                int attemps = 5;
                Random r = new Random();
                int numAAdivinar = r.Next(min, max);
                bool isWork = true;

                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese el número a verificar");
                        numUsuario = Int32.Parse((string)Console.ReadLine());
                        attemps -= 1;
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Ingrese un valor numérico");
                        isWork = false;

                    }


                    if (numAAdivinar != numUsuario && isWork)
                    {

                        Console.WriteLine("Incorrecto, restan: " + attemps + " intentos");
                    }
                    else if (numAAdivinar == numUsuario)
                    {
                        Console.WriteLine("Felicidades, el número: " + numUsuario + " era la opción correcta");
                        Console.WriteLine("Intentos restantes: " + attemps);
                    }


                } while (numAAdivinar != numUsuario && attemps > 0 && isWork);

            }
        }


        
        //14.Modificar el anterior para que dé pistas.

        public void adivinaNumero2()
        {
            int min = 0, max = 0, numUsuario = 0;
            bool isOk = true;

            Console.WriteLine("Elija un numero minimo y uno máximo");
            try
            {

                Console.WriteLine("Ingrese el numero mínimo: ");
                min = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el numero máximo: ");
                max = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                isOk = false;
                Console.WriteLine("Ingrese un valor numérico");
            }

            if (isOk)
            {
                int attemps = 5;
                Random r = new Random();
                int numAAdivinar = r.Next(min, max);
                bool isWork = true;

                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese el número a verificar");
                        numUsuario = Int32.Parse((string)Console.ReadLine());
                        attemps -= 1;
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Ingrese un valor numérico");
                        isWork = false;

                    }


                    if (numAAdivinar != numUsuario && isWork)
                    {
                        if (numUsuario > numAAdivinar)
                        {
                            Console.WriteLine("Incorrecto,el número a adivinar es menor restan: " + attemps + " intentos");
                        }
                        else if (numUsuario < numAAdivinar)
                        {
                            Console.WriteLine("Incorrecto,el número a adivinar es mayor restan: " + attemps + " intentos");
                        }

                    }
                    else if (numAAdivinar == numUsuario)
                    {
                        Console.WriteLine("Felicidades, el número: " + numUsuario + " era la opción correcta");
                        Console.WriteLine("Intentos restantes: " + attemps);
                    }


                } while (numAAdivinar != numUsuario && attemps > 0 && isWork);

            }
        }


        // 15.Crea un programa que permita sumar N números. El usuario decide cuándo
        // termina de introducir números al indicar la palabra ‘fin’.

        public void sumarNNumeros()
        {
            int ac = 0;
            int num = 0;
            string res = "";
            bool isOk; ;

            do
            {
                Console.WriteLine("Ingrese un número para sumar, o escriba 'fin' para cerrar el programa");

                try
                {
                    isOk = true;
                    res = Console.ReadLine();
                    num = Int32.Parse(res);
                }
                catch (FormatException)
                {
                    isOk = false;

                }

                if (isOk)
                {
                    ac += num;
                }


            } while (res != "fin");

            Console.WriteLine("Total sumado: " + ac);
        }

    }

}

