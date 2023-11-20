using BirthdayApp.Classes;
using BirthdayApp.Interfaces;
using BirthdayApp.Repository;

namespace BirthdayApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create instances of MongoDBContext and PersonRepository
            var mongoDBContext = new MongoDBContext("mongodb://localhost:27017", "BirthdayApp");
            var personRepository = new PersonRepository(mongoDBContext);
            var groupRepository = new GroupRepository(mongoDBContext);

            // Pass these instances to the MainForm constructor
            Application.Run(new MainForm(mongoDBContext, personRepository, groupRepository));
        }
    }
}