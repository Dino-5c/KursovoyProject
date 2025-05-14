using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Buyer;

namespace TrainStation.Application.TrainStation.Application.Services.Abstractions
{
    public interface IBuyerApplicationService
    {
        Task<BuyerModel?> GetBuyerByIdAsync(Guid id, CancellationToken cancellationToken);

        Task<BuyerModel?> GetBuyerByLastNameAsync(string lastName, CancellationToken cancellationToken);

        Task<IEnumerable<BuyerModel>> GetBuyerAsync(CancellationToken cancellationToken);

        Task<BuyerModel?> CreateBuyerAsync(CreateBuyerModel buyerInformation, CancellationToken cancellationToken);

        Task<bool> UpdateBuyerAsync(BuyerModel buyer,  CancellationToken cancellationToken);

        Task<bool> DeleteBuyerAsync(Guid id, CancellationToken cancellationToken);
    }
}
