using System;

class Program
{
    static void Main()
    {
        string codigo = "";
        string carrera = "";
        string etiqueta = "";
        string bienvenida = "";

        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("************ MENU DE OPCIONES GIT 123 ************");
            Console.WriteLine("1. Leer código de estudiante y carrera.");
            Console.WriteLine("2. Formar una nueva etiqueta textual con ambos (concatenado).");
            Console.WriteLine("3. Mostrar longitud de caracteres del código, carrera y etiqueta.");
            Console.WriteLine("4. Mostrar el primer y último carácter del código.");
            Console.WriteLine("5. Imprimir la carrera carácter por carácter.");
            Console.WriteLine("6. Crear una nueva etiqueta de bienvenida.");
            Console.WriteLine("7. Salir del menú.");
            Console.WriteLine("***************************************************");

            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese código de estudiante: ");
                    codigo = Console.ReadLine();

                    Console.Write("Ingrese carrera: ");
                    carrera = Console.ReadLine();

                    Console.WriteLine("\nDatos guardados correctamente.");
                    Console.ReadKey();
                    break;

                case 2:
                    etiqueta = codigo + " - " + carrera;

                    Console.WriteLine("Nueva etiqueta: " + etiqueta);
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Longitud del código: " + codigo.Length);
                    Console.WriteLine("Longitud de la carrera: " + carrera.Length);
                    Console.WriteLine("Longitud de la etiqueta: " + etiqueta.Length);

                    Console.ReadKey();
                    break;

                case 4:
                    if (codigo.Length > 0)
                    {
                        Console.WriteLine("Primer carácter: " + codigo[0]);
                        Console.WriteLine("Último carácter: " + codigo[codigo.Length - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Primero debe ingresar el código.");
                    }

                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Carrera carácter por carácter:");

                    for (int i = 0; i < carrera.Length; i++)
                    {
                        Console.WriteLine(carrera[i]);
                    }

                    Console.ReadKey();
                    break;

                case 6:
                    bienvenida = "Bienvenido " + codigo + " a la carrera de " + carrera;

                    Console.WriteLine(bienvenida);
                    Console.ReadKey();
                    break;

                case 7:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 7);
    }
}

