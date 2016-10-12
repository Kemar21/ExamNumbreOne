using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstExam
{
    public class CamelCase 
    {
        public int calculate(string chainCamelCase)
        {
            int countCapitalLetters = 0;//contador para las mayusculas dentro del cadena
            int resul = 0;//guarda la suma de las mayusculas y las minusculas dentro de una cadena
            int coutLowerCase = 0;//contador para las palabras que empiecen con minuscula
            char positionLetters = chainCamelCase[0];//contiene la letra en la posicion 0

            if (char.IsUpper(chainCamelCase[0]))//condicion para saber si la primera letra esta en mayuscula
            {
                Console.WriteLine("No es un string camelCase");
            }
            else
            {
                for (int i = 0; i < chainCamelCase.Length; i++)//realiza un for para que me recorra la cadena 
                {
                    if (char.IsUpper(chainCamelCase[i]))//condicion para saber si existe una letra en mayucula en la posicion cero
                    {
                        countCapitalLetters++;//aumento el contador 
                    }

                    if (char.IsLower(chainCamelCase[0]))// condicion para saber si existe una letra en minuscula en la posicion cero
                    {//si esto se cumple
                        if(coutLowerCase == 0)//preguntamo si la letra en minuscula se encuentra en la posicion cero
                        {
                            coutLowerCase++;//aumento el contador
                        }
                    }

                    resul = coutLowerCase + countCapitalLetters;// ahora se suma los contadores que acumulan las minusculas y las mayuscula
                }
                Console.WriteLine("Total of words:" + resul);
                Console.ReadKey();
            }
            return resul;
        }
    }
}

