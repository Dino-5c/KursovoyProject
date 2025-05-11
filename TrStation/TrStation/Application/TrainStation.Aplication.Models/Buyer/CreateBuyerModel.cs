using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStation.Application.TrainStation.Aplication.Models.Base;

namespace TrainStation.Application.TrainStation.Aplication.Models.Buyer
{
    public record class CreateBuyerModel(Guid Id, string LastName, string FirstName)
        :ICreateModel
    {
    }
}
