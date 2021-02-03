using POC_Consumindo_Api1.net_http.Domain;
using POC_Consumindo_Api1.net_http.Domain.Models;
using POC_Consumindo_Api1.Refit;
using System;
using System.Net.Http;

namespace POC_Consumindo_Api1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acessando Api1 via ConsumoHttpService ....");

            ConsumoHttpService<Taxa> consumoViaHttpNet = new ConsumoHttpService<Taxa>(new HttpClient(), "https://localhost:5001");           

            Taxa taxaComumoHttpService = consumoViaHttpNet.GetAsync("/taxajuros").Result;

            Console.WriteLine(taxaComumoHttpService.Value);

            Console.WriteLine("Acessando Api1 via Refit ....");

            ConsumoRefit consumoRefit = new ConsumoRefit("https://localhost:5001/","taxajuros");            

            Console.WriteLine(consumoRefit.Response.Value);

            Console.ReadLine();
        }
    }
}
