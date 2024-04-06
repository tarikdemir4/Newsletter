using GenericRepository;
using Newsletter.Domain.Entities;
using Newsletter.Domain.Repositories;
using Newsletter.Infrastucture.Context;

namespace Newsletter.Infrastucture.Repositories;
internal sealed class BlogRepository :Repository<Blog,ApplicationDbContext>,IBlogRepository
{
    public BlogRepository(ApplicationDbContext context) : base(context)
    {

    }
}
