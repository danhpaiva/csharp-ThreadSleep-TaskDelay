using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Delay
{
    public partial class F_App : Form
    {
        public F_App()
        {
            InitializeComponent();
        }

        void PausaComThreadSleep()
        {
            Thread.Sleep(5000);
        }

        CancellationTokenSource tokenSource = new CancellationTokenSource();

        async Task PausaComTaskDelay()
        {
            try
            {
                await Task.Delay(5000, tokenSource.Token);
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("A Pausa foi cancelada...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarPausa_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }

        private async void btnTaskDelay_Click(object sender, EventArgs e)
        {
            await PausaComTaskDelay();
            MessageBox.Show("Retornando da pausa...Task.Delay");
        }

        private void btnThreadSleep_Click(object sender, EventArgs e)
        {
            PausaComThreadSleep();
            MessageBox.Show("Retornando da pausa...Thread.Sleep");
        }
    }
}
