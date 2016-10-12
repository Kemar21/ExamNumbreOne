using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FirstExam
{
    public class DiagonalDiferrence
    {
        int[,] mat = new int[0, 0];//declaracion de la matriz 
        public void llenarMatriz()//metdod que llena la matriz
        {
             
            for( int i =0; i< mat.Length; i++)//utilizo un for para llenar la matriz(filas)
            {
                for(int j = 0; j < mat.Length; j++)//Columnas
                {
                    Random random = new Random();//Clase rando que va colocando numeros aleatoriamente entre el 1 y el 9
                    mat[i, j] = random.Next(1, 9);
                }
            }
      }

        public int diferenciaDiagonal()//metodo para sumar las diagonales
        {
            // variables para acumular la suma de las diagonales
            //primero se suma la diagonal primaria y despues la segundaria
            int sumaPrimerDiagonal = 0;
            int sumaSegundaDiago = 0;
            int resultado = 0;// variable para acumular la suma del total de las dos diagonales 
            //pimera saco la suma de la primera diagonal
            for (int i = 0; i < mat.Length; i++)// recorro la matriz y saco la suma de la diagonal 
            {
               
                sumaPrimerDiagonal =+ mat[i, i];
            }

            //Ahora se saca la suma de la segunda diagonal
            for(int i=0; i < mat.Length; i++)
            {
                for(int j = 0; j < mat.Length; j++)
                {
                  
                    sumaSegundaDiago =+ mat[j,i];

                }
                //si el resultado de la primera diagonal es mayor se le resta la segundo apra que no de un numero negativo
                if (sumaPrimerDiagonal > sumaSegundaDiago)
                {
                    resultado = sumaPrimerDiagonal - sumaSegundaDiago;
                }else// se le resta primero la segunda diagonal para que no de un numero negativo
                {
                    resultado = sumaSegundaDiago - sumaPrimerDiagonal;
                }
            }
            Console.WriteLine("El resultado es: " + resultado);
            return resultado;// se retorna el resultado 
        }

        public int matriz(String valor)// metodo que devuelve la diverencia de las diagonales
        {

            return Convert.ToInt16(valor); 
        }
        
    }
}
