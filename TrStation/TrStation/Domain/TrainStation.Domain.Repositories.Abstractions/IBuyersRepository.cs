using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities;

namespace TrainStation.Domain.TrainStation.Domain.Repositories.Abstractions
{
    public interface IBuyersRepository : IRepository<Buyer, Guid>
    {
        Task<Buyer?> GetBuyerByLastNameAsync(string lastName, CancellationToken cancellationToken);
    }
}
