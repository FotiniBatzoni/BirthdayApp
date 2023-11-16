using BirthdayApp.Classes;
using BirthdayApp.Utilities;
using System.ComponentModel;
using System.Data;


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
            // Check if the column clicked is the 'Όνομα' column (assuming it's the first column)
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                // Toggle sorting direction
                isNameColumnSortedAscending = !isNameColumnSortedAscending;

                string columnName = ListDataGridView.Columns[e.ColumnIndex].DataPropertyName;

                // Sort the BindingList
                var sortedList = isNameColumnSortedAscending ?
                    new BindingList<PersonInfo>(bindingList.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList()) :
                    new BindingList<PersonInfo>(bindingList.OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList());

                bindingList = sortedList;

                ListDataGridView.DataSource = null;
                ListDataGridView.DataSource = bindingList;
            }
        }

    }
}
