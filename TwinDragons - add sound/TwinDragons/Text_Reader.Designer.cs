namespace TwinDragons
{
    partial class Text_Reader
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
            this.panelContainButtons = new System.Windows.Forms.Panel();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelContainButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainButtons
            // 
            this.panelContainButtons.BackColor = System.Drawing.Color.Black;
            this.panelContainButtons.Controls.Add(this.buttonRead);
            this.panelContainButtons.Controls.Add(this.buttonStop);
            this.panelContainButtons.Controls.Add(this.buttonPause);
            this.panelContainButtons.Controls.Add(this.buttonResume);
            this.panelContainButtons.Controls.Add(this.buttonFolder);
            this.panelContainButtons.Location = new System.Drawing.Point(12, 3);
            this.panelContainButtons.Name = "panelContainButtons";
            this.panelContainButtons.Size = new System.Drawing.Size(1067, 74);
            this.panelContainButtons.TabIndex = 0;
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.Color.Transparent;
            this.buttonRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRead.Image = global::TwinDragons.Properties.Resources.speaker;
            this.buttonRead.Location = new System.Drawing.Point(109, 15);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(45, 45);
            this.buttonRead.TabIndex = 4;
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BackgroundImage = global::TwinDragons.Properties.Resources.stop;
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.Image = global::TwinDragons.Properties.Resources.stopbnt;
            this.buttonStop.Location = new System.Drawing.Point(356, 15);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(45, 45);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonPause.Image = global::TwinDragons.Properties.Resources.pause;
            this.buttonPause.Location = new System.Drawing.Point(193, 15);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(45, 45);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.Transparent;
            this.buttonResume.Image = global::TwinDragons.Properties.Resources.resume;
            this.buttonResume.Location = new System.Drawing.Point(284, 15);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(45, 45);
            this.buttonResume.TabIndex = 1;
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.BackColor = System.Drawing.Color.Transparent;
            this.buttonFolder.Image = global::TwinDragons.Properties.Resources.open;
            this.buttonFolder.Location = new System.Drawing.Point(19, 15);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(45, 45);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.UseVisualStyleBackColor = false;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.BackColor = System.Drawing.Color.Plum;
            this.labelText.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.Green;
            this.labelText.Location = new System.Drawing.Point(222, 80);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(650, 980);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "please upload your text here to enable reader";
            this.labelText.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 160;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Text_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1091, 485);
            this.Controls.Add(this.panelContainButtons);
            this.Controls.Add(this.labelText);
            this.Name = "Text_Reader";
            this.Text = "Text_Reader";
            this.Load += new System.EventHandler(this.Text_Reader_Load);
            this.panelContainButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainButtons;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}