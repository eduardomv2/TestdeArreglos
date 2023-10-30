using System;
using System.Diagnostics.Contracts;

namespace TestdeArreglos
{ 
    internal class Program
    { 
        static void Main(string[] args)
        {
            //ARREGLO DE OBJETOS (CUALQUIER TIPO DE OBJETOS)
            //EN ESTE CASOP TENEMOS INT, STRING, DOUBLE, BOOL
            //CREACION DEL ARREGLO
            object[] arreglodeobjetos = new object[4];
            arreglodeobjetos[0] = 10;
            arreglodeobjetos[1] = "Hola";
            arreglodeobjetos[2] = 2.0;
            arreglodeobjetos[3] = true;            

            //CICLO PARA MOSTRAR LOS ELEMENTOS DEL ARREGLO "Persona" 
            //PASA POR CADA ELEMENTO Y LOS MUESTRA
            for (int i = 0; i < arreglodeobjetos.Length; i++)
            {
                //Console.WriteLine(arreglodeobjetos[i]);
            }

            //HACEMOS EL ARREGLO CON BASE AL NOMBRE DE LA CLASE
            //RECIBE LAS PROPIEDADES DE LA CLASE PERSONA y CONTACTOS           
            //LAS PROPIEDADES GET Y SET (LECTURA Y ESCRITURA) 
            //DE NOMBRE Y EDAD en Persona y NOMBRE Y NUMERO en Contactos
            //Variable tipo entero para declarar el tamaño fijo del arreglo
            int MaxSize = 3;
            //CREACION DEL ARREGLO
            Persona[] personas = new Persona[MaxSize];
            Juegos[] juegos = new Juegos[MaxSize];
            //ElEMENTOS DEL ARREGLO personas
            personas[0] = new Persona { Nombre = "Juan", Edad = 30 };
            personas[1] = new Persona { Nombre = "María", Edad = 25 };
            personas[2] = new Persona { Nombre = "Carlos", Edad = 40 };
            //ElEMENTOS DEL ARREGLO contactos
            juegos[0] = new Juegos { Nombre = "Minecraft", Costo = 20 };
            juegos[1] = new Juegos { Nombre = "Halo", Costo = 40 };
            juegos[2] = new Juegos { Nombre = "Valorant", Costo = 0 };
            //CICLO PARA MOSTRAR LOS ELEMENTOS DEL ARREGLO "Persona" 
            //PASA POR CADA ELEMENTO Y LOS MUESTRA 
            for (int i = 0; i < MaxSize; i++)
            {
                Console.WriteLine("Nombre: " + personas[i].Nombre + "\n" + "Edad: " + personas[i].Edad);
                Console.WriteLine("Nombre: " + juegos[i].Nombre + "\n" + "Costo: $" + juegos[i].Costo);
            }
        }
    }
}
