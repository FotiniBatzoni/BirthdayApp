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
    }
}
