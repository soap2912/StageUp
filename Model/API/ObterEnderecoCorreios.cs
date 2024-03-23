using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Correios.Net;
using Correios;
using Correios.CorreiosServiceReference;
using StageUP.Model.PaginaCadastro;
using System.Runtime.InteropServices.WindowsRuntime;
using Newtonsoft.Json;
using System.Net.Http;

namespace StageUP.Model.API
{
    public class ObterEnderecoCorreios
    {
        public CEP_Endereco PegarEndereco(CEP_Endereco cep)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync($"https://viacep.com.br/ws/{cep.Cep}/json/").Result;
                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    dynamic data = JsonConvert.DeserializeObject(json);

                    // Verifica se o CEP foi encontrado
                    if (data.erro != null && (bool)data.erro)
                        return null;

                    // Preenche os dados do endereço
                    CEP_Endereco endereco = new CEP_Endereco()
                    {
                        Cep = data.Cep,
                        Rua = data.logradouro,
                        Bairro = data.bairro,
                        Cidade = data.localidade,
                        Uf = data.uf
                    };

                    return endereco;
                }
                return null;
            }


        }
    }
}