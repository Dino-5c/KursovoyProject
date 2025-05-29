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
    /// Представляет тип имени сущности (покупателя, администратора и т. д.).
    /// </summary>
    /// <param name="name">Имя сущности.</param>
    public class FirstName(string name) : ValueObject<string>(new FirstNameValidator(), name); // Наследование от базовой сущности. При создании объекта класса, проверяем(валидируем) его 

}
