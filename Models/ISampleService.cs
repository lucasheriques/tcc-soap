using System.ServiceModel;
using System.Collections.Generic;
namespace Models
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        List<Teacher> GetTeachers();
        [OperationContract]
        Teacher GetTeacher(int id);
    }
}