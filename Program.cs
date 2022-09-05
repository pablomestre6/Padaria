using System;
using System.IO;

namespace Padaria // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu ()

        {
            Console.Clear ();
            Console.WriteLine("Bem vindo ao sistema de padaria");
            Console.WriteLine("1 -  Estoque ");
            Console.WriteLine("2 -  Financeiro ");
            Console.WriteLine("3 -  Recursos Humanos");
            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0 :System.Environment.Exit(0); break;
                case 1: inventory(); break;
              //  case 2: financial(); break;
              //  case 4: Salvar(); break;
                default: Menu(); break;
                
            }
          
          static void inventory()
          {
              inventory I = new inventory () ; 

           Console.Clear(); 
           Console.WriteLine("Produto");
           var product = Console.ReadLine();

            //Descrição
           Console.Clear();
           Console.WriteLine("Descrição");
           var Description = Console.ReadLine();
           Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _");
           string text = "";

            //Data
           Console.Clear();
           DateTime dt1 = new DateTime(2022);
           Console.WriteLine("Complete a data:" +dt1.ToString());

           DateTime dateOnly = dt1.Date;

           Console.WriteLine("Short Date:" +dateOnly.ToString("d"));

           Console.WriteLine("Display date using 24-hour");

           Console.WriteLine(dateOnly.ToString("g"));
           Console.WriteLine(dateOnly.ToString("MM/dd/yyy hh:mm"));



            //Marca
            Console.Clear();
            Console.WriteLine("Marca do Produto");
            var Marca = Console.ReadLine();

          //Quantidadez
          Console.Clear();
          Console.WriteLine("Quantidade");
          var Quantidade = Console.ReadLine();

          
           //Vizualizar
           Console.Clear();
           Console.WriteLine ("Ver");
           var Taxes = Console.ReadLine();
           Console.WriteLine("Aqui os detalhes do seu Produto em estoque");
           Console.WriteLine($"{Environment.NewLine} Seu Produto é {product}");
           Console.WriteLine($"{Environment.NewLine} Descrição  sobre o produto   {Description }"); 
           Console.WriteLine($"{Environment.NewLine} Marca do Produto é  {Marca}"); 
           Console.WriteLine($"{Environment.NewLine} Descrição  {Quantidade}"); 

  

          }


          static void financial(){
            
          }

        }
    }
}
