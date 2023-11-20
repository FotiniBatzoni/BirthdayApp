namespace BirthdayApp
{
    partial class GroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGroupName = new Label();
            txtBoxGroupName = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Location = new Point(113, 57);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(44, 15);
            lblGroupName.TabIndex = 0;
            lblGroupName.Text = "Όνομα";
            // 
            // txtBoxGroupName
            // 
            txtBoxGroupName.Location = new Point(200, 49);
            txtBoxGroupName.Name = "txtBoxGroupName";
            txtBoxGroupName.Size = new Size(294, 23);
            txtBoxGroupName.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(113, 125);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(155, 47);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(355, 125);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 47);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // GroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtBoxGroupName);
            Controls.Add(lblGroupName);
            Name = "GroupForm";
            Text = "Group Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGroupName;
        private TextBox txtBoxGroupName;
        private Button btnOK;
        private Button btnCancel;
    }
}