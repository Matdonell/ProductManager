using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Modele.ProductManager.Entities;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CommandeWCF
{
    [ServiceContract]
    public interface IServiceCommandes
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "getCommandes")]
        List<Commande> GetCommandes();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "getClientCommandes?clientId={idClient}")]
        List<Commande> getClientCommandes(string idClient); 
    }
}
