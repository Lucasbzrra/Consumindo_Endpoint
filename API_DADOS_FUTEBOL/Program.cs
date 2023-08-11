using API_DADOS_FUTEBOL.CRUD;
using API_DADOS_FUTEBOL.Requisiçoes;
using CONSUMINDO_API_DADOS_FUTEBOL;
using CONSUMINDO_API_DADOS_FUTEBOL.Filtros;
using CONSUMINDO_API_DADOS_FUTEBOL.Modelos;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Ocsp;
using System.Collections;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text.Json;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            
            Console.WriteLine("Seja Bem vindo\n");
            Console.WriteLine("Se deseja fazer Deserialização Digite [S]-SIM N-NAO");
            string resposta;
            resposta = Console.ReadLine()!;
            Areas areas1 = RequisaoGet.Chamado();
            if (resposta.ToUpper()[0] == 'S')
            {
                while (true)
                {
                    //Console.Clear();
                    Console.WriteLine("Bem-vindo ao menu dos itens deserializados\n ");
                    Console.WriteLine("[1]-Visualizar Lista ");
                    Console.WriteLine("[2]-Atualizar Lista");
                    Console.WriteLine("[3]-Remover Item da Lista");
                    Console.WriteLine("[4]-Adicionar item na Litsa");
                    Console.WriteLine("[999]-Sair");
                    Console.WriteLine("Digite uma opção");
                    int opcao = Convert.ToInt32(Console.ReadLine())!;
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            VisualizacaoAreas.visualizacao(areas1);
                            break;
                        case 4:
                            Console.WriteLine("Informe os parâmetros obrigatorios");
                            Console.WriteLine("ID:\n");
                            int id = Convert.ToInt32(Console.ReadLine())!;
                            Console.WriteLine("NOME:\n");
                            string nome = Console.ReadLine()!;
                            AdcionarAreas.AdcionandoItem(areas1.Lista_Areas_Filhas, id, nome, null);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Informe os parâmetros obrigatorios");
                            Console.WriteLine("ID:\n");
                            int id3 = Convert.ToInt32(Console.ReadLine())!;
                            RemoverAreas.ExcluirItem(areas1, id3);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Informe os parâmetros obrigatorios");
                            Console.WriteLine("ID:\n");
                            int id4 = Convert.ToInt32(Console.ReadLine())!;
                            AtualizarAreas.AtualizarItem(areas1.Lista_Areas_Filhas, id4);
                            break;
                        default:
                            Console.WriteLine("Opcao invalida");
                            break;

                    }
                    if (opcao == 999)
                    {
                        break;
                    }
                    Console.WriteLine("\n Bonus Adcional\n Lista de Items que o campo FLAG foi preenchido");
                    IEnumerable<AreasFilhas> areas = new List<AreasFilhas>();
                    
                    LinqFiltros.FiltragemPorItemDiferentesDeNulo(areas);

                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();

    }
}