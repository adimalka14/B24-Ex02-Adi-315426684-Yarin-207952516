using BasicFacebookFeatures.Model;
using BasicFacebookFeatures.Model.Adapter;
using BasicFacebookFeatures.ViewModel;

namespace BasicFacebookFeatures.View
{
    partial class FormMemoriesPosts
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label locationLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.memoriesPostsServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.locationsDataBoundCheckedListBox = new BasicFacebookFeatures.Model.DataBoundCheckedListBox();
            this.buttonShowMemories = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filteredPostsListBox = new System.Windows.Forms.ListBox();
            this.postAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.imgUrlPictureBox = new System.Windows.Forms.PictureBox();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoriesPostsServiceBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUrlPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            createdTimeLabel.Location = new System.Drawing.Point(85, 308);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(167, 29);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            locationLabel.Location = new System.Drawing.Point(85, 389);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(110, 29);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "Location:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.labelEnd);
            this.panel1.Controls.Add(this.labelStart);
            this.panel1.Controls.Add(this.dateTimePickerFinish);
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 216);
            this.panel1.TabIndex = 0;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEnd.Location = new System.Drawing.Point(33, 118);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(128, 32);
            this.labelEnd.TabIndex = 4;
            this.labelEnd.Text = "End date";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStart.Location = new System.Drawing.Point(33, 19);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(137, 32);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start date";
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memoriesPostsServiceBindingSource, "EndTime", true));
            this.dateTimePickerFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinish.Location = new System.Drawing.Point(39, 153);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFinish.Size = new System.Drawing.Size(280, 34);
            this.dateTimePickerFinish.TabIndex = 1;
            // 
            // memoriesPostsServiceBindingSource
            // 
            this.memoriesPostsServiceBindingSource.DataSource = typeof(BasicFacebookFeatures.ViewModel.MemoriesPostsService);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePickerStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memoriesPostsServiceBindingSource, "StratTime", true));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(39, 63);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(280, 34);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.Value = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.buttonCity);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.locationsDataBoundCheckedListBox);
            this.panel2.Controls.Add(this.buttonShowMemories);
            this.panel2.Location = new System.Drawing.Point(3, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 428);
            this.panel2.TabIndex = 1;
            // 
            // buttonCity
            // 
            this.buttonCity.Location = new System.Drawing.Point(30, 233);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Size = new System.Drawing.Size(102, 23);
            this.buttonCity.TabIndex = 89;
            this.buttonCity.Text = "Check all";
            this.buttonCity.UseVisualStyleBackColor = true;
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(115, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location";
            // 
            // locationsDataBoundCheckedListBox
            // 
            this.locationsDataBoundCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.memoriesPostsServiceBindingSource, "Locations", true));
            this.locationsDataBoundCheckedListBox.DataSource = null;
            this.locationsDataBoundCheckedListBox.FormattingEnabled = true;
            this.locationsDataBoundCheckedListBox.Location = new System.Drawing.Point(30, 70);
            this.locationsDataBoundCheckedListBox.Name = "locationsDataBoundCheckedListBox";
            this.locationsDataBoundCheckedListBox.Size = new System.Drawing.Size(289, 157);
            this.locationsDataBoundCheckedListBox.TabIndex = 7;
            // 
            // buttonShowMemories
            // 
            this.buttonShowMemories.BackColor = System.Drawing.Color.Magenta;
            this.buttonShowMemories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMemories.ForeColor = System.Drawing.Color.Transparent;
            this.buttonShowMemories.Location = new System.Drawing.Point(53, 325);
            this.buttonShowMemories.Name = "buttonShowMemories";
            this.buttonShowMemories.Size = new System.Drawing.Size(254, 35);
            this.buttonShowMemories.TabIndex = 2;
            this.buttonShowMemories.Text = "Show memories";
            this.buttonShowMemories.UseVisualStyleBackColor = false;
            this.buttonShowMemories.Click += new System.EventHandler(this.buttonShowMemories_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.filteredPostsListBox);
            this.panel3.Location = new System.Drawing.Point(671, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 159);
            this.panel3.TabIndex = 4;
            // 
            // filteredPostsListBox
            // 
            this.filteredPostsListBox.DataSource = this.postAdapterBindingSource;
            this.filteredPostsListBox.FormattingEnabled = true;
            this.filteredPostsListBox.ItemHeight = 16;
            this.filteredPostsListBox.Location = new System.Drawing.Point(25, 19);
            this.filteredPostsListBox.Name = "filteredPostsListBox";
            this.filteredPostsListBox.Size = new System.Drawing.Size(330, 100);
            this.filteredPostsListBox.TabIndex = 7;
            // 
            // postAdapterBindingSource
            // 
            this.postAdapterBindingSource.DataSource = typeof(BasicFacebookFeatures.Model.Adapter.PostAdapter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.descriptionTextBox);
            this.panel4.Controls.Add(createdTimeLabel);
            this.panel4.Controls.Add(this.createdTimeLabel1);
            this.panel4.Controls.Add(this.imgUrlPictureBox);
            this.panel4.Controls.Add(locationLabel);
            this.panel4.Controls.Add(this.locationLabel1);
            this.panel4.Location = new System.Drawing.Point(340, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(736, 486);
            this.panel4.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(405, 58);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(264, 162);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTimeLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createdTimeLabel1.Location = new System.Drawing.Point(351, 308);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 1;
            this.createdTimeLabel1.Text = "label1";
            // 
            // imgUrlPictureBox
            // 
            this.imgUrlPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.postAdapterBindingSource, "ImgUrl", true));
            this.imgUrlPictureBox.Location = new System.Drawing.Point(107, 58);
            this.imgUrlPictureBox.Name = "imgUrlPictureBox";
            this.imgUrlPictureBox.Size = new System.Drawing.Size(218, 183);
            this.imgUrlPictureBox.TabIndex = 5;
            this.imgUrlPictureBox.TabStop = false;
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterBindingSource, "Location", true));
            this.locationLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.locationLabel1.Location = new System.Drawing.Point(351, 383);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(100, 23);
            this.locationLabel1.TabIndex = 7;
            this.locationLabel1.Text = "label1";
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Aqua;
            this.labelTitle.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(349, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(316, 139);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Memories";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMemoriesPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 642);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMemoriesPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memories";
            this.Load += new System.EventHandler(this.formMemoriesPosts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoriesPostsServiceBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUrlPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowMemories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox filteredPostsListBox;
        private System.Windows.Forms.BindingSource memoriesPostsServiceBindingSource;
        private DataBoundCheckedListBox locationsDataBoundCheckedListBox;
        private System.Windows.Forms.Button buttonCity;
        private System.Windows.Forms.BindingSource postAdapterBindingSource;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.PictureBox imgUrlPictureBox;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}