namespace BirthdayApp
{
    partial class DataGridViewList
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
            ListDataGridView = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ListDataGridView
            // 
            ListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListDataGridView.Location = new Point(2, 2);
            ListDataGridView.Name = "ListDataGridView";
            ListDataGridView.RowTemplate.Height = 25;
            ListDataGridView.Size = new Size(770, 404);
            ListDataGridView.TabIndex = 0;
            ListDataGridView.ColumnHeaderMouseClick += ListDataGridView_ColumnHeaderMouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(227, 121);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // DataGridViewList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 450);
            Controls.Add(button1);
            Controls.Add(ListDataGridView);
            Text = "DataGridViewList";
            ((System.ComponentModel.ISupportInitialize)ListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListDataGridView;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn DaysForBirthday;
        private Button button1;
    }
}