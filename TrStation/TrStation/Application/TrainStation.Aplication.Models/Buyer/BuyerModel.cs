using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Base;
using TrainStation.Application.TrainStation.Aplication.Models.Ticket;

namespace TrainStation.Application.TrainStation.Aplication.Models.Buyer
{
    public record class BuyerModel(Guid Id, string LastName, string FirstName)
        : IModel<Guid>
    {
        public IEnumerable<TicketModel> Tickets { get; init; }
        // Ключевое init слово определяет метод доступа в свойстве или индексаторе. Метод задания
        // только для инициализации назначает значение свойству или элементу индексатора только во время построения объекта. Принудительное init
        // применение неизменяемости, поэтому после инициализации объекта его нельзя изменить. Метод init доступа позволяет вызывать код
        // для использования инициализатора объектов для задания начального значения. 
    }
}
