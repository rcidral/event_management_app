using Controllers;

namespace Views
{
    public class Event
    {

        public static ListView List(Panel panel2)
        {
            ListView lista = new ListView();
            lista.Size = new System.Drawing.Size(900, 450);
            lista.Location = new System.Drawing.Point(220, 0);
            lista.View = View.Details;
            lista.BackColor = System.Drawing.Color.White;
            lista.BorderStyle = BorderStyle.None;
            lista.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lista.Columns.Add("ID", 150);
            lista.Columns.Add("Data", 150);
            lista.Columns.Add("Descrição", 150);
            lista.Columns.Add("Usuário", 150);
            lista.Columns.Add("Local", 150);
            lista.Columns.Add("Tipo", 150);
            lista.FullRowSelect = true;
            lista.GridLines = true;
            lista.MultiSelect = false;
            lista.HideSelection = false;

            List<Models.Event> eventList = Controllers.EventControllers.index();
            foreach (Models.Event event_ in eventList)
            {
                ListViewItem item = new ListViewItem(event_.Id.ToString());
                item.SubItems.Add(event_.Date.ToString());
                item.SubItems.Add(event_.Description.ToString());
                item.SubItems.Add(event_.User.Name);
                item.SubItems.Add(event_.Place.Name);
                item.SubItems.Add(event_.Type.Description);
                lista.Items.Add(item);
            }

            Button buttonEdit = new Button();
            buttonEdit.Location = new System.Drawing.Point(565, 490);
            buttonEdit.Size = new System.Drawing.Size(180, 40);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4048");
            buttonEdit.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");
            buttonEdit.Text = "EDITAR";
            buttonEdit.Font = new Font("Arial", 13, FontStyle.Bold);
            buttonEdit.Click += (sender, e) =>
            {
                panel2.Controls.Clear();
                string id = lista.SelectedItems[0].Text;
                panel2.Controls.Add(Event.Edit(id, panel2));
            };


            string imagePath8 = "src/assets/editar.png";
            Image image8 = Image.FromFile(imagePath8);
            image8 = new Bitmap(image8, new Size(26, 26));
            buttonEdit.Image = image8;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            panel2.Controls.Add(buttonEdit);

            Button buttonRemove = new Button();
            buttonRemove.Location = new System.Drawing.Point(805, 490);
            buttonRemove.Size = new System.Drawing.Size(180, 40);
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3C4048");
            buttonRemove.BackColor = System.Drawing.ColorTranslator.FromHtml("#EFF5F5");
            buttonRemove.Text = "REMOVER";
            buttonRemove.Font = new Font("Arial", 13, FontStyle.Bold);
            buttonRemove.Click += (sender, e) =>
            {
                string id = lista.SelectedItems[0].Text;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Confirmação", buttons);
                if (result == DialogResult.Yes){

                Controllers.SponsorControllers.delete(Int32.Parse(id));
                panel2.Controls.Clear();
                panel2.Controls.Add(Views.Event.List(panel2));
                } else {
                    panel2.Controls.Clear();
                    panel2.Controls.Add(Views.Event.List(panel2));
                }

            };

            string imagePath9 = "src/assets/remove.png";
            Image image9 = Image.FromFile(imagePath9);
            image9 = new Bitmap(image9, new Size(26, 26));
            buttonRemove.Image = image9;
            buttonRemove.ImageAlign = ContentAlignment.MiddleLeft;

            panel2.Controls.Add(buttonRemove);
            Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Event.Add(panel2), panel2);

            panel2.Controls.Add(buttonAdd);
            return lista;
        }

        public static Panel Add(Panel panel)
        {
            Panel form = new Panel();
            form.Size = new System.Drawing.Size(900, 450);
            form.Location = new System.Drawing.Point(220, 0);
            form.BackColor = System.Drawing.Color.White;

            Label lblDescription = new Label();
            lblDescription.Text = "Descrição";
            lblDescription.Location = new System.Drawing.Point(190, 50);
            lblDescription.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblDescription);

            TextBox txtDescription = new TextBox();
            txtDescription.Location = new System.Drawing.Point(190, 70);
            txtDescription.Size = new System.Drawing.Size(250, 20);
            form.Controls.Add(txtDescription);

