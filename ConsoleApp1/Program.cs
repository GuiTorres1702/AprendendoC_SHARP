using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forma de pagamento 
            //Se o valor da compra for maior que R$1.000,00 pode parcelar em 3 vezes
            // se não for, apenas a vista
              decimal ValorCompra;
               int parcelas = 3;
               decimal valorParcela;
               decimal ValorMinimoParcelar = 1000.01m;

               Console.WriteLine("Digite o valor a compra: ");
               ValorCompra = Convert.ToDecimal(Console.ReadLine());

               Console.WriteLine("Valor da vista: {0:c}", ValorCompra);
               if (ValorCompra >= ValorMinimoParcelar)                
               {
                   valorParcela = ValorCompra / parcelas;
                   Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da Parcela: {1:c}", parcelas, valorParcela);
            
               }
        }
    }
}