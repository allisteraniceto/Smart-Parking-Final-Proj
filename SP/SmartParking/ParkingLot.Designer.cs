namespace SmartParking
{
    partial class ParkingLot
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
            System.Windows.Forms.Panel s;
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.removeCarButton = new System.Windows.Forms.Button();
            this.addCarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            s = new System.Windows.Forms.Panel();
            s.SuspendLayout();
            this.SuspendLayout();
            // 
            // s
            // 
            s.Anchor = System.Windows.Forms.AnchorStyles.Right;
            s.BackColor = System.Drawing.Color.NavajoWhite;
            s.Controls.Add(this.label1);
            s.Controls.Add(this.welcomeUserLabel);
            s.Controls.Add(this.passwordLabel);
            s.Controls.Add(this.usernameLabel);
            s.Controls.Add(this.passwordTextBox);
            s.Controls.Add(this.removeUserButton);
            s.Controls.Add(this.addUserButton);
            s.Controls.Add(this.userTextBox);
            s.Controls.Add(this.userLabel);
            s.Controls.Add(this.carLabel);
            s.Controls.Add(this.carTextBox);
            s.Controls.Add(this.removeCarButton);
            s.Controls.Add(this.addCarButton);
            s.Controls.Add(this.button1);
            s.Controls.Add(this.loadBtn);
            s.Location = new System.Drawing.Point(732, 38);
            s.Name = "s";
            s.Size = new System.Drawing.Size(301, 737);
            s.TabIndex = 4;
            s.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(45, 521);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 17);
            this.passwordLabel.TabIndex = 13;
            this.passwordLabel.Text = "password";
            this.passwordLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(45, 476);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 17);
            this.usernameLabel.TabIndex = 12;
            this.usernameLabel.Text = "username";
            this.usernameLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(42, 541);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(220, 22);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // removeUserButton
            // 
            this.removeUserButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.removeUserButton.Location = new System.Drawing.Point(157, 582);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(103, 32);
            this.removeUserButton.TabIndex = 10;
            this.removeUserButton.Text = "Remove";
            this.removeUserButton.UseVisualStyleBackColor = false;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.addUserButton.Location = new System.Drawing.Point(48, 582);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(103, 32);
            this.addUserButton.TabIndex = 9;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUser_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(42, 496);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(220, 22);
            this.userTextBox.TabIndex = 8;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userLabel.Location = new System.Drawing.Point(82, 444);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(145, 20);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "Add/Remove User";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.carLabel.Location = new System.Drawing.Point(82, 260);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(136, 20);
            this.carLabel.TabIndex = 6;
            this.carLabel.Text = "Add/Remove Car";
            this.carLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(42, 301);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(220, 22);
            this.carTextBox.TabIndex = 5;
            this.carTextBox.TextChanged += new System.EventHandler(this.carsBox1_TextChanged);
            // 
            // removeCarButton
            // 
            this.removeCarButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.removeCarButton.Location = new System.Drawing.Point(162, 342);
            this.removeCarButton.Name = "removeCarButton";
            this.removeCarButton.Size = new System.Drawing.Size(103, 32);
            this.removeCarButton.TabIndex = 4;
            this.removeCarButton.Text = "Remove";
            this.removeCarButton.UseVisualStyleBackColor = false;
            this.removeCarButton.Click += new System.EventHandler(this.removeCarButton_Click_1);
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.addCarButton.Location = new System.Drawing.Point(42, 342);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(103, 32);
            this.addCarButton.TabIndex = 3;
            this.addCarButton.Text = "Add";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "DrawSquare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DrawSlots);
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.loadBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loadBtn.Location = new System.Drawing.Point(31, 18);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(114, 30);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Read Data";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadData);
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUserLabel.Location = new System.Drawing.Point(53, 130);
            this.welcomeUserLabel.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(207, 64);
            this.welcomeUserLabel.TabIndex = 14;
            this.welcomeUserLabel.Text = "user";
            this.welcomeUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeUserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "WELCOME!";
            // 
            // ParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1067, 805);
            this.Controls.Add(s);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParkingLot";
            this.Text = "Engine";
            this.Load += new System.EventHandler(this.ParkingLot_Load);
            s.ResumeLayout(false);
            s.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button removeCarButton;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.Label label1;
    }
}