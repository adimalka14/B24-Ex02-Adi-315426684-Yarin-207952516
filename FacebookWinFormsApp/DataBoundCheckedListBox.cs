using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class DataBoundCheckedListBox : CheckedListBox
    {
        private IEnumerable m_DataSource;

        public new IEnumerable DataSource
        {
            get => m_DataSource;
            set
            {
                if (m_DataSource != value)
                {
                    m_DataSource = value;
                    UpdateItems();
                }
            }
        }

        private void UpdateItems()
        {
            Items.Clear();
            if (m_DataSource != null)
            {
                foreach (var item in m_DataSource)
                {
                    Items.Add(item);
                }
            }
        }
    }
}