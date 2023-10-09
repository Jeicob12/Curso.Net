using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;

namespace Curso_Net
{
   
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Usuario GetUser(int userId);

    }

    [DataContract]
    public class Usuario 
    {
        [DataMember]
        public string Nombre { get; set;}
        [DataMember]
        public string Apellido { get; set;}
    }

    public class Service : IService
    {
        public Usuario GetUser (int userId)
        {
            return new Usuario()
            {
                Nombre = "Juan",
                Apellido = "perez",
            };
        }
    }
}
