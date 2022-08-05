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
    public void CanCreateDbContext()
    {
        var dbContext = new MovieFinderDbContext();
    }
}
