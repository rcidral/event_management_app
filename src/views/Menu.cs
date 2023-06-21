using System;
using System.Windows.Forms;


namespace Views
{

    public class Menu
    {

        public static void MenuPage()
        {
            Form menu = new Form();
            menu.Text = "Menu";
            menu.Size = new System.Drawing.Size(1100, 650);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedDialog;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;
            menu.ControlBox = false;

            Panel panel1 = new Panel();
            panel1.Size = new System.Drawing.Size(menu.Width / 5, menu.Height - 40);
            panel1.Location = new System.Drawing.Point(0, 40);
            Color color = System.Drawing.ColorTranslator.FromHtml("#3C4048");
            panel1.BackColor = color;

            Panel panel2 = new Panel();
            panel2.Size = new System.Drawing.Size(menu.Width, menu.Height - 40);
            panel2.Location = new System.Drawing.Point(menu.Width - panel2.Width, 40);
            /*Color color1 = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");
            panel2.BackColor = color1;*/
            panel2.BackgroundImage = Image.FromFile("src/assets/gerais.png");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;

            Panel panel3 = new Panel();
            panel3.Size = new System.Drawing.Size(menu.Width, 40);
            panel3.Location = new System.Drawing.Point(0, 0);
            Color color2 = System.Drawing.ColorTranslator.FromHtml("#3C4046");
            panel3.BackColor = color2;

            Button button1 = new Button();
            button1.Location = new System.Drawing.Point(15, 110);
            button1.Size = new System.Drawing.Size(180, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Text = "EVENTO";
            button1.TextAlign = ContentAlignment.MiddleCenter;


            string imagePath = "src/assets/icons8-evento-24.png";
            Image image = Image.FromFile(imagePath);
            button1.Image = image;
            button1.ImageAlign = ContentAlignment.MiddleLeft;

            Button button2 = new Button();
            button2.Location = new System.Drawing.Point(15, 170);
            button2.Size = new System.Drawing.Size(180, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.White;
            button2.Text = "PATRIOCINADOR";
            button2.TextAlign = ContentAlignment.MiddleCenter;

            string imagePath2 = "src/assets/patri.png";
            Image image2 = Image.FromFile(imagePath2);
            image2 = new Bitmap(image2, new Size(26, 26));
            button2.Image = image2;
            button2.ImageAlign = ContentAlignment.MiddleLeft - 15;

            Button button3 = new Button();
            button3.Location = new System.Drawing.Point(15, 230);
            button3.Size = new System.Drawing.Size(180, 40);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.ForeColor = Color.White;
            button3.Text = "ARTISTA";
            button3.TextAlign = ContentAlignment.MiddleCenter;


            string imagePath3 = "src/assets/artist.png";
            Image image3 = Image.FromFile(imagePath3);
            image3 = new Bitmap(image3, new Size(26, 26));
            button3.Image = image3;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Click += (sender, e) =>
            {
                views.UserArtist.List();
            };

            Button button4 = new Button();
            button4.Location = new System.Drawing.Point(15, 290);
            button4.Size = new System.Drawing.Size(180, 40);
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.ForeColor = Color.White;
            button4.Text = "LOCAL";


            string imagePath4 = "src/assets/local.png";
            Image image4 = Image.FromFile(imagePath4);
            image4 = new Bitmap(image4, new Size(26, 26));
            button4.Image = image4;
            button4.ImageAlign = ContentAlignment.MiddleLeft;

            Button button5 = new Button();
            button5.Location = new System.Drawing.Point(15, 350);
            button5.Size = new System.Drawing.Size(180, 40);
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.ForeColor = Color.White;
            button5.Text = "TIPO";


            string imagePath5 = "src/assets/list.png";
            Image image5 = Image.FromFile(imagePath5);
            image5 = new Bitmap(image5, new Size(26, 26));
            button5.Image = image5;
            button5.ImageAlign = ContentAlignment.MiddleLeft;

            Button button6 = new Button();
            button6.Location = new System.Drawing.Point(15, 410);
            button6.Size = new System.Drawing.Size(180, 40);
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.ForeColor = Color.White;
            button6.Text = "USUÁRIO";


            string imagePath6 = "src/assets/user.png";
            Image image6 = Image.FromFile(imagePath6);
            image6 = new Bitmap(image6, new Size(26, 26));
            button6.Image = image6;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Click += (sender, e) =>
            {
                panel2.Controls.Add(views.UserView.List());
                
            };


            Label lineLabel = new Label();
            lineLabel.BackColor = Color.Gray;
            lineLabel.Location = new System.Drawing.Point(15, 470);
            lineLabel.Size = new System.Drawing.Size(180, 1);


            Button button7 = new Button();
            button7.Location = new System.Drawing.Point(15, 500);
            button7.Size = new System.Drawing.Size(180, 40);
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button7.ForeColor = Color.White;
            button7.Text = "SAIR";
            button7.Click += (sender, e) =>
            {
                menu.Close();
                menu.Hide();
            };


            string imagePath7 = "src/assets/sair.png";
            Image image7 = Image.FromFile(imagePath7);
            image7 = new Bitmap(image7, new Size(26, 26));
            button7.Image = image7;
            button7.ImageAlign = ContentAlignment.MiddleLeft;

            string imagePath8 = "src/assets/crm.png";
            Image img = Image.FromFile(imagePath8);
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new System.Drawing.Point(10, 5);
            pictureBox1.Size = new System.Drawing.Size(200, 100);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            string imagePath9 = "src/assets/logo2.png";
            Image image8 = Image.FromFile(imagePath9);
            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.Location = new System.Drawing.Point(8, 10);
            pictureBox2.Size = new System.Drawing.Size(30, 30);
            pictureBox2.Image = image8;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


            Label label = new Label();
            label.Text = "CRM Technology";
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Bangers", 16, FontStyle.Bold);
            label.ForeColor = System.Drawing.Color.Green;
            label.Location = new System.Drawing.Point(495, 11);

            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(lineLabel);
            panel1.Controls.Add(pictureBox1);
            panel3.Controls.Add(label);
            panel3.Controls.Add(pictureBox2);

            menu.Controls.Add(panel1);
            menu.Controls.Add(panel2);
            menu.Controls.Add(panel3);

            menu.ShowDialog();
        }
    }
}