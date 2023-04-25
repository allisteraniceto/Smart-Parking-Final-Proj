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
            System.Windows.Forms.Panel panel1;
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.NavajoWhite;
            panel1.Controls.Add(this.carTextBox);
            panel1.Controls.Add(this.button3);
            panel1.Controls.Add(this.button2);
            panel1.Controls.Add(this.button1);
            panel1.Controls.Add(this.loadBtn);
            panel1.Location = new System.Drawing.Point(732, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(301, 737);
            panel1.TabIndex = 4;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // carTextBox
            // 
            this.carTextBox.Location = new System.Drawing.Point(54, 310);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(100, 22);
            this.carTextBox.TabIndex = 5;
            this.carTextBox.TextChanged += new System.EventHandler(this.carsBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button3.Location = new System.Drawing.Point(178, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove Car";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.removeCarButton_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Location = new System.Drawing.Point(178, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Car";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.addCarButton_Click);
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
            // ParkingLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1067, 805);
            this.Controls.Add(panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParkingLot";
            this.Text = "Engine";
            this.Load += new System.EventHandler(this.ParkingLot_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox carTextBox;
    }
}