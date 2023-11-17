using BirthdayApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BirthdayApp.Utilities
{
    public static class Utilities
    {

        public static void ClearInputFields(TextBox textBox1, TextBox textBox2, DateTimePicker textBox3, ComboBox comboBox)
        {
            // Clear input fields or update UI as needed
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox.Text = "";
        }

        public static Person CreateNewPerson(TextBox textBox1, TextBox textBox2, DateTimePicker textBox3, ComboBox comboBox)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string birthday = textBox3.Text;
            string sex = comboBox.Text;

            Person newPerson = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Birthday = birthday,
                Sex = sex
            };

            return newPerson;
        }
    }
}
