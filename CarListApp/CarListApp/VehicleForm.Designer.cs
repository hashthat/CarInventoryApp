namespace CarListApp
{
    partial class VehicleForm
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
            comboBoxVehicleType = new ComboBox();
            dataGridView1 = new DataGridView();
            lblVehicleType = new Label();
            textMake = new TextBox();
            textModel = new TextBox();
            textYear = new TextBox();
            textPrice = new TextBox();
            textColor = new TextBox();
            textCondition = new TextBox();
            textTruckType = new TextBox();
            textDrivetrain = new TextBox();
            labelMake = new Label();
            labelModel = new Label();
            labelYear = new Label();
            labelPrice = new Label();
            labelColor = new Label();
            labelCondition = new Label();
            labelType = new Label();
            labelDrivetrain = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxVehicleType
            // 
            comboBoxVehicleType.FormattingEnabled = true;
            comboBoxVehicleType.Location = new Point(178, 93);
            comboBoxVehicleType.Name = "comboBoxVehicleType";
            comboBoxVehicleType.Size = new Size(151, 28);
            comboBoxVehicleType.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(438, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(719, 427);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Location = new Point(68, 93);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(87, 20);
            lblVehicleType.TabIndex = 3;
            lblVehicleType.Text = "VehicleType";
            // 
            // textMake
            // 
            textMake.Location = new Point(178, 141);
            textMake.Name = "textMake";
            textMake.Size = new Size(125, 27);
            textMake.TabIndex = 4;
            // 
            // textModel
            // 
            textModel.Location = new Point(178, 174);
            textModel.Name = "textModel";
            textModel.Size = new Size(125, 27);
            textModel.TabIndex = 5;
            // 
            // textYear
            // 
            textYear.Location = new Point(178, 207);
            textYear.Name = "textYear";
            textYear.Size = new Size(125, 27);
            textYear.TabIndex = 6;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(178, 240);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(125, 27);
            textPrice.TabIndex = 7;
            // 
            // textColor
            // 
            textColor.Location = new Point(178, 273);
            textColor.Name = "textColor";
            textColor.Size = new Size(125, 27);
            textColor.TabIndex = 8;
            // 
            // textCondition
            // 
            textCondition.Location = new Point(178, 306);
            textCondition.Name = "textCondition";
            textCondition.Size = new Size(125, 27);
            textCondition.TabIndex = 9;
            // 
            // textTruckType
            // 
            textTruckType.Location = new Point(178, 339);
            textTruckType.Name = "textTruckType";
            textTruckType.Size = new Size(125, 27);
            textTruckType.TabIndex = 10;
            // 
            // textDrivetrain
            // 
            textDrivetrain.Location = new Point(178, 372);
            textDrivetrain.Name = "textDrivetrain";
            textDrivetrain.Size = new Size(125, 27);
            textDrivetrain.TabIndex = 11;
            // 
            // labelMake
            // 
            labelMake.AutoSize = true;
            labelMake.Location = new Point(105, 141);
            labelMake.Name = "labelMake";
            labelMake.Size = new Size(45, 20);
            labelMake.TabIndex = 12;
            labelMake.Text = "Make";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(100, 174);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(52, 20);
            labelModel.TabIndex = 13;
            labelModel.Text = "Model";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(113, 207);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(37, 20);
            labelYear.TabIndex = 14;
            labelYear.Text = "Year";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(105, 240);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 15;
            labelPrice.Text = "Price";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(105, 280);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(45, 20);
            labelColor.TabIndex = 16;
            labelColor.Text = "Color";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(91, 313);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(74, 20);
            labelCondition.TabIndex = 17;
            labelCondition.Text = "Condition";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(91, 346);
            labelType.Name = "labelType";
            labelType.Size = new Size(74, 20);
            labelType.TabIndex = 18;
            labelType.Text = "TruckType";
            // 
            // labelDrivetrain
            // 
            labelDrivetrain.AutoSize = true;
            labelDrivetrain.Location = new Point(91, 379);
            labelDrivetrain.Name = "labelDrivetrain";
            labelDrivetrain.Size = new Size(74, 20);
            labelDrivetrain.TabIndex = 19;
            labelDrivetrain.Text = "Drivetrain";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(178, 419);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(278, 419);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // VehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Matrix;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1219, 586);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(labelDrivetrain);
            Controls.Add(labelType);
            Controls.Add(labelCondition);
            Controls.Add(labelColor);
            Controls.Add(labelPrice);
            Controls.Add(labelYear);
            Controls.Add(labelModel);
            Controls.Add(labelMake);
            Controls.Add(textDrivetrain);
            Controls.Add(textTruckType);
            Controls.Add(textCondition);
            Controls.Add(textColor);
            Controls.Add(textPrice);
            Controls.Add(textYear);
            Controls.Add(textModel);
            Controls.Add(textMake);
            Controls.Add(lblVehicleType);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxVehicleType);
            Name = "VehicleForm";
            Text = "VehicleForm";
            Load += VehicleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxVehicleType;
        private DataGridView dataGridView1;
        private Label lblVehicleType;
        private TextBox textMake;
        private TextBox textModel;
        private TextBox textYear;
        private TextBox textPrice;
        private TextBox textColor;
        private TextBox textCondition;
        private TextBox textTruckType;
        private TextBox textDrivetrain;
        private Label labelMake;
        private Label labelModel;
        private Label labelYear;
        private Label labelPrice;
        private Label labelColor;
        private Label labelCondition;
        private Label labelType;
        private Label labelDrivetrain;
        private Button btnAdd;
        private Button btnDelete;
    }
}