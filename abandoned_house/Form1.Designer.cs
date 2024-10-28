namespace abandoned_house
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.option3Label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(712, 91);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Output Label";
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(92, 556);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(506, 23);
            this.option1Label.TabIndex = 2;
            this.option1Label.Text = "Label";
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(92, 605);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(506, 23);
            this.option2Label.TabIndex = 3;
            this.option2Label.Text = "Label";
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(11, 551);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 28);
            this.option1Button.TabIndex = 4;
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(11, 597);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 28);
            this.option2Button.TabIndex = 5;
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(11, 639);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(75, 28);
            this.option3Button.TabIndex = 7;
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(92, 647);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(506, 23);
            this.option3Label.TabIndex = 6;
            this.option3Label.Text = "Label";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 103);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(712, 440);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 679);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

