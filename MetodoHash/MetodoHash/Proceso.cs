using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoHash
{
    class Proceso
    {
        public void Ejemplo1()
        {
            Console.WriteLine("Ejemplo 1");
            Hash hosh = new Hash(8);//INICIALIZACION
            String[] elementos = { "16", "32", "64", "128", "256","512", "1024", "2048", };
            hosh.Funcionhash(elementos, hosh.Arreglo);//LLAMADA DEL METODO CON PARAMETROS
            hosh.Mostrar();//IMPRESION
            String buscado = hosh.Buscarclave("256");//NUMERO A BUSCAR
            if (buscado == null)
            {
                Console.WriteLine("elemento 256 no se encuentara en la tabla ");
            }
        }
        public void Ejemplo2()
        {
            Hash hash = new Hash(8);//INICIALIZACION
            String[] elementos = { "3", "5", "7", "11", "13", "17", "23", "29", };
            hash.Funcionhash(elementos, hash.Arreglo);//LLAMADA DEL METODO CON PARAMETROS
            hash.Mostrar();//IMPRESION
            String buscado = hash.Buscarclave("20");//NUMERO A BUSCAR
            if (buscado == null)
            {
                Console.WriteLine("elemento 13 no se encuentara en la tabla ");
            }
        }
        public void Impresion()//IMPRESION DE AMBOS METODOS
        {
            Ejemplo1();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Ejemplo 2");
            Ejemplo2();
            Console.ReadKey(true);
        }
    }
}
