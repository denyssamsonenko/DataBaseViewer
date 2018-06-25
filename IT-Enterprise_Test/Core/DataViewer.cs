using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Enterprise_Test
{
    public class DataViewer // Класс работы с БД
    {
        public DataViewer()
        {
        }
        string query; // Запрос построенный с параметров

        public BindingList<ShipmentClass> Transactions = new BindingList<ShipmentClass>();  // Список экземпляров класса ShipmentClass который передается в ShipmentDataGridView.DataSource

        public BindingList<ShipmentClass> ShowData(ViewSelector selectedParams)             // как возращаемое значение метода
        {
            string connectString = ConfigurationManager.AppSettings["ConnectionString"];  //Сторка подключения к базе данных
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();

            var result = String.Join(", ", selectedParams.GetParameters()); // Строим список выбраных столбцов для SQL запросов
            var postfixResult = String.Join(", ", selectedParams.GetReverseParameters()); // Строим обратный список выбраных столбцов для SQL запросов

            if (result != "" && !selectedParams.SortSelect) // При инициализации формы и вызове LoadDataBase(); result - полностью заполнен столбцами
            {
                query = "SELECT " + result + " FROM Shipment";
            }
            else if (selectedParams.SortSelect) // При выборе пользователем столбцов для отображения ключ selectedParams.SortSelect становится равным true;
            {
                query = "SELECT " + result + ", SUM (Amount), SUM(Total) FROM Shipment GROUP BY " + postfixResult;  // При необходимости SUM (Amount) и SUM(Total) можно сделать блоее гибко
            }                                                                                                       // но в задании такого требования не звучит и данная реализация кажется логичной
            else
            {
                MessageBox.Show("Error with Query");
            }

            SqlCommand command = new SqlCommand(query, myConnection);   // Передаем собраную сторку query в команду
            try                                                         // Считываем данные с базы
            {
                SqlDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    ShipmentClass shipmentClass = new ShipmentClass();  // Наполняем список Transactions экземпляров класса ShipmentClass считанными с базы данными

                    if (selectedParams.Date != "")
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
                        shipmentClass.Amount = (int)Reader["Amount"];   // По умолчанию selectedParams.Amount == ""
                    }
                    else
                    {
                        shipmentClass.Amount = (int)Reader[selectedParams.GetParameters().Count];   // Количество пред последний параметр в списке отображения и считывания запросом query
                    }
                    if (selectedParams.Total != "")
                    {
                        shipmentClass.Total = (decimal)Reader["Total"];     // По умолчанию selectedParams.Total == ""
                    }
                    else
                    {
                        shipmentClass.Total = (decimal)Reader[selectedParams.GetParameters().Count + 1];    // Сумма последний параметр в списке отображения и считывания запросом query
                    }
                    Transactions.Add(shipmentClass);    // Добавляем заполеный экземпляр класса в список
                }
                Reader.Close();
                myConnection.Close();
            }
            catch (Exception ex)    // Обрабатываем исключения
            {
                string errorMessage = String.Format(CultureInfo.CurrentCulture,
                        "Exception Type: {0}, Message: {1}{2}",
                        ex.GetType(),
                        ex.Message,
                        ex.InnerException == null ? String.Empty :
                        String.Format(CultureInfo.CurrentCulture,
                                     " InnerException Type: {0}, Message: {1}",
                                     ex.InnerException.GetType(),
                                     ex.InnerException.Message));

                System.Diagnostics.Debug.WriteLine(errorMessage);
            }

            return Transactions;    // Возвращаем списко экземпляров класса ShipmentClass который является DataSource для DataGridView
        }
    }
}
