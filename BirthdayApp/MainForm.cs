using BirthdayApp.Classes;
using BirthdayApp.Interfaces;
using BirthdayApp.Repository;
using BirthdayApp.Utilities;


namespace BirthdayApp
{
    public partial class MainForm : Form
    {
        private readonly PersonRepository _personRepository;

        private readonly GroupRepository _groupRepository;

        public MainForm(
            MongoDBContext mongoDBContext,
            PersonRepository personRepository,
            GroupRepository groupRepository)
        {
            InitializeComponent();

            _personRepository = personRepository;

            _groupRepository = groupRepository;

            PopulateComboBox();

        }

        private void LoadGroups()
        {
            var groups = _groupRepository.GetAll();

            Group.Items.Clear();

            foreach (Group group in groups)
            {
                Group.Items.Add(group.Name);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGroups(); // Load groups into the CheckedListBox when the MainForm loads
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var persons = _personRepository.GetAll();

            // Create an instance of the DataGridViewList form
            DataGridViewList dataGridViewListForm = new DataGridViewList(_groupRepository);

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

                    string selectedGroupId = GetSelectedGroupId();

                    newPerson.PersonsGroup = selectedGroupId;

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

            DataGridViewList dataGridViewListForm = new DataGridViewList(_groupRepository);

            // Populate the DataGridView in the form with the retrieved persons
            dataGridViewListForm.PopulateDataGridView(birthdaysThisMonth);

            // Show the form
            dataGridViewListForm.Show();

        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();

            if (groupForm.ShowDialog() == DialogResult.OK)
            {
                string groupName = groupForm.GroupName;

                Group newGroup = new Group();
                newGroup.Name = groupName;

                try
                {
                    _groupRepository.Add(newGroup);
                    MessageBox.Show("Επιτυχής καταχώρηση!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Λάθος στην καταχώρηση: {ex.Message}");
                }
            }
        }

        private string GetSelectedGroupId()
        {
            if (Group.SelectedItem != null)
            {
                string selectedItem = Group.SelectedItem.ToString();

                Group selectedGroup = _groupRepository.GetByName(selectedItem);

                string selectedGroupId = selectedGroup.Id.ToString();

                return selectedGroupId;

            }
            return null;
        }

        private void btnBirthdaysByGroups_Click(object sender, EventArgs e)
        {
            var persons = _personRepository.GetAll();
            var personsGroupId = GetSelectedGroupId();

            var filteredPersons = persons.Where(p => p.PersonsGroup == personsGroupId).ToList();

            DataGridViewList dataGridViewListForm = new DataGridViewList(_groupRepository);

            dataGridViewListForm.PopulateDataGridView(filteredPersons);

            dataGridViewListForm.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var persons = _personRepository.GetAll();

            // Create an instance of the DataGridViewList form
            DataGridViewUpdate dataGridViewUpdateForm = new DataGridViewUpdate(_groupRepository);

            // Populate the DataGridView in the form with the retrieved persons
            dataGridViewUpdateForm.PopulateDataGridView(persons);

            // Show the form
            dataGridViewUpdateForm.Show();
        }
    }
}