namespace CarListApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AddCar = new Button();
            ListOfCars = new ListBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            txtColor = new TextBox();
            labMake = new Label();
            Model = new Label();
            labYear = new Label();
            labPrice = new Label();
            labColor = new Label();
            groupBox1 = new GroupBox();
            rioManual = new RadioButton();
            rioAutomatic = new RadioButton();
            label1 = new Label();
            cmbTruckType = new ComboBox();
            cmbDrivetrain = new ComboBox();
            chkTruckSUV = new CheckBox();
            grpVehicleType = new GroupBox();
            rdoSUV = new RadioButton();
            rdoTruck = new RadioButton();
            cmbCondition = new ComboBox();
            lblTruckType = new Label();
            lblDrivetrain = new Label();
            lblCondition = new Label();
            ShowCarList = new Button();
            ShowTruckList = new Button();
            ShowSUV_List = new Button();
            label2 = new Label();
            Current_Inventory = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            grpVehicleType.SuspendLayout();
            Current_Inventory.SuspendLayout();
            SuspendLayout();
            // 
            // AddCar
            // 
            AddCar.BackColor = SystemColors.Info;
            AddCar.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddCar.Location = new Point(157, 474);
            AddCar.Name = "AddCar";
            AddCar.Size = new Size(94, 29);
            AddCar.TabIndex = 0;
            AddCar.Text = "Submit";
            AddCar.UseVisualStyleBackColor = false;
            AddCar.Click += AddCar_Click;
            // 
            // ListOfCars
            // 
            ListOfCars.BackColor = SystemColors.InactiveCaption;
            ListOfCars.FormattingEnabled = true;
            ListOfCars.Location = new Point(479, 313);
            ListOfCars.Name = "ListOfCars";
            ListOfCars.Size = new Size(580, 284);
            ListOfCars.TabIndex = 1;
            ListOfCars.SelectedIndexChanged += ListOfCars_SelectedIndexChanged;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(118, 135);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(118, 168);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(118, 212);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(118, 248);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 2;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(118, 281);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(125, 27);
            txtColor.TabIndex = 2;
            // 
            // labMake
            // 
            labMake.AutoSize = true;
            labMake.BackColor = SystemColors.Info;
            labMake.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labMake.Location = new Point(44, 138);
            labMake.Name = "labMake";
            labMake.Size = new Size(56, 22);
            labMake.TabIndex = 3;
            labMake.Text = "Make";
            labMake.Click += labMake_Click;
            // 
            // Model
            // 
            Model.AutoSize = true;
            Model.BackColor = SystemColors.Info;
            Model.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Model.Location = new Point(44, 175);
            Model.Name = "Model";
            Model.Size = new Size(59, 22);
            Model.TabIndex = 3;
            Model.Text = "Model";
            // 
            // labYear
            // 
            labYear.AutoSize = true;
            labYear.BackColor = SystemColors.Info;
            labYear.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labYear.Location = new Point(51, 215);
            labYear.Name = "labYear";
            labYear.Size = new Size(48, 22);
            labYear.TabIndex = 3;
            labYear.Text = "Year";
            // 
            // labPrice
            // 
            labPrice.AutoSize = true;
            labPrice.BackColor = SystemColors.Info;
            labPrice.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labPrice.Location = new Point(51, 248);
            labPrice.Name = "labPrice";
            labPrice.Size = new Size(51, 22);
            labPrice.TabIndex = 3;
            labPrice.Text = "Price";
            // 
            // labColor
            // 
            labColor.AutoSize = true;
            labColor.BackColor = SystemColors.Info;
            labColor.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labColor.Location = new Point(51, 281);
            labColor.Name = "labColor";
            labColor.Size = new Size(52, 22);
            labColor.TabIndex = 3;
            labColor.Text = "Color";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(rioManual);
            groupBox1.Controls.Add(rioAutomatic);
            groupBox1.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 357);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 111);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transmission";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // rioManual
            // 
            rioManual.AutoSize = true;
            rioManual.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rioManual.Location = new Point(82, 56);
            rioManual.Name = "rioManual";
            rioManual.Size = new Size(81, 23);
            rioManual.TabIndex = 0;
            rioManual.TabStop = true;
            rioManual.Text = "Manual";
            rioManual.UseVisualStyleBackColor = true;
            rioManual.CheckedChanged += rioManual_CheckedChanged;
            // 
            // rioAutomatic
            // 
            rioAutomatic.AutoSize = true;
            rioAutomatic.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rioAutomatic.Location = new Point(82, 26);
            rioAutomatic.Name = "rioAutomatic";
            rioAutomatic.Size = new Size(103, 23);
            rioAutomatic.TabIndex = 0;
            rioAutomatic.TabStop = true;
            rioAutomatic.Text = "Automatic";
            rioAutomatic.UseVisualStyleBackColor = true;
            rioAutomatic.CheckedChanged += rioAutomatic_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(479, 288);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 6;
            label1.Text = "New Inventory";
            // 
            // cmbTruckType
            // 
            cmbTruckType.FormattingEnabled = true;
            cmbTruckType.Location = new Point(249, 162);
            cmbTruckType.Name = "cmbTruckType";
            cmbTruckType.Size = new Size(151, 28);
            cmbTruckType.TabIndex = 7;
            // 
            // cmbDrivetrain
            // 
            cmbDrivetrain.FormattingEnabled = true;
            cmbDrivetrain.Location = new Point(249, 224);
            cmbDrivetrain.Name = "cmbDrivetrain";
            cmbDrivetrain.Size = new Size(151, 28);
            cmbDrivetrain.TabIndex = 7;
            cmbDrivetrain.SelectedIndexChanged += cmbDrivetrain_SelectedIndexChanged;
            // 
            // chkTruckSUV
            // 
            chkTruckSUV.AutoSize = true;
            chkTruckSUV.Location = new Point(157, 314);
            chkTruckSUV.Name = "chkTruckSUV";
            chkTruckSUV.Size = new Size(170, 24);
            chkTruckSUV.TabIndex = 8;
            chkTruckSUV.Text = "This is a Truck or SUV";
            chkTruckSUV.UseVisualStyleBackColor = true;
            chkTruckSUV.CheckedChanged += chkTruckSUV_CheckedChanged_1;
            // 
            // grpVehicleType
            // 
            grpVehicleType.BackColor = SystemColors.ActiveCaption;
            grpVehicleType.Controls.Add(rdoSUV);
            grpVehicleType.Controls.Add(rdoTruck);
            grpVehicleType.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpVehicleType.Location = new Point(249, 357);
            grpVehicleType.Name = "grpVehicleType";
            grpVehicleType.Size = new Size(204, 111);
            grpVehicleType.TabIndex = 9;
            grpVehicleType.TabStop = false;
            grpVehicleType.Text = "Vehicle Type";
            grpVehicleType.Enter += grpVehicleType_Enter;
            // 
            // rdoSUV
            // 
            rdoSUV.AutoSize = true;
            rdoSUV.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoSUV.Location = new Point(6, 56);
            rdoSUV.Name = "rdoSUV";
            rdoSUV.Size = new Size(59, 23);
            rdoSUV.TabIndex = 0;
            rdoSUV.TabStop = true;
            rdoSUV.Text = "SUV";
            rdoSUV.UseVisualStyleBackColor = true;
            rdoSUV.CheckedChanged += rioAutomatic_CheckedChanged;
            // 
            // rdoTruck
            // 
            rdoTruck.AutoSize = true;
            rdoTruck.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoTruck.Location = new Point(6, 26);
            rdoTruck.Name = "rdoTruck";
            rdoTruck.Size = new Size(72, 23);
            rdoTruck.TabIndex = 0;
            rdoTruck.TabStop = true;
            rdoTruck.Text = "Truck";
            rdoTruck.UseVisualStyleBackColor = true;
            rdoTruck.CheckedChanged += rioAutomatic_CheckedChanged;
            // 
            // cmbCondition
            // 
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(249, 278);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(151, 28);
            cmbCondition.TabIndex = 7;
            // 
            // lblTruckType
            // 
            lblTruckType.AutoSize = true;
            lblTruckType.BackColor = SystemColors.Info;
            lblTruckType.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTruckType.Location = new Point(250, 135);
            lblTruckType.Name = "lblTruckType";
            lblTruckType.Size = new Size(102, 22);
            lblTruckType.TabIndex = 10;
            lblTruckType.Text = "TruckType";
            lblTruckType.Click += lblTruckType_Click;
            // 
            // lblDrivetrain
            // 
            lblDrivetrain.AutoSize = true;
            lblDrivetrain.BackColor = SystemColors.Info;
            lblDrivetrain.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrivetrain.Location = new Point(250, 199);
            lblDrivetrain.Name = "lblDrivetrain";
            lblDrivetrain.Size = new Size(99, 22);
            lblDrivetrain.TabIndex = 10;
            lblDrivetrain.Text = "Drivetrain";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.BackColor = SystemColors.Info;
            lblCondition.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCondition.Location = new Point(250, 255);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(87, 22);
            lblCondition.TabIndex = 10;
            lblCondition.Text = "Condition";
            // 
            // ShowCarList
            // 
            ShowCarList.BackColor = SystemColors.Info;
            ShowCarList.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowCarList.Location = new Point(125, 62);
            ShowCarList.Name = "ShowCarList";
            ShowCarList.Size = new Size(94, 29);
            ShowCarList.TabIndex = 11;
            ShowCarList.Text = "CarShow";
            ShowCarList.UseVisualStyleBackColor = false;
            ShowCarList.Click += ShowCarList_Click;
            // 
            // ShowTruckList
            // 
            ShowTruckList.BackColor = SystemColors.Info;
            ShowTruckList.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowTruckList.Location = new Point(125, 97);
            ShowTruckList.Name = "ShowTruckList";
            ShowTruckList.Size = new Size(94, 29);
            ShowTruckList.TabIndex = 12;
            ShowTruckList.Text = "TruckShow";
            ShowTruckList.UseVisualStyleBackColor = false;
            ShowTruckList.Click += ShowTruckList_Click;
            // 
            // ShowSUV_List
            // 
            ShowSUV_List.BackColor = SystemColors.Info;
            ShowSUV_List.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowSUV_List.Location = new Point(125, 132);
            ShowSUV_List.Name = "ShowSUV_List";
            ShowSUV_List.Size = new Size(94, 29);
            ShowSUV_List.TabIndex = 13;
            ShowSUV_List.Text = "SUV_Show";
            ShowSUV_List.UseVisualStyleBackColor = false;
            ShowSUV_List.Click += ShowSUV_List_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 193);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 14;
            // 
            // Current_Inventory
            // 
            Current_Inventory.BackColor = SystemColors.GradientInactiveCaption;
            Current_Inventory.Controls.Add(ShowSUV_List);
            Current_Inventory.Controls.Add(ShowTruckList);
            Current_Inventory.Controls.Add(ShowCarList);
            Current_Inventory.Font = new Font("Ink Free", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Current_Inventory.Location = new Point(479, 91);
            Current_Inventory.Name = "Current_Inventory";
            Current_Inventory.Size = new Size(250, 179);
            Current_Inventory.TabIndex = 15;
            Current_Inventory.TabStop = false;
            Current_Inventory.Text = "Click on each button to view the current inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(477, 60);
            label3.Name = "label3";
            label3.Size = new Size(168, 22);
            label3.TabIndex = 16;
            label3.Text = "Current Inventory";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1242, 723);
            Controls.Add(label3);
            Controls.Add(Current_Inventory);
            Controls.Add(label2);
            Controls.Add(lblCondition);
            Controls.Add(lblDrivetrain);
            Controls.Add(lblTruckType);
            Controls.Add(grpVehicleType);
            Controls.Add(chkTruckSUV);
            Controls.Add(cmbCondition);
            Controls.Add(cmbDrivetrain);
            Controls.Add(cmbTruckType);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(labColor);
            Controls.Add(labPrice);
            Controls.Add(labYear);
            Controls.Add(Model);
            Controls.Add(labMake);
            Controls.Add(txtColor);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(ListOfCars);
            Controls.Add(AddCar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpVehicleType.ResumeLayout(false);
            grpVehicleType.PerformLayout();
            Current_Inventory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddCar;
        private ListBox ListOfCars;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtPrice;
        private TextBox txtColor;
        private Label labMake;
        private Label Model;
        private Label labYear;
        private Label labPrice;
        private Label labColor;
        private GroupBox groupBox1;
        private RadioButton rioAutomatic;
        private RadioButton rioManual;
        private Label label1;
        private ComboBox cmbTruckType;
        private ComboBox cmbDrivetrain;
        private CheckBox chkTruckSUV;
        private GroupBox grpVehicleType;
        private RadioButton rdoTruck;
        private ComboBox cmbCondition;
        private Label lblTruckType;
        private Label lblDrivetrain;
        private Label lblCondition;
        private RadioButton rdoSUV;
        private Button ShowCarList;
        private Button ShowTruckList;
        private Button ShowSUV_List;
        private Label label2;
        private GroupBox Current_Inventory;
        private Label label3;
    }
}
