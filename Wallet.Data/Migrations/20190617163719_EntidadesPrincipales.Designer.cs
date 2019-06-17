﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wallet.Data;

namespace Wallet.Data.Migrations
{
    [DbContext(typeof(WalletContext))]
    [Migration("20190617163719_EntidadesPrincipales")]
    partial class EntidadesPrincipales
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wallet.Data.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Account")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Color")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(true);

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<byte[]>("Icon");

                    b.Property<double>("InitialBalance")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<Guid>("TypeId");

                    b.Property<Guid>("UserId");

                    b.Property<Guid?>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Wallet.Data.Entities.AccountType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AccountType")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(true);

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("Wallet.Data.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Category")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Wallet.Data.Entities.Label", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Label")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("Wallet.Data.Entities.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Record")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<double>("Amount");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(true);

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<Guid>("SubCategoryId");

                    b.Property<Guid>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("TypeId");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("Wallet.Data.Entities.RecordLabel", b =>
                {
                    b.Property<Guid>("RecordId");

                    b.Property<Guid>("LabelId");

                    b.HasKey("RecordId", "LabelId");

                    b.HasIndex("LabelId");

                    b.ToTable("RecordLabel");
                });

            modelBuilder.Entity("Wallet.Data.Entities.RecordType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecordType")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("RecordType");
                });

            modelBuilder.Entity("Wallet.Data.Entities.SubCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SubCategory")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Wallet.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("User")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Email")
                        .HasMaxLength(1000)
                        .IsUnicode(true);

                    b.Property<bool>("Enable")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<string>("LastMdifiedBy")
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<DateTime>("ModificationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(true);

                    b.Property<string>("Password")
                        .HasMaxLength(1000)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Wallet.Data.Entities.Account", b =>
                {
                    b.HasOne("Wallet.Data.Entities.AccountType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wallet.Data.Entities.User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wallet.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Wallet.Data.Entities.Record", b =>
                {
                    b.HasOne("Wallet.Data.Entities.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wallet.Data.Entities.RecordType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wallet.Data.Entities.RecordLabel", b =>
                {
                    b.HasOne("Wallet.Data.Entities.Label", "Label")
                        .WithMany("RecordLabels")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wallet.Data.Entities.Record", "Record")
                        .WithMany("RecordLabels")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wallet.Data.Entities.SubCategory", b =>
                {
                    b.HasOne("Wallet.Data.Entities.Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
