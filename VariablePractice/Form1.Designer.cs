namespace VariablePractice
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
            this.hockeyButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.Location = new System.Drawing.Point(35, 22);
            this.hockeyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(108, 41);
            this.hockeyButton.TabIndex = 1;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(165, 22);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(383, 316);
            this.outputLabel.TabIndex = 4;
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(35, 84);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(108, 41);
            this.payButton.TabIndex = 5;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButton.Location = new System.Drawing.Point(35, 146);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(108, 41);
            this.circleButton.TabIndex = 6;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(35, 270);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(108, 41);
            this.billButton.TabIndex = 7;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetButton.Location = new System.Drawing.Point(35, 208);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(108, 41);
            this.carpetButton.TabIndex = 8;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(575, 372);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.hockeyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Variables Practice";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Button carpetButton;
    }
}

