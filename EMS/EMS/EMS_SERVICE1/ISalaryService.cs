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
    public interface ISalaryService
    {
        [OperationContract]
        List<SalaryDetails> GetSalaryDetails(int ID);

        [OperationContract]
        string InsertSalaryDetails(SalaryDetails sd);

        [OperationContract]
        List<SalaryDetails> GetAllSalary();

        [OperationContract]
        bool UpdateSalary(SalaryDetails sd);


        [OperationContract]
        bool FindById(int id);

        [OperationContract]
        getAllSalary getSalaries();
    }

    [DataContract]
    public class SalaryDetails
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int Salary { get; set; }
    }

    [DataContract]
    public class getAllSalary
    {
        [DataMember]
        public DataTable allSalaries
        {
            get;
            set;
        }
    }

}
