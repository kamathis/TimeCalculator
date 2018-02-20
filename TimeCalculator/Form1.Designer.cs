namespace TimeCalculator
{
    partial class TimeCalculator
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
            this.enterSecondsLabel = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.daysLabel = new System.Windows.Forms.Label();
            this.daysDisplayLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.hoursDisplayLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.minutesDisplayLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.displaySecondsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterSecondsLabel
            // 
            this.enterSecondsLabel.AutoSize = true;
            this.enterSecondsLabel.Location = new System.Drawing.Point(14, 15);
            this.enterSecondsLabel.Name = "enterSecondsLabel";
            this.enterSecondsLabel.Size = new System.Drawing.Size(80, 13);
            this.enterSecondsLabel.TabIndex = 0;
            this.enterSecondsLabel.Text = "Enter Seconds:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(164, 17);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(111, 20);
            this.secondsTextBox.TabIndex = 1;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.displaySecondsLabel);
            this.resultsGroupBox.Controls.Add(this.secondsLabel);
            this.resultsGroupBox.Controls.Add(this.minutesDisplayLabel);
            this.resultsGroupBox.Controls.Add(this.minutesLabel);
            this.resultsGroupBox.Controls.Add(this.hoursDisplayLabel);
            this.resultsGroupBox.Controls.Add(this.hoursLabel);
            this.resultsGroupBox.Controls.Add(this.daysDisplayLabel);
            this.resultsGroupBox.Controls.Add(this.daysLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(20, 52);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(254, 212);
            this.resultsGroupBox.TabIndex = 2;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(6, 31);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(34, 13);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Days:";
            // 
            // daysDisplayLabel
            // 
            this.daysDisplayLabel.AutoSize = true;
            this.daysDisplayLabel.Location = new System.Drawing.Point(155, 31);
            this.daysDisplayLabel.Name = "daysDisplayLabel";
            this.daysDisplayLabel.Size = new System.Drawing.Size(13, 13);
            this.daysDisplayLabel.TabIndex = 1;
            this.daysDisplayLabel.Text = "0";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(6, 76);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "Hours:";
            // 
            // hoursDisplayLabel
            // 
            this.hoursDisplayLabel.AutoSize = true;
            this.hoursDisplayLabel.Location = new System.Drawing.Point(155, 76);
            this.hoursDisplayLabel.Name = "hoursDisplayLabel";
            this.hoursDisplayLabel.Size = new System.Drawing.Size(13, 13);
            this.hoursDisplayLabel.TabIndex = 3;
            this.hoursDisplayLabel.Text = "0";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(6, 124);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(47, 13);
            this.minutesLabel.TabIndex = 4;
            this.minutesLabel.Text = "Minutes:";
            // 
            // minutesDisplayLabel
            // 
            this.minutesDisplayLabel.AutoSize = true;
            this.minutesDisplayLabel.Location = new System.Drawing.Point(155, 124);
            this.minutesDisplayLabel.Name = "minutesDisplayLabel";
            this.minutesDisplayLabel.Size = new System.Drawing.Size(13, 13);
            this.minutesDisplayLabel.TabIndex = 5;
            this.minutesDisplayLabel.Text = "0";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(6, 172);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(52, 13);
            this.secondsLabel.TabIndex = 6;
            this.secondsLabel.Text = "Seconds:";
            // 
            // displaySecondsLabel
            // 
            this.displaySecondsLabel.AutoSize = true;
            this.displaySecondsLabel.Location = new System.Drawing.Point(155, 172);
            this.displaySecondsLabel.Name = "displaySecondsLabel";
            this.displaySecondsLabel.Size = new System.Drawing.Size(13, 13);
            this.displaySecondsLabel.TabIndex = 7;
            this.displaySecondsLabel.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 284);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(73, 22);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "C&alculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(110, 284);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(73, 22);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(202, 284);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 21);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // TimeCalculator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.enterSecondsLabel);
            this.Name = "TimeCalculator";
            this.Text = "Time Calculator";
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterSecondsLabel;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Label displaySecondsLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label minutesDisplayLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursDisplayLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label daysDisplayLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

