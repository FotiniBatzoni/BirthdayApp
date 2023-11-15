using BirthdayApp.Classes;
using BirthdayApp.Utilities;
using System.Data;


namespace BirthdayApp
{
    public partial class DataGridViewList : Form
    {
        public DataGridViewList()
        {
            InitializeComponent();

        }

        public void PopulateDataGridView(IEnumerable<Person> persons)
        {
            var transformedData = persons.Select(p => new
            {
                Όνομα = p.FirstName + " " + p.LastName,
                Γενέθλια = p.Birthday,
                Ηλικία = Calculate.Age(p.Birthday),
                Ημέρες_για_τα_γενέθλια = Calculate.DaysUntilBirthday(p.Birthday),
            }).ToList();

            ListDataGridView.DataSource = transformedData;
        }
    }
}
