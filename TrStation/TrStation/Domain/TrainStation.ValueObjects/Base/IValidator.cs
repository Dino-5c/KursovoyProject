using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation.Domain.TrainStation.ValueObjects.Base
{
    /// <summary>
    /// Определяет метод, реализующий проверку объекта.
    /// </summary>
    /// <typeparam name="T">Тип проверяемого объекта</typeparam>
    public interface IValidator<T>
    {
        /// <summary>
        /// Проверяет данные.
        /// </summary>
        /// <param name="value">Проверенное значение</param>
        void Validate(T value);
    }
}
