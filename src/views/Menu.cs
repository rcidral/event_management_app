using System;
using System.Windows.Forms;


namespace Views {

    public class Menu {

        public static void MenuPage() {
            Form menu = new Form();
            menu.Text = "Menu";     
            menu.Size = Screen.PrimaryScreen.WorkingArea.Size;
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.FormBorderStyle = FormBorderStyle.FixedDialog;
            menu.MaximizeBox = false;
            menu.MinimizeBox = false;

            Panel panel1 = new Panel();
            panel1.Size = new System.Drawing.Size(menu.Width / 5, menu.Height - 40);
            panel1.Location = new System.Drawing.Point(0, 40);
            Color color = System.Drawing.ColorTranslator.FromHtml("#3C4048");
            panel1.BackColor = color;



            Panel panel2 = new Panel();
            panel2.Size = new System.Drawing.Size(menu.Width , menu.Height - 40);
            panel2.Location = new System.Drawing.Point(menu.Width - panel2.Width, 40);
            Color color1 = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");
            panel2.BackColor = color1;

            Panel panel3 = new Panel();
            panel3.Size = new System.Drawing.Size(menu.Width , 40);
            panel3.Location = new System.Drawing.Point(0, 0);
            Color color2 = System.Drawing.ColorTranslator.FromHtml("#3C4046");
            panel3.BackColor = color2;

            Button button1 = new Button();
            button1.Location = new System.Drawing.Point(40, 40);
            button1.Size = new System.Drawing.Size(180, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Text = "EVENTOS";
            string imagePath = "src/assets/icons8-evento-24.png"; 
            Image image = Image.FromFile(imagePath);
            button1.Image = image;
            button1.ImageAlign = ContentAlignment.MiddleLeft;

            Button button2 = new Button();
            button2.Location = new System.Drawing.Point(40, 100);
            button2.Size = new System.Drawing.Size(165, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.White;
            button2.Text = "PATRIOCINADORES";
            button2.TextAlign = ContentAlignment.MiddleRight;

            string imagePath2 = "src/assets/patri.png"; 
            Image image2 = Image.FromFile(imagePath2);
            image2 = new Bitmap(image2, new Size(26, 26));
            button2.Image = image2;
            button2.ImageAlign = ContentAlignment.MiddleLeft - 15;

            Button button3 = new Button();
            button3.Location = new System.Drawing.Point(40, 160);
            button3.Size = new System.Drawing.Size(165, 40);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.ForeColor = Color.White;
            button3.Text = "ARTISTA";


            string imagePath3 = "src/assets/artist.png";
            Image image3 = Image.FromFile(imagePath3);
            image3 = new Bitmap(image3, new Size(26, 26));
            button3.Image = image3; 
            button3.ImageAlign = ContentAlignment.MiddleLeft ;



            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);

           


            menu.Controls.Add(panel1);
            menu.Controls.Add(panel2); 
            menu.Controls.Add(panel3); 

            menu.ShowDialog();
            

        }
    }
}