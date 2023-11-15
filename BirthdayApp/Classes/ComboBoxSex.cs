using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Classes
{
    public class ComboBoxSex
    {
        public string DisplayText { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return DisplayText; 
        }


    }
}
