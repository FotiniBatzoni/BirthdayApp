using BirthdayApp.Classes;
using BirthdayApp.Repository;
using BirthdayApp.Utilities;
using System.ComponentModel;
using System.Data;

namespace BirthdayApp
{
    public partial class DataGridViewUpdate : Form
    {
        private bool isNameColumnSortedAscending = false;
        private BindingList<PersonInfo> bindingList;
        private readonly GroupRepository _groupRepository;

        public DataGridViewUpdate(GroupRepository groupRepository)
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
                    Γκρουπ = group != null ? group.Name : "Άγνωστο",
                    Φύλο = p.Sex != null ? p.Sex : "Άγνωστο",
                };
            }).ToList();

            bindingList = new BindingList<PersonInfo>(transformedData);
            UpdateDataGridView.DataSource = bindingList;

        }
    }
}
