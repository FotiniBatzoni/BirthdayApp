using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Classes
{
    public class Person
    {
        private string Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private DateOnly Birthday { get; set; }
    }
}
