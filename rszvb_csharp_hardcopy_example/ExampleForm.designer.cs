namespace rszvb_hardcopy_example
{
    partial class RSZVB_Hardcopy_Example
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSZVB_Hardcopy_Example));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DisplayEnable = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResourceDescriptor = new System.Windows.Forms.TextBox();
            this.ResetDevice = new System.Windows.Forms.CheckBox();
            this.IDQuery = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenButton);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 66);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(342, 33);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 99;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "Save File Path";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisplayEnable
            // 
            this.DisplayEnable.Checked = true;
            this.DisplayEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayEnable.Location = new System.Drawing.Point(462, 86);
            this.DisplayEnable.Name = "DisplayEnable";
            this.DisplayEnable.Size = new System.Drawing.Size(96, 18);
            this.DisplayEnable.TabIndex = 99;
            this.DisplayEnable.Text = "Display Enable";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 207);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 98;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(485, 207);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 97;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(548, 48);
            this.Label2.TabIndex = 96;
            this.Label2.Text = "Rohd && Schwarz Vector Network Analyzer\r\nHardcopy Example";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResourceDescriptor);
            this.groupBox1.Controls.Add(this.ResetDevice);
            this.groupBox1.Controls.Add(this.IDQuery);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 70);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // ResourceDescriptor
            // 
            this.ResourceDescriptor.Location = new System.Drawing.Point(5, 31);
            this.ResourceDescriptor.Name = "ResourceDescriptor";
            this.ResourceDescriptor.Size = new System.Drawing.Size(180, 20);
            this.ResourceDescriptor.TabIndex = 43;
            this.ResourceDescriptor.Text = "GPIB::20::INSTR";
            // 
            // ResetDevice
            // 
            this.ResetDevice.Checked = true;
            this.ResetDevice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ResetDevice.Location = new System.Drawing.Point(277, 31);
            this.ResetDevice.Name = "ResetDevice";
            this.ResetDevice.Size = new System.Drawing.Size(96, 18);
            this.ResetDevice.TabIndex = 42;
            this.ResetDevice.Text = "Reset Device";
            // 
            // IDQuery
            // 
            this.IDQuery.Checked = true;
            this.IDQuery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IDQuery.Location = new System.Drawing.Point(199, 31);
            this.IDQuery.Name = "IDQuery";
            this.IDQuery.Size = new System.Drawing.Size(72, 18);
            this.IDQuery.TabIndex = 41;
            this.IDQuery.Text = "ID Query";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(6, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 16);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "Resource Descriptor";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "wmf files|*.wmf";
            // 
            // RSZVB_Hardcopy_Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DisplayEnable);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RSZVB_Hardcopy_Example";
            this.Text = "RSZVB Hardcopy Example";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.CheckBox DisplayEnable;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox ResourceDescriptor;
        internal System.Windows.Forms.CheckBox ResetDevice;
        internal System.Windows.Forms.CheckBox IDQuery;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

