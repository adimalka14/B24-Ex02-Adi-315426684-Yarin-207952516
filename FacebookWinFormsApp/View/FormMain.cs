using System;
using System.Windows.Forms;
using BasicFacebookFeatures.ViewModel;
using FacebookWrapper;

namespace BasicFacebookFeatures.View
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

        private void init()
        {
            try
            {
                r_MainPageService.Init();
                FormUserPage userPage = new FormUserPage(new UserPageService
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