using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static void GetFiles(string path, string nameFile)
        {
            bool fileFound = false;
            nameFile += (nameFile.IndexOf(".") == -1 ? ".txt" : "");
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                if (f.Name == nameFile)
                {
                    fileFound = true;
                    MessageBox.Show($"Файл знайдений\n Шлях до файлу\n{f.FullName}");
                    FileStream fileStream = File.OpenRead(f.FullName);
                    byte[] array = new byte[fileStream.Length];
                    fileStream.Read(array, 0, array.Length);
                    string textFromFile = Encoding.Default.GetString(array);
                    MessageBox.Show($"\n Текст з файлу:\n {textFromFile}");
                    break;
                }
            }
            if (fileFound == false)
            {
                MessageBox.Show("Файл не знайденно");
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (nameFileTextBox.Text != "" || pathTextBox.Text != "")
            {
                GetFiles(pathTextBox.Text, nameFileTextBox.Text);
            }
            else
            {
                MessageBox.Show("Введіть данні");
            }
        }
    }
}