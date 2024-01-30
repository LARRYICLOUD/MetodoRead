using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");
            //Creamos un flujo/stream para trabajar con la memoria RAM
            MemoryStream ms1 = new MemoryStream();
            //Mostramos la capacidad, longitud y posicion del puntero del stream
            InformacionStream(ms1);

            //Matriz de bytes para guardar a la cadena convertida
            byte[] matrizCadenaByte;

            //Codificamos  a cadena1 para obtener la secuencia de bytes
            matrizCadenaByte = Encoding.UTF8.GetBytes("Hola a todos");
            //Escribiendo dato en el flujo
            ms1.Write(matrizCadenaByte, 0 , matrizCadenaByte.Length);

            //Mensaje para separar el antes y despues del write
            Console.WriteLine("Despues de escribir en el stream...");
            //Mostramos la capacidad, longitud y posicion del puntero del stream
            InformacionStream(ms1);

            //Bufer para almacenar los bytes leidos por READ
            byte[] buferBytesLeidos = new byte[100];

            ms1.Seek(0, SeekOrigin.Begin); //Mover el puntero al inicio del flujo
            //Leemos el contenido de nuestro flujo usando el metodo READ
            int bytesLeidos = ms1.Read(buferBytesLeidos, 0,(int)ms1.Length); //Aqui castiamos

            //Mostramos cuantos bytes fueron leidos por Read
            Console.WriteLine($"Bytes leidos del stream: {bytesLeidos} ");

        }
        static void InformacionStream(MemoryStream ms1Pa)
        {
            Console.WriteLine($"\nCapacidad: {ms1Pa.Capacity}");
            Console.WriteLine($"Longuitud: {ms1Pa.Length}");
            Console.WriteLine($"Posicion del puntero: {ms1Pa.Position}\n");

        }


    }
}
