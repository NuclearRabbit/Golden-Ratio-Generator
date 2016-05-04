namespace GoldenRatioProject
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.invalidLabel = new System.Windows.Forms.Label();
            this.rectButton = new System.Windows.Forms.RadioButton();
            this.pyramidButton = new System.Windows.Forms.RadioButton();
            this.bottomHeader = new System.Windows.Forms.PictureBox();
            this.triangleButton = new System.Windows.Forms.RadioButton();
            this.rectImage = new System.Windows.Forms.PictureBox();
            this.pyramidImage = new System.Windows.Forms.PictureBox();
            this.triangleImage = new System.Windows.Forms.PictureBox();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.headerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottomHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pyramidImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleImage)).BeginInit();
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.BackColor = System.Drawing.Color.White;
            this.instructionsLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.instructionsLabel.Location = new System.Drawing.Point(11, 89);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(198, 22);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "Enter In Base Width:";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthInput
            // 
            this.widthInput.AcceptsReturn = true;
            this.widthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthInput.Location = new System.Drawing.Point(224, 85);
            this.widthInput.Margin = new System.Windows.Forms.Padding(2);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(79, 26);
            this.widthInput.TabIndex = 2;
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.widthInput_KeyDown);
            // 
            // calcButton
            // 
            this.calcButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(12, 160);
            this.calcButton.Margin = new System.Windows.Forms.Padding(2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(84, 33);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calc_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(108, 161);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(56, 32);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.BackColor = System.Drawing.Color.White;
            this.dimensionsLabel.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionsLabel.ForeColor = System.Drawing.Color.Black;
            this.dimensionsLabel.Location = new System.Drawing.Point(4, 10);
            this.dimensionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(116, 27);
            this.dimensionsLabel.TabIndex = 6;
            this.dimensionsLabel.Text = "Results:";
            this.dimensionsLabel.UseMnemonic = false;
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.BackColor = System.Drawing.Color.White;
            this.aLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.aLabel.Location = new System.Drawing.Point(6, 61);
            this.aLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(50, 18);
            this.aLabel.TabIndex = 7;
            this.aLabel.Text = "label3";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.BackColor = System.Drawing.Color.White;
            this.bLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.bLabel.Location = new System.Drawing.Point(6, 111);
            this.bLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(50, 18);
            this.bLabel.TabIndex = 8;
            this.bLabel.Text = "label1";
            // 
            // invalidLabel
            // 
            this.invalidLabel.AutoSize = true;
            this.invalidLabel.BackColor = System.Drawing.Color.White;
            this.invalidLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidLabel.Location = new System.Drawing.Point(5, 16);
            this.invalidLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.invalidLabel.Name = "invalidLabel";
            this.invalidLabel.Size = new System.Drawing.Size(225, 19);
            this.invalidLabel.TabIndex = 9;
            this.invalidLabel.Text = "Error: Word Input = Derp";
            // 
            // rectButton
            // 
            this.rectButton.AutoSize = true;
            this.rectButton.BackColor = System.Drawing.Color.White;
            this.rectButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectButton.Location = new System.Drawing.Point(12, 128);
            this.rectButton.Margin = new System.Windows.Forms.Padding(2);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(84, 20);
            this.rectButton.TabIndex = 10;
            this.rectButton.TabStop = true;
            this.rectButton.Text = "Rectangle";
            this.rectButton.UseVisualStyleBackColor = false;
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            this.rectButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rectButton_KeyDown);
            // 
            // pyramidButton
            // 
            this.pyramidButton.AutoSize = true;
            this.pyramidButton.BackColor = System.Drawing.Color.White;
            this.pyramidButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pyramidButton.Location = new System.Drawing.Point(108, 128);
            this.pyramidButton.Margin = new System.Windows.Forms.Padding(2);
            this.pyramidButton.Name = "pyramidButton";
            this.pyramidButton.Size = new System.Drawing.Size(74, 20);
            this.pyramidButton.TabIndex = 11;
            this.pyramidButton.TabStop = true;
            this.pyramidButton.Text = "Pyramid";
            this.pyramidButton.UseVisualStyleBackColor = false;
            this.pyramidButton.Click += new System.EventHandler(this.pyramidButton_Click);
            this.pyramidButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pyramidButton_KeyDown);
            // 
            // bottomHeader
            // 
            this.bottomHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomHeader.BackColor = System.Drawing.Color.Black;
            this.bottomHeader.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bottomHeader.ErrorImage")));
            this.bottomHeader.Image = ((System.Drawing.Image)(resources.GetObject("bottomHeader.Image")));
            this.bottomHeader.InitialImage = ((System.Drawing.Image)(resources.GetObject("bottomHeader.InitialImage")));
            this.bottomHeader.Location = new System.Drawing.Point(-29, 395);
            this.bottomHeader.Margin = new System.Windows.Forms.Padding(2);
            this.bottomHeader.Name = "bottomHeader";
            this.bottomHeader.Size = new System.Drawing.Size(513, 19);
            this.bottomHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bottomHeader.TabIndex = 12;
            this.bottomHeader.TabStop = false;
            // 
            // triangleButton
            // 
            this.triangleButton.AutoSize = true;
            this.triangleButton.BackColor = System.Drawing.Color.White;
            this.triangleButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleButton.Location = new System.Drawing.Point(199, 128);
            this.triangleButton.Margin = new System.Windows.Forms.Padding(2);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(71, 20);
            this.triangleButton.TabIndex = 15;
            this.triangleButton.TabStop = true;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = false;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            this.triangleButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.triangleButton_KeyDown);
            // 
            // rectImage
            // 
            this.rectImage.BackColor = System.Drawing.Color.Transparent;
            this.rectImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("rectImage.ErrorImage")));
            this.rectImage.Image = ((System.Drawing.Image)(resources.GetObject("rectImage.Image")));
            this.rectImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("rectImage.InitialImage")));
            this.rectImage.Location = new System.Drawing.Point(273, 180);
            this.rectImage.Name = "rectImage";
            this.rectImage.Size = new System.Drawing.Size(209, 212);
            this.rectImage.TabIndex = 16;
            this.rectImage.TabStop = false;
            // 
            // pyramidImage
            // 
            this.pyramidImage.BackColor = System.Drawing.Color.Transparent;
            this.pyramidImage.Image = ((System.Drawing.Image)(resources.GetObject("pyramidImage.Image")));
            this.pyramidImage.Location = new System.Drawing.Point(275, 135);
            this.pyramidImage.Name = "pyramidImage";
            this.pyramidImage.Size = new System.Drawing.Size(210, 238);
            this.pyramidImage.TabIndex = 5;
            this.pyramidImage.TabStop = false;
            // 
            // triangleImage
            // 
            this.triangleImage.BackColor = System.Drawing.Color.Transparent;
            this.triangleImage.Image = ((System.Drawing.Image)(resources.GetObject("triangleImage.Image")));
            this.triangleImage.Location = new System.Drawing.Point(292, 95);
            this.triangleImage.Name = "triangleImage";
            this.triangleImage.Size = new System.Drawing.Size(181, 291);
            this.triangleImage.TabIndex = 17;
            this.triangleImage.TabStop = false;
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.White;
            this.resultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPanel.Controls.Add(this.dimensionsLabel);
            this.resultPanel.Controls.Add(this.aLabel);
            this.resultPanel.Controls.Add(this.bLabel);
            this.resultPanel.Controls.Add(this.invalidLabel);
            this.resultPanel.Location = new System.Drawing.Point(12, 198);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(252, 164);
            this.resultPanel.TabIndex = 18;
            // 
            // headerImage
            // 
            this.headerImage.BackColor = System.Drawing.Color.Black;
            this.headerImage.Image = ((System.Drawing.Image)(resources.GetObject("headerImage.Image")));
            this.headerImage.Location = new System.Drawing.Point(0, 0);
            this.headerImage.Name = "headerImage";
            this.headerImage.Size = new System.Drawing.Size(493, 60);
            this.headerImage.TabIndex = 19;
            this.headerImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 412);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.headerImage);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.triangleImage);
            this.Controls.Add(this.pyramidImage);
            this.Controls.Add(this.bottomHeader);
            this.Controls.Add(this.rectImage);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.pyramidButton);
            this.Controls.Add(this.rectButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.instructionsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Golden Ratio Generator v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottomHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pyramidImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleImage)).EndInit();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label invalidLabel;
        private System.Windows.Forms.RadioButton rectButton;
        private System.Windows.Forms.RadioButton pyramidButton;
        private System.Windows.Forms.PictureBox bottomHeader;
        private System.Windows.Forms.RadioButton triangleButton;
        private System.Windows.Forms.PictureBox rectImage;
        private System.Windows.Forms.PictureBox pyramidImage;
        private System.Windows.Forms.PictureBox triangleImage;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.PictureBox headerImage;
    }
}

