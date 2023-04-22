using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClasseObjetoAlteraValorPadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Ana";

            Console.WriteLine("Banco Virtual - Imprimindo dados alterando o valor padrão dos objetos: \r\n");

            Console.WriteLine("Titular: " + conta.titular + ".");
            Console.WriteLine("Agência Padrão: " + conta.agencia + ".");
            Console.WriteLine("Conta Padrão: " + conta.numConta + ".");
            Console.WriteLine("Saldo Padrão: R$ " + conta.saldo + ".");

            Console.ReadLine();
        }
    }
}
