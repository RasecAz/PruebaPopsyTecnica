using System;

namespace PruebaTecnicaCoopidrogas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir cadenas de texto al reves
            //string Prueba = "Palabra";
            //string TextPrueba = "";

            //for (int i = Prueba.Length - 1; i >= 0; i--)
            //{
            //    TextPrueba += Prueba[i];
            //}
            //Console.WriteLine(TextPrueba);
            //Console.ReadKey();

            //Buscador de caracteres especificos en cadenas de texto
            //string Text = "SLLDODÑLsdoewfd´KDQP´D2103940DSKDJLJSñlÑLÑAÑKASJFLÑAL";
            //char Catacter = 'A';

            //int n = 0;

            //foreach (var c in Text)
            //{
            //    if (c == Catacter)
            //    {
            //        n++;
            //    }               
            //}
            //Console.WriteLine($"La letra {Catacter} esta {n} veces");
            //Console.ReadKey();

            //Buscador de Hamming
            //string Text1 = "LaTazaPer";
            //string Text2 = "LaRazaCer";

            //int dist = 0;

            //if (Text1.Length != Text2.Length)
            //    throw new Exception("No son igules!!");

            //for (int i = 0; i < Text1.Length; i++)
            //{
            //    if(Text1[i] != Text2[i])
            //    {
            //        dist++;
            //    }
            //}
            //Console.WriteLine(dist);
            //Console.ReadKey();

            //int sample;
            //int[] array = new int[4];
            //try
            //{
            //    sample = 5;
            //    array[sample] = 22;
            //} catch ( FormatException e)
            //{
            //    Console.WriteLine("X");
            //}catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("Y");
            //}
            //Console.WriteLine("Z");
            //Console.ReadKey();

            //string[] Nombre = new string[3];

            //Console.WriteLine("Introduzca su nombre");
            //Nombre[0] = Console.ReadLine();

            //Console.WriteLine("Introduzca su apellido");
            //Nombre[1] = Console.ReadLine();

            //Console.WriteLine("Introduzca su segundo apellido");
            //Nombre[2] = Console.ReadLine();

            //Console.WriteLine(Nombre[0]+ " " + Nombre[1] + " " + Nombre[2]);
            //Console.ReadKey();

            int[] Array1;

            Array1 = new int[3];
            Array1[0] = 1;
            Array1[1] = 2;
            Array1[2] = 3;

            int[] Array2 = new int[3] {1, 2, 3};
            int[] Array3 = {1, 2, 3};

            int[,] Array4 = new int[3, 3];
            Array4[1,2] = 32;

            Console.WriteLine(Array4);
            Console.ReadKey();


        }
        
    }
}
