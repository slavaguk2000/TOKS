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
            this.attemptCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Location = new System.Drawing.Point(6, 22);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(205, 45);
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
            this.inputTextBox.Size = new System.Drawing.Size(199, 27);
            this.inputTextBox.TabIndex = 5;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroupBox.Controls.Add(this.outputPanel);
            this.outputGroupBox.Location = new System.Drawing.Point(6, 73);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(205, 100);
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
            this.outputPanel.Size = new System.Drawing.Size(199, 81);
            this.outputPanel.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.Location = new System.Drawing.Point(3, 10);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 0;
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlGroupBox.Controls.Add(this.attemptCountTextBox);
            this.controlGroupBox.Controls.Add(this.label1);
            this.controlGroupBox.Controls.Add(this.groupBox1);
            this.controlGroupBox.Location = new System.Drawing.Point(6, 179);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(202, 156);
            this.controlGroupBox.TabIndex = 0;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control && Debug";
            // 
            // attemptCountTextBox
            // 
            this.attemptCountTextBox.Location = new System.Drawing.Point(95, 17);
            this.attemptCountTextBox.Name = "attemptCountTextBox";
            this.attemptCountTextBox.Size = new System.Drawing.Size(37, 20);
            this.attemptCountTextBox.TabIndex = 11;
            this.attemptCountTextBox.Text = "10";
            this.attemptCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Attempt count:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 107);
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
            this.panel1.Size = new System.Drawing.Size(184, 88);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.controlGroupBox);
            this.groupBox2.Controls.Add(this.inputGroupBox);
            this.groupBox2.Controls.Add(this.outputGroupBox);
            this.groupBox2.Location = new System.Drawing.Point(26, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 341);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Station 1";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(706, 654);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "Token Ring";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox attemptCountTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

