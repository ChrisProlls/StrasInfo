using StrasInfo.StrasServiceSoap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StrasInfo.Service
{
    static public class StrasService
    {
        static public async Task<List<Arrivee>> GetArret(string codeArret)
        {
            ServiceSoapClient strasContract = new ServiceSoapClient();

            using (OperationContextScope scope = new OperationContextScope(strasContract.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(new MyMessageHeader());

                var mode = 0;
                var heure = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
                var nbHeure = 3;

                var response = await strasContract.rechercheProchainesArriveesWebAsync(
                    codeArret,
                    mode,
                    heure,
                    nbHeure);

                return response.ListeArrivee.ToList();
            }
        }

        static public async Task<List<Arrivee>> GetArretByLibelle(string libelle)
        {
            ServiceSoapClient strasContract = new ServiceSoapClient();

            using (OperationContextScope scope = new OperationContextScope(strasContract.InnerChannel))
            {
                OperationContext.Current.OutgoingMessageHeaders.Add(new MyMessageHeader());

                var mode = 0;
                var heure = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
                var nbHeure = 3;

                var responseByLibelle = await strasContract.rechercherCodesArretsDepuisLibelleAsync(
                   libelle, 1);

                var response = await strasContract.rechercheProchainesArriveesWebAsync(
                    responseByLibelle.ListeArret.First().Code,
                    mode,
                    heure,
                    nbHeure
                    );

                return response.ListeArrivee.ToList();
            }
        }
    }

    public class MyMessageHeader : MessageHeader
    {
        public override string Name
        {
            get
            {
                return "CredentialHeader";
            }
        }

        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {

            writer.WriteStartElement("ID");

            writer.WriteString("1250");

            writer.WriteEndElement();

            writer.WriteStartElement("MDP");

            writer.WriteString("vki45opi2");

            writer.WriteEndElement();

        }

        public override string Namespace
        {
            get
            {
                return "http://www.cts-strasbourg.fr/";
            }
        }
    }
}
