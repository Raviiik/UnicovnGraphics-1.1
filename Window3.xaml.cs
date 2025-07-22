using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;

namespace GrapWPFconvertUnicod
{
    public partial class Window3 : Window
    {
        private string currentFilePath = null;

        public Window3()
        {
            InitializeComponent();
        }


        private void ThemeMod(object sender, RoutedEventArgs e)
        {
#pragma warning disable WPF0001
            this.ThemeMode = this.ThemeMode == ThemeMode.Dark
                ? ThemeMode.Light
                : ThemeMode.Dark;
#pragma warning restore WPF0001
        }

        private void CreateFile_Click(object sender, RoutedEventArgs e)
        {
            currentFilePath = null;
            TextEditorBox.Clear();
            TextEditorBox.Focus();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                currentFilePath = openFileDialog.FileName;
                TextEditorBox.Text = File.ReadAllText(currentFilePath, Encoding.UTF8);
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            if (currentFilePath == null)
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    currentFilePath = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }

            File.WriteAllText(currentFilePath, TextEditorBox.Text, Encoding.UTF8);
            
        }
    }
}
