using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService1
{
    [ServiceContract]
    public interface IDepartmentService
    {
        [OperationContract]
        List<DepartmentDetails> GetDepartmentDetails(int ID);

        [OperationContract]
        string InsertDepartmentDetails(DepartmentDetails DepartmentInfo);

        [OperationContract]
        List<DepartmentDetails> GetAllDepartments();

        [OperationContract]
        bool UpdateDepartment(DepartmentDetails DepartmentID);

        [OperationContract]
        bool DeleteDepartment(int EmployeeInfo);

        [OperationContract]
        string deleteDepartment(deleteDepartment dd);

        [OperationContract]
        bool FindById(int id);

        [OperationContract]
        getAllDepartments getDepartments();
    }

    [DataContract]
    public class DepartmentDetails
    {
        int id;
        string name = string.Empty;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    [DataContract]
    public class getAllDepartments
    {
        [DataMember]
        public DataTable allDepartments
        {
            get;
            set;
        }
    }

    [DataContract]
    public class deleteDepartment
    {
        int did;
        [DataMember]
        public int d_id
        {
            get { return did; }
            set { did = value; }
        }
    }
}
