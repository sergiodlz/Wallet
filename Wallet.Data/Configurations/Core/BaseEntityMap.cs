﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wallet.Data.Entities;

namespace Wallet.Data.Configurations.Core
{
    public abstract class BaseEntityMap<TEntityType> : IEntityTypeMap
        where TEntityType : BaseEntity
    {
        private readonly string TableName;
        private readonly string IdName;

        public BaseEntityMap(string TableName, string IdName)
        {
            this.TableName = TableName;
            this.IdName = IdName;
        }

        public void Map(ModelBuilder builder)
        {
            #region EntityBase Configuration

            builder.Entity<TEntityType>()
                .ToTable(TableName);

            builder.Entity<TEntityType>()
                .HasKey(x => x.Id);

            builder.Entity<TEntityType>()
                .Property(x => x.Id)
                .HasColumnName(IdName)
                .HasDefaultValueSql("NEWID()")
                .IsRequired();

            builder.Entity<TEntityType>()
                .Property(x => x.Enable)
                .HasDefaultValueSql("1")
                .IsRequired();

            builder.Entity<TEntityType>()
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GetDate()")
                .IsRequired();

            builder.Entity<TEntityType>()
                .Property(x => x.ModificationDate)
                .HasDefaultValueSql("GetDate()")
                .IsRequired();

            builder.Entity<TEntityType>()
                .Property(x => x.CreatedBy)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(255);

            builder.Entity<TEntityType>()
                .Property(x => x.LastMdifiedBy)
                .IsUnicode()
                .HasMaxLength(255);

            #endregion EntityBase Configuration

            InternalMap(builder.Entity<TEntityType>());
        }

        protected abstract void InternalMap(EntityTypeBuilder<TEntityType> builder);
    }
}