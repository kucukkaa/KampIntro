using System;
using System.Collections.Generic;
using System.Text;
using Gun5Odev5TheGame.Abstract;
using Gun5Odev5TheGame.Entities;
using MernisServiceReference;

namespace Gun5Odev5TheGame.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool IsRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.BirthDate.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
