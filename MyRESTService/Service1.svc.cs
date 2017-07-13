using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static String str;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string SetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetTeste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select texto from mensagens", ConfigurationManager.ConnectionStrings["dbMessages"].ConnectionString);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            return ""; // ds.Tables[0].Columns.ToString();
            
            //return str;
        }
        public void SetTeste(string parStr)
        {
            str = parStr;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
