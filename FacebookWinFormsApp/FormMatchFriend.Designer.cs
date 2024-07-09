namespace BasicFacebookFeatures
{
    partial class FormMatchFriend
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxMatchFriends = new System.Windows.Forms.ListBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkedListBoxLikedPage = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxFavoriteTeams = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxCity = new System.Windows.Forms.CheckedListBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.hScrollBarMinAge = new System.Windows.Forms.HScrollBar();
            this.labelMinAge = new System.Windows.Forms.Label();
            this.hScrollBarMaxAge = new System.Windows.Forms.HScrollBar();
            this.labelMaxAge = new System.Windows.Forms.Label();
            this.labelMinAgeValue = new System.Windows.Forms.Label();
            this.labelMaxAgeValue = new System.Windows.Forms.Label();
            this.buttonCity = new System.Windows.Forms.Button();
            this.buttonLikedPage = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.listBoxUserDetails = new System.Windows.Forms.ListBox();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Location = new System.Drawing.Point(195, 613);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 35);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Match friend";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxMatchFriends
            // 
            this.listBoxMatchFriends.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxMatchFriends.FormattingEnabled = true;
            this.listBoxMatchFriends.ItemHeight = 16;
            this.listBoxMatchFriends.Location = new System.Drawing.Point(686, 24);
            this.listBoxMatchFriends.Name = "listBoxMatchFriends";
            this.listBoxMatchFriends.Size = new System.Drawing.Size(291, 164);
            this.listBoxMatchFriends.TabIndex = 5;
            this.listBoxMatchFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxMatchFriends_SelectedIndexChanged);
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxMale.Location = new System.Drawing.Point(133, 68);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(126, 45);
            this.checkBoxMale.TabIndex = 6;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxMale.UseVisualStyleBackColor = false;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkedListBoxLikedPage
            // 
            this.checkedListBoxLikedPage.FormattingEnabled = true;
            this.checkedListBoxLikedPage.Location = new System.Drawing.Point(56, 328);
            this.checkedListBoxLikedPage.Name = "checkedListBoxLikedPage";
            this.checkedListBoxLikedPage.Size = new System.Drawing.Size(431, 123);
            this.checkedListBoxLikedPage.TabIndex = 75;
            // 
            // checkedListBoxFavoriteTeams
            // 
            this.checkedListBoxFavoriteTeams.FormattingEnabled = true;
            this.checkedListBoxFavoriteTeams.Location = new System.Drawing.Point(56, 467);
            this.checkedListBoxFavoriteTeams.Name = "checkedListBoxFavoriteTeams";
            this.checkedListBoxFavoriteTeams.Size = new System.Drawing.Size(431, 140);
            this.checkedListBoxFavoriteTeams.TabIndex = 75;
            // 
            // checkedListBoxCity
            // 
            this.checkedListBoxCity.FormattingEnabled = true;
            this.checkedListBoxCity.Location = new System.Drawing.Point(56, 199);
            this.checkedListBoxCity.Name = "checkedListBoxCity";
            this.checkedListBoxCity.Size = new System.Drawing.Size(431, 123);
            this.checkedListBoxCity.TabIndex = 76;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxFemale.Checked = true;
            this.checkBoxFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxFemale.Location = new System.Drawing.Point(288, 68);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(124, 37);
            this.checkBoxFemale.TabIndex = 78;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxFemale.UseVisualStyleBackColor = false;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // labelGender
            // 
            this.labelGender.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGender.Location = new System.Drawing.Point(12, 70);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(110, 39);
            this.labelGender.TabIndex = 79;
            this.labelGender.Text = "Gender:";
            this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(552, 660);
            this.splitter1.TabIndex = 80;
            this.splitter1.TabStop = false;
            // 
            // hScrollBarMinAge
            // 
            this.hScrollBarMinAge.LargeChange = 1;
            this.hScrollBarMinAge.Location = new System.Drawing.Point(211, 119);
            this.hScrollBarMinAge.Maximum = 120;
            this.hScrollBarMinAge.Name = "hScrollBarMinAge";
            this.hScrollBarMinAge.Size = new System.Drawing.Size(276, 29);
            this.hScrollBarMinAge.TabIndex = 82;
            this.hScrollBarMinAge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarMinAge_Scroll);
            // 
            // labelMinAge
            // 
            this.labelMinAge.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelMinAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMinAge.Location = new System.Drawing.Point(12, 119);
            this.labelMinAge.Name = "labelMinAge";
            this.labelMinAge.Size = new System.Drawing.Size(112, 29);
            this.labelMinAge.TabIndex = 83;
            this.labelMinAge.Text = "Min age:";
            this.labelMinAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarMaxAge
            // 
            this.hScrollBarMaxAge.LargeChange = 1;
            this.hScrollBarMaxAge.Location = new System.Drawing.Point(211, 155);
            this.hScrollBarMaxAge.Maximum = 120;
            this.hScrollBarMaxAge.Name = "hScrollBarMaxAge";
            this.hScrollBarMaxAge.Size = new System.Drawing.Size(276, 29);
            this.hScrollBarMaxAge.TabIndex = 84;
            this.hScrollBarMaxAge.Value = 120;
            this.hScrollBarMaxAge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarMaxAge_Scroll);
            // 
            // labelMaxAge
            // 
            this.labelMaxAge.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaxAge.Location = new System.Drawing.Point(12, 159);
            this.labelMaxAge.Name = "labelMaxAge";
            this.labelMaxAge.Size = new System.Drawing.Size(110, 29);
            this.labelMaxAge.TabIndex = 85;
            this.labelMaxAge.Text = "Max age:";
            this.labelMaxAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinAgeValue
            // 
            this.labelMinAgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinAgeValue.Location = new System.Drawing.Point(128, 119);
            this.labelMinAgeValue.Name = "labelMinAgeValue";
            this.labelMinAgeValue.Size = new System.Drawing.Size(51, 29);
            this.labelMinAgeValue.TabIndex = 86;
            this.labelMinAgeValue.Text = "0";
            this.labelMinAgeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxAgeValue
            // 
            this.labelMaxAgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxAgeValue.Location = new System.Drawing.Point(128, 155);
            this.labelMaxAgeValue.Name = "labelMaxAgeValue";
            this.labelMaxAgeValue.Size = new System.Drawing.Size(51, 33);
            this.labelMaxAgeValue.TabIndex = 87;
            this.labelMaxAgeValue.Text = "120";
            this.labelMaxAgeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCity
            // 
            this.buttonCity.Location = new System.Drawing.Point(385, 287);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(102, 23);
            this.buttonCity.TabIndex = 88;
            this.buttonCity.Text = "Check all";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonLikedPage
            // 
            this.buttonLikedPage.Location = new System.Drawing.Point(385, 416);
            this.buttonLikedPage.Name = "buttonLikedPage";
            this.buttonLikedPage.Size = new System.Drawing.Size(102, 23);
            this.buttonLikedPage.TabIndex = 89;
            this.buttonLikedPage.Text = "Check all";
            this.buttonLikedPage.UseVisualStyleBackColor = true;
            this.buttonLikedPage.Click += new System.EventHandler(this.buttonLikedPage_Click);
            // 
            // buttonFavoriteTeams
            // 
            this.buttonFavoriteTeams.Location = new System.Drawing.Point(385, 571);
            this.buttonFavoriteTeams.Name = "buttonFavoriteTeams";
            this.buttonFavoriteTeams.Size = new System.Drawing.Size(102, 23);
            this.buttonFavoriteTeams.TabIndex = 90;
            this.buttonFavoriteTeams.Text = "Check all";
            this.buttonFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFavoriteTeams.Click += new System.EventHandler(this.buttonFavoriteTeams_Click);
            // 
            // listBoxUserDetails
            // 
            this.listBoxUserDetails.FormattingEnabled = true;
            this.listBoxUserDetails.ItemHeight = 16;
            this.listBoxUserDetails.Location = new System.Drawing.Point(686, 503);
            this.listBoxUserDetails.Name = "listBoxUserDetails";
            this.listBoxUserDetails.Size = new System.Drawing.Size(291, 116);
            this.listBoxUserDetails.TabIndex = 93;
            // 
            // pictureProfile
            // 
            this.pictureProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProfile.Location = new System.Drawing.Point(686, 211);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(291, 240);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureProfile.TabIndex = 91;
            this.pictureProfile.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelUserName.Location = new System.Drawing.Point(720, 454);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(218, 46);
            this.labelUserName.TabIndex = 92;
            this.labelUserName.Text = "UserName";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelTitle.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(121, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(355, 71);
            this.labelTitle.TabIndex = 94;
            this.labelTitle.Text = "Matching friend";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // FormMatchFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBoxUserDetails);
            this.Controls.Add(this.pictureProfile);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonFavoriteTeams);
            this.Controls.Add(this.buttonLikedPage);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.labelMaxAgeValue);
            this.Controls.Add(this.labelMinAgeValue);
            this.Controls.Add(this.labelMaxAge);
            this.Controls.Add(this.hScrollBarMaxAge);
            this.Controls.Add(this.checkedListBoxFavoriteTeams);
            this.Controls.Add(this.checkedListBoxLikedPage);
            this.Controls.Add(this.checkedListBoxCity);
            this.Controls.Add(this.labelMinAge);
            this.Controls.Add(this.hScrollBarMinAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.listBoxMatchFriends);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMatchFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matching friend";
            this.Load += new System.EventHandler(this.formMatchFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxMatchFriends;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckedListBox checkedListBoxLikedPage;
        private System.Windows.Forms.CheckedListBox checkedListBoxFavoriteTeams;
        private System.Windows.Forms.CheckedListBox checkedListBoxCity;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.HScrollBar hScrollBarMinAge;
        private System.Windows.Forms.Label labelMinAge;
        private System.Windows.Forms.HScrollBar hScrollBarMaxAge;
        private System.Windows.Forms.Label labelMaxAge;
        private System.Windows.Forms.Label labelMinAgeValue;
        private System.Windows.Forms.Label labelMaxAgeValue;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.Button buttonLikedPage;
        private System.Windows.Forms.Button buttonFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxUserDetails;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelTitle;
    }
}