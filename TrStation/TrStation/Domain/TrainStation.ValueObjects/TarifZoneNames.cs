using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrainStation.Domain.TrainStation.ValueObjects
{
    /// <summary>
    /// Представляет тип названия тарифной зоны
    /// </summary>
    /// <param name="name">Название тарифной зоны</param>
    public class TarifZoneNames(string name) : ValueObject<string>(new TarifZoneNamesValidator(), name); // Наследование от базовой сущности. При создании объекта класса, проверяем(валидируем) его  

}
