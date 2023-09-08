using System;
using System.Drawing;
using System.Windows.Forms;

namespace Version_1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string imagePath = "1.jpg";

            if (PictureBox.Image != null)
            {
                PictureBox.Image.Dispose(); // Освобождаем ресурсы текущей картинки
            }

            PictureBox.Image = null; // Удаляем текущую картинку

            // Дополнительные действия, если нужно

            // Загрузка новой картинки
            if (System.IO.File.Exists(imagePath))
            {
                try
                {
                    PictureBox.Image = Image.FromFile(imagePath);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
            PictureBox2.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imagePath = "2.jpg";

            if (PictureBox2.Image != null)
            {
                PictureBox2.Image.Dispose(); // Освобождаем ресурсы текущей картинки
            }

            if (System.IO.File.Exists(imagePath))
            {
                try
                {
                    PictureBox2.Image = Image.FromFile(imagePath);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                }
            }
        }
    }
}
