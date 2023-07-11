using Controllers;

namespace Views
{
    public class Type
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
            lista.Columns.Add("ID", 450);
            lista.Columns.Add("Descrição", 450);
            lista.FullRowSelect = true;
            lista.GridLines = true;
            lista.MultiSelect = false;
            lista.HideSelection = false;

            List<Models.Type> typelist = Controllers.TypeControllers.index();
            foreach (Models.Type type in typelist)
            {
                ListViewItem item = new ListViewItem(type.Id.ToString());
                item.SubItems.Add(type.Description);
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
                try
                {
                    panel2.Controls.Clear();
                    string id = lista.SelectedItems[0].Text;
                    panel2.Controls.Add(Type.Edit(id, panel2));
                }

                catch (System.Exception)
                {
                    MessageBox.Show("Selecione um tipo para Editar");
                    panel2.Controls.Clear();
                    panel2.Controls.Add(Views.Type.List(panel2));

                    Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Type.Add(panel2), panel2);
                    Button buttonRemove = Views.ButtonAED.btnDeletar(Views.Type.Add(panel2), panel2);

                    panel2.Controls.Add(buttonAdd);
                    panel2.Controls.Add(buttonRemove);
                }
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
                try
                {
                    string id = lista.SelectedItems[0].Text;
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Confirmação", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Controllers.TypeControllers.delete(id);
                        panel2.Controls.Clear();
                        panel2.Controls.Add(Views.Type.List(panel2));
                    }
                    else
                    {
                        panel2.Controls.Clear();
                        panel2.Controls.Add(Views.Type.List(panel2));
                    }
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Selecione um tipo para Remover");
                }

            };

            string imagePath9 = "src/assets/remove.png";
            Image image9 = Image.FromFile(imagePath9);
            image9 = new Bitmap(image9, new Size(26, 26));
            buttonRemove.Image = image9;
            buttonRemove.ImageAlign = ContentAlignment.MiddleLeft;

            panel2.Controls.Add(buttonRemove);
            Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Type.Add(panel2), panel2);

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
            txtDescription.Location = new System.Drawing.Point(190, 80);
            txtDescription.Size = new System.Drawing.Size(500, 20);
            form.Controls.Add(txtDescription);

            Button btnAdd = new Button();
            btnAdd.Text = "Adicionar";
            btnAdd.Location = new System.Drawing.Point(400, 150);
            btnAdd.Size = new System.Drawing.Size(100, 20);
            btnAdd.Click += (sender, e) =>
            {
                if  (txtDescription.Text != "")
                {
                    Controllers.TypeControllers.store(new Models.Type(txtDescription.Text));
                    panel.Controls.Clear();
                    panel.Controls.Add(Views.Type.List(panel));

                    Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Type.Add(panel), panel);
                    Button buttonRemove = Views.ButtonAED.btnDeletar(Views.Type.Add(panel), panel);

                    panel.Controls.Add(buttonAdd);
                    panel.Controls.Add(buttonRemove);
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            };
            form.Controls.Add(btnAdd);

            return form;
        }

        public static Panel Edit(string id, Panel panel2)
        {
            Models.Type typelist = Controllers.TypeControllers.show(Int32.Parse(id));
            Panel form = new Panel();
            form.Size = new System.Drawing.Size(900, 450);
            form.Location = new System.Drawing.Point(220, 0);
            form.BackColor = System.Drawing.Color.White;

            Label lbldescription = new Label();
            lbldescription.Text = "Descrição";
            lbldescription.Location = new System.Drawing.Point(190, 50);
            lbldescription.Size = new System.Drawing.Size(100, 20);
            form.Controls.Add(lbldescription);

            TextBox txtName = new TextBox();
            txtName.Location = new System.Drawing.Point(190, 80);
            txtName.Size = new System.Drawing.Size(500, 20);
            txtName.Text = typelist.Description;
            form.Controls.Add(txtName);

            Button btnAdd = new Button();
            btnAdd.Text = "Editar";
            btnAdd.Location = new System.Drawing.Point(400, 150);
            btnAdd.Size = new System.Drawing.Size(100, 20);
            btnAdd.Click += (sender, e) =>
            {
                Controllers.TypeControllers.update(id, new Models.Type(txtName.Text));
                panel2.Controls.Clear();
                panel2.Controls.Add(Views.Type.List(panel2));
                Button buttonAdd = Views.ButtonAED.btnAdicionar(Views.Type.Add(panel2), panel2);
                Button buttonRemove = Views.ButtonAED.btnDeletar(Views.Type.Add(panel2), panel2);
                panel2.Controls.Add(buttonAdd);
                panel2.Controls.Add(buttonRemove);
            };
            form.Controls.Add(btnAdd);

            return form;
        }
    }
}