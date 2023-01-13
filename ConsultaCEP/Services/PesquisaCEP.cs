using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsultaCEP.Services
{
    public class PesquisaCEP
    {
        public ViaCEP Consulta(string CEP)
        {
            string oCEP = CEP;
            string oURL = "https://viacep.com.br/ws/" + CEP + "/json/";

            HttpClient _httpClient = new HttpClient();
            HttpResponseMessage result = _httpClient.GetAsync(oURL).Result;

            string JsonRetorno = result.Content.ReadAsStringAsync().Result;
            ViaCEP oviaCEP = new ViaCEP();
            oviaCEP = JsonConvert.DeserializeObject<ViaCEP>(JsonRetorno);
            return oviaCEP;
        }
    }
}
