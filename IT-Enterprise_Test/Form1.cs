using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Enterprise_Test
{
    public partial class Shipment : Form
    {
        ViewSelector viewSelector = new ViewSelector("", "", "", "", "", "", "", false); 
        public Shipment()
        {
            InitializeComponent();
            LoadDataBase();
            UpdateButton.Enabled = false;
        }
        
        private void LoadDataBase()
        {
            viewSelector = new ViewSelector("Date", "Organization", "City", "Country", "Manager", "Amount", "Total", false);
            DataViewer dataViewer = new DataViewer();
            ShipmentDataGridView.DataSource = dataViewer.ShowData(viewSelector);
            HideIdAndRenameColumns(viewSelector);
            viewSelector = new ViewSelector("", "", "", "", "", "", "", false);
        }

        private void LoadDataBase(ViewSelector viewSelector)
        {
            DataViewer dataViewer = new DataViewer();
            ShipmentDataGridView.DataSource = dataViewer.ShowData(viewSelector);
            HideIdAndRenameColumns(viewSelector);
        }

        
        
        private void Shipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTEnterpriseStorageDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.iTEnterpriseStorageDataSet.Shipment);
        }

        #region Buttons
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(viewSelector.Date) || !String.IsNullOrEmpty(viewSelector.Organization) ||
                !String.IsNullOrEmpty(viewSelector.City) || !String.IsNullOrEmpty(viewSelector.Country) ||
                !String.IsNullOrEmpty(viewSelector.Manager))
            {
                viewSelector.SortSelect = true;
                LoadDataBase(viewSelector);
                viewSelector.SortSelect = false;
            }
            else
            {
                UpdateButton.Enabled = false;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoadDataBase(new ViewSelector("Date", "Organization", "City", "Country", "Manager", "Amount", "Total", false));
        }
        #endregion

        #region CheckBoxes

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(DateCheckBox.Checked)
            {
                viewSelector.Date = "Date";
                UpdateButton.Enabled = true;
            }
            else if(DateCheckBox.Checked == false)
            {
                viewSelector.Date = "";
            }
        }

        private void OrganizationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OrganizationCheckBox.Checked)
            {
                viewSelector.Organization = "Organization";
                UpdateButton.Enabled = true;
            }
            else if (OrganizationCheckBox.Checked == false)
            {
                viewSelector.Organization = "";
            }
        }

        private void CityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CityCheckBox.Checked)
            {
                viewSelector.City = "City";
                UpdateButton.Enabled = true;
            }
            else if (CityCheckBox.Checked == false)
            {
                viewSelector.City = "";
            }
        }

        private void CountryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CountryCheckBox.Checked)
            {
                viewSelector.Country = "Country";
                UpdateButton.Enabled = true;
            }
            else if (CountryCheckBox.Checked == false)
            {
                viewSelector.Country = "";
            }
        }

        private void ManagerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ManagerCheckBox.Checked)
            {
                viewSelector.Manager = "Manager";
                UpdateButton.Enabled = true;
            }
            else if (ManagerCheckBox.Checked == false)
            {
                viewSelector.Manager = "";
            }
        }

        private void AmountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AmountCheckBox.Checked)
            {
                //viewSelector.Amount = "Amount";
            }
            else if (AmountCheckBox.Checked == false)
            {
                viewSelector.Amount = "";
            }
        }

        private void TotalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TotalCheckBox.Checked)
            {
                //viewSelector.Total = "Total";
            }
            else if (TotalCheckBox.Checked == false)
            {
                viewSelector.Total = "";
            }
        }
        #endregion

        private void HideIdAndRenameColumns(ViewSelector viewSelector)
        {
            for (int i = 0; i < ShipmentDataGridView.Columns.Count; i++)
            {
                ShipmentDataGridView.Columns[i].Visible = false;
            }
                if (viewSelector.Date != "")
                {
                    ShipmentDataGridView.Columns[0].HeaderText = "Дата";
                    ShipmentDataGridView.Columns[0].Visible = true;
                    //viewSelector.Date = "";
                }
                if (viewSelector.Organization != "")
                {
                    ShipmentDataGridView.Columns[1].HeaderText = "Организация";
                    ShipmentDataGridView.Columns[1].Visible = true;
                    //viewSelector.Organization = "";
                }
                if (viewSelector.City != "")
                {
                    ShipmentDataGridView.Columns[2].HeaderText = "Город";
                    ShipmentDataGridView.Columns[2].Visible = true;
                    //viewSelector.City = "";
                }
                if (viewSelector.Country != "")
                {
                    ShipmentDataGridView.Columns[3].HeaderText = "Страна";
                    ShipmentDataGridView.Columns[3].Visible = true;
                    //viewSelector.Country = "";
                }
                if (viewSelector.Manager != "")
                {
                    ShipmentDataGridView.Columns[4].HeaderText = "Менеджер";
                    ShipmentDataGridView.Columns[4].Visible = true;
                    //viewSelector.Manager = "";
                }
            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count-2].HeaderText = "Количство";
            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count - 2].Visible = true;

            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count - 1].HeaderText = "Сумма";
            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count - 1].Visible = true;
        }

    }
}
