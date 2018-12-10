using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoHash
{
    class Hash
    {
        public String[] Arreglo;//ARREGLO QUE UTILIZARA EL METODO HASH
        int tamaño;//TAMAÑO DEL ARREGLO
        public Hash(int tamaño)
        {
            this.tamaño = tamaño;//POLIMORFISMO DE VAIABLES
            Arreglo = new String[tamaño];//INICIALIZACION DEL ARREGLO
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = "0";//INICIANDO POSICIONES DEL ARREGLO UN NUMERO CUALQUIERA EN STRING
            }
        }
        public void Funcionhash(String[] cadenarreglo, String[] Arreglo)//METODO HASH
        {
            for (int i = 0; i < cadenarreglo.Length; i++)//SE RECORREN TODOS LOS ELEMENTOS DEL ARREGLO
            {
                String elemento = cadenarreglo[i];//SEGUN EL NUMERO QUE SE GUARDA EN LA POSICION SE LE ASIGNA UN
                int indicearreglo = int.Parse(elemento) % Arreglo.Length;//IDENTIFICADOR A CADA NUMERO
                Console.WriteLine("el indice es " + indicearreglo + " para el elemento o valor " + elemento);

                //PARTE ANTI COLISIONES
                while (Arreglo[indicearreglo] != "0")//MIENTRAS NO SE ENCUENTRE 0 EN EL ARREGLO
                {
                    indicearreglo++;
                    Console.WriteLine("ocurrio una colision en el indice " + (indicearreglo - 1) + " cambiar indice  " + indicearreglo);
                    indicearreglo %= tamaño;//ASIGNACION DE OTRO IDENTIFICADOR AL NUMERO DEL ARREGLO

                }
                Arreglo[indicearreglo] = elemento;
            }
        }
        public void Mostrar()//IMPRESION DEL METODO  HASH
        {
            int incremento = 0, i, j;
            for (i = 0; i < 1; i++)
            {
                incremento += 8;
                for (j = 0; j < 71; j++)
                {
                    Console.Write("-");

                }
                Console.WriteLine();
                for (j = incremento - 8; j < incremento; j++)
                {
                    Console.Write(String.Format("[ {0}  ]", j));//SE USA PARA IMPRIMIR STRINGS CON LOS CORCHETES
                }
                Console.WriteLine();
                for (int n = 0; n < 71; n++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
                for (j = incremento - 8; j < incremento; j++)
                {
                    if (Arreglo[j].Equals("-1"))
                    {
                        Console.Write("[      ");
                    }
                    else
                    {
                        Console.Write(String.Format("[ {0} ]", Arreglo[j]));//SE USA PARA IMPRIMIR STRINGS CON LOS CORCHETES
                    }
                }
                Console.WriteLine();
                for (j = 0; j < 71; j++)
                {
                    Console.Write("-");
                }
            }
        }

        public String Buscarclave(String elemento)//METODO QUE BUSCA EL ELEMENTO EN EL ARREGLO SEGUN EL IDENTIFICADOR
        {
            int Indice = Convert.ToInt32(elemento) % Arreglo.Length;//EXTRAE EL IDENTIFICADOR SEGUN EL NUMERO INGRESADO
            int contador = 0;
            while (Arreglo[Indice] != "-1")//CICLO DE COMPARACIONES PARA ENCONTRAR EL NUMERO
            {
                if (Arreglo[Indice] == elemento)
                {
                  Console.WriteLine("\nEl elemento " + elemento + " fue encontardo en el indice " + Indice);
                    return Arreglo[Indice];
                }
                Indice++;
                Indice %= tamaño;
                if (contador > 7)
                {
                    break;
                }
            }
            return null;//SI NO ENCUENTRA EL DATO REGRESA UN NULO
        }

    }
}
