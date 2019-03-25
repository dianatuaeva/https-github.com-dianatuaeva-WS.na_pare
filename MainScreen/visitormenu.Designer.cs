namespace MainScreen
{
    partial class visitormenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelNba = new System.Windows.Forms.Label();
            this.labelVisitormenu = new System.Windows.Forms.Label();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.paneltobutton = new System.Windows.Forms.Panel();
            this.buttonPlayers = new System.Windows.Forms.Button();
            this.buttonTeams = new System.Windows.Forms.Button();
            this.buttonMatchups = new System.Windows.Forms.Button();
            this.buttonPhotos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelinfo.SuspendLayout();
            this.paneltobutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelVisitormenu);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.labelNba);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = global::MainScreen.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(63, 98);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(704, 33);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 21);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // labelNba
            // 
            this.labelNba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNba.AutoSize = true;
            this.labelNba.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNba.Location = new System.Drawing.Point(69, 41);
            this.labelNba.Name = "labelNba";
            this.labelNba.Size = new System.Drawing.Size(131, 13);
            this.labelNba.TabIndex = 1;
            this.labelNba.Text = "NBA Management System";
            // 
            // labelVisitormenu
            // 
            this.labelVisitormenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelVisitormenu.AutoSize = true;
            this.labelVisitormenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVisitormenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelVisitormenu.Location = new System.Drawing.Point(345, 37);
            this.labelVisitormenu.Name = "labelVisitormenu";
            this.labelVisitormenu.Size = new System.Drawing.Size(115, 24);
            this.labelVisitormenu.TabIndex = 4;
            this.labelVisitormenu.Text = "Visitor menu";
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panelinfo.Controls.Add(this.labelInfo);
            this.panelinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelinfo.Location = new System.Drawing.Point(0, 419);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(806, 31);
            this.panelinfo.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo.Location = new System.Drawing.Point(0, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(806, 31);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "The current season is 2016–2017, and the NBA already has a history of 71 years";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // paneltobutton
            // 
            this.paneltobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paneltobutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltobutton.Controls.Add(this.buttonPhotos);
            this.paneltobutton.Controls.Add(this.buttonMatchups);
            this.paneltobutton.Controls.Add(this.buttonPlayers);
            this.paneltobutton.Controls.Add(this.buttonTeams);
            this.paneltobutton.Location = new System.Drawing.Point(22, 150);
            this.paneltobutton.Name = "paneltobutton";
            this.paneltobutton.Size = new System.Drawing.Size(758, 222);
            this.paneltobutton.TabIndex = 2;
            // 
            // buttonPlayers
            // 
            this.buttonPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonPlayers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlayers.Location = new System.Drawing.Point(424, 37);
            this.buttonPlayers.Name = "buttonPlayers";
            this.buttonPlayers.Size = new System.Drawing.Size(151, 49);
            this.buttonPlayers.TabIndex = 1;
            this.buttonPlayers.Text = "Players";
            this.buttonPlayers.UseVisualStyleBackColor = false;
            // 
            // buttonTeams
            // 
            this.buttonTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonTeams.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTeams.Location = new System.Drawing.Point(180, 37);
            this.buttonTeams.Name = "buttonTeams";
            this.buttonTeams.Size = new System.Drawing.Size(151, 49);
            this.buttonTeams.TabIndex = 0;
            this.buttonTeams.Text = "Teams";
            this.buttonTeams.UseVisualStyleBackColor = false;
            // 
            // buttonMatchups
            // 
            this.buttonMatchups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMatchups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonMatchups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMatchups.Location = new System.Drawing.Point(180, 128);
            this.buttonMatchups.Name = "buttonMatchups";
            this.buttonMatchups.Size = new System.Drawing.Size(151, 48);
            this.buttonMatchups.TabIndex = 2;
            this.buttonMatchups.Text = "Matchups";
            this.buttonMatchups.UseVisualStyleBackColor = false;
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonPhotos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPhotos.Location = new System.Drawing.Point(424, 128);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(151, 48);
            this.buttonPhotos.TabIndex = 3;
            this.buttonPhotos.Text = "Photos";
            this.buttonPhotos.UseVisualStyleBackColor = false;
            // 
            // visitormenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.paneltobutton);
            this.Controls.Add(this.panelinfo);
            this.Controls.Add(this.panel1);
            this.Name = "visitormenu";
            this.Text = "visitormenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelinfo.ResumeLayout(false);
            this.paneltobutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelNba;
        private System.Windows.Forms.Label labelVisitormenu;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel paneltobutton;
        private System.Windows.Forms.Button buttonPhotos;
        private System.Windows.Forms.Button buttonMatchups;
        private System.Windows.Forms.Button buttonPlayers;
        private System.Windows.Forms.Button buttonTeams;
    }
}