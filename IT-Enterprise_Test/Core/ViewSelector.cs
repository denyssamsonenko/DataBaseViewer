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
        private bool sortSelect;
        #endregion

        public List<string> parameters = new List<string>();
        private List<string> reverseParameters = new List<string>();

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

        public List<string> GetReverseParameters()
        {
            reverseParameters.Clear();
            for (int i = parameters.Count - 1; i >= 0; i-- )
            {
                reverseParameters.Add(parameters[i]);
            }
            return reverseParameters;
        }

        public ViewSelector(string date, string organization, string city, string country,
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
