namespace CarListApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            textRegFirst = new TextBox();
            textRegisterLast = new TextBox();
            textRegUser = new TextBox();
            textRegPass = new TextBox();
            labelRegFirst = new Label();
            labelRegLast = new Label();
            labelRegUser = new Label();
            labelRegPass = new Label();
            btnSubRegister = new Button();
            SuspendLayout();
            // 
            // textRegFirst
            // 
            textRegFirst.BackColor = SystemColors.Info;
            textRegFirst.Location = new Point(284, 80);
            textRegFirst.Name = "textRegFirst";
            textRegFirst.Size = new Size(125, 27);
            textRegFirst.TabIndex = 0;
            // 
            // textRegisterLast
            // 
            textRegisterLast.BackColor = SystemColors.Info;
            textRegisterLast.Location = new Point(284, 117);
            textRegisterLast.Name = "textRegisterLast";
            textRegisterLast.Size = new Size(125, 27);
            textRegisterLast.TabIndex = 1;
            // 
            // textRegUser
            // 
            textRegUser.BackColor = SystemColors.Info;
            textRegUser.Location = new Point(284, 157);
            textRegUser.Name = "textRegUser";
            textRegUser.Size = new Size(125, 27);
            textRegUser.TabIndex = 2;
            // 
            // textRegPass
            // 
            textRegPass.BackColor = SystemColors.Info;
            textRegPass.Location = new Point(284, 194);
            textRegPass.Name = "textRegPass";
            textRegPass.Size = new Size(125, 27);
            textRegPass.TabIndex = 3;
            // 
            // labelRegFirst
            // 
            labelRegFirst.AutoSize = true;
            labelRegFirst.BackColor = SystemColors.GradientInactiveCaption;
            labelRegFirst.Location = new Point(190, 83);
            labelRegFirst.Name = "labelRegFirst";
            labelRegFirst.Size = new Size(76, 20);
            labelRegFirst.TabIndex = 4;
            labelRegFirst.Text = "FirstName";
            // 
            // labelRegLast
            // 
            labelRegLast.AutoSize = true;
            labelRegLast.BackColor = SystemColors.GradientInactiveCaption;
            labelRegLast.Location = new Point(190, 124);
            labelRegLast.Name = "labelRegLast";
            labelRegLast.Size = new Size(75, 20);
            labelRegLast.TabIndex = 5;
            labelRegLast.Text = "LastName";
            // 
            // labelRegUser
            // 
            labelRegUser.AutoSize = true;
            labelRegUser.BackColor = SystemColors.GradientInactiveCaption;
            labelRegUser.Location = new Point(190, 160);
            labelRegUser.Name = "labelRegUser";
            labelRegUser.Size = new Size(75, 20);
            labelRegUser.TabIndex = 6;
            labelRegUser.Text = "Username";
            // 
            // labelRegPass
            // 
            labelRegPass.AutoSize = true;
            labelRegPass.BackColor = SystemColors.GradientInactiveCaption;
            labelRegPass.Location = new Point(190, 197);
            labelRegPass.Name = "labelRegPass";
            labelRegPass.Size = new Size(70, 20);
            labelRegPass.TabIndex = 7;
            labelRegPass.Text = "Password";
            // 
            // btnSubRegister
            // 
            btnSubRegister.BackColor = SystemColors.ButtonFace;
            btnSubRegister.BackgroundImage = Properties.Resources.Designer_11_;
            btnSubRegister.Location = new Point(284, 248);
            btnSubRegister.Name = "btnSubRegister";
            btnSubRegister.Size = new Size(94, 29);
            btnSubRegister.TabIndex = 8;
            btnSubRegister.Text = "Register";
            btnSubRegister.UseVisualStyleBackColor = false;
            btnSubRegister.Click += btnSubRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(761, 422);
            Controls.Add(btnSubRegister);
            Controls.Add(labelRegPass);
            Controls.Add(labelRegUser);
            Controls.Add(labelRegLast);
            Controls.Add(labelRegFirst);
            Controls.Add(textRegPass);
            Controls.Add(textRegUser);
            Controls.Add(textRegisterLast);
            Controls.Add(textRegFirst);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textRegFirst;
        private TextBox textRegisterLast;
        private TextBox textRegUser;
        private TextBox textRegPass;
        private Label labelRegFirst;
        private Label labelRegLast;
        private Label labelRegUser;
        private Label labelRegPass;
        private Button btnSubRegister;
    }
}