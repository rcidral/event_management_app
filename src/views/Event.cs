namespace views
{
    public class Event
    {
        public static bool isOpen = false;
        public static Form event_;

        public static void List()
        {
            if (!isOpen)
            {
                event_ = new Form();
                event_.Text = "Evento";
                event_.Size = new Size(500, 500);
                event_.FormBorderStyle = FormBorderStyle.FixedDialog;
                event_.MaximizeBox = false;
                event_.StartPosition = FormStartPosition.CenterScreen;
                event_.FormClosed += (s, e) => isOpen = false;

                Label lblDate = new Label();
                lblDate.Text = "Data do Evento";
                lblDate.Location = new Point(10, 10);
                lblDate.AutoSize = true;

                DateTimePicker date = new DateTimePicker();
                date.Location = new Point(10, 30);
                date.Size = new Size(250, 20);

                Label lblOrg = new Label();
                lblOrg.Text = "Organizador";
                lblOrg.Location = new Point(10, 60);
                lblOrg.AutoSize = true;

                TextBox txtOrg = new TextBox();
                txtOrg.Location = new Point(10, 80);
                txtOrg.Size = new Size(200, 20);

                Label lblPlace = new Label();
                lblPlace.Text = "Local";
                lblPlace.Location = new Point(10, 110);
                lblPlace.AutoSize = true;

                TextBox txtCountry = new TextBox();
                txtCountry.Location = new Point(10, 130);
                txtCountry.Size = new Size(200, 20);

                Label lblType = new Label();
                lblType.Text = "Tipo de evento";
                lblType.Location = new Point(10, 160);
                lblType.AutoSize = true;

                TextBox txtType = new TextBox();
                txtType.Location = new Point(10, 180);
                txtType.Size = new Size(200, 20);

                Label lblArtist = new Label();
                lblArtist.Text = "Artista";
                lblArtist.Location = new Point(10, 210);
                lblArtist.AutoSize = true;

                TextBox txtArtist = new TextBox();
                txtArtist.Location = new Point(10, 230);
                txtArtist.Size = new Size(200, 20);

                Label lblDescription = new Label();
                lblDescription.Text = "Descrição";
                lblDescription.Location = new Point(10, 260);
                lblDescription.AutoSize = true;

                TextBox txtDescription = new TextBox();
                txtDescription.Location = new Point(10, 280);
                txtDescription.Size = new Size(200, 20);

                Label lblSponsor = new Label();
                lblSponsor.Text = "Patrocinador";
                lblSponsor.Location = new Point(10, 310);
                lblSponsor.AutoSize = true;

                TextBox txtSponsor = new TextBox();
                txtSponsor.Location = new Point(10, 330);
                txtSponsor.Size = new Size(200, 20);

                Label lblValue = new Label();
                lblValue.Text = "Valor";
                lblValue.Location = new Point(10, 360);
                lblValue.AutoSize = true;

                TextBox txtValue = new TextBox();
                txtValue.Location = new Point(10, 380);
                txtValue.Size = new Size(200, 20);


                Button btnAdd = new Button();
                btnAdd.Text = "Adicionar";
                btnAdd.Location = new Point(10, 410);
                btnAdd.AutoSize = true;

                event_.Controls.Add(lblDate);
                event_.Controls.Add(date);
                event_.Controls.Add(lblOrg);
                event_.Controls.Add(txtOrg);
                event_.Controls.Add(lblPlace);
                event_.Controls.Add(txtCountry);
                event_.Controls.Add(lblType);
                event_.Controls.Add(txtType);
                event_.Controls.Add(lblArtist);
                event_.Controls.Add(txtArtist);
                event_.Controls.Add(lblDescription);
                event_.Controls.Add(txtDescription);
                event_.Controls.Add(lblSponsor);
                event_.Controls.Add(txtSponsor);
                event_.Controls.Add(lblValue);
                event_.Controls.Add(txtValue);


                event_.Controls.Add(btnAdd);

                btnAdd.Click += (s, e) =>
                {
                    string name = date.Text;
                    string genre = txtOrg.Text;
                    string country = txtCountry.Text;
                    string members = txtType.Text;
                    string albums = txtArtist.Text;
                    string description = txtDescription.Text;
                    string sponsor = txtSponsor.Text;
                    string value = txtValue.Text;

                    if (name == "" || genre == "" || country == "" || members == "" || albums == "" || description == "" || sponsor == "" || value == "")
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }
                    else
                    {
                        MessageBox.Show("Evento adicionado com sucesso!");
                        date.Text = "";
                        txtOrg.Text = "";
                        txtCountry.Text = "";
                        txtType.Text = "";
                        txtArtist.Text = "";
                        txtDescription.Text = "";
                        txtSponsor.Text = "";
                        txtValue.Text = "";
                    }
                };

                event_.ShowDialog();
            }
        }
    }
}

