using BasicFacebookFeatures.Adapter;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label relationshipStatusLabel;
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.matchFriendServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelMinAge = new System.Windows.Forms.Label();
            this.labelMaxAge = new System.Windows.Forms.Label();
            this.buttonCity = new System.Windows.Forms.Button();
            this.buttonLikedPage = new System.Windows.Forms.Button();
            this.buttonFavoriteTeams = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonRefreshAll = new System.Windows.Forms.Button();
            this.CitiesDataBoundCheckedListBox = new BasicFacebookFeatures.DataBoundCheckedListBox();
            this.favoriteTeamsDataBoundCheckedListBox = new BasicFacebookFeatures.DataBoundCheckedListBox();
            this.likedPagesDataBoundCheckedListBox = new BasicFacebookFeatures.DataBoundCheckedListBox();
            this.matchingFriendListListBox = new System.Windows.Forms.ListBox();
            this.userFacadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.genderLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.pictureLargeUrlPictureBox = new System.Windows.Forms.PictureBox();
            this.relationshipStatusLabel1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            relationshipStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchFriendServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLargeUrlPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(650, 491);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(106, 29);
            birthdayLabel.TabIndex = 99;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(654, 530);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(80, 29);
            emailLabel.TabIndex = 101;
            emailLabel.Text = "Email:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(654, 414);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(137, 29);
            firstNameLabel.TabIndex = 103;
            firstNameLabel.Text = "First Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(654, 563);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(100, 29);
            genderLabel.TabIndex = 105;
            genderLabel.Text = "Gender:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(650, 452);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(134, 29);
            lastNameLabel.TabIndex = 107;
            lastNameLabel.Text = "Last Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(654, 599);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(110, 29);
            locationLabel.TabIndex = 109;
            locationLabel.Text = "Location:";
            // 
            // relationshipStatusLabel
            // 
            relationshipStatusLabel.AutoSize = true;
            relationshipStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            relationshipStatusLabel.Location = new System.Drawing.Point(654, 634);
            relationshipStatusLabel.Name = "relationshipStatusLabel";
            relationshipStatusLabel.Size = new System.Drawing.Size(225, 29);
            relationshipStatusLabel.TabIndex = 113;
            relationshipStatusLabel.Text = "Relationship Status:";
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
            // checkBoxMale
            // 
            this.checkBoxMale.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.matchFriendServiceBindingSource, "IsMaleChecked", true));
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
            // matchFriendServiceBindingSource
            // 
            this.matchFriendServiceBindingSource.DataSource = typeof(BasicFacebookFeatures.Services.MatchFriendService);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.BackColor = System.Drawing.Color.DodgerBlue;
            this.checkBoxFemale.Checked = true;
            this.checkBoxFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFemale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.matchFriendServiceBindingSource, "IsFemaleChecked", true));
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
            this.splitter1.Size = new System.Drawing.Size(552, 690);
            this.splitter1.TabIndex = 80;
            this.splitter1.TabStop = false;
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
            // buttonCity
            // 
            this.buttonCity.Location = new System.Drawing.Point(361, 305);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(102, 23);
            this.buttonCity.TabIndex = 88;
            this.buttonCity.Text = "Check all";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonLikedPage
            // 
            this.buttonLikedPage.Location = new System.Drawing.Point(361, 421);
            this.buttonLikedPage.Name = "buttonLikedPage";
            this.buttonLikedPage.Size = new System.Drawing.Size(102, 23);
            this.buttonLikedPage.TabIndex = 89;
            this.buttonLikedPage.Text = "Check all";
            this.buttonLikedPage.UseVisualStyleBackColor = true;
            this.buttonLikedPage.Click += new System.EventHandler(this.buttonLikedPage_Click);
            // 
            // buttonFavoriteTeams
            // 
            this.buttonFavoriteTeams.Location = new System.Drawing.Point(361, 563);
            this.buttonFavoriteTeams.Name = "buttonFavoriteTeams";
            this.buttonFavoriteTeams.Size = new System.Drawing.Size(102, 23);
            this.buttonFavoriteTeams.TabIndex = 90;
            this.buttonFavoriteTeams.Text = "Check all";
            this.buttonFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFavoriteTeams.Click += new System.EventHandler(this.buttonFavoriteTeams_Click);
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
            // 
            // buttonRefreshAll
            // 
            this.buttonRefreshAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshAll.BackColor = System.Drawing.Color.Silver;
            this.buttonRefreshAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefreshAll.Location = new System.Drawing.Point(449, 613);
            this.buttonRefreshAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshAll.Name = "buttonRefreshAll";
            this.buttonRefreshAll.Size = new System.Drawing.Size(148, 44);
            this.buttonRefreshAll.TabIndex = 98;
            this.buttonRefreshAll.Text = "Refresh Page";
            this.buttonRefreshAll.UseVisualStyleBackColor = false;
            this.buttonRefreshAll.Click += new System.EventHandler(this.buttonRefreshAll_Click);
            // 
            // CitiesDataBoundCheckedListBox
            // 
            this.CitiesDataBoundCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.matchFriendServiceBindingSource, "Cities", true));
            this.CitiesDataBoundCheckedListBox.DataSource = null;
            this.CitiesDataBoundCheckedListBox.FormattingEnabled = true;
            this.CitiesDataBoundCheckedListBox.Location = new System.Drawing.Point(44, 222);
            this.CitiesDataBoundCheckedListBox.Name = "CitiesDataBoundCheckedListBox";
            this.CitiesDataBoundCheckedListBox.Size = new System.Drawing.Size(311, 106);
            this.CitiesDataBoundCheckedListBox.TabIndex = 97;
            // 
            // favoriteTeamsDataBoundCheckedListBox
            // 
            this.favoriteTeamsDataBoundCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.matchFriendServiceBindingSource, "UserFacadeProfile.FavoriteTeams", true));
            this.favoriteTeamsDataBoundCheckedListBox.DataSource = null;
            this.favoriteTeamsDataBoundCheckedListBox.FormattingEnabled = true;
            this.favoriteTeamsDataBoundCheckedListBox.Location = new System.Drawing.Point(44, 472);
            this.favoriteTeamsDataBoundCheckedListBox.Name = "favoriteTeamsDataBoundCheckedListBox";
            this.favoriteTeamsDataBoundCheckedListBox.Size = new System.Drawing.Size(311, 123);
            this.favoriteTeamsDataBoundCheckedListBox.TabIndex = 96;
            // 
            // likedPagesDataBoundCheckedListBox
            // 
            this.likedPagesDataBoundCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.matchFriendServiceBindingSource, "UserFacadeProfile.LikedPages", true));
            this.likedPagesDataBoundCheckedListBox.DataSource = null;
            this.likedPagesDataBoundCheckedListBox.FormattingEnabled = true;
            this.likedPagesDataBoundCheckedListBox.Location = new System.Drawing.Point(44, 334);
            this.likedPagesDataBoundCheckedListBox.Name = "likedPagesDataBoundCheckedListBox";
            this.likedPagesDataBoundCheckedListBox.Size = new System.Drawing.Size(311, 123);
            this.likedPagesDataBoundCheckedListBox.TabIndex = 95;
            // 
            // matchingFriendListListBox
            // 
            this.matchingFriendListListBox.DataSource = this.userFacadeBindingSource;
            this.matchingFriendListListBox.FormattingEnabled = true;
            this.matchingFriendListListBox.ItemHeight = 16;
            this.matchingFriendListListBox.Location = new System.Drawing.Point(673, 20);
            this.matchingFriendListListBox.Name = "matchingFriendListListBox";
            this.matchingFriendListListBox.Size = new System.Drawing.Size(283, 164);
            this.matchingFriendListListBox.TabIndex = 99;
            // 
            // userFacadeBindingSource
            // 
            this.userFacadeBindingSource.DataSource = typeof(BasicFacebookFeatures.NewUser.UserFacade);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Birthday", true));
            this.birthdayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel1.Location = new System.Drawing.Point(903, 497);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(142, 23);
            this.birthdayLabel1.TabIndex = 100;
            this.birthdayLabel1.Text = "label1";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Email", true));
            this.emailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel1.Location = new System.Drawing.Point(903, 536);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(142, 23);
            this.emailLabel1.TabIndex = 102;
            this.emailLabel1.Text = "label1";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "FirstName", true));
            this.firstNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel1.Location = new System.Drawing.Point(903, 414);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(142, 23);
            this.firstNameLabel1.TabIndex = 104;
            this.firstNameLabel1.Text = "label1";
            // 
            // genderLabel1
            // 
            this.genderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Gender", true));
            this.genderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel1.Location = new System.Drawing.Point(903, 563);
            this.genderLabel1.Name = "genderLabel1";
            this.genderLabel1.Size = new System.Drawing.Size(142, 23);
            this.genderLabel1.TabIndex = 106;
            this.genderLabel1.Text = "label1";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "LastName", true));
            this.lastNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel1.Location = new System.Drawing.Point(903, 458);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(142, 23);
            this.lastNameLabel1.TabIndex = 108;
            this.lastNameLabel1.Text = "label1";
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Location", true));
            this.locationLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel1.Location = new System.Drawing.Point(903, 595);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(142, 23);
            this.locationLabel1.TabIndex = 110;
            this.locationLabel1.Text = "label1";
            // 
            // pictureLargeUrlPictureBox
            // 
            this.pictureLargeUrlPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("imageLocation", this.userFacadeBindingSource, "PictureLargeUrl", true));
            this.pictureLargeUrlPictureBox.Location = new System.Drawing.Point(677, 208);
            this.pictureLargeUrlPictureBox.Name = "pictureLargeUrlPictureBox";
            this.pictureLargeUrlPictureBox.Size = new System.Drawing.Size(285, 186);
            this.pictureLargeUrlPictureBox.TabIndex = 112;
            this.pictureLargeUrlPictureBox.TabStop = false;
            // 
            // relationshipStatusLabel1
            // 
            this.relationshipStatusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "RelationshipStatus", true));
            this.relationshipStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipStatusLabel1.Location = new System.Drawing.Point(903, 634);
            this.relationshipStatusLabel1.Name = "relationshipStatusLabel1";
            this.relationshipStatusLabel1.Size = new System.Drawing.Size(142, 23);
            this.relationshipStatusLabel1.TabIndex = 114;
            this.relationshipStatusLabel1.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchFriendServiceBindingSource, "MinAge", true));
            this.numericUpDown1.Location = new System.Drawing.Point(176, 126);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 115;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matchFriendServiceBindingSource, "MaxAge", true));
            this.numericUpDown2.Location = new System.Drawing.Point(176, 162);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 116;
            // 
            // FormMatchFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 690);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailLabel1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameLabel1);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderLabel1);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationLabel1);
            this.Controls.Add(this.pictureLargeUrlPictureBox);
            this.Controls.Add(relationshipStatusLabel);
            this.Controls.Add(this.relationshipStatusLabel1);
            this.Controls.Add(this.matchingFriendListListBox);
            this.Controls.Add(this.buttonRefreshAll);
            this.Controls.Add(this.CitiesDataBoundCheckedListBox);
            this.Controls.Add(this.favoriteTeamsDataBoundCheckedListBox);
            this.Controls.Add(this.likedPagesDataBoundCheckedListBox);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonFavoriteTeams);
            this.Controls.Add(this.buttonLikedPage);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.labelMaxAge);
            this.Controls.Add(this.labelMinAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMatchFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Matching friend";
            this.Load += new System.EventHandler(this.FormMatchFriend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchFriendServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLargeUrlPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelMinAge;
        private System.Windows.Forms.Label labelMaxAge;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.Button buttonLikedPage;
        private System.Windows.Forms.Button buttonFavoriteTeams;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.BindingSource matchFriendServiceBindingSource;
        private DataBoundCheckedListBox likedPagesDataBoundCheckedListBox;
        private DataBoundCheckedListBox favoriteTeamsDataBoundCheckedListBox;
        private DataBoundCheckedListBox CitiesDataBoundCheckedListBox;
        private System.Windows.Forms.Button buttonRefreshAll;
        private System.Windows.Forms.ListBox matchingFriendListListBox;
        private System.Windows.Forms.BindingSource userFacadeBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Label genderLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.PictureBox pictureLargeUrlPictureBox;
        private System.Windows.Forms.Label relationshipStatusLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}