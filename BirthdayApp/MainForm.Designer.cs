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
            dateTimePicker1 = new DateTimePicker();
            lblGroup = new Label();
            Group = new CheckedListBox();
            btnAdd = new Button();
            btnList = new Button();
            btnListByMonth = new Button();
            lblSex = new Label();
            cmbBoxSex = new ComboBox();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(131, 134);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 23);
            dateTimePicker1.TabIndex = 5;
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
            Group.Size = new Size(299, 94);
            Group.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(552, 237);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Πρόσθεσε";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.Location = new Point(552, 50);
            btnList.Name = "btnList";
            btnList.Size = new Size(140, 44);
            btnList.TabIndex = 9;
            btnList.Text = "Λίστα";
            btnList.UseVisualStyleBackColor = true;
            // 
            // btnListByMonth
            // 
            btnListByMonth.Location = new Point(552, 140);
            btnListByMonth.Name = "btnListByMonth";
            btnListByMonth.Size = new Size(140, 44);
            btnListByMonth.TabIndex = 10;
            btnListByMonth.Text = "Γενέθλια του μήνα";
            btnListByMonth.UseVisualStyleBackColor = true;
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
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBoxSex);
            Controls.Add(lblSex);
            Controls.Add(btnListByMonth);
            Controls.Add(btnList);
            Controls.Add(btnAdd);
            Controls.Add(Group);
            Controls.Add(lblGroup);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblBirthday);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblFirstName);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtBoxFirstName;
        private Label lblLastName;
        private TextBox txtBoxLastName;
        private Label lblBirthday;
        private DateTimePicker dateTimePicker1;
        private Label lblGroup;
        private CheckedListBox Group;
        private Button btnAdd;
        private Button btnList;
        private Button btnListByMonth;
        private Label lblSex;
        private ComboBox cmbBoxSex;
    }
}