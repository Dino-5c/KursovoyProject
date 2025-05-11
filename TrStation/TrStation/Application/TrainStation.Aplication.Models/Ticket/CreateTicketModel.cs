
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Base;

namespace TrainStation.Application.TrainStation.Aplication.Models.Ticket
{
    public record class CreateTicketModel(
        Guid Id,
        DateTime BuyDate,
        Guid StartStationid,
        Guid EndStationId,
        Guid Buyer
        /* , string Tickettype */
        ) : ICreateModel
    {
    }
}
