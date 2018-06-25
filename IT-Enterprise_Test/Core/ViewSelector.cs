using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Enterprise_Test
{
    public class ViewSelector
    {
        // Переменные повторяются с Моделью ShipmentClass, но в селекторе они все имеют тип string и используются для построения запросов к БД
        #region private Variables
        private string date;
        private string organization;
        private string city;
        private string country;
        private string manager;
        private string amount;
        private string total;
        private bool sortSelect;
        #endregion

        public List<string> parameters = new List<string>();         // Параметры (все выбраные пользователем столбцы) которые необходимы для построения SQL query ("SELECT " + result +...)
        private List<string> reverseParameters = new List<string>();    // Параметры в обратном порядке (все выбраные пользователем столбцы) которые необходимы для построения SQL query (... + "GROUP BY " + postfixResult)

        public List<string> GetParameters() // Метод возвращающий параметры
        {
            parameters.Clear();             // Каждый раз список параметров очищается и строится по-новой
            if(Date!="")                    // Из Form1 выбраных пользователем CheckBox.Checked устанавливаем, например, viewSelector.Date = "Date";
            {
                parameters.Add(date);   //Добавляем параметри
            }
            if(Organization!="")
            {
                parameters.Add(organization);
            }
            if(City!="")
            {
                parameters.Add(city);
            }
            if(Country!= "")
            {
                parameters.Add(country);
            }
            if(Manager !="")
            {
                parameters.Add(manager);
            }
            if(Amount != "")
            {
                parameters.Add(amount);
            }
            if(Total != "")
            {
                parameters.Add(total);
            }
            return parameters; // Возвращаем List
        }

        public List<string> GetReverseParameters() // List parameters в обратном порядке для GROUP BY в SQL Query
        {
            reverseParameters.Clear();
            for (int i = parameters.Count - 1; i >= 0; i-- )
            {
                reverseParameters.Add(parameters[i]);
            }
            return reverseParameters;
        }

        public ViewSelector(string date, string organization, string city, string country,      // Контроуктор ViewSelector 
            string manager, string amount, string total, bool sortSelect)
        {
            this.date = date;
            this.organization = organization;
            this.city = city;
            this.country = country;
            this.manager = manager;
            this.amount = amount;
            this.total = total;
            this.sortSelect = sortSelect;
        }

        //Публичные методы переменных класса
        #region pubic VaraiblesProperties
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Total
        {
            get { return total; }
            set { total = value; }
        }
        public bool SortSelect
        {
            get { return sortSelect; }
            set { sortSelect = value; }
        }
    }
    #endregion

}
