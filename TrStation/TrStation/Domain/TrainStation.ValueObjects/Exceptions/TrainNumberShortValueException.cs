using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class TrainNumberShortValueException(string trainNumber, int minLength)
        : ArgumentException($"Number of train length {trainNumber} less than minimum allowed length (допустимая длина) {minLength}") // FormatException. Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.  Наследование  Object ==> Exception ==> SystemException ==> FormatException
        // ArgumentException, Это исключение выбрасывается, если один из передаваемых методу аргументов является недопустимым. Наследование: Object ==> Exception ==> SystemException ==> ArgumentException
    {
        public string TrainNumber => trainNumber;

        public int MinLength => minLength;
    }
}
