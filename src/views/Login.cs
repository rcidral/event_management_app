namespace Views {
    public class Login {
        public static void Show() {
            Form form = new Form();
            form.Width = 500;
            form.Height = 500;
            form.BackColor = Color.White;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;


            PictureBox pictureBox = new PictureBox();
            pictureBox.Load("src/assets/user2.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(100, 100);
            pictureBox.Location = new Point(190, 0);
            
            Label EmailLabel = new Label();
            EmailLabel.Text = "Email";
            EmailLabel.Width = 150;
            EmailLabel.Height = 30;
            EmailLabel.Font = new Font(EmailLabel.Font.FontFamily, 15, FontStyle.Regular);
            EmailLabel.Location = new Point(100, 150);

            RichTextBox EmailTextBox = new RichTextBox();
            EmailTextBox.BorderStyle = BorderStyle.None;
            EmailTextBox.Font = new Font("Segoe UI", 12);
            EmailTextBox.BackColor = Color.WhiteSmoke;
            EmailTextBox.ForeColor = Color.Black;
            EmailTextBox.Multiline = true;
            EmailTextBox.Size = new Size(300, 30);
            EmailTextBox.Location = new Point(100, 185);

            Label PasswordLabel = new Label();
            PasswordLabel.Text = "Senha";
            PasswordLabel.Width = 150;
            PasswordLabel.Height = 30;
            PasswordLabel.Font = new Font(PasswordLabel.Font.FontFamily, 15, FontStyle.Regular);
            PasswordLabel.Location = new Point(100, 220);

            RichTextBox PasswordTextBox = new RichTextBox();
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Segoe UI", 12);
            PasswordTextBox.BackColor = Color.WhiteSmoke;
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Size = new Size(300, 30);
            PasswordTextBox.Location = new Point(100, 255);
            
            Button button = new Button();
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
            button.Font = new Font("Segoe UI", 12);
            button.FlatAppearance.BorderSize = 0;
            button.Size = new Size(100, 40);
            button.Text = "Entrar";
            button.Location = new Point(200, 300);
            button.Click += (sender, e) =>
            { 
                if(Controllers.UserController.login(EmailTextBox.Text, PasswordTextBox.Text)){
                    form.Hide();
                    Menu.MenuPage();
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos!");
                }
            };

            // Adicionar sombra ao botão
            button.Paint += (sender, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, button.ClientRectangle,
                    Color.FromArgb(100, Color.Black), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(100, Color.Black), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(100, Color.Black), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(100, Color.Black), 2, ButtonBorderStyle.Solid);
            };

            form.Controls.Add(pictureBox);
            form.Controls.Add(EmailTextBox);
            form.Controls.Add(EmailLabel);
            form.Controls.Add(PasswordTextBox);
            form.Controls.Add(PasswordLabel);
            form.Controls.Add(button);

            form.ShowDialog();
        }
    }
}