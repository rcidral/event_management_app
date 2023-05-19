using Models;

namespace Test
{
    public class ArtistTeste
    {
        public static void store()
        {
            try
            {
                Artist artist = new Artist("Teste");
                Artist.store(artist);
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
                form.Text = "Artists";

                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");

                List<Artist> artists = Artist.index();

                foreach (Artist artist in artists)
                {
                    ListViewItem item = new ListViewItem(artist.Id.ToString());
                    item.SubItems.Add(artist.Name);
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
        public static void show(int id)
        {
            try
            {
                Form form = new Form();
                form.Width = 500;
                form.Height = 500;
                form.Text = "Artists";

                ListView listView = new ListView();
                listView.Width = 500;
                listView.Height = 500;
                listView.View = View.Details;
                listView.Columns.Add("Id");
                listView.Columns.Add("Name");

                List<Artist> artists = Artist.show(id);

                foreach (Artist artist in artists)
                {
                    ListViewItem item = new ListViewItem(artist.Id.ToString());
                    item.SubItems.Add(artist.Name);
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

        public static void update(int id, Artist artist)
        {
            try
            {
                Artist.update(id, artist);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        public static void delete(int id)
        {
            try
            {
                Artist.delete(id);
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

    }
}