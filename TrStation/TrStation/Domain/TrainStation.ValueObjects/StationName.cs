using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects.Base;
using TrainStation.Domain.TrainStation.ValueObjects.Validators;
using TrStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrainStation.Domain.TrainStation.ValueObjects
{
    public class StationName(string name) : ValueObject<string>(new StationNameValidator(), name);  // Наследование от базовой сущности. При создании объекта класса, проверяем(валидируем) его  

}
