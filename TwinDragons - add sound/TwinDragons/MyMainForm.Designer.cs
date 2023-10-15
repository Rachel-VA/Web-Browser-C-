namespace TwinDragons
{
    partial class MyMainForm
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.webBrowserDisplay = new System.Windows.Forms.WebBrowser();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPlayMusic = new System.Windows.Forms.Button();
            this.buttonLinkTextReader = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonBookMark = new System.Windows.Forms.Button();
            this.buttonWaze = new System.Windows.Forms.Button();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonBing = new System.Windows.Forms.Button();
            this.buttonInstagram = new System.Windows.Forms.Button();
            this.buttonChrome = new System.Windows.Forms.Button();
            this.buttonFaceBook = new System.Windows.Forms.Button();
            this.buttonLinkedIn = new System.Windows.Forms.Button();
            this.buttonAmazon = new System.Windows.Forms.Button();
            this.buttonYouTube = new System.Windows.Forms.Button();
            this.buttonFireFox = new System.Windows.Forms.Button();
            this.buttonMSEdge = new System.Windows.Forms.Button();
            this.buttonGoogle = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelWebBrowser = new System.Windows.Forms.Label();
            this.comboBoxWebSite = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSave = new System.Windows.Forms.TabPage();
            this.buttonHideFavorite = new System.Windows.Forms.Button();
            this.buttonClearfavorite = new System.Windows.Forms.Button();
            this.Favorites = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonHideHistory = new System.Windows.Forms.Button();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.ListBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonStopMusic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSave.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Image = global::TwinDragons.Properties.Resources.Search_icon__1_;
            this.buttonSearch.Location = new System.Drawing.Point(920, 46);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(51, 38);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxURL
            // 
            this.textBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURL.Location = new System.Drawing.Point(404, 46);
            this.textBoxURL.Multiline = true;
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(517, 35);
            this.textBoxURL.TabIndex = 1;
            this.textBoxURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webBrowserDisplay
            // 
            this.webBrowserDisplay.Location = new System.Drawing.Point(-1, 150);
            this.webBrowserDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserDisplay.Name = "webBrowserDisplay";
            this.webBrowserDisplay.ScriptErrorsSuppressed = true;
            this.webBrowserDisplay.Size = new System.Drawing.Size(1300, 577);
            this.webBrowserDisplay.TabIndex = 2;
            this.webBrowserDisplay.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserDisplay_DocumentCompleted);
            this.webBrowserDisplay.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowserDisplay_ProgressChanged);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.Color.Silver;
            this.buttonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.Location = new System.Drawing.Point(967, 44);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(48, 35);
            this.buttonForward.TabIndex = 3;
            this.buttonForward.Text = ">>";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonBackward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackward.Location = new System.Drawing.Point(1007, 44);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(46, 35);
            this.buttonBackward.TabIndex = 4;
            this.buttonBackward.Text = "<<";
            this.buttonBackward.UseVisualStyleBackColor = false;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Image = global::TwinDragons.Properties.Resources.refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(1059, 44);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(44, 35);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.White;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Image = global::TwinDragons.Properties.Resources.print;
            this.buttonPrint.Location = new System.Drawing.Point(1155, 43);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(47, 35);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonPreview
            // 
            this.buttonPreview.BackColor = System.Drawing.Color.Gray;
            this.buttonPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreview.Image = global::TwinDragons.Properties.Resources.preview2;
            this.buttonPreview.Location = new System.Drawing.Point(1109, 43);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(40, 35);
            this.buttonPreview.TabIndex = 7;
            this.buttonPreview.UseVisualStyleBackColor = false;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.buttonStopMusic);
            this.panel1.Controls.Add(this.buttonPlayMusic);
            this.panel1.Controls.Add(this.buttonLinkTextReader);
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.buttonBookMark);
            this.panel1.Controls.Add(this.buttonWaze);
            this.panel1.Controls.Add(this.buttonMap);
            this.panel1.Controls.Add(this.buttonBing);
            this.panel1.Controls.Add(this.buttonInstagram);
            this.panel1.Controls.Add(this.buttonChrome);
            this.panel1.Controls.Add(this.buttonFaceBook);
            this.panel1.Controls.Add(this.buttonLinkedIn);
            this.panel1.Controls.Add(this.buttonAmazon);
            this.panel1.Controls.Add(this.buttonYouTube);
            this.panel1.Controls.Add(this.buttonFireFox);
            this.panel1.Controls.Add(this.buttonMSEdge);
            this.panel1.Controls.Add(this.buttonGoogle);
            this.panel1.Location = new System.Drawing.Point(-1, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 50);
            this.panel1.TabIndex = 8;
            // 
            // buttonPlayMusic
            // 
            this.buttonPlayMusic.BackColor = System.Drawing.Color.Violet;
            this.buttonPlayMusic.Location = new System.Drawing.Point(668, 9);
            this.buttonPlayMusic.Name = "buttonPlayMusic";
            this.buttonPlayMusic.Size = new System.Drawing.Size(55, 37);
            this.buttonPlayMusic.TabIndex = 17;
            this.buttonPlayMusic.Text = "Music";
            this.buttonPlayMusic.UseVisualStyleBackColor = false;
            this.buttonPlayMusic.Click += new System.EventHandler(this.buttonPlayMusic_Click);
            // 
            // buttonLinkTextReader
            // 
            this.buttonLinkTextReader.BackColor = System.Drawing.Color.Chocolate;
            this.buttonLinkTextReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLinkTextReader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLinkTextReader.Location = new System.Drawing.Point(827, 3);
            this.buttonLinkTextReader.Name = "buttonLinkTextReader";
            this.buttonLinkTextReader.Size = new System.Drawing.Size(94, 45);
            this.buttonLinkTextReader.TabIndex = 16;
            this.buttonLinkTextReader.Text = "Text Reader";
            this.buttonLinkTextReader.UseVisualStyleBackColor = false;
            this.buttonLinkTextReader.Click += new System.EventHandler(this.buttonLinkTextReader_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.Black;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonShow.Location = new System.Drawing.Point(1156, 0);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(90, 53);
            this.buttonShow.TabIndex = 15;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            this.buttonShow.MouseLeave += new System.EventHandler(this.buttonHistory_MouseLeave);
            this.buttonShow.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // buttonBookMark
            // 
            this.buttonBookMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonBookMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookMark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBookMark.Location = new System.Drawing.Point(1029, 0);
            this.buttonBookMark.Name = "buttonBookMark";
            this.buttonBookMark.Size = new System.Drawing.Size(100, 51);
            this.buttonBookMark.TabIndex = 14;
            this.buttonBookMark.Text = "Book Mark";
            this.buttonBookMark.UseVisualStyleBackColor = false;
            this.buttonBookMark.Click += new System.EventHandler(this.buttonBookMark_Click);
            this.buttonBookMark.MouseLeave += new System.EventHandler(this.buttonFavorite_MouseLeave);
            this.buttonBookMark.MouseHover += new System.EventHandler(this.buttonFavorite_MouseHover);
            // 
            // buttonWaze
            // 
            this.buttonWaze.Image = global::TwinDragons.Properties.Resources.waze;
            this.buttonWaze.Location = new System.Drawing.Point(307, 3);
            this.buttonWaze.Name = "buttonWaze";
            this.buttonWaze.Size = new System.Drawing.Size(45, 45);
            this.buttonWaze.TabIndex = 13;
            this.buttonWaze.UseVisualStyleBackColor = true;
            this.buttonWaze.Click += new System.EventHandler(this.buttonWaze_Click);
            // 
            // buttonMap
            // 
            this.buttonMap.Image = global::TwinDragons.Properties.Resources.googlemaps;
            this.buttonMap.Location = new System.Drawing.Point(491, 4);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(45, 45);
            this.buttonMap.TabIndex = 12;
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // buttonBing
            // 
            this.buttonBing.Image = global::TwinDragons.Properties.Resources.binglogo;
            this.buttonBing.Location = new System.Drawing.Point(542, 2);
            this.buttonBing.Name = "buttonBing";
            this.buttonBing.Size = new System.Drawing.Size(45, 45);
            this.buttonBing.TabIndex = 11;
            this.buttonBing.UseVisualStyleBackColor = true;
            this.buttonBing.Click += new System.EventHandler(this.buttonBing_Click);
            // 
            // buttonInstagram
            // 
            this.buttonInstagram.Image = global::TwinDragons.Properties.Resources.Instagram;
            this.buttonInstagram.Location = new System.Drawing.Point(156, 4);
            this.buttonInstagram.Name = "buttonInstagram";
            this.buttonInstagram.Size = new System.Drawing.Size(45, 45);
            this.buttonInstagram.TabIndex = 10;
            this.buttonInstagram.UseVisualStyleBackColor = true;
            this.buttonInstagram.Click += new System.EventHandler(this.buttonInstagram_Click);
            // 
            // buttonChrome
            // 
            this.buttonChrome.Image = global::TwinDragons.Properties.Resources.Gchrome;
            this.buttonChrome.Location = new System.Drawing.Point(105, 4);
            this.buttonChrome.Name = "buttonChrome";
            this.buttonChrome.Size = new System.Drawing.Size(45, 45);
            this.buttonChrome.TabIndex = 9;
            this.buttonChrome.UseVisualStyleBackColor = true;
            this.buttonChrome.Click += new System.EventHandler(this.buttonChrome_Click);
            // 
            // buttonFaceBook
            // 
            this.buttonFaceBook.Image = global::TwinDragons.Properties.Resources.facebook_icon;
            this.buttonFaceBook.Location = new System.Drawing.Point(258, 2);
            this.buttonFaceBook.Name = "buttonFaceBook";
            this.buttonFaceBook.Size = new System.Drawing.Size(45, 45);
            this.buttonFaceBook.TabIndex = 6;
            this.buttonFaceBook.UseVisualStyleBackColor = true;
            this.buttonFaceBook.Click += new System.EventHandler(this.buttonFaceBook_Click);
            // 
            // buttonLinkedIn
            // 
            this.buttonLinkedIn.Image = global::TwinDragons.Properties.Resources.LinkedIn;
            this.buttonLinkedIn.Location = new System.Drawing.Point(207, 3);
            this.buttonLinkedIn.Name = "buttonLinkedIn";
            this.buttonLinkedIn.Size = new System.Drawing.Size(45, 45);
            this.buttonLinkedIn.TabIndex = 5;
            this.buttonLinkedIn.UseVisualStyleBackColor = true;
            this.buttonLinkedIn.Click += new System.EventHandler(this.buttonLinkedIn_Click);
            // 
            // buttonAmazon
            // 
            this.buttonAmazon.Image = global::TwinDragons.Properties.Resources.Amazon;
            this.buttonAmazon.Location = new System.Drawing.Point(429, 4);
            this.buttonAmazon.Name = "buttonAmazon";
            this.buttonAmazon.Size = new System.Drawing.Size(45, 45);
            this.buttonAmazon.TabIndex = 4;
            this.buttonAmazon.UseVisualStyleBackColor = true;
            this.buttonAmazon.Click += new System.EventHandler(this.buttonAmazon_Click);
            // 
            // buttonYouTube
            // 
            this.buttonYouTube.Image = global::TwinDragons.Properties.Resources.YouTube_logo;
            this.buttonYouTube.Location = new System.Drawing.Point(366, 4);
            this.buttonYouTube.Name = "buttonYouTube";
            this.buttonYouTube.Size = new System.Drawing.Size(45, 45);
            this.buttonYouTube.TabIndex = 3;
            this.buttonYouTube.UseVisualStyleBackColor = true;
            this.buttonYouTube.Click += new System.EventHandler(this.buttonYouTube_Click);
            // 
            // buttonFireFox
            // 
            this.buttonFireFox.Image = global::TwinDragons.Properties.Resources.mozilla_firefox;
            this.buttonFireFox.Location = new System.Drawing.Point(54, 3);
            this.buttonFireFox.Name = "buttonFireFox";
            this.buttonFireFox.Size = new System.Drawing.Size(45, 45);
            this.buttonFireFox.TabIndex = 2;
            this.buttonFireFox.UseVisualStyleBackColor = true;
            this.buttonFireFox.Click += new System.EventHandler(this.buttonFireFox_Click);
            // 
            // buttonMSEdge
            // 
            this.buttonMSEdge.Image = global::TwinDragons.Properties.Resources.microsoftedge;
            this.buttonMSEdge.Location = new System.Drawing.Point(3, 3);
            this.buttonMSEdge.Name = "buttonMSEdge";
            this.buttonMSEdge.Size = new System.Drawing.Size(45, 45);
            this.buttonMSEdge.TabIndex = 1;
            this.buttonMSEdge.UseVisualStyleBackColor = true;
            this.buttonMSEdge.Click += new System.EventHandler(this.buttonMSEdge_Click);
            // 
            // buttonGoogle
            // 
            this.buttonGoogle.Image = global::TwinDragons.Properties.Resources.google;
            this.buttonGoogle.Location = new System.Drawing.Point(593, 5);
            this.buttonGoogle.Name = "buttonGoogle";
            this.buttonGoogle.Size = new System.Drawing.Size(45, 45);
            this.buttonGoogle.TabIndex = 0;
            this.buttonGoogle.UseVisualStyleBackColor = true;
            this.buttonGoogle.Click += new System.EventHandler(this.buttonGoogle_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Image = global::TwinDragons.Properties.Resources.icon_home;
            this.buttonHome.Location = new System.Drawing.Point(1208, 41);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(49, 39);
            this.buttonHome.TabIndex = 9;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(13, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(48, 20);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(12, 46);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(47, 20);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendar.Location = new System.Drawing.Point(331, 43);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(67, 39);
            this.buttonCalendar.TabIndex = 12;
            this.buttonCalendar.Text = "Calendar";
            this.buttonCalendar.UseVisualStyleBackColor = false;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(-1, 85);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1308, 10);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // labelWebBrowser
            // 
            this.labelWebBrowser.AutoSize = true;
            this.labelWebBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWebBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebBrowser.ForeColor = System.Drawing.Color.White;
            this.labelWebBrowser.Location = new System.Drawing.Point(304, 4);
            this.labelWebBrowser.Name = "labelWebBrowser";
            this.labelWebBrowser.Size = new System.Drawing.Size(94, 24);
            this.labelWebBrowser.TabIndex = 14;
            this.labelWebBrowser.Text = "Web Site";
            // 
            // comboBoxWebSite
            // 
            this.comboBoxWebSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWebSite.FormattingEnabled = true;
            this.comboBoxWebSite.Location = new System.Drawing.Point(404, 0);
            this.comboBoxWebSite.Name = "comboBoxWebSite";
            this.comboBoxWebSite.Size = new System.Drawing.Size(710, 26);
            this.comboBoxWebSite.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSave);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1018, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(226, 407);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPageSave
            // 
            this.tabPageSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageSave.Controls.Add(this.buttonHideFavorite);
            this.tabPageSave.Controls.Add(this.buttonClearfavorite);
            this.tabPageSave.Controls.Add(this.Favorites);
            this.tabPageSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageSave.Location = new System.Drawing.Point(4, 22);
            this.tabPageSave.Name = "tabPageSave";
            this.tabPageSave.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSave.Size = new System.Drawing.Size(218, 381);
            this.tabPageSave.TabIndex = 0;
            this.tabPageSave.Text = "Favorites";
            // 
            // buttonHideFavorite
            // 
            this.buttonHideFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonHideFavorite.Location = new System.Drawing.Point(122, 329);
            this.buttonHideFavorite.Name = "buttonHideFavorite";
            this.buttonHideFavorite.Size = new System.Drawing.Size(75, 29);
            this.buttonHideFavorite.TabIndex = 20;
            this.buttonHideFavorite.Text = "Hide";
            this.buttonHideFavorite.UseVisualStyleBackColor = false;
            this.buttonHideFavorite.Click += new System.EventHandler(this.buttonHideFavorite_Click);
            // 
            // buttonClearfavorite
            // 
            this.buttonClearfavorite.BackColor = System.Drawing.Color.Magenta;
            this.buttonClearfavorite.Location = new System.Drawing.Point(17, 329);
            this.buttonClearfavorite.Name = "buttonClearfavorite";
            this.buttonClearfavorite.Size = new System.Drawing.Size(75, 29);
            this.buttonClearfavorite.TabIndex = 19;
            this.buttonClearfavorite.Text = "Clear";
            this.buttonClearfavorite.UseVisualStyleBackColor = false;
            this.buttonClearfavorite.Click += new System.EventHandler(this.button2_Click);
            // 
            // Favorites
            // 
            this.Favorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Favorites.FormattingEnabled = true;
            this.Favorites.ItemHeight = 15;
            this.Favorites.Location = new System.Drawing.Point(6, 6);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(206, 304);
            this.Favorites.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Green;
            this.tabPage2.Controls.Add(this.buttonHideHistory);
            this.tabPage2.Controls.Add(this.buttonClearHistory);
            this.tabPage2.Controls.Add(this.History);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(218, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            // 
            // buttonHideHistory
            // 
            this.buttonHideHistory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHideHistory.Location = new System.Drawing.Point(122, 346);
            this.buttonHideHistory.Name = "buttonHideHistory";
            this.buttonHideHistory.Size = new System.Drawing.Size(75, 29);
            this.buttonHideHistory.TabIndex = 18;
            this.buttonHideHistory.Text = "Hide";
            this.buttonHideHistory.UseVisualStyleBackColor = false;
            this.buttonHideHistory.Click += new System.EventHandler(this.buttonHideHistory_Click);
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonClearHistory.Location = new System.Drawing.Point(17, 346);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(75, 29);
            this.buttonClearHistory.TabIndex = 17;
            this.buttonClearHistory.Text = "Clear";
            this.buttonClearHistory.UseVisualStyleBackColor = false;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.History.FormattingEnabled = true;
            this.History.ItemHeight = 15;
            this.History.Location = new System.Drawing.Point(6, 6);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(209, 334);
            this.History.TabIndex = 1;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.ForeColor = System.Drawing.Color.MintCream;
            this.buttonGo.Location = new System.Drawing.Point(1120, -7);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(40, 40);
            this.buttonGo.TabIndex = 16;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click_1);
            // 
            // buttonStopMusic
            // 
            this.buttonStopMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopMusic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStopMusic.Location = new System.Drawing.Point(729, 11);
            this.buttonStopMusic.Name = "buttonStopMusic";
            this.buttonStopMusic.Size = new System.Drawing.Size(55, 37);
            this.buttonStopMusic.TabIndex = 18;
            this.buttonStopMusic.Text = "Stop Music";
            this.buttonStopMusic.UseVisualStyleBackColor = false;
            this.buttonStopMusic.Click += new System.EventHandler(this.buttonStopMusic_Click);
            // 
            // MyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TwinDragons.Properties.Resources.bea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1306, 592);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBoxWebSite);
            this.Controls.Add(this.labelWebBrowser);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCalendar);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPreview);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBackward);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.webBrowserDisplay);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.buttonSearch);
            this.Name = "MyMainForm";
            this.Text = "RPhuongForm";
            this.Load += new System.EventHandler(this.MyMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSave.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.WebBrowser webBrowserDisplay;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGoogle;
        private System.Windows.Forms.Button buttonMSEdge;
        private System.Windows.Forms.Button buttonFaceBook;
        private System.Windows.Forms.Button buttonLinkedIn;
        private System.Windows.Forms.Button buttonAmazon;
        private System.Windows.Forms.Button buttonYouTube;
        private System.Windows.Forms.Button buttonFireFox;
        private System.Windows.Forms.Button buttonChrome;
        private System.Windows.Forms.Button buttonInstagram;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonBing;
        private System.Windows.Forms.Button buttonWaze;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelWebBrowser;
        private System.Windows.Forms.ComboBox comboBoxWebSite;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonBookMark;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSave;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox Favorites;
        private System.Windows.Forms.ListBox History;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonHideFavorite;
        private System.Windows.Forms.Button buttonClearfavorite;
        private System.Windows.Forms.Button buttonHideHistory;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.Button buttonLinkTextReader;
        private System.Windows.Forms.Button buttonPlayMusic;
        private System.Windows.Forms.Button buttonStopMusic;
    }
}

