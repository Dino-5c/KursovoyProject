using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrStation.Domain.TrainStation.Domain.Entities.Base;

namespace TrStation.Domain.TrainStation.Domain.Entities
{
    class Route : Entity<Guid>
    {
        public Guid Id { get; private set; }

        public RoName RouteName { private get; private set; }

        private /*readonly*/ ICollection<Station> _stations = []; // Список станций

        public Route(Guid id, RoName routeName) : base(id)
        {
            RouteName = routeName; 
        }

        public void SetRouteName(RoName routeName)
        {

        }

        public RoName GetRouteName()
        {
            return RouteName;
        }
    }
}
