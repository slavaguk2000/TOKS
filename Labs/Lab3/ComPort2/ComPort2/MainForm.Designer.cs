namespace ComPort
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.outputLabel = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.ErrorGenerationCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComPortComboBox = new System.Windows.Forms.ComboBox();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlLabel = new System.Windows.Forms.Label();
            this.radioButtonDTR = new System.Windows.Forms.RadioButton();
            this.controlEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButtonRTS = new System.Windows.Forms.RadioButton();
            this.SourceAddressTextBox = new System.Windows.Forms.TextBox();
            this.DistanitionAddressTextBox = new System.Windows.Forms.TextBox();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(360, 45);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(3, 16);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(354, 27);
            this.inputTextBox.TabIndex = 5;
            this.inputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroupBox.Controls.Add(this.outputPanel);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 63);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(360, 100);
            this.outputGroupBox.TabIndex = 0;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputPanel
            // 
            this.outputPanel.AutoScroll = true;
            this.outputPanel.Controls.Add(this.outputLabel);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel.Location = new System.Drawing.Point(3, 16);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(354, 81);
            this.outputPanel.TabIndex = 0;
            this.outputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.outputPanel_Paint);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.Location = new System.Drawing.Point(3, 10);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Click += new System.EventHandler(this.outputLabl_Click);
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlGroupBox.Controls.Add(this.DistanitionAddressTextBox);
            this.controlGroupBox.Controls.Add(this.SourceAddressTextBox);
            this.controlGroupBox.Controls.Add(this.ErrorGenerationCheckBox);
            this.controlGroupBox.Controls.Add(this.label3);
            this.controlGroupBox.Controls.Add(this.label2);
            this.controlGroupBox.Controls.Add(this.label1);
            this.controlGroupBox.Controls.Add(this.ComPortComboBox);
            this.controlGroupBox.Controls.Add(this.ComPortLabel);
            this.controlGroupBox.Controls.Add(this.groupBox1);
            this.controlGroupBox.Controls.Add(this.radioButtonDTR);
            this.controlGroupBox.Controls.Add(this.controlEnableCheckBox);
            this.controlGroupBox.Controls.Add(this.radioButtonRTS);
            this.controlGroupBox.Location = new System.Drawing.Point(12, 169);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(360, 180);
            this.controlGroupBox.TabIndex = 0;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control && Debug";
            this.controlGroupBox.Enter += new System.EventHandler(this.controlGroupBox_Enter);
            // 
            // ErrorGenerationCheckBox
            // 
            this.ErrorGenerationCheckBox.AutoSize = true;
            this.ErrorGenerationCheckBox.Location = new System.Drawing.Point(327, 66);
            this.ErrorGenerationCheckBox.Name = "ErrorGenerationCheckBox";
            this.ErrorGenerationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ErrorGenerationCheckBox.TabIndex = 10;
            this.ErrorGenerationCheckBox.UseVisualStyleBackColor = true;
            this.ErrorGenerationCheckBox.CheckedChanged += new System.EventHandler(this.ErrorGenerationCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Error generation:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Distanition address:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ComPortComboBox
            // 
            this.ComPortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPortComboBox.Location = new System.Drawing.Point(71, 17);
            this.ComPortComboBox.Name = "ComPortComboBox";
            this.ComPortComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComPortComboBox.TabIndex = 8;
            this.ComPortComboBox.DropDown += new System.EventHandler(this.ComPortComboBox_DropDown_1);
            this.ComPortComboBox.SelectedIndexChanged += new System.EventHandler(this.ComPortComboBox_SelectedIndexChanged_1);
            this.ComPortComboBox.DropDownClosed += new System.EventHandler(this.ComPortComboBox_DropDownClosed);
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Location = new System.Drawing.Point(12, 20);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(53, 13);
            this.ComPortLabel.TabIndex = 7;
            this.ComPortLabel.Text = "COM-Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.controlLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 72);
            this.panel1.TabIndex = 5;
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Location = new System.Drawing.Point(4, 4);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(0, 13);
            this.controlLabel.TabIndex = 0;
            // 
            // radioButtonDTR
            // 
            this.radioButtonDTR.AutoSize = true;
            this.radioButtonDTR.Enabled = false;
            this.radioButtonDTR.Location = new System.Drawing.Point(132, 68);
            this.radioButtonDTR.Name = "radioButtonDTR";
            this.radioButtonDTR.Size = new System.Drawing.Size(76, 17);
            this.radioButtonDTR.TabIndex = 4;
            this.radioButtonDTR.TabStop = true;
            this.radioButtonDTR.Text = "DTR/DSR";
            this.radioButtonDTR.UseVisualStyleBackColor = true;
            this.radioButtonDTR.CheckedChanged += new System.EventHandler(this.radioButtonDTR_CheckedChanged);
            // 
            // controlEnableCheckBox
            // 
            this.controlEnableCheckBox.AutoSize = true;
            this.controlEnableCheckBox.Location = new System.Drawing.Point(6, 44);
            this.controlEnableCheckBox.Name = "controlEnableCheckBox";
            this.controlEnableCheckBox.Size = new System.Drawing.Size(120, 17);
            this.controlEnableCheckBox.TabIndex = 1;
            this.controlEnableCheckBox.Text = "Flow Control Enable";
            this.controlEnableCheckBox.UseVisualStyleBackColor = true;
            this.controlEnableCheckBox.CheckedChanged += new System.EventHandler(this.controlEnableCheckBox_CheckedChanged);
            // 
            // radioButtonRTS
            // 
            this.radioButtonRTS.AutoSize = true;
            this.radioButtonRTS.Checked = true;
            this.radioButtonRTS.Enabled = false;
            this.radioButtonRTS.Location = new System.Drawing.Point(132, 45);
            this.radioButtonRTS.Name = "radioButtonRTS";
            this.radioButtonRTS.Size = new System.Drawing.Size(73, 17);
            this.radioButtonRTS.TabIndex = 4;
            this.radioButtonRTS.TabStop = true;
            this.radioButtonRTS.Text = "RTS/CTS";
            this.radioButtonRTS.UseVisualStyleBackColor = true;
            this.radioButtonRTS.CheckedChanged += new System.EventHandler(this.radioButtonRTS_CheckedChanged);
            // 
            // SourceAddressTextBox
            // 
            this.SourceAddressTextBox.Location = new System.Drawing.Point(314, 17);
            this.SourceAddressTextBox.Name = "SourceAddressTextBox";
            this.SourceAddressTextBox.Size = new System.Drawing.Size(37, 20);
            this.SourceAddressTextBox.TabIndex = 11;
            this.SourceAddressTextBox.Text = "0";
            this.SourceAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SourceAddressTextBox.TextChanged += new System.EventHandler(this.SourceAddressTextBox_TextChanged);
            this.SourceAddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SourceAddressTextBox_KeyPress);
            this.SourceAddressTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SourceAddressTextBox_MouseDown);
            // 
            // DistanitionAddressTextBox
            // 
            this.DistanitionAddressTextBox.Location = new System.Drawing.Point(314, 40);
            this.DistanitionAddressTextBox.Name = "DistanitionAddressTextBox";
            this.DistanitionAddressTextBox.Size = new System.Drawing.Size(37, 20);
            this.DistanitionAddressTextBox.TabIndex = 11;
            this.DistanitionAddressTextBox.Text = "0";
            this.DistanitionAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DistanitionAddressTextBox.TextChanged += new System.EventHandler(this.DistanitionAddressTextBox_TextChanged);
            this.DistanitionAddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SourceAddressTextBox_KeyPress);
            this.DistanitionAddressTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SourceAddressTextBox_MouseDown);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "COM-Port Tranciver";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.CheckBox controlEnableCheckBox;
        private System.Windows.Forms.RadioButton radioButtonRTS;
        private System.Windows.Forms.RadioButton radioButtonDTR;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComPortComboBox;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ErrorGenerationCheckBox;
        private System.Windows.Forms.TextBox SourceAddressTextBox;
        private System.Windows.Forms.TextBox DistanitionAddressTextBox;
    }
}

