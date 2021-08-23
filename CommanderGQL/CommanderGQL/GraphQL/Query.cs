using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using System.Linq;

namespace CommanderGQL.GraphQL1
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}
