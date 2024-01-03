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
    internal class DonatorConfig : IEntityTypeConfiguration<Donator>
    {
        public void Configure(EntityTypeBuilder<Donator> builder)
        {
            builder.OwnsOne(h => h.MyContact);
        }
    }
}
