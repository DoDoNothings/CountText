using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CountText
{
//Задание 1
//Написать приложение, которое отображает количество текста, прочитанного из файла с помощью ProgressBar.
    public partial class Text : Form
    {
        public Text()
        {            
            InitializeComponent();
            this.Text = "Количество текста, прочитанного из файла";
        }

        string fileName;//название файла

        private void btnDownlooad_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            f.FileName = fileName;
            // 1. Открытие окна и проверка, выбран ли файл
            if (f.ShowDialog() == DialogResult.OK)
            {
                // 2. Вывести имя файла на форме в компоненте label1
                label1.Text = "Открыт файл : " + f.FileName;
                //// 3. Прочитать файл в richTextBox1
                //// очистить предыдущий текст в richTextBox1
                richTextBox1.Clear();
                // 4. Создать объект класса StreamReader и прочитать данные из файла
                StreamReader sr = File.OpenText(f.FileName);
                // дополнительная переменная для чтения строки из файла
                string line = null;
                //перемення для progressBar
                int i = 0;
                line = sr.ReadLine(); // чтение первой строки
                // 5. Цикл чтения строк из файла, если строки уже нет, то line=null
                while (line != null)
                {
                    // 5.1. Добавить строку в richTextBox1
                    richTextBox1.AppendText(line);
                    // 5.2. Добавить символ перевода строки
                    richTextBox1.AppendText("\r\n");
                    // 5.3. Считать следующую строку
                    line = sr.ReadLine();
                    i++;//увеличить счетчик 
                    progressBarText.Value = i;//вывести в progressBar
                }
                // 6. Закрыть соединение с файлом
                sr.Close();
            }
        }
    }
}

