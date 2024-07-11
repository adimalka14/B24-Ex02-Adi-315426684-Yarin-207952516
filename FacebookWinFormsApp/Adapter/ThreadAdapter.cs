using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Adapter
{
    public class ThreadAdapter : IThreadAdapter
    {
        public void Execute(Action action)
        {
            Thread newThread = new Thread(() =>
            {
                try
                {
                    action();
                }
                catch (NullReferenceException ex)
                {
                    Form.ActiveForm.Invoke((MethodInvoker)delegate
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception caught: {ex.Message}");
                }
            });
            newThread.Start();
        }
    }
}