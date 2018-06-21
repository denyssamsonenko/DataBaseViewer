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

        #region private Variables

        private string date;
        private string organization;
        private string city;
        private string country;
        private string manager;
        private string amount;
        private string total;
        #endregion

        public List<string> parameters = new List<string>();
        public List<string> GetParameters()
        {
            parameters.Clear();
            if(Date!="")
            {
                parameters.Add(date);
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

            return parameters;
        }

        public ViewSelector(string date, string organization, string city, string country,
            string manager, string amount, string total)
        {
            this.date = date;
            this.organization = organization;
            this.city = city;
            this.country = country;
            this.manager = manager;
            this.amount = amount;
            this.total = total;
        }

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
    }
    #endregion

}
