using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Views
    {
        public class User : Form
        {
            private label title;
            private label email;
            private label password;

            private textbox password;
            private textbox email;

            private button login;

            public LoginUser(int id)
            {
                InitializeComponent(id);
            }

            private void InitializeComponent(int id)
            {
                this.title = new label();
                this.email = new label();
                this.password = new label();

                this.password = new textbox();
                this.email = new textbox();

                this.login = new button();

                this.title.Text = "Login";
                this.email.Text = "Email";
                this.password.Text = "Password";

                this.login.Text = "Login";

                this.login.Click += new EventHandler(this.login_Click);

                this.Controls.Add(this.title);
                this.Controls.Add(this.email);
                this.Controls.Add(this.password);

                this.Controls.Add(this.login);
            }



            
            
            
            
        }
    }