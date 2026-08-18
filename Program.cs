using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace meu_cep
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Informe o CEP: ");
            var cep = Console.ReadLine()?.Replace("-", "").Trim();

            if (string.IsNullOrEmpty(cep) || cep.Length != 8)
            {
                Console.WriteLine("CEP inválido. Digite 8 números.");
                return;
            }

            using var client = new HttpClient();

            try
            {
                var url = $"https://viacep.com.br/ws/{cep}/json/";
                var endereco = await client.GetFromJsonAsync<Endereco>(url);

                if (endereco == null || endereco.Erro == "true")
                {
                    Console.WriteLine("CEP não encontrado.");
                    return;
                }

                Console.WriteLine($"\nEndereço: {endereco.Logradouro}");
                Console.WriteLine($"Bairro:   {endereco.Bairro}");
                Console.WriteLine($"Cidade:   {endereco.Localidade} - {endereco.Uf}");
            
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar CEP: {ex.Message}");
            }
        }
        public record Endereco(
            string Logradouro,
            string Bairro,
            string Localidade,
            string Uf,
            string Erro
        );
    }
}