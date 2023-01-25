using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
            new User
            {
                Id = new Guid("8615e23f-2548-4ef7-a440-af6edc214fb0"),
                Name = "Alpha",
                Addres = "Moscow",
                Phone = "89279988777"
            },
            new User
            {
                Id = new Guid("713a847a-2875-469d-aefb-fd7bb283a8d4"),
                Name = "Delta",
                Addres = "Saransk",
                Phone = "89279966777"
            });
        }
    }
}
