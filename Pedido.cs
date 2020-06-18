using System;

namespace ex20
{
    public class Pedido
    {
        public string[] itens;
        public string Client;
        public string Restaurant;
        public string PayForm;
        

        private void makeRequisition(string arg1){
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Entregando para o cliente:.{0}",Client);
            Console.WriteLine("Pedido no restaurante:.....{0}",Restaurant);
            Console.WriteLine("Forma de pagamento:........{0}",PayForm);
            Console.ResetColor();
            string[] array=arg1.Split("/");
            Console.WriteLine("Lista do pedido:");
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
            Console.ResetColor();

        }
        public Pedido(string arg1,string arg2,string arg3,string arg4){
            
            if(arg4.Length >0){
                Client=arg2;
                Restaurant=arg3;
                PayForm=arg4;
                makeRequisition(arg1);
            }else{
                Console.ForegroundColor=ConsoleColor.DarkRed;
                Console.WriteLine("Forma de pagamento nao especificada,desligando...");
                Console.ResetColor();
            }

        }


        
    }
}