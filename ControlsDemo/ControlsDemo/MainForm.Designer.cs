namespace ControlsDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOptions = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btonClear = new System.Windows.Forms.Button();
            this.lstLayer = new System.Windows.Forms.ListBox();
            this.lstLinetype = new System.Windows.Forms.ListBox();
            this.lstTextstyle = new System.Windows.Forms.ListBox();
            this.lblLayerCount = new System.Windows.Forms.Label();
            this.lblLinetypeCount = new System.Windows.Forms.Label();
            this.lblTextstyle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btonClear);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Controls.Add(this.cboOptions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options Container";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTextstyle);
            this.groupBox2.Controls.Add(this.lstLinetype);
            this.groupBox2.Controls.Add(this.lstLayer);
            this.groupBox2.Controls.Add(this.lblTextstyle);
            this.groupBox2.Controls.Add(this.lblLinetypeCount);
            this.groupBox2.Controls.Add(this.lblLayerCount);
            this.groupBox2.Location = new System.Drawing.Point(412, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 432);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Container";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item to Display:";
            // 
            // cboOptions
            // 
            this.cboOptions.FormattingEnabled = true;
            this.cboOptions.Items.AddRange(new object[] {
            "All",
            "Layer",
            "Linetype",
            "Textstyle"});
            this.cboOptions.Location = new System.Drawing.Point(176, 45);
            this.cboOptions.Name = "cboOptions";
            this.cboOptions.Size = new System.Drawing.Size(121, 24);
            this.cboOptions.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(26, 385);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Show Items";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // btonClear
            // 
            this.btonClear.Location = new System.Drawing.Point(123, 385);
            this.btonClear.Name = "btonClear";
            this.btonClear.Size = new System.Drawing.Size(75, 23);
            this.btonClear.TabIndex = 2;
            this.btonClear.Text = "Clear All";
            this.btonClear.UseVisualStyleBackColor = true;
            // 
            // lstLayer
            // 
            this.lstLayer.FormattingEnabled = true;
            this.lstLayer.ItemHeight = 16;
            this.lstLayer.Location = new System.Drawing.Point(6, 45);
            this.lstLayer.Name = "lstLayer";
            this.lstLayer.Size = new System.Drawing.Size(160, 308);
            this.lstLayer.TabIndex = 0;
            // 
            // lstLinetype
            // 
            this.lstLinetype.FormattingEnabled = true;
            this.lstLinetype.ItemHeight = 16;
            this.lstLinetype.Location = new System.Drawing.Point(216, 45);
            this.lstLinetype.Name = "lstLinetype";
            this.lstLinetype.Size = new System.Drawing.Size(160, 308);
            this.lstLinetype.TabIndex = 0;
            // 
            // lstTextstyle
            // 
            this.lstTextstyle.FormattingEnabled = true;
            this.lstTextstyle.ItemHeight = 16;
            this.lstTextstyle.Location = new System.Drawing.Point(419, 45);
            this.lstTextstyle.Name = "lstTextstyle";
            this.lstTextstyle.Size = new System.Drawing.Size(160, 308);
            this.lstTextstyle.TabIndex = 0;
            // 
            // lblLayerCount
            // 
            this.lblLayerCount.AutoSize = true;
            this.lblLayerCount.Location = new System.Drawing.Point(6, 368);
            this.lblLayerCount.Name = "lblLayerCount";
            this.lblLayerCount.Size = new System.Drawing.Size(20, 17);
            this.lblLayerCount.TabIndex = 0;
            this.lblLayerCount.Text = "...";
            // 
            // lblLinetypeCount
            // 
            this.lblLinetypeCount.AutoSize = true;
            this.lblLinetypeCount.Location = new System.Drawing.Point(213, 368);
            this.lblLinetypeCount.Name = "lblLinetypeCount";
            this.lblLinetypeCount.Size = new System.Drawing.Size(20, 17);
            this.lblLinetypeCount.TabIndex = 0;
            this.lblLinetypeCount.Text = "...";
            // 
            // lblTextstyle
            // 
            this.lblTextstyle.AutoSize = true;
            this.lblTextstyle.Location = new System.Drawing.Point(416, 368);
            this.lblTextstyle.Name = "lblTextstyle";
            this.lblTextstyle.Size = new System.Drawing.Size(20, 17);
            this.lblTextstyle.TabIndex = 0;
            this.lblTextstyle.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btonClear;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cboOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstTextstyle;
        private System.Windows.Forms.ListBox lstLinetype;
        private System.Windows.Forms.ListBox lstLayer;
        private System.Windows.Forms.Label lblTextstyle;
        private System.Windows.Forms.Label lblLinetypeCount;
        private System.Windows.Forms.Label lblLayerCount;
    }
}