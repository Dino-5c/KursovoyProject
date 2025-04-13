using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class TrainNumberLongValueException(string trainNumber, int maxLength)
        : FormatException($"Number of train length {trainNumber} greated than maximum allowed length (допустимая длина) {maxLength}") // FormatException. Исключение, которое возникает в случае, если формат аргумента недопустим или строка
                                // составного формата построена неправильно. Наследование  Object ==> Exception ==> SystemException ==> FormatException
    {
        public string TrainNumber => trainNumber;

        public int MaxLength => maxLength;
    }
}
