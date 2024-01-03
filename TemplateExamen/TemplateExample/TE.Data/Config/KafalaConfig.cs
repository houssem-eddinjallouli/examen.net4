using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE.Core.Domain;

namespace TE.Data.Config
{
    internal class KafalaConfig : IEntityTypeConfiguration<Kafala>
    {
        public void Configure(EntityTypeBuilder<Kafala> builder)
        {
            builder
                .HasOne(r => r.MyBeneficiary)
                .WithMany(p => p.Kafalas)
                .HasForeignKey(r => r.BeneficiaryFk);

            builder
                .HasOne(r => r.MYDonator)
                .WithMany(f => f.Kafalas)
                .HasForeignKey(r => r.DonatorFk);


            builder.HasKey(r => new
            {
                r.BeneficiaryFk,
                r.DonatorFk
            });
        }
    }
}
