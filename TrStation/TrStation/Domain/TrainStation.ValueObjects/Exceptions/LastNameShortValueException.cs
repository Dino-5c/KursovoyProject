using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    internal class LastNameShortValueException(string lastName, int minLength)
        : FormatException($"Last name length {lastName} less than minimum allowed(допустимая длина) length {minLength}") // FormatException. Исключение, которое возникает в случае, если формат аргумента недопустим или строка составного формата построена неправильно.  Наследование Object ==> Exception ==> SystemException ==> FormatException
    {
        public string LastName => lastName;
        public int MinLength => minLength;
    }
}
