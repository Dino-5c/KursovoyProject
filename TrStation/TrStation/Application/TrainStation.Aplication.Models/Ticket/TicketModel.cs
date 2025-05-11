using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Base;

namespace TrainStation.Application.TrainStation.Aplication.Models.Ticket
{
    public record class TicketModel(
        Guid Id,
        DateTime BuyDate,
        Guid StartStationId,
        Guid EndStationId,
        Guid BuyerId
        /*, string TicketType */
        ) : IModel<Guid>
    {
    }
}
