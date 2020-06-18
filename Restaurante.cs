using System;

namespace ex20
{
    public class Restaurante
    {
        public string fantasyName;
        public string adress;

        public Restaurante(string arg1, string arg2){
            fantasyName=arg1;
            adress=arg2;
            showData();
        }

        public void showData(){
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Mostrando dados");
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Restaurante:....{0}",fantasyName);
            Console.WriteLine("Endereço:.......{0}",adress);
            Console.ResetColor();

        }

    }
}