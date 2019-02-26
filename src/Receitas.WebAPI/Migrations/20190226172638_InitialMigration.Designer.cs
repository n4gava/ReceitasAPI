﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Receitas.WebAPI.Data;

namespace Receitas.WebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190226172638_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Receitas.WebAPI.Entities.Ingrediente", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(255);

                    b.Property<long?>("ReceitaID");

                    b.HasKey("ID");

                    b.HasIndex("ReceitaID");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("Receitas.WebAPI.Entities.PassoPreparo", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(255);

                    b.Property<long?>("ReceitaID");

                    b.HasKey("ID");

                    b.HasIndex("ReceitaID");

                    b.ToTable("PassosPreparo");
                });

            modelBuilder.Entity("Receitas.WebAPI.Entities.Receita", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .HasMaxLength(255);

                    b.Property<int>("Porcoes")
                        .HasMaxLength(4);

                    b.Property<int>("TempoPreparo")
                        .HasMaxLength(3);

                    b.HasKey("ID");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("Receitas.WebAPI.Entities.Ingrediente", b =>
                {
                    b.HasOne("Receitas.WebAPI.Entities.Receita")
                        .WithMany("Ingredientes")
                        .HasForeignKey("ReceitaID");
                });

            modelBuilder.Entity("Receitas.WebAPI.Entities.PassoPreparo", b =>
                {
                    b.HasOne("Receitas.WebAPI.Entities.Receita")
                        .WithMany("ModoPreparo")
                        .HasForeignKey("ReceitaID");
                });
#pragma warning restore 612, 618
        }
    }
}
