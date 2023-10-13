using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace NasaAPODService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string getAPOD();

        [OperationContract]
        string getAPODTitle();

        [OperationContract]
        string getAPODExp();

        [OperationContract]
        string getAPODDate();

        [OperationContract]
        string getOldImage(string year, string month, string day);

        [OperationContract]
        string getOldTitle(string year, string month, string day);

        [OperationContract]
        string getOldExp(string year, string month, string day);

        [OperationContract]
        string getOldDate(string year, string month, string day);
    }    

}
