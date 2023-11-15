using BirthdayApp.Classes;
using BirthdayApp.Interfaces;


namespace BirthdayApp
{
    public partial class MainForm : Form
    {
        private readonly MongoDBContext _mongoDBContext;

        private readonly PersonRepository _personRepository;

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
            string firstName = txtBoxFirstName.Text;
            string lastName = txtBoxLastName.Text;
            string birthday = bday.Text;
            string sex = cmbBoxSex.Text;

            Person newPerson = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Birthday = birthday,
                Sex = sex
            };


            try
            {
                _personRepository.Add(newPerson);
                MessageBox.Show("Επιτυχής καταχώρηση!");

                // Optionally, update UI or clear input fields after successful addition
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Λάθος στην καταχώρηση: {ex.Message}");

            }
        }

        private void ClearInputFields()
        {
            // Clear input fields or update UI as needed
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            bday.Text = "";
            cmbBoxSex.Text = "";
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
    }
}