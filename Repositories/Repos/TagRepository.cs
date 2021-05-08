using Models;
using Repositories.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repositories.Repos
{
    public interface ITagRepository : IRepository<Tag>
    {
        IEnumerable<Tag> GetTopPopularTags(int count);
        IEnumerable<Tag> GetTagsWithRestaurants(int pageIndex, int pageSize);
    }

    public class TagRepository : Repository<Tag>, ITagRepository
    {
        public ExpressoDbContext ExpressoContext 
        {
            get { return Context as ExpressoDbContext; }
        }

        public TagRepository(ExpressoDbContext context)
            : base(context)
        {
        }

        public IEnumerable<Tag> GetTopPopularTags(int count)
        {
            return ExpressoContext.Tags.Take(count).ToList();
        }

        public IEnumerable<Tag> GetTagsWithRestaurants(int pageIndex = 1, int pageSize = 10)
        {
            return ExpressoContext.Tags
                .Include(t => t.Restaurants)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
