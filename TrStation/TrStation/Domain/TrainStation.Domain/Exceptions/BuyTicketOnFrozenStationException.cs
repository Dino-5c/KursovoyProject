using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrStation.Domain.TrainStation.Domain.Entities;

namespace TrainStation.Domain.TrainStation.Domain.Exceptions
{
    public class BuyTicketOnFrozenStationException(Ticket ticket, Station station)
        : InvalidOperationException($"It impossible to buy ticket {ticket}, because station {station}, on that you buying tiket is frozen.")
    // InvalidOperationException: Исключение, которое выдается при вызове метода, недопустимого для текущего состояния объекта. Наследование: Object ==> Exception ==> SystemException ==> InvalidOperationException
    {
        public Ticket Ticket => ticket;
        public Station Station => station;
    }
}
