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
        ViewSelector viewSelector = new ViewSelector("", "", "", "", "", "", "", false); // Создаем экземпляр класса ViewSelector с пустыми параметрами (которые отвечают за выбраные CheckBox-ы) и ключем False
                                                                                         // Ключ false указывает но то что CheckBox-ы не выбраны.
        public Shipment()
        {
            InitializeComponent();
            LoadDataBase();                    // Функция загружает данные и содержит функцию изменения отрисовки данных в DataGridView
            SelectButton.Enabled = false;       // При загрузке Формы убираем возможность нажать на кнопку 'Сортировать'
        }                                        // При изменении CheckBox.Checked кнопка становится активной для пользователя

        private void LoadDataBase()     // Функция загрузки данных в DataGidView (ShipmentDataGridView) Вызываем при инициализации формы
        {                                 // Далее в программе используется перегрузка функции которая принимает выбраные параметры сортировки (viewSelector)
            viewSelector = new ViewSelector("Date", "Organization", "City", "Country", "Manager", "Amount", "Total", false);  // Полностью заполненый селектор для отображения всей таблички базы данных
            DataViewer dataViewer = new DataViewer();                                   // Создаем экземпляр класса работы с базой данных. В классе реализовано чтение базы
            ShipmentDataGridView.DataSource = dataViewer.ShowData(viewSelector);            // А метод ShowData принимает селектор для напонения выбраных в селекторе столбиков и возвращает BindingList<ShipmentClass> который отображается в в DataGridView
            HideIdAndRenameColumns(viewSelector);                   // Функция необходимый для сокрытия не используемых столбцов DataGridView и для переименования Header-ов
            viewSelector = new ViewSelector("", "", "", "", "", "", "", false); // После чего "обнуляем" viewSelector
        }

        private void LoadDataBase(ViewSelector viewSelector)  // Вызываем функцию при запросе пользователя отобразить выбранные данные
        {                                                       // В таком случае выбраные пользователем столбцы отмечены в viewSelector соответсвенно
            DataViewer dataViewer = new DataViewer();
            ShipmentDataGridView.DataSource = dataViewer.ShowData(viewSelector);
            HideIdAndRenameColumns(viewSelector);
        }

        
        
        private void Shipment_Load(object sender, EventArgs e)
        {
           
        }

        #region Buttons
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(viewSelector.Date) || !String.IsNullOrEmpty(viewSelector.Organization) ||   //При нажатии на кнопку 'Сортировать'
                !String.IsNullOrEmpty(viewSelector.City) || !String.IsNullOrEmpty(viewSelector.Country) ||        // Проверяем выбран ли хотя-бы один столбец
                !String.IsNullOrEmpty(viewSelector.Manager))                                                      
            {                                                                                                     
                viewSelector.SortSelect = true;      // Если выбран - устанавливаем ключ выборки true      
                LoadDataBase(viewSelector);         // Загружаем и отрисовываем данные
                viewSelector.SortSelect = false;    // В конце устанавливаем ключ выборки false
            }
            else
            {
                SelectButton.Enabled = false;       // Если нет выбраных столбцов деактивируем кнопку 'Сортировать' пока пользователь не установит
            }                                       // любой CheckBox.Checked
        }

        private void BackButton_Click(object sender, EventArgs e)   //При нажатии кнопки 'Назад' Загружаем все данные с таблицы
        {                                                           // как при инициализации формы
            LoadDataBase();                                         // и сбрасываем все CheckBox-ы
            DateCheckBox.Checked = false;
            OrganizationCheckBox.Checked = false;
            CityCheckBox.Checked = false;
            CountryCheckBox.Checked = false;
            ManagerCheckBox.Checked = false;
        }
        #endregion

        #region CheckBoxes

        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)    
        {                                                                       
            if (DateCheckBox.Checked)
            {                                                       // CheckBox 'Дата' при событии Checked устанавливаем параметр
                viewSelector.Date = "Date";                         // в селекторе (viewSelector.Date)
                SelectButton.Enabled = true;                        // и активируем доступ к кнопке 'Сортировать'
            }
            else if(DateCheckBox.Checked == false)                  // Если CheckBox 'Дата' не выбран, то
            {
                viewSelector.Date = "";                             // обнуляем параметр в селекторе
            }
        }

        private void OrganizationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OrganizationCheckBox.Checked)
            {                                                       // CheckBox 'Организация' при событии Checked устанавливаем параметр
                viewSelector.Organization = "Organization";         // в селекторе (viewSelector.Organization)
                SelectButton.Enabled = true;                        // и активируем доступ к кнопке 'Сортировать'
            }
            else if (OrganizationCheckBox.Checked == false)         // Если CheckBox 'Организация' не выбран, то
            {
                viewSelector.Organization = "";                     // обнуляем параметр в селекторе
            }
        }

        private void CityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CityCheckBox.Checked)
            {                                               // CheckBox 'Город' при событии Checked устанавливаем параметр
                viewSelector.City = "City";                 // в селекторе (viewSelector.City)
                SelectButton.Enabled = true;                // и активируем доступ к кнопке 'Город'
            }
            else if (CityCheckBox.Checked == false)         // Если CheckBox 'Город' не выбран, то
            {
                viewSelector.City = "";                     // обнуляем параметр в селекторе
            }
        }

        private void CountryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CountryCheckBox.Checked)
            {                                               // CheckBox 'Страна' при событии Checked устанавливаем параметр
                viewSelector.Country = "Country";           // в селекторе (viewSelector.Country)
                SelectButton.Enabled = true;                // и активируем доступ к кнопке 'Страна'
            }
            else if (CountryCheckBox.Checked == false)      // Если CheckBox 'Страна' не выбран, то
            {
                viewSelector.Country = "";                  // обнуляем параметр в селекторе
            }
        }

        private void ManagerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ManagerCheckBox.Checked)
            {                                               // CheckBox 'Менеджер' при событии Checked устанавливаем параметр
                viewSelector.Manager = "Manager";           // в селекторе (viewSelector.Manager)
                SelectButton.Enabled = true;                // и активируем доступ к кнопке 'Менеджер'
            }
            else if (ManagerCheckBox.Checked == false)      // Если CheckBox 'Менеджер' не выбран, то
            {
                viewSelector.Manager = "";                  // обнуляем параметр в селекторе
            }
        }

        private void AmountCheckBox_CheckedChanged(object sender, EventArgs e) // По умолчанию НЕ активны, так как необходимо вывести сумму по колисеству и цене
        {
            if (AmountCheckBox.Checked)
            {                                               // CheckBox 'Количество' при событии Checked устанавливаем параметр
                //viewSelector.Amount = "Amount";           // в селекторе (viewSelector.Amount)
                SelectButton.Enabled = true;                // и активируем доступ к кнопке 'Количество'
            }
            else if (AmountCheckBox.Checked == false)       // Если CheckBox 'Количество' не выбран, то
            {
                viewSelector.Amount = "";                   // обнуляем параметр в селекторе
            }
        }

        private void TotalCheckBox_CheckedChanged(object sender, EventArgs e) // По умолчанию НЕ активны, так как необходимо вывести сумму по колисеству и цене
        {
            if (TotalCheckBox.Checked)
            {                                               // CheckBox 'Сумма' при событии Checked устанавливаем параметр
                //viewSelector.Total = "Total";               // в селекторе (viewSelector.Total)
                SelectButton.Enabled = true;                // и активируем доступ к кнопке 'Сумма'
            }
            else if (TotalCheckBox.Checked == false)        // Если CheckBox 'Сумма' не выбран, то
            {
                viewSelector.Total = "";                    // обнуляем параметр в селекторе
            }
        }
        #endregion

        private void HideIdAndRenameColumns(ViewSelector viewSelector)  // Прячем не используемые столбцы и переименовываем Заголовки
        {
            for (int i = 0; i < ShipmentDataGridView.Columns.Count; i++)
            {
                ShipmentDataGridView.Columns[i].Visible = false;        // Прячем все столбцы, затем отображаем только выбранные пользователем
            }
                if (viewSelector.Date != "")
            {                                                           // Индекс столбцов фиксирован и соответсвует порядку добавления в List<string> GetParameters() класса ViewSelector
                ShipmentDataGridView.Columns[0].HeaderText = "Дата";    // Переименовываем Заголовок столбца
                    ShipmentDataGridView.Columns[0].Visible = true;         // Отображаем столбец
                }
                if (viewSelector.Organization != "")
                {
                    ShipmentDataGridView.Columns[1].HeaderText = "Организация";
                    ShipmentDataGridView.Columns[1].Visible = true;
                }
                if (viewSelector.City != "")
                {
                    ShipmentDataGridView.Columns[2].HeaderText = "Город";
                    ShipmentDataGridView.Columns[2].Visible = true;
                }
                if (viewSelector.Country != "")
                {
                    ShipmentDataGridView.Columns[3].HeaderText = "Страна";
                    ShipmentDataGridView.Columns[3].Visible = true;
                }
                if (viewSelector.Manager != "")
                {
                    ShipmentDataGridView.Columns[4].HeaderText = "Менеджер";
                    ShipmentDataGridView.Columns[4].Visible = true;
                }
            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count-2].HeaderText = "Количество";    //'Количество' и 'Сумма' выводятся в конце таблицы
            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count - 2].Visible = true;            // Даже если добавятся новые столбцы в будующем
                                                                                                            // Аналогичной логикой реализовано запись SQL запроса SUM (Amount) и SUM (Total)
            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count - 1].HeaderText = "Сумма";
            ShipmentDataGridView.Columns[ShipmentDataGridView.Columns.Count - 1].Visible = true;
        }

    }
}
