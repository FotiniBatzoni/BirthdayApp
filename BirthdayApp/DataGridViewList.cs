﻿using BirthdayApp.Classes;
using BirthdayApp.Utilities;
using System.ComponentModel;
using System.Data;
using System.Globalization;


namespace BirthdayApp
{
    public partial class DataGridViewList : Form
    {
        private bool isNameColumnSortedAscending = false;
        private BindingList<PersonInfo> bindingList; // Define BindingList to hold data


        public DataGridViewList()
        {
            InitializeComponent();

        }

        public void PopulateDataGridView(IEnumerable<Person> persons)
        {
            var transformedData = persons.Select(p => new PersonInfo
            {
                Όνομα = p.FirstName + " " + p.LastName,
                Γενέθλια = p.Birthday,
                Ηλικία = Calculate.Age(p.Birthday),
                Ημέρες_για_τα_γενέθλια = Calculate.DaysUntilBirthday(p.Birthday),
            }).ToList();

            bindingList = new BindingList<PersonInfo>(transformedData);
            ListDataGridView.DataSource = bindingList;
        }

        private void ListDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Toggle sorting direction
            isNameColumnSortedAscending = !isNameColumnSortedAscending;

            string columnName = ListDataGridView.Columns[e.ColumnIndex].DataPropertyName;

            // Check if the column clicked is the 'Όνομα' column (assuming it's the first column)
            if (e.ColumnIndex == 0)
            {
                // Sort the BindingList
                var sortedList = isNameColumnSortedAscending ?
                    new BindingList<PersonInfo>(bindingList.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList()) :
                    new BindingList<PersonInfo>(bindingList.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList());

                bindingList = sortedList;

                ListDataGridView.DataSource = null;
                ListDataGridView.DataSource = bindingList;
            }
            else if (e.ColumnIndex == 1)
            {
                var cultureInfo = new System.Globalization.CultureInfo("el-GR");
                var dateTimeStyle = System.Globalization.DateTimeStyles.None;

                var sortedList = isNameColumnSortedAscending ?
         new BindingList<PersonInfo>(bindingList.OrderBy(x =>
         {
             // Extract the date part and convert it to DateTime for sorting
             string birthdayString = x.GetType().GetProperty(columnName).GetValue(x, null)?.ToString();
             if (!string.IsNullOrEmpty(birthdayString))
             {
                 // Parsing the string date into DateTime using the appropriate format
                 DateTime parsedDate;
                 if (DateTime.TryParseExact(birthdayString, "dddd, dd MMMM yyyy", cultureInfo, dateTimeStyle, out parsedDate))
                 {
                     return parsedDate;
                 }
             }
             return DateTime.MinValue; // Or any default value if parsing fails
         }).ToList()) :
         new BindingList<PersonInfo>(bindingList.OrderByDescending(x =>
         {
             string birthdayString = x.GetType().GetProperty(columnName).GetValue(x, null)?.ToString();
             if (!string.IsNullOrEmpty(birthdayString))
             {
                 DateTime parsedDate;
                 if (DateTime.TryParseExact(birthdayString, "dddd, dd MMMM yyyy", cultureInfo, dateTimeStyle, out parsedDate))
                 {
                     return parsedDate;
                 }
             }
             return DateTime.MinValue; // Or any default value if parsing fails
         }).ToList());

                bindingList = sortedList;

                ListDataGridView.DataSource = null;
                ListDataGridView.DataSource = bindingList;
            }
        }

    }
}
