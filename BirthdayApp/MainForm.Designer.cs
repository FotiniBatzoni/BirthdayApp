using System.Xml.Linq;

namespace BirthdayApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtBoxFirstName = new TextBox();
            lblLastName = new Label();
            txtBoxLastName = new TextBox();
            lblBirthday = new Label();
            bday = new DateTimePicker();
            lblGroup = new Label();
            Group = new CheckedListBox();
            btnAdd = new Button();
            btnList = new Button();
            btnListByMonth = new Button();
            lblSex = new Label();
            cmbBoxSex = new ComboBox();
            btnGroup = new Button();
            btnBirthdaysByGroups = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(48, 50);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(44, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Όνομα";
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.Location = new Point(131, 50);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(299, 23);
            txtBoxFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(48, 97);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(59, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Επώνυμο";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Location = new Point(131, 89);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(299, 23);
            txtBoxLastName.TabIndex = 3;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(48, 140);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(52, 15);
            lblBirthday.TabIndex = 4;
            lblBirthday.Text = "Γενέθλια";
            // 
            // bday
            // 
            bday.Location = new Point(131, 134);
            bday.Name = "bday";
            bday.Size = new Size(299, 23);
            bday.TabIndex = 5;
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Location = new Point(48, 237);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(48, 15);
            lblGroup.TabIndex = 6;
            lblGroup.Text = "Γκρουπ";
            // 
            // Group
            // 
            Group.FormattingEnabled = true;
            Group.Location = new Point(131, 237);
            Group.Name = "Group";
            Group.Size = new Size(299, 166);
            Group.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(537, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Πρόσθεσε Γενέθλια";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(537, 161);
            btnList.Name = "btnList";
            btnList.Size = new Size(140, 44);
            btnList.TabIndex = 9;
            btnList.Text = "Λίστα";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnListByMonth
            // 
            btnListByMonth.Location = new Point(786, 161);
            btnListByMonth.Name = "btnListByMonth";
            btnListByMonth.Size = new Size(140, 44);
            btnListByMonth.TabIndex = 10;
            btnListByMonth.Text = "Γενέθλια του μήνα";
            btnListByMonth.UseVisualStyleBackColor = true;
            btnListByMonth.Click += btnListByMonth_Click;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(48, 188);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(36, 15);
            lblSex.TabIndex = 11;
            lblSex.Text = "Φύλο";
            // 
            // cmbBoxSex
            // 
            cmbBoxSex.FormattingEnabled = true;
            cmbBoxSex.Location = new Point(133, 182);
            cmbBoxSex.Name = "cmbBoxSex";
            cmbBoxSex.Size = new Size(121, 23);
            cmbBoxSex.TabIndex = 12;
            cmbBoxSex.SelectedIndexChanged += cmbBoxSex_SelectedIndexChanged;
            // 
            // btnGroup
            // 
            btnGroup.Location = new Point(537, 258);
            btnGroup.Name = "btnGroup";
            btnGroup.Size = new Size(140, 44);
            btnGroup.TabIndex = 13;
            btnGroup.Text = "Πρόσθεσε Γκρουπ";
            btnGroup.UseVisualStyleBackColor = true;
            btnGroup.Click += btnGroup_Click;
            // 
            // btnBirthdaysByGroups
            // 
            btnBirthdaysByGroups.Location = new Point(786, 258);
            btnBirthdaysByGroups.Name = "btnBirthdaysByGroups";
            btnBirthdaysByGroups.Size = new Size(140, 44);
            btnBirthdaysByGroups.TabIndex = 14;
            btnBirthdaysByGroups.Text = "Γενέθλια ανα Γκρουπ";
            btnBirthdaysByGroups.UseVisualStyleBackColor = true;
            btnBirthdaysByGroups.Click += btnBirthdaysByGroups_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(786, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 44);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Διόρθωση";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnBirthdaysByGroups);
            Controls.Add(btnGroup);
            Controls.Add(cmbBoxSex);
            Controls.Add(lblSex);
            Controls.Add(btnListByMonth);
            Controls.Add(btnList);
            Controls.Add(btnAdd);
            Controls.Add(Group);
            Controls.Add(lblGroup);
            Controls.Add(bday);
            Controls.Add(lblBirthday);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblFirstName);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtBoxFirstName;
        private Label lblLastName;
        private TextBox txtBoxLastName;
        private Label lblBirthday;
        private DateTimePicker bday;
        private Label lblGroup;
        private CheckedListBox Group;
        private Button btnAdd;
        private Button btnList;
        private Button btnListByMonth;
        private Label lblSex;
        private ComboBox cmbBoxSex;
        private Button btnGroup;
        private Button btnBirthdaysByGroups;
        private Button btnUpdate;
    }
}