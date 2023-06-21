namespace views
{
    public class UserArtist
    {
        public static bool isOpen = false;
        public static Form artist;

        public static void List()
        {
            if (!isOpen)
            {
                artist = new Form();
                artist.Text = "Artista";
                artist.Size = new Size(500, 500);
                artist.FormBorderStyle = FormBorderStyle.FixedDialog;
                artist.MaximizeBox = false;
                artist.StartPosition = FormStartPosition.CenterScreen;
                artist.FormClosed += (s, e) => isOpen = false;

                Label lblName = new Label();
                lblName.Text = "Nome";
                lblName.Location = new Point(10, 10);
                lblName.AutoSize = true;

                TextBox txtName = new TextBox();
                txtName.Location = new Point(10, 30);
                txtName.Size = new Size(200, 20);

                Label lblGenre = new Label();
                lblGenre.Text = "Gênero";
                lblGenre.Location = new Point(10, 60);
                lblGenre.AutoSize = true;

                TextBox txtGenre = new TextBox();
                txtGenre.Location = new Point(10, 80);
                txtGenre.Size = new Size(200, 20);

                Label lblCountry = new Label();
                lblCountry.Text = "País";
                lblCountry.Location = new Point(10, 110);
                lblCountry.AutoSize = true;

                TextBox txtCountry = new TextBox();
                txtCountry.Location = new Point(10, 130);
                txtCountry.Size = new Size(200, 20);

                Label lblMembers = new Label();
                lblMembers.Text = "Membros";
                lblMembers.Location = new Point(10, 160);
                lblMembers.AutoSize = true;

                TextBox txtMembers = new TextBox();
                txtMembers.Location = new Point(10, 180);
                txtMembers.Size = new Size(200, 20);

                Label lblAlbums = new Label();
                lblAlbums.Text = "Álbuns";
                lblAlbums.Location = new Point(10, 210);
                lblAlbums.AutoSize = true;

                TextBox txtAlbums = new TextBox();
                txtAlbums.Location = new Point(10, 230);
                txtAlbums.Size = new Size(200, 20);

                Label lblDescription = new Label();
                lblDescription.Text = "Descrição";
                lblDescription.Location = new Point(10, 260);
                lblDescription.AutoSize = true;

                TextBox txtDescription = new TextBox();
                txtDescription.Location = new Point(10, 280);

                Button btnAdd = new Button();
                btnAdd.Text = "Adicionar";
                btnAdd.Location = new Point(10, 310);
                btnAdd.AutoSize = true;

                artist.Controls.Add(lblName);
                artist.Controls.Add(txtName);
                artist.Controls.Add(lblGenre);
                artist.Controls.Add(txtGenre);
                artist.Controls.Add(lblCountry);
                artist.Controls.Add(txtCountry);
                artist.Controls.Add(lblMembers);
                artist.Controls.Add(txtMembers);
                artist.Controls.Add(lblAlbums);
                artist.Controls.Add(txtAlbums);
                artist.Controls.Add(lblDescription);
                artist.Controls.Add(txtDescription);

                artist.Controls.Add(btnAdd);

                btnAdd.Click += (s, e) =>
                {
                    string name = txtName.Text;
                    string genre = txtGenre.Text;
                    string country = txtCountry.Text;
                    string members = txtMembers.Text;
                    string albums = txtAlbums.Text;
                    string description = txtDescription.Text;

                    if (name == "" || genre == "" || country == "" || members == "" || albums == "" || description == "")
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }
                    else
                    {
                        MessageBox.Show("Artista adicionado com sucesso!");
                        txtName.Text = "";
                        txtGenre.Text = "";
                        txtCountry.Text = "";
                        txtMembers.Text = "";
                        txtAlbums.Text = "";
                        txtDescription.Text = "";
                    }
                };

                artist.ShowDialog();
            }
        }
    }
}

