using BirthdayApp.Classes;
using BirthdayApp.Interfaces;
using BirthdayApp.Repository;
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
        private readonly GroupRepository _groupRepository;


        public DataGridViewList(GroupRepository groupRepository)
        {
            InitializeComponent();
            _groupRepository = groupRepository;
        }

        public void PopulateDataGridView(IEnumerable<Person> persons)
        {
            var transformedData = persons.Select(p =>
            {
                var group = _groupRepository.GetById(p.PersonsGroup);
                return new PersonInfo
                {
                    Όνομα = p.FirstName + " " + p.LastName,
                    Γενέθλια = p.Birthday,
                    Ηλικία = Calculate.Age(p.Birthday),
                    Ημέρες_για_τα_γενέθλια = Calculate.DaysUntilBirthday(p.Birthday),
                    Γκρουπ = group != null ? group.Name : "Unknown"
                };
            }).ToList();

            bindingList = new BindingList<PersonInfo>(transformedData);
            ListDataGridView.DataSource = bindingList;
        }

        private void ListDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Toggle sorting direction
            isNameColumnSortedAscending = !isNameColumnSortedAscending;

            string columnName = ListDataGridView.Columns[e.ColumnIndex].DataPropertyName;

            if (e.ColumnIndex == 0)
            {
                // Sort the BindingList
                var sortedList = isNameColumnSortedAscending ?
                    new BindingList<PersonInfo>(bindingList
                    .OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList()) :
                    new BindingList<PersonInfo>(bindingList
                    .OrderByDescending(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList());

                bindingList = sortedList;

                ListDataGridView.DataSource = null;
                ListDataGridView.DataSource = bindingList;
            }
            else if (e.ColumnIndex == 1)
            {

                var sortedList = isNameColumnSortedAscending ?
                new BindingList<PersonInfo>(bindingList.OrderBy(x =>
                {
                    string birthdayString = x.GetType().GetProperty(columnName).GetValue(x, null)?.ToString();
                    return Calculate.ParsedDate(birthdayString);
                }).ToList()) :
                new BindingList<PersonInfo>(bindingList.OrderByDescending(x =>
                {
                    string birthdayString = x.GetType().GetProperty(columnName).GetValue(x, null)?.ToString();
                    return Calculate.ParsedDate(birthdayString);
                }).ToList());

                bindingList = sortedList;

                ListDataGridView.DataSource = null;
                ListDataGridView.DataSource = bindingList;
            }
        }


    }
}
