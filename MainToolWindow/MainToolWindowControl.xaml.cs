namespace w3wpHUD
{
    using System.Windows.Controls;

    public partial class MainToolWindowControl : UserControl
    {
        public MainToolWindowControl()
        {
            InitializeComponent();
        }

        public void SetStatus(string status)
        {
            statusTextBlock.Text = status;
        }

        private void Refresh_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SetStatus(AppCommand.GetWorkerProcessesList());
        }
    }
}
