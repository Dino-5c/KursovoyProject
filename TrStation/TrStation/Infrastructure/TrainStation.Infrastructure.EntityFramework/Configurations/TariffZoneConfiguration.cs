



using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
// using TrStation.Domain.TrainStation.Domain.Entities;
using TrStation.Domain.TrainStation.Domain.Entities;
using TrainStation.Domain.TrainStation.ValueObjects;
using TrainStation.Domain.TrainStation.ValueObjects.Validators;

namespace TrainStation.Infrastructure.TrainStation.Infrastructure.EntityFramework.Configurations
{
    public class TariffZoneConfiguration : IEntityTypeConfiguration<Tariffes>
    {
        public void Configure(EntityTypeBuilder<Tariffes> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TariffName)
                .IsRequired()
                .HasConversion(tarifName => tarifName.Value, z => new TarifZoneNames(z));
            builder.Property(x => x.Price)
                .IsRequired() // required Boolean. Значение, указывающее, является ли свойство обязательным.
                .HasConversion(price => price.Value, d => new Money(d)); // Для преобразований из базы данных и в базу данных 
            builder.Property(x => x.Distance)
                .IsRequired()
                .HasConversion(distance => distance.Value, c => new Distance(c));
            // builder.HasOne(x => x.) // Как добавить, что тарифы связаны с билетами, (в Билете есть коллекция тарифов)
              // И администратор связан с билетами. Или он может посмотреть билеты у покупателей

        }
    }
}
