using BirthdayApp.Classes;
using BirthdayApp.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace BirthdayApp
{
    public partial class MainForm : Form
    {
        private readonly MongoDBContext _mongoDBContext;

        private readonly PersonRepository _personRepository;

        public MainForm(MongoDBContext mongoDBContext,PersonRepository personRepository)
        {
            InitializeComponent();

            _mongoDBContext = new MongoDBContext("mongodb://localhost:27017", "BirthdayApp");

            _personRepository = personRepository;


        }


    }
}