namespace week_6
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lnlName = new System.Windows.Forms.Label();
            this.lnlEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.checkBoxPhp = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxJava = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxAge = new System.Windows.Forms.GroupBox();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.groupBoxGift = new System.Windows.Forms.GroupBox();
            this.radioButtonTablet = new System.Windows.Forms.RadioButton();
            this.radioButtonPc = new System.Windows.Forms.RadioButton();
            this.radioButtonPhone = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxAge.SuspendLayout();
            this.groupBoxGift.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lnlName
            // 
            this.lnlName.AutoSize = true;
            this.lnlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnlName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lnlName.Location = new System.Drawing.Point(46, 25);
            this.lnlName.Name = "lnlName";
            this.lnlName.Size = new System.Drawing.Size(67, 22);
            this.lnlName.TabIndex = 1;
            this.lnlName.Text = "Name :";
            // 
            // lnlEmail
            // 
            this.lnlEmail.AutoSize = true;
            this.lnlEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnlEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lnlEmail.Location = new System.Drawing.Point(46, 68);
            this.lnlEmail.Name = "lnlEmail";
            this.lnlEmail.Size = new System.Drawing.Size(69, 22);
            this.lnlEmail.TabIndex = 1;
            this.lnlEmail.Text = "Email : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add the List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(331, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 212);
            this.listBox1.TabIndex = 3;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(405, 230);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(101, 23);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "Save as file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // checkBoxPhp
            // 
            this.checkBoxPhp.AutoSize = true;
            this.checkBoxPhp.Location = new System.Drawing.Point(50, 125);
            this.checkBoxPhp.Name = "checkBoxPhp";
            this.checkBoxPhp.Size = new System.Drawing.Size(57, 20);
            this.checkBoxPhp.TabIndex = 4;
            this.checkBoxPhp.Text = "PHP";
            this.checkBoxPhp.UseVisualStyleBackColor = true;
            this.checkBoxPhp.CheckedChanged += new System.EventHandler(this.boxes);
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(50, 151);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(38, 20);
            this.checkBoxC.TabIndex = 4;
            this.checkBoxC.Text = "C";
            this.checkBoxC.UseVisualStyleBackColor = true;
            this.checkBoxC.CheckedChanged += new System.EventHandler(this.boxes);
            // 
            // checkBoxJava
            // 
            this.checkBoxJava.AutoSize = true;
            this.checkBoxJava.Location = new System.Drawing.Point(50, 177);
            this.checkBoxJava.Name = "checkBoxJava";
            this.checkBoxJava.Size = new System.Drawing.Size(59, 20);
            this.checkBoxJava.TabIndex = 4;
            this.checkBoxJava.Text = "Java";
            this.checkBoxJava.UseVisualStyleBackColor = true;
            this.checkBoxJava.CheckedChanged += new System.EventHandler(this.boxes);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(50, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(50, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Java";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.boxes);
            // 
            // groupBoxAge
            // 
            this.groupBoxAge.Controls.Add(this.radioButton20);
            this.groupBoxAge.Controls.Add(this.radioButton19);
            this.groupBoxAge.Controls.Add(this.radioButton18);
            this.groupBoxAge.Location = new System.Drawing.Point(50, 273);
            this.groupBoxAge.Name = "groupBoxAge";
            this.groupBoxAge.Size = new System.Drawing.Size(210, 165);
            this.groupBoxAge.TabIndex = 5;
            this.groupBoxAge.TabStop = false;
            this.groupBoxAge.Text = "Age";
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(7, 74);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(42, 20);
            this.radioButton20.TabIndex = 0;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "20";
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.groupRadioButtons);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(7, 48);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(42, 20);
            this.radioButton19.TabIndex = 0;
            this.radioButton19.TabStop = true;
            this.radioButton19.Text = "19";
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.groupRadioButtons);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(7, 22);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(42, 20);
            this.radioButton18.TabIndex = 0;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "18";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.groupRadioButtons);
            // 
            // groupBoxGift
            // 
            this.groupBoxGift.Controls.Add(this.radioButtonTablet);
            this.groupBoxGift.Controls.Add(this.radioButtonPc);
            this.groupBoxGift.Controls.Add(this.radioButtonPhone);
            this.groupBoxGift.Location = new System.Drawing.Point(296, 273);
            this.groupBoxGift.Name = "groupBoxGift";
            this.groupBoxGift.Size = new System.Drawing.Size(210, 165);
            this.groupBoxGift.TabIndex = 5;
            this.groupBoxGift.TabStop = false;
            this.groupBoxGift.Text = "Gift";
            // 
            // radioButtonTablet
            // 
            this.radioButtonTablet.AutoSize = true;
            this.radioButtonTablet.Location = new System.Drawing.Point(6, 74);
            this.radioButtonTablet.Name = "radioButtonTablet";
            this.radioButtonTablet.Size = new System.Drawing.Size(67, 20);
            this.radioButtonTablet.TabIndex = 1;
            this.radioButtonTablet.TabStop = true;
            this.radioButtonTablet.Text = "Tablet";
            this.radioButtonTablet.UseVisualStyleBackColor = true;
            this.radioButtonTablet.CheckedChanged += new System.EventHandler(this.groupRadioButtons);
            // 
            // radioButtonPc
            // 
            this.radioButtonPc.AutoSize = true;
            this.radioButtonPc.Location = new System.Drawing.Point(6, 48);
            this.radioButtonPc.Name = "radioButtonPc";
            this.radioButtonPc.Size = new System.Drawing.Size(44, 20);
            this.radioButtonPc.TabIndex = 1;
            this.radioButtonPc.TabStop = true;
            this.radioButtonPc.Text = "Pc";
            this.radioButtonPc.UseVisualStyleBackColor = true;
            this.radioButtonPc.CheckedChanged += new System.EventHandler(this.groupRadioButtons);
            // 
            // radioButtonPhone
            // 
            this.radioButtonPhone.AutoSize = true;
            this.radioButtonPhone.Location = new System.Drawing.Point(6, 22);
            this.radioButtonPhone.Name = "radioButtonPhone";
            this.radioButtonPhone.Size = new System.Drawing.Size(67, 20);
            this.radioButtonPhone.TabIndex = 1;
            this.radioButtonPhone.TabStop = true;
            this.radioButtonPhone.Text = "Phone";
            this.radioButtonPhone.UseVisualStyleBackColor = true;
            this.radioButtonPhone.CheckedChanged += new System.EventHandler(this.groupRadioButtons);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxGift);
            this.Controls.Add(this.groupBoxAge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBoxJava);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxPhp);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lnlEmail);
            this.Controls.Add(this.lnlName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxAge.ResumeLayout(false);
            this.groupBoxAge.PerformLayout();
            this.groupBoxGift.ResumeLayout(false);
            this.groupBoxGift.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lnlName;
        private System.Windows.Forms.Label lnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.CheckBox checkBoxPhp;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxJava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxAge;
        private System.Windows.Forms.GroupBox groupBoxGift;
        private System.Windows.Forms.RadioButton radioButtonTablet;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButtonPc;
        private System.Windows.Forms.RadioButton radioButtonPhone;
        private System.Windows.Forms.Timer timer1;
    }
}