using Controllers;

namespace Views
{
    public class Place
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
            lista.Columns.Add("ID", 300);
            lista.Columns.Add("Name", 300);
            lista.Columns.Add("Address", 300);
            lista.FullRowSelect = true;
            lista.GridLines = true;
            lista.MultiSelect = false;
            lista.HideSelection = false;

            List<Models.Place> placeList = Controllers.PlaceControllers.index();
            foreach (Models.Place place in placeList)
            {
                ListViewItem item = new ListViewItem(place.Id.ToString());
                item.SubItems.Add(place.Name);
                item.SubItems.Add(place.Address);
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
                panel2.Controls.Add(Place.Edit(id, panel2));
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

                Controllers.PlaceControllers.delete(Int32.Parse(id));
                panel2.Controls.Clear();
                panel2.Controls.Add(Views.Place.List(panel2));
                } else {
                    panel2.Controls.Clear();
                    panel2.Controls.Add(Views.Place.List(panel2));
                }

            };

            string imagePath9 = "src/assets/remove.png";
            Image image9 = Image.FromFile(imagePath9);
            image9 = new Bitmap(image9, new Size(26, 26));
            buttonRemove.Image = image9;
            buttonRemove.ImageAlign = ContentAlignment.MiddleLeft;

            panel2.Controls.Add(buttonRemove);
            Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Place.Add(panel2), panel2);

            panel2.Controls.Add(buttonAdd);
            return lista;
        }

        public static Panel Add(Panel panel)
        {
            Panel form = new Panel();
            form.Size = new System.Drawing.Size(900, 450);
            form.Location = new System.Drawing.Point(220, 0);
            form.BackColor = System.Drawing.Color.White;

            Label lblName = new Label();
            lblName.Text = "Nome";
            lblName.Location = new System.Drawing.Point(190, 50);
            lblName.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblName);

            TextBox txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(190, 70);
            txtName.Size = new System.Drawing.Size(500, 40);
            form.Controls.Add(txtName);


            Label lblAdress = new Label();
            lblAdress.Text = "Endereço";
            lblAdress.Location = new System.Drawing.Point(190, 100);
            lblAdress.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblAdress);

            TextBox txtAdress = new TextBox();
            txtAdress.Location = new System.Drawing.Point(190, 120);
            txtAdress.Size = new System.Drawing.Size(500, 40);
            form.Controls.Add(txtAdress);

            Button btnAdd = new Button();
            btnAdd.Text = "Adicionar";
            btnAdd.Location = new System.Drawing.Point(400, 150);
            btnAdd.Size = new System.Drawing.Size(100, 20);
            btnAdd.Click += (sender, e) =>
            {
                Controllers.PlaceControllers.store(new Models.Place(txtName.Text, txtAdress.Text));
                panel.Controls.Clear();
                panel.Controls.Add(Views.Place.List(panel));

                Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Place.Add(panel), panel);
                Button buttonRemove = Views.ButtonAED.btnDeletar(Views.Place.Add(panel), panel);


                panel.Controls.Add(buttonAdd);
                panel.Controls.Add(buttonRemove);
            };
            form.Controls.Add(btnAdd);

            return form;
        }

        public static Panel Edit(string id, Panel panel2)
        {
            List<Models.Place> placeList = Controllers.PlaceControllers.show(id);
            Panel form = new Panel();
            form.Size = new System.Drawing.Size(900, 450);
            form.Location = new System.Drawing.Point(220, 0);
            form.BackColor = System.Drawing.Color.White;

            Label lblName = new Label();
            lblName.Text = "Nome";
            lblName.Location = new System.Drawing.Point(190, 50);
            lblName.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblName);

            TextBox txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(190, 70);
            txtName.Size = new System.Drawing.Size(500, 40);
            txtName.Text = placeList[0].Name;
            form.Controls.Add(txtName);


            Label lblAdress = new Label();
            lblAdress.Text = "Endereço";
            lblAdress.Location = new System.Drawing.Point(190, 100);
            lblAdress.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lblAdress);

            TextBox txtAdress = new TextBox();
            txtAdress.Location = new System.Drawing.Point(190, 120);
            txtAdress.Size = new System.Drawing.Size(500, 40);
            txtAdress.Text = placeList[0].Address;
            form.Controls.Add(txtAdress);

            Button btnAdd = new Button();
            btnAdd.Text = "Alterar";
            btnAdd.Location = new System.Drawing.Point(400, 150);
            btnAdd.Size = new System.Drawing.Size(100, 20);
            btnAdd.Click += (sender, e) =>
            {
                Controllers.PlaceControllers.update(id, new Models.Place(txtName.Text, txtAdress.Text));
                panel2.Controls.Clear();
                panel2.Controls.Add(Views.Place.List(panel2));
                Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Place.Add(panel2), panel2);
                Button buttonRemove = Views.ButtonAED.btnDeletar(Views.Place.Add(panel2), panel2);
                panel2.Controls.Add(buttonAdd);
                panel2.Controls.Add(buttonRemove);
            };
            form.Controls.Add(btnAdd);

            return form;
        }


    }
}