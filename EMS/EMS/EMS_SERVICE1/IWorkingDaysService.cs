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
    public interface IWorkingDaysService
    {
        [OperationContract]
        List<WorkingDaysDetails> GetWDDetails(int ID);

        [OperationContract]
        string InsertWDDetails(WorkingDaysDetails wd);

        [OperationContract]
        List<WorkingDaysDetails> GetAllWD();

        [OperationContract]
        bool UpdateWD(WorkingDaysDetails wdID);

        [OperationContract]
        bool DeleteWD(int EmployeeInfo);

        [OperationContract]
        string deleteWD(deleteWD dd);

        [OperationContract]
        bool FindById(int id);

        [OperationContract]
        getAllWD getWDs();
    }

    [DataContract]
    public class WorkingDaysDetails
    {
        int id;
        
        string shiftdetails = string.Empty;


        [DataMember]
        public int NumberOfWD { get; set; }

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string ShiftDetails
        {
            get { return shiftdetails; }
            set { shiftdetails = value; }
        }
    }

    [DataContract]
    public class getAllWD
    {
        [DataMember]
        public DataTable allWds
        {
            get;
            set;
        }
    }

    [DataContract]
    public class deleteWD
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
