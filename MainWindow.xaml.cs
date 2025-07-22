using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using System.Security.Permissions;


namespace GrapWPFconvertUnicod
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer hideTimer;
        private bool isDark = false;

        public MainWindow()
        {
            InitializeComponent();

            hideTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(300)
            };
            hideTimer.Tick += (s, e) =>
            {
                FlyoutPopup.IsOpen = false;
                hideTimer.Stop();
            };

            CheckYuditInstallationAndSetup();  // Автоматическая установка Yudit (снизу хуекод) челу который читает код : соси бяку взломщик гребаный
        }

        public void ThemeMod(object sender, RoutedEventArgs e)
        {
#pragma warning disable WPF0001
            this.ThemeMode = this.ThemeMode == ThemeMode.Dark
                ? ThemeMode.Light
                : ThemeMode.Dark;
#pragma warning restore WPF0001
        }






        private void Window3_click(object sender, RoutedEventArgs e)
        {
            var editor = new Window3();
            editor.Show();
        }

        private void ShowNotification(string message)
        {
            var notification = new Border
            {
                Background = System.Windows.Media.Brushes.Black,
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(12),
                Margin = new Thickness(10),
                Child = new TextBlock
                {
                    Text = message,
                    Foreground = System.Windows.Media.Brushes.Black,
                    FontSize = 14
                },
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Bottom,
                Effect = new System.Windows.Media.Effects.DropShadowEffect
                {
                    Color = System.Windows.Media.Colors.AliceBlue,
                    Direction = 320,
                    ShadowDepth = 5,
                    Opacity = 0.5
                }
            };

            var container = new Grid();
            container.Children.Add(notification);

            var popupWindow = new Window
            {
                Width = 300,
                Height = 80,
                Content = container,
                WindowStyle = WindowStyle.None,
                AllowsTransparency = true,
                Background = System.Windows.Media.Brushes.Transparent,
                ShowInTaskbar = false,
                Topmost = true,
                ResizeMode = ResizeMode.NoResize,
                Owner = this
            };

            popupWindow.Loaded += (s, e) =>
            {
                // правый нижний уголок
                var mainWindow = this;
                var offset = 20;
                popupWindow.Left = mainWindow.Left + mainWindow.Width - popupWindow.Width - offset;
                popupWindow.Top = mainWindow.Top + mainWindow.Height - popupWindow.Height - offset;
            };

            popupWindow.Show();

            var closeTimer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            closeTimer.Tick += (s, e) =>
            {
                closeTimer.Stop();
                popupWindow.Close();
            };
            closeTimer.Start();
        }

        private void ResursButtonTUM_TUM_TUM_SAHUR_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://simp.ly/p/w7lqZt";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening browser :(");
            }
        }

        private void Window1_Click(object sender, RoutedEventArgs e)
        {
            Window1 secondWindow = new Window1();
            secondWindow.Show();
        }

        private void FlyoutButton_MouseEnter(object sender, MouseEventArgs e)
        {
            FlyoutPopup.IsOpen = true;
            hideTimer.Stop();
        }

        private void FlyoutButton_MouseLeave(object sender, MouseEventArgs e)
        {
            hideTimer.Start();
        }

        private void FlyoutPopup_MouseEnter(object sender, MouseEventArgs e)
        {
            hideTimer.Stop();
        }

        private void FlyoutPopup_MouseLeave(object sender, MouseEventArgs e)
        {
            hideTimer.Start();
        }

        private void ShowStackPanel1(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Visible;
            Panel3.Visibility = Visibility.Collapsed;
            Panel4.Visibility = Visibility.Collapsed;
            Panel5.Visibility = Visibility.Collapsed;
            Panel7.Visibility = Visibility.Collapsed;
            Panel8.Visibility = Visibility.Collapsed;
            Panel9.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Collapsed;
        }

        private void ShowStackPanel2(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Collapsed;
            Panel3.Visibility = Visibility.Visible;
            Panel4.Visibility = Visibility.Collapsed;
            Panel5.Visibility = Visibility.Collapsed;
            Panel7.Visibility = Visibility.Collapsed;
            Panel8.Visibility = Visibility.Collapsed;
            Panel9.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Collapsed;
        }

        private void ShowStackPanel3(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Collapsed;
            Panel3.Visibility = Visibility.Collapsed;
            Panel4.Visibility = Visibility.Visible;
            Panel5.Visibility = Visibility.Collapsed;
            Panel7.Visibility = Visibility.Collapsed;
            Panel8.Visibility = Visibility.Collapsed;
            Panel9.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Collapsed;
        }

        private void ShowStackPanel4(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Collapsed;
            Panel3.Visibility = Visibility.Collapsed;
            Panel4.Visibility = Visibility.Collapsed;
            Panel5.Visibility = Visibility.Visible;
            Panel7.Visibility = Visibility.Collapsed;
            Panel8.Visibility = Visibility.Collapsed;
            Panel9.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Collapsed;
        }



        // снизу обратная кодировка и все остольное



        private void DeRUE(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Collapsed;
            Panel3.Visibility = Visibility.Collapsed;
            Panel4.Visibility = Visibility.Collapsed;
            Panel5.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Visible;
            Panel7.Visibility = Visibility.Collapsed;
            Panel8.Visibility = Visibility.Collapsed;
            Panel9.Visibility = Visibility.Collapsed;
            
        }
        private void IrDEE(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Collapsed;
            Panel3.Visibility = Visibility.Collapsed;
            Panel4.Visibility = Visibility.Collapsed;
            Panel5.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Collapsed;
            Panel7.Visibility = Visibility.Visible;
            Panel8.Visibility = Visibility.Collapsed;
            Panel9.Visibility = Visibility.Collapsed;
        }
        private void VeDEE(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Collapsed;
            Panel3.Visibility = Visibility.Collapsed;
            Panel4.Visibility = Visibility.Collapsed;
            Panel5.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Collapsed;
            Panel7.Visibility = Visibility.Collapsed;
            Panel8.Visibility = Visibility.Visible;
            Panel9.Visibility = Visibility.Collapsed;
        }
        private void LaRuE(object sender, RoutedEventArgs e)
        {
            Panel1.Visibility = Visibility.Collapsed;
            Panel3.Visibility = Visibility.Collapsed;
            Panel4.Visibility = Visibility.Collapsed;
            Panel5.Visibility = Visibility.Collapsed;
            Panel6.Visibility = Visibility.Collapsed;
            Panel7.Visibility = Visibility.Collapsed;
            Panel8.Visibility = Visibility.Collapsed;
            Panel9.Visibility = Visibility.Visible;
        }

        // === Методы конвертации ===

        private void Devanagari_to_рус_діак(object sender, RoutedEventArgs e)
        {
            RunUniconv("-decode utf-8 -encode Devanagari_rus");
        }

        private void Devanāgari_to_itrans(object sender, RoutedEventArgs e)
        {
            RunUniconv("-decode utf-8 -encode Devanagari");
        }

        private void Velthius_on_devanāgari(object sender, RoutedEventArgs e)
        {
            RunUniconv("-decode Devanagari-Velthuis -encode utf-8");
        }

        private void Latin_transliteration_to_рус_діак(object sender, RoutedEventArgs e)
        {
            RunUniconv("-decode utf-8 -encode Sanskrit-Translit-rus");
        }

        private void RunUniconv(string arguments)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog { Title = "Select input file" };
            if (openFileDialog.ShowDialog() != true) return;
            string inputFile = openFileDialog.FileName;

            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Title = "Name and select a save location for the output file",
                Filter = "Text files (.txt)|.txt|All files (.)|."
            };
            if (saveFileDialog.ShowDialog() != true) return;
            string outputFile = saveFileDialog.FileName;

            string tempCopy = Path.Combine(Path.GetDirectoryName(inputFile), "unicopy.txt");

            try
            {
                // Сохраняем временную копию с UTF-8 BOM BOM BOM BOM SAHUR :)
                File.WriteAllText(tempCopy, File.ReadAllText(inputFile), new System.Text.UTF8Encoding(true));

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "uniconv",
                        Arguments = $"-out \"{outputFile}\" -in \"{tempCopy}\" {arguments}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                process.WaitForExit();

                // Принудительно перекодируем выходной файл в UTF-8 с BOM
                string resultText = File.ReadAllText(outputFile);
                File.WriteAllText(outputFile, resultText, new System.Text.UTF8Encoding(true));

                File.Delete(tempCopy);
                Process.Start("explorer.exe", $"/select,\"{outputFile}\"");
            }
            catch
            {
                // Игнорируем ошибки
            }
        }
        private void DeRUe(object sender, RoutedEventArgs e)
        {
            RunUniconvE("-encode utf-8 -decode Devanagari_rus");
        }

        private void IrDEe(object sender, RoutedEventArgs e)
        {
            RunUniconvE("-encode utf-8 -decode Devanagari");
        }

        private void VeDEe(object sender, RoutedEventArgs e)
        {
            RunUniconvE("-encode Devanagari-Velthuis -decode utf-8");
        }

        private void LaRUe(object sender, RoutedEventArgs e)
        {
            RunUniconvE("-encode utf-8 -decode Sanskrit-Translit-rus");
        }

        private void RunUniconvE(string arguments)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog { Title = "Select input file" };
            if (openFileDialog.ShowDialog() != true) return;
            string inputFile = openFileDialog.FileName;

            var saveFileDialog = new Microsoft.Win32.SaveFileDialog
            {
                Title = "Name and select a save location for the output file",
                Filter = "Text files (.txt)|.txt|All files (.)|."
            };
            if (saveFileDialog.ShowDialog() != true) return;
            string outputFile = saveFileDialog.FileName;

            string tempCopy = Path.Combine(Path.GetDirectoryName(inputFile), "unicopy.txt");

            try
            {
                // Сохраняем временную копию с UTF-8 BOM BOM BOM BOM SAHUR :)
                File.WriteAllText(tempCopy, File.ReadAllText(inputFile), new System.Text.UTF8Encoding(true));

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "uniconv",
                        Arguments = $"-out \"{outputFile}\" -in \"{tempCopy}\" {arguments}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                process.WaitForExit();

                // Принудительно кодируем выходной файл в UTF-8 BOM BOM BOM BOM SAHUR
                string resultText = File.ReadAllText(outputFile);
                File.WriteAllText(outputFile, resultText, new System.Text.UTF8Encoding(true));

                File.Delete(tempCopy);
                Process.Start("explorer.exe", $"/select,\"{outputFile}\"");
            }
            catch
            {
                // Ошибок не бывает :)
            }
        }



        private void CheckYuditInstallationAndSetup()
        {
            if (TryGetYuditInstallPath(out string yuditPath))
            {
                AddYuditBinToPath(yuditPath);

                try
                {
                    string dataDir = Path.Combine(yuditPath, "data");
                    string scrDir = Path.Combine(yuditPath, "src");

                    CopyFilesByExtension("*.my", dataDir);
                    CopyFilesByExtension("*.kmap", scrDir);

                    ShowSmallNotification("Yudit is already installed and configured!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error copying files :(");
                }

                return;
            }

            string installerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "yudit-3.1.0-1.x86_64.exe");
            if (File.Exists(installerPath))
            {
                try
                {
                    var process = Process.Start(new ProcessStartInfo
                    {
                        FileName = installerPath,
                        Arguments = "/silent",
                        UseShellExecute = true,
                        Verb = "runas"
                    });


                    StartRestartTimer(30);
                    MessageBox.Show("через 30 секунд приложение перезапустится");

                    process.WaitForExit();

                    if (TryGetYuditInstallPath(out string newPath))
                    {
                        AddYuditBinToPath(newPath);

                        CopyFilesByExtension("*.my", Path.Combine(newPath, "data"));
                        CopyFilesByExtension("*.kmap", Path.Combine(newPath, "src"));

                        ShowSmallNotification("Yudit установлен и настроен!");
                    }
                    else
                    {
                        MessageBox.Show("Yudit installed but path not found. :(");
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to install Yudit. :(");
                }
            }
            else
            {
                MessageBox.Show("Yudit installer file not found. :(");
            }
        }

        private void StartRestartTimer(int seconds)
        {
            var restartTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(seconds)
            };
            restartTimer.Tick += (s, e) =>
            {
                restartTimer.Stop();
                RestartApplication();
            };
            restartTimer.Start();
        }

        private void RestartApplication()
        {
            string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Process.Start(appPath);
            Application.Current.Shutdown();
        }

        private bool TryGetYuditInstallPath(out string installPath)
        {
            installPath = null;
            string displayName = "Yudit";

            string[] registryKeys =
            {
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
                @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
            };

            foreach (string keyPath in registryKeys)
            {
                using (var key = Registry.LocalMachine.OpenSubKey(keyPath))
                {
                    if (key == null) continue;

                    foreach (string subkeyName in key.GetSubKeyNames())
                    {
                        using (var subkey = key.OpenSubKey(subkeyName))
                        {
                            string name = subkey?.GetValue("DisplayName") as string;
                            if (!string.IsNullOrEmpty(name) && name.Contains(displayName, StringComparison.OrdinalIgnoreCase))
                            {
                                installPath = subkey.GetValue("InstallLocation") as string;

                                if (string.IsNullOrWhiteSpace(installPath))
                                {
                                    string uninstallString = subkey.GetValue("UninstallString") as string;
                                    if (!string.IsNullOrEmpty(uninstallString))
                                    {
                                        try
                                        {
                                            string path = Path.GetDirectoryName(uninstallString.Trim('"'));
                                            if (Directory.Exists(path))
                                            {
                                                installPath = path;
                                            }
                                        }
                                        catch { }
                                    }
                                }

                                return Directory.Exists(installPath);
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void CopyFilesByExtension(string extension, string targetDir)
        {
            if (!Directory.Exists(targetDir))
                Directory.CreateDirectory(targetDir);

            string[] sourceFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, extension, SearchOption.AllDirectories);
            foreach (var file in sourceFiles)
            {
                string fileName = Path.GetFileName(file);
                string destPath = Path.Combine(targetDir, fileName);
                File.Copy(file, destPath, overwrite: true);
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessageTimeout(
    IntPtr hWnd,
    uint Msg,
    UIntPtr wParam,
    string lParam,
    uint fuFlags,
    uint uTimeout,
    out UIntPtr lpdwResult);

        private const uint WM_SETTINGCHANGE = 0x001A;
        private const uint HWND_BROADCAST = 0xffff;
        private const uint SMTO_ABORTIFHUNG = 0x0002;

        private void SendEnvironmentChangedMessage()
        {
            SendMessageTimeout(
                new IntPtr(HWND_BROADCAST),
                WM_SETTINGCHANGE,
                UIntPtr.Zero,
                "Environment",
                SMTO_ABORTIFHUNG,
                5000,
                out _);
        }


        private void AddYuditBinToPath(string installPath)
        {
            string newPath = Path.Combine(installPath, "bin");
            const string userEnvKey = @"Environment";

            using (RegistryKey envKey = Registry.CurrentUser.OpenSubKey(userEnvKey, writable: true))
            {
                if (envKey == null) return;

                string currentPath = (string)envKey.GetValue("Path", "", RegistryValueOptions.DoNotExpandEnvironmentNames);

                var paths = currentPath.Split(';')
                                       .Select(p => p.Trim())
                                       .Where(p => !string.IsNullOrEmpty(p));

                if (!paths.Contains(newPath, StringComparer.OrdinalIgnoreCase))
                {
                    string updatedPath = currentPath;
                    if (!string.IsNullOrEmpty(updatedPath) && !updatedPath.EndsWith(";"))
                        updatedPath += ";";
                    updatedPath += newPath;

                    envKey.SetValue("Path", updatedPath, RegistryValueKind.ExpandString);
                    SendEnvironmentChangedMessage();
                }
            }

        }

        private void ShowSmallNotification(string message)
        {
            var notif = new Window
            {
                Width = 300,
                Height = 80,
                Topmost = true,
                WindowStyle = WindowStyle.None,
                ResizeMode = ResizeMode.NoResize,
                AllowsTransparency = true,
                Background = System.Windows.Media.Brushes.LightGreen,
                Content = new TextBlock
                {
                    Text = message,
                    FontSize = 16,
                    Margin = new Thickness(10),
                    TextWrapping = TextWrapping.Wrap
                },
                ShowInTaskbar = false,
                Left = SystemParameters.WorkArea.Width - 310,
                Top = SystemParameters.WorkArea.Height - 90
            };

            notif.Loaded += (_, __) =>
            {
                DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
                timer.Tick += (_, __) => { notif.Close(); timer.Stop(); };
                timer.Start();
            };

            notif.Show();
        }
    }
}