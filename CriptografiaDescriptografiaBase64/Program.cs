using System.IO;
using System.Text;

namespace Programas
{
    public class Program 
    {
        public static void Main(string[] args)
        {

             int opcao;
             string arquivo, conteudoArquivo, caminhoArquivo;

             void Criptografar(){

                try
                {
                    string conteudoEncriptado = Convert.ToBase64String(Encoding.UTF8.GetBytes(conteudoArquivo));

                    Console.WriteLine("\nResultado: " + conteudoEncriptado);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Formato não aceito.",e);
                }
            }
            
            void Descriptografar()
            {
                try
                {
                    string conteudoDescriptado = Encoding.UTF8.GetString(Convert.FromBase64String(conteudoArquivo));

                    Console.WriteLine("\nResultado: " + conteudoDescriptado);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Formato não aceito.", e);
                }
            }

            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("\nCriptografia e descriptografia de arquivos - Base 64\n");
            Console.Write("1 - Criptografar arquivo\n");
            Console.Write("2 - Decriptografar arquivo\n");


            Console.WriteLine("\nDigite a opção escolhida: \n");

            opcao = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o caminho do arquivo - (com a extensão do arquivo, exemplo: txt): \n");

            caminhoArquivo = Console.ReadLine();

            arquivo = caminhoArquivo;

            conteudoArquivo = File.ReadAllText(arquivo.ToString(), Encoding.UTF8);

            switch (opcao)
                {
                    case 1:

                        Criptografar();
                        break;

                    case 2:

                        Descriptografar();
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
        }

    }
}