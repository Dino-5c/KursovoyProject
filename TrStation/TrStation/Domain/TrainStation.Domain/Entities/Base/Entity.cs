using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrStation.Domain.TrainStation.Domain.Entities.Base
{
    public abstract class Entity<TId>(TId id) where TId : struct, IEquatable<TId>
    {
        /// <summary>
        /// Получение Id сущности
        /// </summary>
        public TId Id { get; } = id;

        /// <summary>
        /// Protected конструктор для framework сущности, если необходимо
        /// </summary>
        protected Entity() : this(default!)
        {

        }
    }
}
