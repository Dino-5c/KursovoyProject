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
    /// Представляет тип номера поезда
    /// </summary>
    /// <param name="numberOfTrain">Номер поезда</param>
    public class TrainNumber(string numberOfTrain) : ValueObject<string>(new TrainNumberValidator(), numberOfTrain); // Наследование от базовой сущности. При создании объекта класса, проверяем(валидируем) его 
     
}
