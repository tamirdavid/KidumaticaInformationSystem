namespace Kidumatica_Update
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ThirdPlaceTextBox = new System.Windows.Forms.TextBox();
            this.SecondPlaceTextBox = new System.Windows.Forms.TextBox();
            this.FirstPlaceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstPlace = new System.Windows.Forms.Label();
            this.SecondPlace = new System.Windows.Forms.Label();
            this.ThirdPlace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.White;
            this.UserNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UserNameLabel.Location = new System.Drawing.Point(31, 205);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(75, 24);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User ID";
            this.UserNameLabel.Click += new System.EventHandler(this.UserNameLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PasswordLabel.Location = new System.Drawing.Point(31, 247);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(85, 24);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UserNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.Location = new System.Drawing.Point(147, 205);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(100, 31);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(147, 249);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 31);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25743F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Red;
            this.SubmitButton.Location = new System.Drawing.Point(77, 306);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(117, 70);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Login";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 22.09901F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(638, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 51);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Kidumatica Note Board";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(592, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(439, 478);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ThirdPlaceTextBox
            // 
            this.ThirdPlaceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ThirdPlaceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPlaceTextBox.Location = new System.Drawing.Point(323, 320);
            this.ThirdPlaceTextBox.Name = "ThirdPlaceTextBox";
            this.ThirdPlaceTextBox.Size = new System.Drawing.Size(240, 27);
            this.ThirdPlaceTextBox.TabIndex = 7;
            this.ThirdPlaceTextBox.TextChanged += new System.EventHandler(this.ThirdPlaceTextBox_TextChanged);
            // 
            // SecondPlaceTextBox
            // 
            this.SecondPlaceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SecondPlaceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlaceTextBox.Location = new System.Drawing.Point(323, 249);
            this.SecondPlaceTextBox.Name = "SecondPlaceTextBox";
            this.SecondPlaceTextBox.Size = new System.Drawing.Size(240, 27);
            this.SecondPlaceTextBox.TabIndex = 8;
            this.SecondPlaceTextBox.TextChanged += new System.EventHandler(this.SecondPlaceTextBox_TextChanged);
            // 
            // FirstPlaceTextBox
            // 
            this.FirstPlaceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FirstPlaceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlaceTextBox.Location = new System.Drawing.Point(323, 175);
            this.FirstPlaceTextBox.Name = "FirstPlaceTextBox";
            this.FirstPlaceTextBox.Size = new System.Drawing.Size(240, 27);
            this.FirstPlaceTextBox.TabIndex = 9;
            this.FirstPlaceTextBox.TextChanged += new System.EventHandler(this.FirstPlaceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.69307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Top Rating Students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstPlace
            // 
            this.FirstPlace.AutoSize = true;
            this.FirstPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FirstPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FirstPlace.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlace.Location = new System.Drawing.Point(329, 146);
            this.FirstPlace.Name = "FirstPlace";
            this.FirstPlace.Size = new System.Drawing.Size(84, 19);
            this.FirstPlace.TabIndex = 11;
            this.FirstPlace.Text = "First Place:";
            // 
            // SecondPlace
            // 
            this.SecondPlace.AutoSize = true;
            this.SecondPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SecondPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SecondPlace.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlace.Location = new System.Drawing.Point(329, 221);
            this.SecondPlace.Name = "SecondPlace";
            this.SecondPlace.Size = new System.Drawing.Size(97, 19);
            this.SecondPlace.TabIndex = 12;
            this.SecondPlace.Text = "Second Place:";
            this.SecondPlace.Click += new System.EventHandler(this.label3_Click);
            // 
            // ThirdPlace
            // 
            this.ThirdPlace.AutoSize = true;
            this.ThirdPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ThirdPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThirdPlace.Font = new System.Drawing.Font("Comic Sans MS", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPlace.Location = new System.Drawing.Point(329, 293);
            this.ThirdPlace.Name = "ThirdPlace";
            this.ThirdPlace.Size = new System.Drawing.Size(86, 19);
            this.ThirdPlace.TabIndex = 13;
            this.ThirdPlace.Text = "Third Place:";
            this.ThirdPlace.Click += new System.EventHandler(this.label4_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 635);
            this.Controls.Add(this.ThirdPlace);
            this.Controls.Add(this.SecondPlace);
            this.Controls.Add(this.FirstPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstPlaceTextBox);
            this.Controls.Add(this.SecondPlaceTextBox);
            this.Controls.Add(this.ThirdPlaceTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.DoubleBuffered = true;
            this.Name = "HomePage";
            this.Text = "Kidumatica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox ThirdPlaceTextBox;
        private System.Windows.Forms.TextBox SecondPlaceTextBox;
        private System.Windows.Forms.TextBox FirstPlaceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstPlace;
        private System.Windows.Forms.Label SecondPlace;
        private System.Windows.Forms.Label ThirdPlace;
    }
}

