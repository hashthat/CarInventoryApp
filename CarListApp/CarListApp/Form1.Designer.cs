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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddCar
            // 
            AddCar.BackColor = SystemColors.Info;
            AddCar.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddCar.Location = new Point(195, 320);
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
            ListOfCars.Location = new Point(320, 65);
            ListOfCars.Name = "ListOfCars";
            ListOfCars.Size = new Size(394, 284);
            ListOfCars.TabIndex = 1;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(164, 35);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(164, 68);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(164, 101);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(164, 137);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 2;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(164, 170);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(125, 27);
            txtColor.TabIndex = 2;
            // 
            // labMake
            // 
            labMake.AutoSize = true;
            labMake.BackColor = SystemColors.Info;
            labMake.Font = new Font("Ink Free", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labMake.Location = new Point(90, 38);
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
            Model.Location = new Point(90, 75);
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
            labYear.Location = new Point(97, 104);
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
            labPrice.Location = new Point(97, 137);
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
            labColor.Location = new Point(97, 170);
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
            groupBox1.Location = new Point(82, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 111);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transmission";
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
            label1.Location = new Point(320, 37);
            label1.Name = "label1";
            label1.Size = new Size(199, 22);
            label1.TabIndex = 6;
            label1.Text = "List of Available Cars";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(885, 540);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
