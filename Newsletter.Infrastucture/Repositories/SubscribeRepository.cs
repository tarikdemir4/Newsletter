using GenericRepository;
using Newsletter.Domain.Entities;
using Newsletter.Domain.Repositories;
using Newsletter.Infrastucture.Context;

namespace Newsletter.Infrastucture.Repositories;

internal sealed class SubscribeRepository : Repository<Subscribe, ApplicationDbContext>, ISubscribeRepository
{
    public SubscribeRepository(ApplicationDbContext context) : base(context)
    {

    }
}
