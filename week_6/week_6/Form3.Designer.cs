namespace week_6
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnStretchImage = new System.Windows.Forms.RadioButton();
            this.radioBtnZoom = new System.Windows.Forms.RadioButton();
            this.radioBtnAutoSize = new System.Windows.Forms.RadioButton();
            this.radioBtnNormal = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnStretchImage);
            this.groupBox1.Controls.Add(this.radioBtnZoom);
            this.groupBox1.Controls.Add(this.radioBtnAutoSize);
            this.groupBox1.Controls.Add(this.radioBtnNormal);
            this.groupBox1.Location = new System.Drawing.Point(340, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size Mod";
            // 
            // radioBtnStretchImage
            // 
            this.radioBtnStretchImage.AutoSize = true;
            this.radioBtnStretchImage.Location = new System.Drawing.Point(5, 113);
            this.radioBtnStretchImage.Name = "radioBtnStretchImage";
            this.radioBtnStretchImage.Size = new System.Drawing.Size(107, 20);
            this.radioBtnStretchImage.TabIndex = 0;
            this.radioBtnStretchImage.TabStop = true;
            this.radioBtnStretchImage.Text = "StretchImage";
            this.radioBtnStretchImage.UseVisualStyleBackColor = true;
            this.radioBtnStretchImage.CheckedChanged += new System.EventHandler(this.sizeMode);
            // 
            // radioBtnZoom
            // 
            this.radioBtnZoom.AutoSize = true;
            this.radioBtnZoom.Location = new System.Drawing.Point(5, 87);
            this.radioBtnZoom.Name = "radioBtnZoom";
            this.radioBtnZoom.Size = new System.Drawing.Size(63, 20);
            this.radioBtnZoom.TabIndex = 0;
            this.radioBtnZoom.TabStop = true;
            this.radioBtnZoom.Text = "Zoom";
            this.radioBtnZoom.UseVisualStyleBackColor = true;
            this.radioBtnZoom.CheckedChanged += new System.EventHandler(this.sizeMode);
            // 
            // radioBtnAutoSize
            // 
            this.radioBtnAutoSize.AutoSize = true;
            this.radioBtnAutoSize.Location = new System.Drawing.Point(5, 61);
            this.radioBtnAutoSize.Name = "radioBtnAutoSize";
            this.radioBtnAutoSize.Size = new System.Drawing.Size(84, 20);
            this.radioBtnAutoSize.TabIndex = 0;
            this.radioBtnAutoSize.TabStop = true;
            this.radioBtnAutoSize.Text = "Auto Size";
            this.radioBtnAutoSize.UseVisualStyleBackColor = true;
            this.radioBtnAutoSize.CheckedChanged += new System.EventHandler(this.sizeMode);
            // 
            // radioBtnNormal
            // 
            this.radioBtnNormal.AutoSize = true;
            this.radioBtnNormal.Location = new System.Drawing.Point(5, 35);
            this.radioBtnNormal.Name = "radioBtnNormal";
            this.radioBtnNormal.Size = new System.Drawing.Size(72, 20);
            this.radioBtnNormal.TabIndex = 0;
            this.radioBtnNormal.TabStop = true;
            this.radioBtnNormal.Text = "Normal";
            this.radioBtnNormal.UseVisualStyleBackColor = true;
            this.radioBtnNormal.CheckedChanged += new System.EventHandler(this.sizeMode);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnStretchImage;
        private System.Windows.Forms.RadioButton radioBtnZoom;
        private System.Windows.Forms.RadioButton radioBtnAutoSize;
        private System.Windows.Forms.RadioButton radioBtnNormal;
        private System.Windows.Forms.Timer timer1;
    }
}