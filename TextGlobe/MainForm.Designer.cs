namespace TextGlobe
{
    partial class MainForm
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
            this.browseButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.filtersTextBox = new System.Windows.Forms.TextBox();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(981, 51);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(201, 67);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browse_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(74, 51);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(875, 53);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Enabled = false;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(74, 746);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(875, 53);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // findButton
            // 
            this.findButton.Enabled = false;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(981, 746);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(201, 67);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(74, 268);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(1108, 426);
            this.resultTextBox.TabIndex = 4;
            // 
            // scanButton
            // 
            this.scanButton.Enabled = false;
            this.scanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanButton.Location = new System.Drawing.Point(981, 157);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(201, 67);
            this.scanButton.TabIndex = 5;
            this.scanButton.Text = "scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scan_Click);
            // 
            // filtersTextBox
            // 
            this.filtersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersTextBox.Location = new System.Drawing.Point(403, 157);
            this.filtersTextBox.Name = "filtersTextBox";
            this.filtersTextBox.Size = new System.Drawing.Size(546, 53);
            this.filtersTextBox.TabIndex = 6;
            this.filtersTextBox.TextChanged += new System.EventHandler(this.filtersTextBox_TextChanged);
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersLabel.Location = new System.Drawing.Point(68, 157);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(309, 46);
            this.filtersLabel.TabIndex = 7;
            this.filtersLabel.Text = "extensions filter:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 872);
            this.Controls.Add(this.filtersLabel);
            this.Controls.Add(this.filtersTextBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.browseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Text Globe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.TextBox filtersTextBox;
        private System.Windows.Forms.Label filtersLabel;
    }
}

