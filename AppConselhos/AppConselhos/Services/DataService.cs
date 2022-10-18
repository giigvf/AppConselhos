using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppConselhos.Model;

namespace AppConselhos.Services
{
   
        class DataService
        {
            public static async Task<Conselhos> GetVida(string ID)
            {

                string queryString = "https://api.adviceslip.com/advice" + ID + "&unitsm=metric" + "&appid=" + appId;
                dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

                if (resultado["weather"] != null)
                {
                    Conselho Vida = new Conselho();
                    Vida.ID = (string)resultado["numeric"];
                    Conselho Vida = new Conselho();
                    Conselho. Vida = (string)resultado["name"];
        
            }
        }
}
