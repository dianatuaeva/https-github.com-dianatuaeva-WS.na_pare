namespace MainScreen
{
    partial class FormMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainScreen));
            this.panelinfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.labelwelcom = new System.Windows.Forms.Label();
            this.labelmanangment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.panelphoto = new System.Windows.Forms.Panel();
            this.buttonleft = new System.Windows.Forms.Button();
            this.buttonright = new System.Windows.Forms.Button();
            this.pictureBoxphoto1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxphoto2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxphoto3 = new System.Windows.Forms.PictureBox();
            this.panelinfo.SuspendLayout();
            this.paneltitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelphoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panelinfo.Controls.Add(this.label1);
            this.panelinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinfo.Location = new System.Drawing.Point(0, 419);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(800, 31);
            this.panelinfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "The current season is 2016–2017, and the NBA already has a history of 71 years";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.White;
            this.paneltitle.Controls.Add(this.labelwelcom);
            this.paneltitle.Controls.Add(this.labelmanangment);
            this.paneltitle.Controls.Add(this.pictureBox1);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(800, 120);
            this.paneltitle.TabIndex = 2;
            // 
            // labelwelcom
            // 
            this.labelwelcom.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelwelcom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelwelcom.Location = new System.Drawing.Point(63, 63);
            this.labelwelcom.Name = "labelwelcom";
            this.labelwelcom.Size = new System.Drawing.Size(737, 57);
            this.labelwelcom.TabIndex = 2;
            this.labelwelcom.Text = "Welcome to use this NBA Management system, you can redirect to different pages ac" +
    "cording to your role by clicking the buttons bellow.\r\n\r\n";
            this.labelwelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelmanangment
            // 
            this.labelmanangment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelmanangment.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmanangment.Location = new System.Drawing.Point(63, 0);
            this.labelmanangment.Name = "labelmanangment";
            this.labelmanangment.Size = new System.Drawing.Size(737, 63);
            this.labelmanangment.TabIndex = 1;
            this.labelmanangment.Text = "NBA Management System";
            this.labelmanangment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.Color.Pink;
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbutton.Location = new System.Drawing.Point(0, 120);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(800, 120);
            this.panelbutton.TabIndex = 3;
            // 
            // panelphoto
            // 
            this.panelphoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelphoto.BackColor = System.Drawing.Color.White;
            this.panelphoto.Controls.Add(this.pictureBoxphoto3);
            this.panelphoto.Controls.Add(this.pictureBoxphoto2);
            this.panelphoto.Controls.Add(this.pictureBoxphoto1);
            this.panelphoto.Controls.Add(this.buttonright);
            this.panelphoto.Controls.Add(this.buttonleft);
            this.panelphoto.Location = new System.Drawing.Point(0, 240);
            this.panelphoto.Name = "panelphoto";
            this.panelphoto.Size = new System.Drawing.Size(800, 179);
            this.panelphoto.TabIndex = 4;
            // 
            // buttonleft
            // 
            this.buttonleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonleft.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonleft.Location = new System.Drawing.Point(0, 0);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(44, 179);
            this.buttonleft.TabIndex = 0;
            this.buttonleft.Text = "<";
            this.buttonleft.UseVisualStyleBackColor = true;
            // 
            // buttonright
            // 
            this.buttonright.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonright.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonright.Location = new System.Drawing.Point(750, 0);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(50, 179);
            this.buttonright.TabIndex = 1;
            this.buttonright.Text = ">";
            this.buttonright.UseVisualStyleBackColor = true;
            // 
            // pictureBoxphoto1
            // 
            this.pictureBoxphoto1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBoxphoto1.Location = new System.Drawing.Point(66, 30);
            this.pictureBoxphoto1.Name = "pictureBoxphoto1";
            this.pictureBoxphoto1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxphoto1.Size = new System.Drawing.Size(165, 122);
            this.pictureBoxphoto1.TabIndex = 2;
            this.pictureBoxphoto1.TabStop = false;
            // 
            // pictureBoxphoto2
            // 
            this.pictureBoxphoto2.BackColor = System.Drawing.Color.Maroon;
            this.pictureBoxphoto2.Location = new System.Drawing.Point(318, 28);
            this.pictureBoxphoto2.Name = "pictureBoxphoto2";
            this.pictureBoxphoto2.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxphoto2.Size = new System.Drawing.Size(165, 122);
            this.pictureBoxphoto2.TabIndex = 3;
            this.pictureBoxphoto2.TabStop = false;
            // 
            // pictureBoxphoto3
            // 
            this.pictureBoxphoto3.BackColor = System.Drawing.Color.Maroon;
            this.pictureBoxphoto3.Location = new System.Drawing.Point(563, 28);
            this.pictureBoxphoto3.Name = "pictureBoxphoto3";
            this.pictureBoxphoto3.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxphoto3.Size = new System.Drawing.Size(165, 122);
            this.pictureBoxphoto3.TabIndex = 4;
            this.pictureBoxphoto3.TabStop = false;
            // 
            // FormMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelphoto);
            this.Controls.Add(this.panelbutton);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelinfo);
            this.Name = "FormMainScreen";
            this.Text = "Main Screen";
            this.panelinfo.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelphoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxphoto3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Panel panelbutton;
        private System.Windows.Forms.Panel panelphoto;
        private System.Windows.Forms.Label labelwelcom;
        private System.Windows.Forms.Label labelmanangment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.PictureBox pictureBoxphoto1;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.PictureBox pictureBoxphoto3;
        private System.Windows.Forms.PictureBox pictureBoxphoto2;
    }
}

