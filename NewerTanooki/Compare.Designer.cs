namespace NewerTanooki
{
    partial class Compare
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
            this.compareLabel = new System.Windows.Forms.Label();
            this.withLabel = new System.Windows.Forms.Label();
            this.compareComboBox = new System.Windows.Forms.ComboBox();
            this.withComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compareLabel
            // 
            this.compareLabel.AutoSize = true;
            this.compareLabel.Location = new System.Drawing.Point(71, 51);
            this.compareLabel.Name = "compareLabel";
            this.compareLabel.Size = new System.Drawing.Size(80, 13);
            this.compareLabel.TabIndex = 0;
            this.compareLabel.Text = "Compare Save:";
            // 
            // withLabel
            // 
            this.withLabel.AutoSize = true;
            this.withLabel.Location = new System.Drawing.Point(206, 51);
            this.withLabel.Name = "withLabel";
            this.withLabel.Size = new System.Drawing.Size(60, 13);
            this.withLabel.TabIndex = 1;
            this.withLabel.Text = "With Save:";
            // 
            // compareComboBox
            // 
            this.compareComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compareComboBox.FormattingEnabled = true;
            this.compareComboBox.Items.AddRange(new object[] {
            "Save 1",
            "Save 2",
            "Save 3",
            "Quicksave 1",
            "Quicksave 2",
            "Quicksave 3"});
            this.compareComboBox.Location = new System.Drawing.Point(48, 67);
            this.compareComboBox.Name = "compareComboBox";
            this.compareComboBox.Size = new System.Drawing.Size(121, 21);
            this.compareComboBox.TabIndex = 2;
            // 
            // withComboBox
            // 
            this.withComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.withComboBox.FormattingEnabled = true;
            this.withComboBox.Items.AddRange(new object[] {
            "Save 1",
            "Save 2",
            "Save 3",
            "Quicksave 1",
            "Quicksave 2",
            "Quicksave 3"});
            this.withComboBox.Location = new System.Drawing.Point(175, 67);
            this.withComboBox.Name = "withComboBox";
            this.withComboBox.Size = new System.Drawing.Size(121, 21);
            this.withComboBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(137, 110);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 176);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.withComboBox);
            this.Controls.Add(this.compareComboBox);
            this.Controls.Add(this.withLabel);
            this.Controls.Add(this.compareLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Compare";
            this.ShowIcon = false;
            this.Text = "Compare Saves";
            this.Load += new System.EventHandler(this.Compare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label compareLabel;
        private System.Windows.Forms.Label withLabel;
        private System.Windows.Forms.ComboBox compareComboBox;
        private System.Windows.Forms.ComboBox withComboBox;
        private System.Windows.Forms.Button okButton;
    }
}