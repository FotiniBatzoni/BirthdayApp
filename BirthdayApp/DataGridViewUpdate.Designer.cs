namespace BirthdayApp
{
    partial class DataGridViewUpdate
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
            UpdateDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UpdateDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UpdateDataGridView
            // 
            UpdateDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            UpdateDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpdateDataGridView.Location = new Point(0, 0);
            UpdateDataGridView.Name = "UpdateDataGridView";
            UpdateDataGridView.Size = new Size(788, 438);
            UpdateDataGridView.TabIndex = 0;
            // 
            // DataGridViewUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateDataGridView);
            Name = "DataGridViewUpdate";
            Text = "DataGridViewUpdate";
            ((System.ComponentModel.ISupportInitialize)UpdateDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView UpdateDataGridView;
        private DataGridViewTextBoxColumn NameU;
        private DataGridViewTextBoxColumn BirthdayU;
        private DataGridViewTextBoxColumn AgeU;
        private DataGridViewTextBoxColumn DaysForBirthdayU;
        private DataGridViewTextBoxColumn SexU;
    }
}