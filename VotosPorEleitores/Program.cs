using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotosPorEleitores
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            var voto = new Voto();

            Console.WriteLine("Votação:\r\nEscolha uma das opções para acompanhar a porcentagem dos votos:");
            /*
            Console.WriteLine($"Porcentagem dos votos válidos: {voto.PorcentagemVotoValido()}");
            Console.WriteLine($"Porcentagem dos votos brancos: {voto.PorcentagemVotoBranco()}");
            Console.WriteLine($"Porcentagem dos votos Nulos: {voto.PorcentagemVotoNulo()}");
            Console.WriteLine($"Porcentagem dos proporcionais ao aumento de 3/12 de eleitores e nulos: {voto.PorcentagemProporcional()}\r\n");
            */
            
            Console.WriteLine("1 - Votos validos.");
            Console.WriteLine("2 - Votos Brancos.");
            Console.WriteLine("3 - Votos Nulos.");
            Console.WriteLine("4 - Votos proporcionais a aumento de 3/12.");
            Console.WriteLine("5 - Para finalizar aplicação.");
            Console.WriteLine("Dgitie uma opção:");
            
            do
            {
                switch (opcao = Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("O total de votos Validos é de {0}%", voto.PorcentagemVotoValido());
                        break;
                    case "2":
                        Console.WriteLine("O total de votos em Branco é de {0}%", voto.PorcentagemVotoBranco());
                        break;
                    case "3":
                        Console.WriteLine("O total de votos Nulos é de {0}%", voto.PorcentagemVotoNulo());
                        break;
                    case "4":
                        Console.WriteLine("O total de votos Proporcionais ao aumento de 3/12 é de {0}%", voto.PorcentagemProporcional());
                        break;
                    case "5":
                        Console.WriteLine("Finalizando aplicação, digite qualquer tecla para fechar.");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opção inválida digite");
                        break;
                }
            } while (opcao != "5");
        }
    }
}
