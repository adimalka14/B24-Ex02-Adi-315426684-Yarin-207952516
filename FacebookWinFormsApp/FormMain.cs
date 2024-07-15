﻿using System;
using System.Windows.Forms;
using BasicFacebookFeatures.Services;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly MainPageService r_MainPageService = new MainPageService();

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            init();
        }

        public void init()
        {
            try
            {
                r_MainPageService.Init();
                FormUserPage userPage = new FormUserPage(new GeneralPageService
                {
                    InUserFacade = r_MainPageService.i_UserFacade
                });

                userPage.Show();
                userPage.Tag = this;
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}