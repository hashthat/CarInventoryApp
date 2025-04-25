namespace CarListApp
{
    partial class CarShow
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
            vehicleDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).BeginInit();
            SuspendLayout();
            // 
            // vehicleDataGrid
            // 
            vehicleDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicleDataGrid.Location = new Point(3, 4);
            vehicleDataGrid.Name = "vehicleDataGrid";
            vehicleDataGrid.RowHeadersWidth = 51;
            vehicleDataGrid.Size = new Size(785, 443);
            vehicleDataGrid.TabIndex = 0;
            vehicleDataGrid.CellContentClick += vehicleData_CellContentClick;
            // 
            // CarShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vehicleDataGrid);
            Name = "CarShow";
            Text = "CarShow";
            ((System.ComponentModel.ISupportInitialize)vehicleDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vehicleDataGrid;
    }
}