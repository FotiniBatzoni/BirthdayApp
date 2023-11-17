using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Utilities
{
    public static class ValidationOf
    {
        public static bool TextBox(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show(text, "Name is required.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
