namespace BasicFacebookFeatures
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowMemories = new System.Windows.Forms.Button();
            this.listBoxFoundedMemories = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxSelectedMemory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.labelEnd);
            this.panel1.Controls.Add(this.labelStart);
            this.panel1.Controls.Add(this.dateTimePickerFinish);
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 235);
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
            this.dateTimePickerFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinish.Location = new System.Drawing.Point(39, 153);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerFinish.Size = new System.Drawing.Size(280, 34);
            this.dateTimePickerFinish.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
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
            this.panel2.Controls.Add(this.comboBoxLocation);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 117);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(60, 56);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(259, 37);
            this.comboBoxLocation.TabIndex = 5;
            this.comboBoxLocation.Text = "All post";
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
            // buttonShowMemories
            // 
            this.buttonShowMemories.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonShowMemories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowMemories.ForeColor = System.Drawing.Color.Transparent;
            this.buttonShowMemories.Location = new System.Drawing.Point(90, 387);
            this.buttonShowMemories.Name = "buttonShowMemories";
            this.buttonShowMemories.Size = new System.Drawing.Size(254, 35);
            this.buttonShowMemories.TabIndex = 2;
            this.buttonShowMemories.Text = "Show memories";
            this.buttonShowMemories.UseVisualStyleBackColor = false;
            this.buttonShowMemories.Click += new System.EventHandler(this.buttonShowMemories_Click);
            // 
            // listBoxFoundedMemories
            // 
            this.listBoxFoundedMemories.FormattingEnabled = true;
            this.listBoxFoundedMemories.ItemHeight = 16;
            this.listBoxFoundedMemories.Location = new System.Drawing.Point(29, 24);
            this.listBoxFoundedMemories.Name = "listBoxFoundedMemories";
            this.listBoxFoundedMemories.Size = new System.Drawing.Size(307, 100);
            this.listBoxFoundedMemories.TabIndex = 3;
            this.listBoxFoundedMemories.SelectedIndexChanged += new System.EventHandler(this.listBoxFoundedMemories_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.listBoxFoundedMemories);
            this.panel3.Location = new System.Drawing.Point(30, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 150);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.textBoxSelectedMemory);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(474, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(614, 477);
            this.panel4.TabIndex = 5;
            // 
            // textBoxSelectedMemory
            // 
            this.textBoxSelectedMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSelectedMemory.Location = new System.Drawing.Point(63, 272);
            this.textBoxSelectedMemory.Multiline = true;
            this.textBoxSelectedMemory.Name = "textBoxSelectedMemory";
            this.textBoxSelectedMemory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSelectedMemory.Size = new System.Drawing.Size(459, 128);
            this.textBoxSelectedMemory.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(157, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 206);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.labelTitle.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(474, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(614, 105);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Memories";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMemoriesPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 634);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonShowMemories);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMemoriesPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Memories";
            this.Load += new System.EventHandler(this.formMemoriesPosts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowMemories;
        private System.Windows.Forms.ListBox listBoxFoundedMemories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSelectedMemory;
        private System.Windows.Forms.Label labelTitle;
    }
}