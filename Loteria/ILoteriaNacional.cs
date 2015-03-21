using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Loteria.Entidades;

namespace Loteria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ILoteriaNacional
    {
        [OperationContract]
        String NumeroGanador();

        [OperationContract]
        Premio PremioMayor();

        [OperationContract]
        void AgregarPremio(Premio premio);

        [OperationContract]
        Double TipoCambio();

        // TODO: agregue aquí sus operaciones de servicio
    }
}
