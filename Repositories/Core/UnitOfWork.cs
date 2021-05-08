using Repositories.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExpressoDbContext _context;

        public UnitOfWork(ExpressoDbContext context)
        {
            _context = context;

            Tags = new TagRepository(_context);
        }

        public ITagRepository Tags { get; private set; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
