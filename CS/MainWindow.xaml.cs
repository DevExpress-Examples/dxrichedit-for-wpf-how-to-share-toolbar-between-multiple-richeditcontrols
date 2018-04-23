using System.Windows;
using DevExpress.Xpf.RichEdit;

namespace RichEditTwoControlsOneToolbarWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            richEditControl1.KeyCodeConverter.Focus();
        }

        private void richEditControl_GotFocus(object sender, RoutedEventArgs e) {
            RichEditControl richEditControl = (RichEditControl)sender;

            richEditControl1.BarManager = null;
            richEditControl2.BarManager = null;
            richEditControl.BarManager = barManager1;
            richEditControlProvider1.RichEditControl = richEditControl;
        }
    }
}
