namespace MathGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.answerTextbox = new System.Windows.Forms.TextBox();
            this.additionSignLabel = new System.Windows.Forms.Label();
            this.equalsignLabel = new System.Windows.Forms.Label();
            this.roundsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.highestNumTextbox = new System.Windows.Forms.TextBox();
            this.roundsTextbox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.mathGroupbox = new System.Windows.Forms.GroupBox();
            this.testGroupbox = new System.Windows.Forms.GroupBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.mathGroupbox.SuspendLayout();
            this.testGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(197, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addition Game!";
            // 
            // num1Label
            // 
            this.num1Label.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num1Label.Location = new System.Drawing.Point(22, 33);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(107, 64);
            this.num1Label.TabIndex = 1;
            this.num1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2Label
            // 
            this.num2Label.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num2Label.Location = new System.Drawing.Point(208, 32);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(102, 64);
            this.num2Label.TabIndex = 2;
            this.num2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextbox
            // 
            this.answerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextbox.Location = new System.Drawing.Point(394, 33);
            this.answerTextbox.MaximumSize = new System.Drawing.Size(87, 65);
            this.answerTextbox.MinimumSize = new System.Drawing.Size(87, 65);
            this.answerTextbox.Name = "answerTextbox";
            this.answerTextbox.Size = new System.Drawing.Size(87, 67);
            this.answerTextbox.TabIndex = 3;
            this.answerTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // additionSignLabel
            // 
            this.additionSignLabel.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionSignLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.additionSignLabel.Location = new System.Drawing.Point(115, 33);
            this.additionSignLabel.Name = "additionSignLabel";
            this.additionSignLabel.Size = new System.Drawing.Size(87, 65);
            this.additionSignLabel.TabIndex = 4;
            this.additionSignLabel.Text = "+";
            this.additionSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsignLabel
            // 
            this.equalsignLabel.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsignLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.equalsignLabel.Location = new System.Drawing.Point(301, 32);
            this.equalsignLabel.Name = "equalsignLabel";
            this.equalsignLabel.Size = new System.Drawing.Size(87, 65);
            this.equalsignLabel.TabIndex = 5;
            this.equalsignLabel.Text = "=";
            this.equalsignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundsLabel
            // 
            this.roundsLabel.AutoSize = true;
            this.roundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsLabel.Location = new System.Drawing.Point(22, 107);
            this.roundsLabel.Name = "roundsLabel";
            this.roundsLabel.Size = new System.Drawing.Size(163, 24);
            this.roundsLabel.TabIndex = 6;
            this.roundsLabel.Text = "Number of rounds";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(37, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(148, 24);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Highest Number";
            // 
            // highestNumTextbox
            // 
            this.highestNumTextbox.Location = new System.Drawing.Point(53, 62);
            this.highestNumTextbox.Name = "highestNumTextbox";
            this.highestNumTextbox.Size = new System.Drawing.Size(100, 26);
            this.highestNumTextbox.TabIndex = 8;
            // 
            // roundsTextbox
            // 
            this.roundsTextbox.Location = new System.Drawing.Point(53, 131);
            this.roundsTextbox.Name = "roundsTextbox";
            this.roundsTextbox.Size = new System.Drawing.Size(100, 26);
            this.roundsTextbox.TabIndex = 9;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(237, 311);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 55);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mathGroupbox
            // 
            this.mathGroupbox.BackColor = System.Drawing.Color.Transparent;
            this.mathGroupbox.Controls.Add(this.equalsignLabel);
            this.mathGroupbox.Controls.Add(this.additionSignLabel);
            this.mathGroupbox.Controls.Add(this.answerTextbox);
            this.mathGroupbox.Controls.Add(this.num2Label);
            this.mathGroupbox.Controls.Add(this.num1Label);
            this.mathGroupbox.Location = new System.Drawing.Point(101, 92);
            this.mathGroupbox.Name = "mathGroupbox";
            this.mathGroupbox.Size = new System.Drawing.Size(530, 134);
            this.mathGroupbox.TabIndex = 11;
            this.mathGroupbox.TabStop = false;
            this.mathGroupbox.Visible = false;
            // 
            // testGroupbox
            // 
            this.testGroupbox.BackColor = System.Drawing.Color.Transparent;
            this.testGroupbox.Controls.Add(this.roundsTextbox);
            this.testGroupbox.Controls.Add(this.highestNumTextbox);
            this.testGroupbox.Controls.Add(this.nameLabel);
            this.testGroupbox.Controls.Add(this.roundsLabel);
            this.testGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testGroupbox.Location = new System.Drawing.Point(12, 290);
            this.testGroupbox.Name = "testGroupbox";
            this.testGroupbox.Size = new System.Drawing.Size(219, 178);
            this.testGroupbox.TabIndex = 12;
            this.testGroupbox.TabStop = false;
            this.testGroupbox.Text = "For Instructor Use";
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.Location = new System.Drawing.Point(389, 262);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(100, 54);
            this.nextQuestionButton.TabIndex = 13;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Visible = false;
            this.nextQuestionButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(531, 261);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 55);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(703, 476);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.testGroupbox);
            this.Controls.Add(this.mathGroupbox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mathGroupbox.ResumeLayout(false);
            this.mathGroupbox.PerformLayout();
            this.testGroupbox.ResumeLayout(false);
            this.testGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.TextBox answerTextbox;
        private System.Windows.Forms.Label additionSignLabel;
        private System.Windows.Forms.Label equalsignLabel;
        private System.Windows.Forms.Label roundsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox highestNumTextbox;
        private System.Windows.Forms.TextBox roundsTextbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox mathGroupbox;
        private System.Windows.Forms.GroupBox testGroupbox;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.Button submitButton;
    }
}

