using System;

namespace ex20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?\n");
            string nome=Console.ReadLine();
            Console.WriteLine("Qual seu endereço?\n");
            string endereco=Console.ReadLine();
            Cliente Client = new Cliente(nome,endereco);

            Console.WriteLine("Qual nome do restaurante solicitado?\n");
            string restaurante=Console.ReadLine();
            Console.WriteLine("Qual endereço do restaurante solicitado?\n");
            string endRestaurante=Console.ReadLine();

            Restaurante restaurant = new Restaurante(restaurante,endRestaurante);

            Console.WriteLine("Faça o pedido \n\nex: Batata/Refri/Hamburguer");
            string pedido=Console.ReadLine();
            Console.WriteLine("Qual a forma de pagamento?\n\ncaso Vazio o pedido sera interrompido!!!");
            string fPaga=Console.ReadLine();
            Pedido requisition=new Pedido(pedido,Client.name,restaurant.fantasyName,fPaga);


        }
    }
}
