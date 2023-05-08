﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto_SolCar;

#nullable disable

namespace Projeto_SolCar.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230508190505_addPlanos")]
    partial class addPlanos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Projeto_SolCar.Entidades.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data_nasc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CLIENTES");
                });

            modelBuilder.Entity("Projeto_SolCar.Entidades.Planos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClientesId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.ToTable("Planos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Planos");
                });

            modelBuilder.Entity("Projeto_SolCar.Entidades.SeguroCarro", b =>
                {
                    b.HasBaseType("Projeto_SolCar.Entidades.Planos");

                    b.Property<string>("AnoFabricacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnoModelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chassi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quilometragem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCobertura")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("SeguroCarro");
                });

            modelBuilder.Entity("Projeto_SolCar.Entidades.SeguroCasa", b =>
                {
                    b.HasBaseType("Projeto_SolCar.Entidades.Planos");

                    b.Property<string>("Alagamentos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Aluguel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Basica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DanosEletricos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DanosMorais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desmoronamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipamentos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Impacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roubo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCobertura")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SeguroCasa_TipoCobertura");

                    b.Property<string>("TipoResedência")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendaval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vidros")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("SeguroCasa");
                });

            modelBuilder.Entity("Projeto_SolCar.Entidades.Planos", b =>
                {
                    b.HasOne("Projeto_SolCar.Entidades.Clientes", null)
                        .WithMany("Planos")
                        .HasForeignKey("ClientesId");
                });

            modelBuilder.Entity("Projeto_SolCar.Entidades.Clientes", b =>
                {
                    b.Navigation("Planos");
                });
#pragma warning restore 612, 618
        }
    }
}
