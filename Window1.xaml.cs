using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace GrapWPFconvertUnicod
{
    public partial class Window1 : Window
    {
        private bool showingFirstPanel = true;

        public Window1()
        {
            InitializeComponent();

           
            TextBox1.PreviewMouseWheel += TextBox_PreviewMouseWheel;
            TextBox2.PreviewMouseWheel += TextBox_PreviewMouseWheel;
        }
        private void ThemeMod(object sender, RoutedEventArgs e)
        {
#pragma warning disable WPF0001
            this.ThemeMode = this.ThemeMode == ThemeMode.Dark
                ? ThemeMode.Light
                : ThemeMode.Dark;
#pragma warning restore WPF0001
        }


        private void RU_Click(object sender, RoutedEventArgs e)
        {
            showingFirstPanel = !showingFirstPanel;

            Panel11.Visibility = Visibility.Visible;
            Panel12.Visibility = Visibility.Collapsed;

            if (showingFirstPanel)
                TextBox1.ScrollToEnd();
            else
                TextBox2.ScrollToEnd();
        }

        private void EN_Click(object sender, RoutedEventArgs e)
        {
            showingFirstPanel = !showingFirstPanel;

            Panel12.Visibility = Visibility.Visible;
            Panel11.Visibility = Visibility.Collapsed;

            if (showingFirstPanel)
                TextBox1.ScrollToEnd();
            else
                TextBox2.ScrollToEnd();
        }

        
        private void TextBox_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return;

            var scrollViewer = GetScrollViewer(textBox);
            if (scrollViewer != null)
            {
                if (e.Delta > 0)
                    scrollViewer.LineUp();
                else
                    scrollViewer.LineDown();

                e.Handled = true; 
            }
        }

        
        private ScrollViewer GetScrollViewer(DependencyObject depObj)
        {
            if (depObj is ScrollViewer) return (ScrollViewer)depObj;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                var child = VisualTreeHelper.GetChild(depObj, i);
                var result = GetScrollViewer(child);
                if (result != null) return result;
            }
            return null;
        }
    }
}




