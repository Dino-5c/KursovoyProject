using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TrStation.Domain.TrainStation.Domain.Entities;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrainStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrainStation.Infrastructure.TrainStation.Infrastructure.EntityFramework.Configurations
{
    public class StationConfiguration : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.StationName)
                .IsRequired()
                .HasConversion(stationName => stationName.Value, str => new StationName(str))
                .HasMaxLength(StationNameValidator.MAX_LENGTH);
            builder.HasOne(x => x.Route).WithMany("_stations");
            builder.HasOne<Station>().WithOne("Tariffes"); // Связь один к одному? У станции одна тарифная зона, у тарифной зоны не обязательно должна быть станция
            builder.Property(x => x.StationStatus).IsRequired();
            // builder.HasOne(x => x.) // Добавление станции в коллекцию станций администратора
            builder.Ignore(x => x.IsFrozen);
            builder.Ignore(x => x.IsActive);
        }
    }
}
