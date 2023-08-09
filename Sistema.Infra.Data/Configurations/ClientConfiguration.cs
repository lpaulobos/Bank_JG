﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistem.Domain.Impl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Infra.Data.SqlServer.Configurations
{
    /// <summary>
    /// mapeamento ORM da entidade 
    /// </summary>
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasIndex(c => c.User).IsUnique();
            builder.HasIndex(c => c.Email).IsUnique();
        }
    }
}
