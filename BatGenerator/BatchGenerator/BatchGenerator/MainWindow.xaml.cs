using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BatchGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string FilePath = @"c:/temp/GeneratedBatch.bat";

        public MainWindow()
        {
            InitializeComponent();
            FilePathTextBox.Text = FilePath;
        }

        private void GenerateBtn_OnClick_Click(object sender, RoutedEventArgs e)
        {
            //Feature1CheckBox.IsChecked
            //throw new NotImplementedException();
            var batFileContent = new StringBuilder();
            batFileContent.Append("Alap content");
            if ((bool)Feature1CheckBox.IsChecked)
            {
                batFileContent.Append("\nBe volt pipálva az első checkbox");
            }

            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                sw.Write(batFileContent.ToString());
            }
        }
    }
}
