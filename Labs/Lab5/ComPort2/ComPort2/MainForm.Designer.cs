namespace ComPort2
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
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputPanel1 = new System.Windows.Forms.Panel();
            this.outputLabel = new System.Windows.Forms.Label();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.package1 = new System.Windows.Forms.Label();
            this.Station1Token = new System.Windows.Forms.Label();
            this.destinationAddress1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.holdTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.monitorToken = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.holdTimeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Station2Token = new System.Windows.Forms.Label();
            this.destinationAddress2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.outputPanel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.Station3Token = new System.Windows.Forms.Label();
            this.destinationAddress3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.inputTextBox3 = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.outputPanel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.package2 = new System.Windows.Forms.Label();
            this.package3 = new System.Windows.Forms.Label();
            this.packageMonitor = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.outputPanel1.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.outputPanel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.outputPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroupBox.Controls.Add(this.inputTextBox1);
            this.inputGroupBox.Location = new System.Drawing.Point(6, 22);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(205, 45);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox1.Location = new System.Drawing.Point(3, 16);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(199, 27);
            this.inputTextBox1.TabIndex = 5;
            this.inputTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputGroupBox.Controls.Add(this.outputPanel1);
            this.outputGroupBox.Location = new System.Drawing.Point(6, 73);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(205, 100);
            this.outputGroupBox.TabIndex = 0;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputPanel1
            // 
            this.outputPanel1.AutoScroll = true;
            this.outputPanel1.Controls.Add(this.outputLabel);
            this.outputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel1.Location = new System.Drawing.Point(3, 16);
            this.outputPanel1.Name = "outputPanel1";
            this.outputPanel1.Size = new System.Drawing.Size(199, 81);
            this.outputPanel1.TabIndex = 0;
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
            this.controlGroupBox.Controls.Add(this.package1);
            this.controlGroupBox.Controls.Add(this.Station1Token);
            this.controlGroupBox.Controls.Add(this.destinationAddress1);
            this.controlGroupBox.Controls.Add(this.label1);
            this.controlGroupBox.Location = new System.Drawing.Point(6, 179);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(202, 58);
            this.controlGroupBox.TabIndex = 0;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control && Debug";
            // 
            // package1
            // 
            this.package1.AutoSize = true;
            this.package1.Location = new System.Drawing.Point(13, 40);
            this.package1.Name = "package1";
            this.package1.Size = new System.Drawing.Size(35, 13);
            this.package1.TabIndex = 14;
            this.package1.Text = "label2";
            // 
            // Station1Token
            // 
            this.Station1Token.AutoSize = true;
            this.Station1Token.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Station1Token.Location = new System.Drawing.Point(173, 15);
            this.Station1Token.Name = "Station1Token";
            this.Station1Token.Size = new System.Drawing.Size(20, 25);
            this.Station1Token.TabIndex = 13;
            this.Station1Token.Text = "*";
            // 
            // destinationAddress1
            // 
            this.destinationAddress1.FormattingEnabled = true;
            this.destinationAddress1.Location = new System.Drawing.Point(122, 17);
            this.destinationAddress1.Name = "destinationAddress1";
            this.destinationAddress1.Size = new System.Drawing.Size(46, 21);
            this.destinationAddress1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Destination address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.controlGroupBox);
            this.groupBox2.Controls.Add(this.inputGroupBox);
            this.groupBox2.Controls.Add(this.outputGroupBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Station 1";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(268, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitor";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.packageMonitor);
            this.groupBox4.Controls.Add(this.holdTimeCheckBox);
            this.groupBox4.Controls.Add(this.monitorToken);
            this.groupBox4.Controls.Add(this.startButton);
            this.groupBox4.Controls.Add(this.holdTimeTextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 83);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control && Debug";
            // 
            // holdTimeCheckBox
            // 
            this.holdTimeCheckBox.AutoSize = true;
            this.holdTimeCheckBox.Location = new System.Drawing.Point(7, 44);
            this.holdTimeCheckBox.Name = "holdTimeCheckBox";
            this.holdTimeCheckBox.Size = new System.Drawing.Size(122, 17);
            this.holdTimeCheckBox.TabIndex = 14;
            this.holdTimeCheckBox.Text = "Hold time (seconds):";
            this.holdTimeCheckBox.UseVisualStyleBackColor = true;
            this.holdTimeCheckBox.CheckedChanged += new System.EventHandler(this.holdTimeCheckBox_CheckedChanged);
            // 
            // monitorToken
            // 
            this.monitorToken.AutoSize = true;
            this.monitorToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monitorToken.Location = new System.Drawing.Point(59, 14);
            this.monitorToken.Name = "monitorToken";
            this.monitorToken.Size = new System.Drawing.Size(20, 25);
            this.monitorToken.TabIndex = 13;
            this.monitorToken.Text = "*";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(7, 14);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(50, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // holdTimeTextBox
            // 
            this.holdTimeTextBox.Location = new System.Drawing.Point(135, 42);
            this.holdTimeTextBox.Name = "holdTimeTextBox";
            this.holdTimeTextBox.Size = new System.Drawing.Size(22, 20);
            this.holdTimeTextBox.TabIndex = 11;
            this.holdTimeTextBox.Text = "10";
            this.holdTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.holdTimeTextBox.TextChanged += new System.EventHandler(this.holdTimeTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Location = new System.Drawing.Point(246, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Station 2";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.package2);
            this.groupBox5.Controls.Add(this.Station2Token);
            this.groupBox5.Controls.Add(this.destinationAddress2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 179);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 63);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control && Debug";
            // 
            // Station2Token
            // 
            this.Station2Token.AutoSize = true;
            this.Station2Token.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Station2Token.Location = new System.Drawing.Point(173, 15);
            this.Station2Token.Name = "Station2Token";
            this.Station2Token.Size = new System.Drawing.Size(20, 25);
            this.Station2Token.TabIndex = 13;
            this.Station2Token.Text = "*";
            // 
            // destinationAddress2
            // 
            this.destinationAddress2.FormattingEnabled = true;
            this.destinationAddress2.Location = new System.Drawing.Point(122, 17);
            this.destinationAddress2.Name = "destinationAddress2";
            this.destinationAddress2.Size = new System.Drawing.Size(46, 21);
            this.destinationAddress2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destination address:";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.inputTextBox2);
            this.groupBox6.Location = new System.Drawing.Point(6, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 45);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Input";
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox2.Location = new System.Drawing.Point(3, 16);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(199, 27);
            this.inputTextBox2.TabIndex = 5;
            this.inputTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.outputPanel2);
            this.groupBox7.Location = new System.Drawing.Point(6, 73);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(205, 100);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output";
            // 
            // outputPanel2
            // 
            this.outputPanel2.AutoScroll = true;
            this.outputPanel2.Controls.Add(this.label4);
            this.outputPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel2.Location = new System.Drawing.Point(3, 16);
            this.outputPanel2.Name = "outputPanel2";
            this.outputPanel2.Size = new System.Drawing.Size(199, 81);
            this.outputPanel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Location = new System.Drawing.Point(477, 255);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(217, 248);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Station 3";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.package3);
            this.groupBox9.Controls.Add(this.Station3Token);
            this.groupBox9.Controls.Add(this.destinationAddress3);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Location = new System.Drawing.Point(6, 179);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(202, 63);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Control && Debug";
            // 
            // Station3Token
            // 
            this.Station3Token.AutoSize = true;
            this.Station3Token.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Station3Token.Location = new System.Drawing.Point(173, 15);
            this.Station3Token.Name = "Station3Token";
            this.Station3Token.Size = new System.Drawing.Size(20, 25);
            this.Station3Token.TabIndex = 13;
            this.Station3Token.Text = "*";
            // 
            // destinationAddress3
            // 
            this.destinationAddress3.FormattingEnabled = true;
            this.destinationAddress3.Location = new System.Drawing.Point(122, 17);
            this.destinationAddress3.Name = "destinationAddress3";
            this.destinationAddress3.Size = new System.Drawing.Size(46, 21);
            this.destinationAddress3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Destination address:";
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.inputTextBox3);
            this.groupBox10.Location = new System.Drawing.Point(6, 22);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(205, 45);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Input";
            // 
            // inputTextBox3
            // 
            this.inputTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox3.Location = new System.Drawing.Point(3, 16);
            this.inputTextBox3.Name = "inputTextBox3";
            this.inputTextBox3.Size = new System.Drawing.Size(199, 27);
            this.inputTextBox3.TabIndex = 5;
            this.inputTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.outputPanel3);
            this.groupBox11.Location = new System.Drawing.Point(6, 73);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(205, 100);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Output";
            // 
            // outputPanel3
            // 
            this.outputPanel3.AutoScroll = true;
            this.outputPanel3.Controls.Add(this.label7);
            this.outputPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanel3.Location = new System.Drawing.Point(3, 16);
            this.outputPanel3.Name = "outputPanel3";
            this.outputPanel3.Size = new System.Drawing.Size(199, 81);
            this.outputPanel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 0;
            // 
            // package2
            // 
            this.package2.AutoSize = true;
            this.package2.Location = new System.Drawing.Point(12, 42);
            this.package2.Name = "package2";
            this.package2.Size = new System.Drawing.Size(35, 13);
            this.package2.TabIndex = 14;
            this.package2.Text = "label2";
            // 
            // package3
            // 
            this.package3.AutoSize = true;
            this.package3.Location = new System.Drawing.Point(13, 40);
            this.package3.Name = "package3";
            this.package3.Size = new System.Drawing.Size(35, 13);
            this.package3.TabIndex = 14;
            this.package3.Text = "label2";
            // 
            // packageMonitor
            // 
            this.packageMonitor.AutoSize = true;
            this.packageMonitor.Location = new System.Drawing.Point(6, 64);
            this.packageMonitor.Name = "packageMonitor";
            this.packageMonitor.Size = new System.Drawing.Size(35, 13);
            this.packageMonitor.TabIndex = 14;
            this.packageMonitor.Text = "label2";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(706, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "Token Ring";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputPanel1.ResumeLayout(false);
            this.outputPanel1.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.outputPanel2.ResumeLayout(false);
            this.outputPanel2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.outputPanel3.ResumeLayout(false);
            this.outputPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Panel outputPanel1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Station1Token;
        private System.Windows.Forms.ComboBox destinationAddress1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox holdTimeCheckBox;
        private System.Windows.Forms.Label monitorToken;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox holdTimeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label Station2Token;
        private System.Windows.Forms.ComboBox destinationAddress2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel outputPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label Station3Token;
        private System.Windows.Forms.ComboBox destinationAddress3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox inputTextBox3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel outputPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label package1;
        private System.Windows.Forms.Label packageMonitor;
        private System.Windows.Forms.Label package2;
        private System.Windows.Forms.Label package3;
    }
}

