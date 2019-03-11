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
            this.labelInfo = new System.Windows.Forms.Label();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.labelwelcom = new System.Windows.Forms.Label();
            this.labelmanangment = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.panelphoto = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonright = new System.Windows.Forms.Button();
            this.buttonleft = new System.Windows.Forms.Button();
            this.paneltobutton = new System.Windows.Forms.Panel();
            this.buttonVisitor = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.panelinfo.SuspendLayout();
            this.paneltitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelbutton.SuspendLayout();
            this.panelphoto.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.paneltobutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panelinfo.Controls.Add(this.labelInfo);
            this.panelinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinfo.Location = new System.Drawing.Point(0, 535);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(1038, 31);
            this.panelinfo.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Location = new System.Drawing.Point(0, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(1038, 31);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "The current season is 2016–2017, and the NBA already has a history of 71 years";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.White;
            this.paneltitle.Controls.Add(this.labelwelcom);
            this.paneltitle.Controls.Add(this.labelmanangment);
            this.paneltitle.Controls.Add(this.pictureBoxLogo);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1038, 120);
            this.paneltitle.TabIndex = 2;
            // 
            // labelwelcom
            // 
            this.labelwelcom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelwelcom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelwelcom.Location = new System.Drawing.Point(63, 63);
            this.labelwelcom.Name = "labelwelcom";
            this.labelwelcom.Size = new System.Drawing.Size(975, 57);
            this.labelwelcom.TabIndex = 2;
            this.labelwelcom.Text = "Welcome to use this NBA Management system, you can redirect to different pages ac" +
    "cording to your role by clicking the buttons bellow.\r\n\r\n";
            this.labelwelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelwelcom.UseWaitCursor = true;
            // 
            // labelmanangment
            // 
            this.labelmanangment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelmanangment.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmanangment.Location = new System.Drawing.Point(63, 0);
            this.labelmanangment.Name = "labelmanangment";
            this.labelmanangment.Size = new System.Drawing.Size(975, 63);
            this.labelmanangment.TabIndex = 1;
            this.labelmanangment.Text = "NBA Management System";
            this.labelmanangment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(63, 120);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.Color.White;
            this.panelbutton.Controls.Add(this.paneltobutton);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbutton.Location = new System.Drawing.Point(0, 120);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(1038, 212);
            this.panelbutton.TabIndex = 3;
            // 
            // panelphoto
            // 
            this.panelphoto.BackColor = System.Drawing.Color.White;
            this.panelphoto.Controls.Add(this.tableLayoutPanel1);
            this.panelphoto.Controls.Add(this.buttonright);
            this.panelphoto.Controls.Add(this.buttonleft);
            this.panelphoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelphoto.Location = new System.Drawing.Point(0, 332);
            this.panelphoto.Name = "panelphoto";
            this.panelphoto.Size = new System.Drawing.Size(1038, 203);
            this.panelphoto.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 203);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(317, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(631, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(310, 197);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // buttonright
            // 
            this.buttonright.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonright.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonright.Location = new System.Drawing.Point(988, 0);
            this.buttonright.Name = "buttonright";
            this.buttonright.Size = new System.Drawing.Size(50, 203);
            this.buttonright.TabIndex = 3;
            this.buttonright.Text = ">";
            this.buttonright.UseVisualStyleBackColor = true;
            this.buttonright.Click += new System.EventHandler(this.buttonright_Click);
            // 
            // buttonleft
            // 
            this.buttonleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonleft.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonleft.Location = new System.Drawing.Point(0, 0);
            this.buttonleft.Name = "buttonleft";
            this.buttonleft.Size = new System.Drawing.Size(44, 203);
            this.buttonleft.TabIndex = 0;
            this.buttonleft.Text = "<";
            this.buttonleft.UseVisualStyleBackColor = true;
            this.buttonleft.Click += new System.EventHandler(this.buttonleft_Click);
            // 
            // paneltobutton
            // 
            this.paneltobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltobutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltobutton.Controls.Add(this.buttonAdmin);
            this.paneltobutton.Controls.Add(this.buttonVisitor);
            this.paneltobutton.Location = new System.Drawing.Point(347, 50);
            this.paneltobutton.Name = "paneltobutton";
            this.paneltobutton.Size = new System.Drawing.Size(308, 100);
            this.paneltobutton.TabIndex = 0;
            // 
            // buttonVisitor
            // 
            this.buttonVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVisitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonVisitor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonVisitor.Location = new System.Drawing.Point(14, 17);
            this.buttonVisitor.Name = "buttonVisitor";
            this.buttonVisitor.Size = new System.Drawing.Size(76, 66);
            this.buttonVisitor.TabIndex = 0;
            this.buttonVisitor.Text = "Visitor";
            this.buttonVisitor.UseVisualStyleBackColor = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdmin.Location = new System.Drawing.Point(208, 17);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(76, 66);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            // 
            // FormMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 566);
            this.Controls.Add(this.panelphoto);
            this.Controls.Add(this.panelbutton);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelinfo);
            this.Name = "FormMainScreen";
            this.Text = "Main Screen";
            this.panelinfo.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelbutton.ResumeLayout(false);
            this.panelphoto.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.paneltobutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Panel panelbutton;
        private System.Windows.Forms.Panel panelphoto;
        private System.Windows.Forms.Label labelwelcom;
        private System.Windows.Forms.Label labelmanangment;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonleft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonright;
        private System.Windows.Forms.Panel paneltobutton;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonVisitor;
    }
}

