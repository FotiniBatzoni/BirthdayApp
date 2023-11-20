using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayApp
{
    public partial class GroupForm : Form
    {
        public string GroupName { get; private set; }

        public GroupForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Retrieve the group name from the textbox and set it to GroupName property
            GroupName = txtBoxGroupName.Text;

            // Close the form
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
