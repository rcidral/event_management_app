using Xunit;

namespace Test {
    public class ArtistTest {
        [Fact]
        public void CreateTest() {
            Controllers.Artist.store(new Models.Artist("Test Artist"));
            Models.Artist artist = Controllers.Artist.getByName("Test Artist");

            Assert.Equal("Test Artist", artist.Name);

        }

        [Fact]
        public void UpdateTest() {
            Models.Artist artist = Controllers.Artist.getByName("Test Artist");

            Controllers.Artist.update(artist.Id.ToString(), new Models.Artist("Test Artist 2"));
            Models.Artist artist2 = Controllers.Artist.getByName("Test Artist 2");

            Assert.Equal("Test Artist 2", artist2.Name);
        }

        [Fact]
        public void DeleteTest() {
            Models.Artist artist = Controllers.Artist.getByName("Test Artist 2");

            Controllers.Artist.delete(artist.Id.ToString());

            artist = Controllers.Artist.getByName("Test Artist 2");

            Assert.Null(artist);
        }

        [Fact]
        public void LoginTest() {
            Controllers.UserController.store(new Models.User("Ricardo", "rcidralm", "123"));
            bool isLogin = Controllers.UserController.login("rcidralm", "123");

            Assert.True(isLogin);

            Models.User user = Controllers.UserController.getUserByName("Ricardo");

            Controllers.UserController.Delete(user.Id);
        }


    }
}