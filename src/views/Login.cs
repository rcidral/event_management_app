namespace Views
{
    public class Login
    {
        public static void Show()
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 500;
            form.Text = "Login";

            Panel panel = new Panel();
            panel.Size = new System.Drawing.Size(400, 500);
            panel.Location = new System.Drawing.Point(0, 0);
            panel.BackColor = System.Drawing.ColorTranslator.FromHtml("#3C4048");

            string imagePath8 = "src/assets/crm.png";
            Image img = Image.FromFile(imagePath8);
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Location = new System.Drawing.Point(100, 150);
            pictureBox1.Size = new System.Drawing.Size(200, 100);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            panel.Controls.Add(pictureBox1);

            Panel panel2 = new Panel();
            panel2.Size = new System.Drawing.Size(400, 500);
            panel2.Location = new System.Drawing.Point(400, 0);
            panel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");

            Label lblLogin = new Label();
            lblLogin.Text = "Usuario";
            lblLogin.Location = new System.Drawing.Point(130, 130);
            lblLogin.Size = new System.Drawing.Size(100, 20);
            lblLogin.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0000");

            TextBox txtLogin = new TextBox();
            txtLogin.Location = new System.Drawing.Point(130, 160);
            txtLogin.Size = new System.Drawing.Size(150, 20);

            Label lblPassword = new Label();
            lblPassword.Text = "Senha";
            lblPassword.Location = new System.Drawing.Point(130, 190);
            lblPassword.Size = new System.Drawing.Size(100, 20);
            lblPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0000");

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(130, 210);
            txtPassword.Size = new System.Drawing.Size(150, 20);

            Button btnLogin = new Button();
            btnLogin.Text = "Entrar";
            btnLogin.Location = new System.Drawing.Point(157, 250);
            btnLogin.Size = new System.Drawing.Size(100, 20);
            btnLogin.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F6");
            btnLogin.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0000");
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F9");
            btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F9");
            btnLogin.Cursor = Cursors.Hand;

            btnLogin.Click += (sender, e) =>
            {
                if (Controllers.UserController.login(txtLogin.Text, txtPassword.Text))
                {
                    form.Hide();
                    form.Close();
                    Views.Menu.MenuPage();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
            };

            panel2.Controls.Add(lblLogin);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(btnLogin);

            form.Controls.Add(panel);
            form.Controls.Add(panel2);
            form.ShowDialog();
        }
    }
}