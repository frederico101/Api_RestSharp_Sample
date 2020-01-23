using System.Net;
using RestSharp;
using Newtonsoft.Json;
using ApiPNB.entities;
using ApiPNB.Interfaces;


namespace ApiPNB.InfraInstrutura.InfraInstrutura
{
    public class PnbRestCpf : IPnbRestCpf
    {
        public JsonCpf ProcessaAsync(string cpf)
        {
            string url = "https://localhost";
            var client = new RestClient(url);
            client.Proxy = new WebProxy("111.111.111.11", 8080);

            var request = new RestRequest(Method.GET);
            request.AddHeader("access_token", "xxxxxxxx");
            request.AddHeader("client_id", "xxxxxxxxxx");
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<JsonCpf>(response.Content);
        }


    }
}