            Label lblDate = new Label();
            lblDate.Text = "Data";
            lblDate.Location = new System.Drawing.Point(450, 50);
            lblDate.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblDate);

            DateTimePicker txtDate = new DateTimePicker();
            txtDate.Location = new System.Drawing.Point(450, 70);
            txtDate.Size = new System.Drawing.Size(250, 20);
            form.Controls.Add(txtDate);

            Label lblUser = new Label();
            lblUser.Text = "Usuário";
            lblUser.Location = new System.Drawing.Point(190, 100);
            lblUser.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblUser);

            ComboBox txtUser = new ComboBox();
            txtUser.Location = new System.Drawing.Point(190, 120);
            txtUser.Size = new System.Drawing.Size(250, 40);
            txtUser.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.User> userList = Controllers.UserController.Index();
            foreach (Models.User user in userList)
            {
                txtUser.Items.Add(user.Name);
            }
            form.Controls.Add(txtUser);

            Label lblPlace = new Label();
            lblPlace.Text = "Local";
            lblPlace.Location = new System.Drawing.Point(450, 100);
            lblPlace.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblPlace);

            ComboBox txtPlace = new ComboBox();
            txtPlace.Location = new System.Drawing.Point(450, 120);
            txtPlace.Size = new System.Drawing.Size(250, 40);
            txtPlace.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.Place> placeList = Controllers.PlaceControllers.index();
            foreach (Models.Place place in placeList)
            {
                txtPlace.Items.Add(place.Name);
            }

            form.Controls.Add(txtPlace);

            Label lblType = new Label();
            lblType.Text = "Tipo";
            lblType.Location = new System.Drawing.Point(190, 150);
            lblType.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblType);

            ComboBox txtType = new ComboBox();
            txtType.Location = new System.Drawing.Point(190, 170);
            txtType.Size = new System.Drawing.Size(250, 40);
            txtType.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.Type> typeList = Controllers.TypeControllers.index();

            foreach (Models.Type type in typeList)
            {
                txtType.Items.Add(type.Description);
            }

            form.Controls.Add(txtType);

            Label lblArtist = new Label();
            lblArtist.Text = "Artista";
            lblArtist.Location = new System.Drawing.Point(450, 150);
            lblArtist.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblArtist);

            ComboBox txtArtist = new ComboBox();
            txtArtist.Location = new System.Drawing.Point(450, 170);
            txtArtist.Size = new System.Drawing.Size(250, 40);
            txtArtist.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.Artist> artistList = Controllers.Artist.index();

            foreach (Models.Artist artist in artistList)
            {
                txtArtist.Items.Add(artist.Name);
            }

            form.Controls.Add(txtArtist);

            Label lblSponsor = new Label();
            lblSponsor.Text = "Patrocinador";
            lblSponsor.Location = new System.Drawing.Point(190, 200);
            lblSponsor.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblSponsor);

            ComboBox txtSponsor = new ComboBox();
            txtSponsor.Location = new System.Drawing.Point(190, 220);
            txtSponsor.Size = new System.Drawing.Size(250, 40);
            txtSponsor.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.Sponsor> sponsorList = Controllers.SponsorControllers.index();

            foreach (Models.Sponsor sponsor in sponsorList)
            {
                txtSponsor.Items.Add(sponsor.Name);
            }

            form.Controls.Add(txtSponsor);

            Label lblValue = new Label();
            lblValue.Text = "Valor";
            lblValue.Location = new System.Drawing.Point(450, 200);
            lblValue.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblValue);

            TextBox txtValue = new TextBox();
            txtValue.Location = new System.Drawing.Point(450, 220);
            txtValue.Size = new System.Drawing.Size(250, 20);
            form.Controls.Add(txtValue);

            Button btnAdd = new Button();
            btnAdd.Text = "Adicionar";
            btnAdd.Location = new System.Drawing.Point(190, 260);
            btnAdd.Size = new System.Drawing.Size(510, 20);
            btnAdd.Click += (sender, e) =>
            {
                Controllers.EventControllers.store(DateOnly.FromDateTime(txtDate.Value.Date), txtDescription.Text, txtUser.Text, txtPlace.Text, txtType.Text, txtArtist.Text, txtSponsor.Text, Double.Parse(txtValue.Text));
                panel.Controls.Clear();
                panel.Controls.Add(Views.Sponsor.List(panel));

                Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Event.Add(panel), panel);
                Button buttonRemove = Views.ButtonAED.btnDeletar(Views.Event.Add(panel), panel);


                panel.Controls.Add(buttonAdd);
                panel.Controls.Add(buttonRemove);
            };
            form.Controls.Add(btnAdd);

            return form;
        }

        public static Panel Edit(string id, Panel panel2)
        {
            List<Models.Event> eventsList = Controllers.EventControllers.show(Int32.Parse(id));
            Panel form = new Panel();
            form.Size = new System.Drawing.Size(900, 450);
            form.Location = new System.Drawing.Point(220, 0);
            form.BackColor = System.Drawing.Color.White;

            Label lblDate = new Label();
            lblDate.Text = "Data";
            lblDate.Location = new System.Drawing.Point(190, 10);
            lblDate.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblDate);

            DateTimePicker txtDate = new DateTimePicker();
            txtDate.Location = new System.Drawing.Point(190, 30);
            txtDate.Size = new System.Drawing.Size(200, 20);
            txtDate.Value = new DateTime(eventsList[0].Date.Year, eventsList[0].Date.Month, eventsList[0].Date.Day);
            form.Controls.Add(txtDate);

            Label lblDescription = new Label();
            lblDescription.Text = "Descrição";
            lblDescription.Location = new System.Drawing.Point(190, 70);
            lblDescription.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblDescription);

            TextBox txtDescription = new TextBox();
            txtDescription.Location = new System.Drawing.Point(190, 90);
            txtDescription.Size = new System.Drawing.Size(500, 20);
            txtDescription.Text = eventsList[0].Description;
            form.Controls.Add(txtDescription);

            Label lblUser = new Label();
            lblUser.Text = "Usuário";
            lblUser.Location = new System.Drawing.Point(190, 130);
            lblUser.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblUser);

            ComboBox txtUser = new ComboBox();
            txtUser.Location = new System.Drawing.Point(190, 150);
            txtUser.Size = new System.Drawing.Size(500, 40);
            txtUser.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.User> userList = Controllers.UserController.Index();

            foreach (Models.User user in userList)
            {
                txtUser.Items.Add(user.Name);
            }

            form.Controls.Add(txtUser);

            Label lblPlace = new Label();
            lblPlace.Text = "Local";
            lblPlace.Location = new System.Drawing.Point(190, 190);
            lblPlace.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblPlace);

            ComboBox txtPlace = new ComboBox();
            txtPlace.Location = new System.Drawing.Point(190, 210);
            txtPlace.Size = new System.Drawing.Size(500, 40);
            txtPlace.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.Place> placeList = Controllers.PlaceControllers.index();

            foreach (Models.Place place in placeList)
            {
                txtPlace.Items.Add(place.Name);
            }

            form.Controls.Add(txtPlace);

            Label lblType = new Label();
            lblType.Text = "Tipo";
            lblType.Location = new System.Drawing.Point(190, 250);
            lblType.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblType); 

            ComboBox txtType = new ComboBox();
            txtType.Location = new System.Drawing.Point(190, 270);
            txtType.Size = new System.Drawing.Size(500, 40);
            txtType.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.Type> typeList = Controllers.TypeControllers.index();

            foreach (Models.Type type in typeList)
            {
                txtType.Items.Add(type.Description);
            }

            form.Controls.Add(txtType);

            Label lblArtist = new Label();
            lblArtist.Text = "Artista";
            lblArtist.Location = new System.Drawing.Point(190, 310);
            lblArtist.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblArtist);

            ComboBox txtArtist = new ComboBox();
            txtArtist.Location = new System.Drawing.Point(190, 330);
            txtArtist.Size = new System.Drawing.Size(500, 40);
            txtArtist.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Models.Artist> artistList = Controllers.Artist.index();

            foreach (Models.Artist artist in artistList)
            {
                txtArtist.Items.Add(artist.Name);
            }

            form.Controls.Add(txtArtist);


            Button btnAdd = new Button();
            btnAdd.Text = "Editar";
            btnAdd.Location = new System.Drawing.Point(190, 380);
            btnAdd.Size = new System.Drawing.Size(100, 40);
            /* btnAdd.Click += (sender, e) =>
            {
                Controllers.EventControllers.update(Int32.Parse(id), DateOnly.FromDateTime(txtDate.Value.Date), txtDescription.Text, txtUser.Text, txtPlace.Text, txtType.Text, txtArtist.Text);
                panel2.Controls.Clear();
                panel2.Controls.Add(Views.Sponsor.List(panel2));
                Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Sponsor.Add(panel2), panel2);
                Button buttonRemove = Views.ButtonAED.btnDeletar(Views.Sponsor.Add(panel2), panel2);
                panel2.Controls.Add(buttonAdd);
                panel2.Controls.Add(buttonRemove);
            }; */
            form.Controls.Add(btnAdd);

            return form;
        }


    }
}