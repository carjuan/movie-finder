using MovieFinder.Data;
using MovieFinder.Models;

namespace DbContextTests;

[TestClass]
public class UnitTest1
{
    [TestInitialize]
    public void Init()
    {
        // Code to run before Test Methods
    }

    [TestCleanup]
    public void CleanUp()
    {
        // do dome cleanup
    }
    [TestMethod]
    public void Can_Create_DbContext()
    {
        var dbContext = new MovieFinderDbContext();

        Assert.IsNotNull(dbContext);
    }

    [TestMethod]
    public void Can_Insert_An_User()
    {
        using (var dbContext = new MovieFinderDbContext())
        {
            var sebastian = new User()
            {
                FirstName = "Juan",
                LastName = "Carvajal",
                Email = "juansebastiancl@outlook.com",
                MiddleName = "S.",
                Password = "ThePassword"
            };

            Assert.IsTrue(sebastian.Id == 0);

            dbContext.Users.Add(sebastian);

            dbContext.SaveChanges();

            Assert.IsTrue(sebastian.Id != 0);
        }

    }

    [TestMethod]
    public void Can_Update_An_User()
    {
        using (var dbContext = new MovieFinderDbContext())
        {
            var user = dbContext.Users.FirstOrDefault<User>(u => u.FirstName == "Juan");

            Assert.IsNotNull(user);

            user.LastName = "Lesmes";

            /* If the entry is being tracked, then invoking update API is not needed. 
            The API only needs to be invoked if the entry was not tracked. */
            // context.Products.Update(entity); dbContext.Users.Update(user);
            dbContext.Users.Update(user);

            var databaseOperations = dbContext.SaveChanges();

            Assert.IsTrue(databaseOperations > 0);
        }

    }

    [TestMethod]
    public void Can_Delete_An_User()
    {
        using (var dbcontext = new MovieFinderDbContext())
        {
            var user = dbcontext.Users.FirstOrDefault<User>(u => u.FirstName == "Juan");

            Assert.IsNotNull(user);

            dbcontext.Users.Remove(user);

            var databaseOperations = dbcontext.SaveChanges();

            Assert.IsTrue(databaseOperations > 0);
        }
    }
}
