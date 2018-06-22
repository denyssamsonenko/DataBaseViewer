using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Enterprise_Test
{
    public class ShipmentClass
    {

        #region private Variables

        private DateTime date;
        private string organization;
        private string city;
        private string country;
        private string manager;
        private int amount;
        private decimal total;

        #endregion

        public ShipmentClass()
        {

        }

        public ShipmentClass( DateTime date, string organization, string city, string country,
            string manager, int amount, decimal total)
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

        public DateTime Date
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
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
    }
    #endregion
}
