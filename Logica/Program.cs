using System;

namespace Logica
{
    class Program
    {
        static void Main()
        {
            int[] array = { 1, 2, 2, 3, 6, 4, 4, 4, 5, 5, 7, 5, 9, 2 };
            //siguiente array proporcionandole la longuitud del primer array
            int[] list = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    //comparo el dato que esta en el primer array obtenido en el primero for
                    // y lo compararemos con el dato del segundo clico for, para verificar si tenemos datos duplicados
                    if (array[i] == array[j])
                    {
                        //al encontrar un valor duplicado aumentara el valor de count
                        count++;
                        if (numero(array[i]))
                        {
                            list[i] = array[i];
                        }
                    }
                }
                if (list[i] !=0)
                {
                    //ahora si el dato que estamos recibiendo de la coleccion de datos
                    //que va a contener los valores duplicados, los vamos a mostrar por consola
                    //si es distinto a 0 significa que si recibimos informacion.
                    Console.WriteLine(list[i] + " se repite: " + count);

                }
            }

            bool numero(int num) 
            {
                //usaremos esta funcion para comparar los datos que entran por el array
                //si el dato es igual retornaremos un false,dando a entender que esta repetido y por lo tanto
                //no es necesario agregarlo a la coleccion de datos list
                for (int i = 0; i < list.Length; i++)
                {
                    //obtendremos los datos del array list 
                    if (list[i] == num)
                    {
                        return false;
                    }
                }
                //sino es repetido retornara true y almacenara dicho dato.
                return true;

            }


        }
    }
}
