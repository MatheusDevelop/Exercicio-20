using System;

namespace ex20
{
    public class Cliente
    {
        public string name;
        public string actualAdress;

        public Cliente(string arg1,string arg2){
            name=arg1;
            actualAdress=arg2;
            showData();
            
        }

        public void showData(){
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Mostrando dados");
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Nome:..............{0}",name);
            Console.WriteLine("Endereço Atual:....{0}",actualAdress);
            Console.ResetColor();
        }

    }
}