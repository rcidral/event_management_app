using Models;

namespace Test
{
    public class UserTest
    {
        public static void store()
        {
            try
            {
                User user = new User("Test", "test", "test");
                User.store(user);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
        public static void index()
        {
            try
            {
                Form form = new Form();
                form.Width = 500;
                form.Height = 500;
                form.Text = "Users";
                
                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");
                listView.Columns.Add("Login");
                listView.Columns.Add("Password");
                
                List<User> users = User.index();

                foreach (User user in users)
                {
                    ListViewItem item = new ListViewItem(user.Id.ToString());
                    item.SubItems.Add(user.Name);
                    item.SubItems.Add(user.Login);
                    item.SubItems.Add(user.Password);
                    listView.Items.Add(item);
                }

                form.Controls.Add(listView);
                form.ShowDialog();
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}