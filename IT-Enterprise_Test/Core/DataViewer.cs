using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Enterprise_Test
{
    public class DataViewer
    {
        public DataViewer()
        {

        }
        string query;
        string finalQuery;

        public BindingList<ShipmentClass> Transactions = new BindingList<ShipmentClass>();

        public BindingList<ShipmentClass> ShowData(ViewSelector selectedParams)
        {
            string connectString = "Data Source=DESKTOP-MF59TE3;Initial Catalog=ITEnterpriseStorage;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            var result = String.Join(", ", selectedParams.GetParameters());
            if(result != "")
            {
                query = "SELECT Id, " + result + " FROM Shipment";
            }
            else
            {
                query = "SELECT * FROM Shipment";
            }
            finalQuery = query.ToString();

            SqlCommand command = new SqlCommand(finalQuery, myConnection);

            SqlDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                ShipmentClass shipmentClass = new ShipmentClass();
                shipmentClass.Id = (Guid)Reader["Id"];
                if (selectedParams.Date !="")
                {
                    shipmentClass.Date = (DateTime)Reader["Date"];
                }
                if (selectedParams.Organization != "")
                {
                    shipmentClass.Organization = Reader["Organization"].ToString();
                }
                if (selectedParams.City != "")
                {
                    shipmentClass.City = Reader["City"].ToString();
                }
                if (selectedParams.Country != "")
                {
                    shipmentClass.Country = Reader["Country"].ToString();
                }
                if (selectedParams.Manager != "")
                {
                    shipmentClass.Manager = Reader["Manager"].ToString();
                }
                if (selectedParams.Amount != "")
                {
                    shipmentClass.Amount = (int)Reader["Amount"];
                }
                if (selectedParams.Total != "")
                {
                    shipmentClass.Total = (decimal)Reader["Total"];
                }

                Transactions.Add(shipmentClass);
            }
            Reader.Close();
            myConnection.Close();

            return Transactions;
        }

    }
}
