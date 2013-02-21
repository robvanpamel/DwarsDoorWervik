using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using NUnit.Framework;

namespace DDW.Web.Tests.Experiments
{
    [TestFixture, Explicit]
    public class MongoDbTryoutsTestFixture
    {
        [Test]
        public void WhenAccessingAMongoDBDatabaseItReturnsSomething()
        {
            var connectionString = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionString);
            var server = client.GetServer();

            var databaseName = "Codes";
            var database = server.GetDatabase(databaseName);
            var personCollection = database.GetCollection("Persons");
            if ( personCollection == null)
            {
                var commandResult = database.CreateCollection("Persons");
                Assert.That(commandResult.Ok, Is.EqualTo(true));
            }
            var result = personCollection.Save(new Person {FirstName = "John", LastName = "Doe"});
            Assert.That(result.Ok, Is.True);

            var personResult =personCollection.Find(Query.EQ("FirstName", "John"));
            Assert.That(personResult.Any());
        }


    }
}