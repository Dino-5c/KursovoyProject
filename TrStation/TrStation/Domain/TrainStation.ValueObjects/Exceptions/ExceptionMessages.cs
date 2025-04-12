using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Exceptions
{
    /// <summary>
    /// Обеспечивает строковые константы для сообщений об ошибках для исключений
    /// </summary>
    internal static class ExceptionMessages
    {

        public const string VALIDATOR_MUST_BE_SPECIFIED = "Validator must be specified for type (Валидатор для типа должен быть указан)";
        public const string LASTNAME_NOT_NULL_OR_WHITE_SPACE = "The Last Name of administrator, buyer, ect.  mustn't be null, empty or consists only of white-space characters (Фамилия администратора, покупателя и тд. не должна быть нулевой, пустой или состоять только из символов пробела)";
        public const string FIRSTNAME_NOT_NULL_OR_WHITE_SPACE = "The First Name of administrator, buyer, ect. mustn't be null, empty or consists only of white-space characters (Имя администратора, покупателя и тд. не должно быть нулевым, пустым или состоять только из символов пробела)";
        public const string RO_NAME_NOT_NULL_OR_WHITE_SPACE = "The Route Name mustn't be null, empty or consists only of white-space characters (Название маршрута не должно быть нулевым, пустым или состоять только из символов пробела)";
    }
}
