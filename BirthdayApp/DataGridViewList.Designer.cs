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
            ((System.ComponentModel.ISupportInitialize)ListDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ListDataGridView
            // 
            ListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListDataGridView.Location = new Point(1, 1);
            ListDataGridView.Name = "ListDataGridView";
            ListDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ListDataGridView.RowTemplate.Height = 25;
            ListDataGridView.Size = new Size(893, 437);
            ListDataGridView.TabIndex = 0;
            ListDataGridView.ColumnHeaderMouseClick += ListDataGridView_ColumnHeaderMouseClick;
            // 
            // DataGridViewList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(924, 450);
            Controls.Add(ListDataGridView);
            MinimizeBox = false;
            Name = "DataGridViewList";
            Text = "DataGridViewList";
            ((System.ComponentModel.ISupportInitialize)ListDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListDataGridView;
        private DataGridViewTextBoxColumn NameL;
        private DataGridViewTextBoxColumn BirthdayL;
        private DataGridViewTextBoxColumn AgeL;
        private DataGridViewTextBoxColumn DaysForBirthdayL;
    }
}