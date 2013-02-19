using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace DDW.Web.Tests.Experiments
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    } 
}