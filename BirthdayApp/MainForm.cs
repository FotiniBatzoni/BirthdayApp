using BirthdayApp.Classes;

namespace BirthdayApp
{
    public partial class MainForm : Form
    {
        private MongoDBContext _mongoDBContext;
        public MainForm()
        {
            InitializeComponent();

            _mongoDBContext = new MongoDBContext("mongodb://localhost:27017", "BirthdayApp");
        }
    }
}