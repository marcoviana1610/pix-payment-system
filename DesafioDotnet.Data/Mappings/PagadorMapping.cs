﻿using DesafioDotnet.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioDotnet.Data.Mappings
{
    public class PagadorMapping : IEntityTypeConfiguration<Pagador>
    {
        public void Configure(EntityTypeBuilder<Pagador> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Nome)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.ToTable("Pagador");

        }
    }
}