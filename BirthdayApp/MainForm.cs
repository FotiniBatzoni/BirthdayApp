using BirthdayApp.Classes;
using BirthdayApp.Interfaces;
using BirthdayApp.Utilities;
using System.ComponentModel;


namespace BirthdayApp
{
    public partial class MainForm : Form
    {
        private readonly MongoDBContext _mongoDBContext;

        private readonly PersonRepository _personRepository;

        private readonly ErrorProvider errorProvider = new ErrorProvider();

      

        public MainForm(MongoDBContext mongoDBContext, PersonRepository personRepository)
        {
            InitializeComponent();

            _mongoDBContext = new MongoDBContext("mongodb://localhost:27017", "BirthdayApp");

            _personRepository = personRepository;

            PopulateComboBox();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var persons = _personRepository.GetAll();

            // Create an instance of the DataGridViewList form
            DataGridViewList dataGridViewListForm = new DataGridViewList();

            // Populate the DataGridView in the form with the retrieved persons
            dataGridViewListForm.PopulateDataGridView(persons);

            // Show the form
            dataGridViewListForm.Show();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidationOf.TextBox(txtBoxFirstName.Text))
            {
                var newPerson = Utilities.Utilities.CreateNewPerson(txtBoxFirstName, txtBoxLastName, bday, cmbBoxSex);

                try
                {
                    Calculate.ParseGreekDate(newPerson.Birthday);

                    _personRepository.Add(newPerson);
                    MessageBox.Show("Επιτυχής καταχώρηση!");

                    //ClearInputFields
                    Utilities.Utilities.ClearInputFields(txtBoxFirstName, txtBoxLastName, bday, cmbBoxSex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Λάθος στην καταχώρηση: {ex.Message}");
                }
            }
        }

        private void PopulateComboBox()
        {
            // Create ComboBoxItem instances
            ComboBoxSex man = new ComboBoxSex { DisplayText = "'Αντρας", Value = 1 };
            ComboBoxSex woman = new ComboBoxSex { DisplayText = "Γυναίκα", Value = 2 };

            // Add items to the ComboBox
            cmbBoxSex.Items.Add(man);
            cmbBoxSex.Items.Add(woman);
        }

        private void cmbBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Access the selected item and its associated value
            if (cmbBoxSex.SelectedItem is ComboBoxSex selected)
            {
                int selectedValue = selected.Value;

            }
        }

        private void btnListByMonth_Click(object sender, EventArgs e)
        {
            int currentMonth = DateTime.Today.Month;

            var persons = _personRepository.GetAll();

            var birthdaysThisMonth = persons.Where(person =>
             Calculate.MonthOfBirth(person.Birthday) == currentMonth
         ).ToList();

            DataGridViewList dataGridViewListForm = new DataGridViewList();

            // Populate the DataGridView in the form with the retrieved persons
            dataGridViewListForm.PopulateDataGridView(birthdaysThisMonth);

            // Show the form
            dataGridViewListForm.Show();

        }
    }
}