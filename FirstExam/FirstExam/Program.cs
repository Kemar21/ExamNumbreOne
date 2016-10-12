using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstExam
{
    class Program 
    {
        static void Main(string[] args)
        {
            CamelCase i = new CamelCase();
            string chainCamelCase = "tryingSomethingMore";
            i.calculate(chainCamelCase);

            DiagonalDiferrence dig = new DiagonalDiferrence();
            int valor = 0;
            dig.llenarMatriz();
            dig.diferenciaDiagonal();
            dig.matriz(Convert.ToString( valor));

        }
    }
}
