namespace IT_Enterprise_Test
{
    partial class Shipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ShipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEnterpriseStorageDataSet = new IT_Enterprise_Test.ITEnterpriseStorageDataSet();
            this.shipmentTableAdapter = new IT_Enterprise_Test.ITEnterpriseStorageDataSetTableAdapters.ShipmentTableAdapter();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.OrganizationCheckBox = new System.Windows.Forms.CheckBox();
            this.CityCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryCheckBox = new System.Windows.Forms.CheckBox();
            this.ManagerCheckBox = new System.Windows.Forms.CheckBox();
            this.AmountCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalCheckBox = new System.Windows.Forms.CheckBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEnterpriseStorageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(92, 12);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(91, 23);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Сортировать";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ShipmentDataGridView
            // 
            this.ShipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipmentDataGridView.Location = new System.Drawing.Point(12, 76);
            this.ShipmentDataGridView.Name = "ShipmentDataGridView";
            this.ShipmentDataGridView.Size = new System.Drawing.Size(776, 264);
            this.ShipmentDataGridView.TabIndex = 2;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.iTEnterpriseStorageDataSet;
            // 
            // iTEnterpriseStorageDataSet
            // 
            this.iTEnterpriseStorageDataSet.DataSetName = "ITEnterpriseStorageDataSet";
            this.iTEnterpriseStorageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Location = new System.Drawing.Point(72, 53);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(52, 17);
            this.DateCheckBox.TabIndex = 3;
            this.DateCheckBox.Text = "Дата";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // OrganizationCheckBox
            // 
            this.OrganizationCheckBox.AutoSize = true;
            this.OrganizationCheckBox.Location = new System.Drawing.Point(155, 53);
            this.OrganizationCheckBox.Name = "OrganizationCheckBox";
            this.OrganizationCheckBox.Size = new System.Drawing.Size(93, 17);
            this.OrganizationCheckBox.TabIndex = 3;
            this.OrganizationCheckBox.Text = "Организация";
            this.OrganizationCheckBox.UseVisualStyleBackColor = true;
            this.OrganizationCheckBox.CheckedChanged += new System.EventHandler(this.OrganizationCheckBox_CheckedChanged);
            // 
            // CityCheckBox
            // 
            this.CityCheckBox.AutoSize = true;
            this.CityCheckBox.Location = new System.Drawing.Point(271, 53);
            this.CityCheckBox.Name = "CityCheckBox";
            this.CityCheckBox.Size = new System.Drawing.Size(56, 17);
            this.CityCheckBox.TabIndex = 3;
            this.CityCheckBox.Text = "Город";
            this.CityCheckBox.UseVisualStyleBackColor = true;
            this.CityCheckBox.CheckedChanged += new System.EventHandler(this.CityCheckBox_CheckedChanged);
            // 
            // CountryCheckBox
            // 
            this.CountryCheckBox.AutoSize = true;
            this.CountryCheckBox.Location = new System.Drawing.Point(367, 53);
            this.CountryCheckBox.Name = "CountryCheckBox";
            this.CountryCheckBox.Size = new System.Drawing.Size(62, 17);
            this.CountryCheckBox.TabIndex = 3;
            this.CountryCheckBox.Text = "Страна";
            this.CountryCheckBox.UseVisualStyleBackColor = true;
            this.CountryCheckBox.CheckedChanged += new System.EventHandler(this.CountryCheckBox_CheckedChanged);
            // 
            // ManagerCheckBox
            // 
            this.ManagerCheckBox.AutoSize = true;
            this.ManagerCheckBox.Location = new System.Drawing.Point(458, 53);
            this.ManagerCheckBox.Name = "ManagerCheckBox";
            this.ManagerCheckBox.Size = new System.Drawing.Size(79, 17);
            this.ManagerCheckBox.TabIndex = 3;
            this.ManagerCheckBox.Text = "Менеджер";
            this.ManagerCheckBox.UseVisualStyleBackColor = true;
            this.ManagerCheckBox.CheckedChanged += new System.EventHandler(this.ManagerCheckBox_CheckedChanged);
            // 
            // AmountCheckBox
            // 
            this.AmountCheckBox.AutoSize = true;
            this.AmountCheckBox.Checked = true;
            this.AmountCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AmountCheckBox.Location = new System.Drawing.Point(556, 53);
            this.AmountCheckBox.Name = "AmountCheckBox";
            this.AmountCheckBox.Size = new System.Drawing.Size(85, 17);
            this.AmountCheckBox.TabIndex = 3;
            this.AmountCheckBox.Text = "Количество";
            this.AmountCheckBox.UseVisualStyleBackColor = true;
            this.AmountCheckBox.CheckedChanged += new System.EventHandler(this.AmountCheckBox_CheckedChanged);
            // 
            // TotalCheckBox
            // 
            this.TotalCheckBox.AutoSize = true;
            this.TotalCheckBox.Checked = true;
            this.TotalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TotalCheckBox.Location = new System.Drawing.Point(665, 53);
            this.TotalCheckBox.Name = "TotalCheckBox";
            this.TotalCheckBox.Size = new System.Drawing.Size(60, 17);
            this.TotalCheckBox.TabIndex = 3;
            this.TotalCheckBox.Text = "Сумма";
            this.TotalCheckBox.UseVisualStyleBackColor = true;
            this.TotalCheckBox.CheckedChanged += new System.EventHandler(this.TotalCheckBox_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(2, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TotalCheckBox);
            this.Controls.Add(this.AmountCheckBox);
            this.Controls.Add(this.ManagerCheckBox);
            this.Controls.Add(this.CountryCheckBox);
            this.Controls.Add(this.CityCheckBox);
            this.Controls.Add(this.OrganizationCheckBox);
            this.Controls.Add(this.DateCheckBox);
            this.Controls.Add(this.ShipmentDataGridView);
            this.Controls.Add(this.UpdateButton);
            this.Name = "Shipment";
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.Shipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEnterpriseStorageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView ShipmentDataGridView;
        private ITEnterpriseStorageDataSet iTEnterpriseStorageDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private ITEnterpriseStorageDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.CheckBox OrganizationCheckBox;
        private System.Windows.Forms.CheckBox CityCheckBox;
        private System.Windows.Forms.CheckBox CountryCheckBox;
        private System.Windows.Forms.CheckBox ManagerCheckBox;
        private System.Windows.Forms.CheckBox AmountCheckBox;
        private System.Windows.Forms.CheckBox TotalCheckBox;
        private System.Windows.Forms.Button BackButton;
    }
}

