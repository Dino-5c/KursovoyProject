using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Buyer;
using TrainStation.Application.TrainStation.Aplication.Models.Ticket;
using TrStation.Domain.TrainStation.Domain.Entities;

namespace TrainStation.Application.TrainStation.Application.Services.Abstractions
{
    public interface ITicketApplicationService
    {
        Task<Ticket?> GetTicketByIdAsync(Guid id, CancellationToken cancellationToken);

        Task<IEnumerable<Ticket>> GetTicketsAsync(CancellationToken cancellationToken);

        Task<Ticket?> CreateTicketAsync(CreateTicketModel ticketInformation, CancellationToken cancellationToken);

        Task<bool> UpdateTicketAsync(TicketModel ticket, CancellationToken cancellationToken);

        Task<bool> DeletTicketAsync(Guid id, CancellationToken cancellationToken);
    }
}
