using System;
using System.Globalization;


namespace Retorna_Preco
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlTotal =0;
            //double vlSubTotal;            
           // Produto p = new Produto();
            Console.WriteLine("Deseja lançar produtos?" + "\n"
                             + "(1) SIM / (0) NÃO");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                double vlSubTotal;
                //------------
                Console.WriteLine("Escolha os produtos:");
                Console.WriteLine("(1) Rosa Monique" + "\n"
                                + "(2) Sepala Pequena" + "\n"
                                + "(3) Folha de Rosa Grande" + "\n"
                                + "(4) Flor Desidratada" + "\n"
                                + "(5) Arame" + "\n"
                                + "(6) Vaso de Vidro" + "\n"
                                + "(7) Fita Floral");
                int id_produto = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre com a quantidade:");
                int qt_produto = int.Parse(Console.ReadLine());

                Produto p = new Produto(id_produto, qt_produto);                
                vlSubTotal = p.CalculaValor(id_produto, qt_produto);
                //----
                vlTotal = vlTotal + vlSubTotal;
                Console.WriteLine("Deseja lançar produtos?" + "\n"
                                + "(1) SIM / (0) NÃO");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------");
                Console.WriteLine(p);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Valor Total: " + vlTotal.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
