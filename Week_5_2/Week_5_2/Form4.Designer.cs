namespace Week_5_2
{
    partial class Form4
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
            this.radioPhp = new System.Windows.Forms.RadioButton();
            this.radioJava = new System.Windows.Forms.RadioButton();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShowIcon = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // radioPhp
            // 
            this.radioPhp.AutoSize = true;
            this.radioPhp.Location = new System.Drawing.Point(68, 33);
            this.radioPhp.Name = "radioPhp";
            this.radioPhp.Size = new System.Drawing.Size(56, 20);
            this.radioPhp.TabIndex = 0;
            this.radioPhp.TabStop = true;
            this.radioPhp.Text = "PHP";
            this.radioPhp.UseVisualStyleBackColor = true;
            this.radioPhp.CheckedChanged += new System.EventHandler(this.radioChange);
            // 
            // radioJava
            // 
            this.radioJava.AutoSize = true;
            this.radioJava.Location = new System.Drawing.Point(131, 33);
            this.radioJava.Name = "radioJava";
            this.radioJava.Size = new System.Drawing.Size(58, 20);
            this.radioJava.TabIndex = 1;
            this.radioJava.TabStop = true;
            this.radioJava.Text = "Java";
            this.radioJava.UseVisualStyleBackColor = true;
            this.radioJava.CheckedChanged += new System.EventHandler(this.radioChange);
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Location = new System.Drawing.Point(195, 33);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(37, 20);
            this.radioC.TabIndex = 2;
            this.radioC.TabStop = true;
            this.radioC.Text = "C";
            this.radioC.UseVisualStyleBackColor = true;
            this.radioC.CheckedChanged += new System.EventHandler(this.radioChange);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(91, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(44, 16);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // btnShowIcon
            // 
            this.btnShowIcon.Location = new System.Drawing.Point(323, 205);
            this.btnShowIcon.Name = "btnShowIcon";
            this.btnShowIcon.Size = new System.Drawing.Size(131, 40);
            this.btnShowIcon.TabIndex = 4;
            this.btnShowIcon.Text = "Show Icon";
            this.btnShowIcon.UseVisualStyleBackColor = true;
            this.btnShowIcon.Click += new System.EventHandler(this.btnShowIcon_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowIcon);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.radioJava);
            this.Controls.Add(this.radioPhp);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioPhp;
        private System.Windows.Forms.RadioButton radioJava;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnShowIcon;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}