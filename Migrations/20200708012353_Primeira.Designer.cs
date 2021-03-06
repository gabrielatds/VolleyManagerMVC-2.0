﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolleyMVC.Data;

namespace VolleyMVC.Migrations
{
    [DbContext(typeof(VolleyMVCContext))]
    [Migration("20200708012353_Primeira")]
    partial class Primeira
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VolleyMVC.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genero");

                    b.Property<int>("Idade_Max");

                    b.Property<int>("TimeId");

                    b.HasKey("Id");

                    b.HasIndex("TimeId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("VolleyMVC.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Altura");

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome");

                    b.Property<int>("Numero_Camisa");

                    b.Property<string>("Rg");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("VolleyMVC.Models.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Time");
                });

            modelBuilder.Entity("VolleyMVC.Models.Categoria", b =>
                {
                    b.HasOne("VolleyMVC.Models.Time", "Time")
                        .WithMany("Categorias")
                        .HasForeignKey("TimeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VolleyMVC.Models.Jogador", b =>
                {
                    b.HasOne("VolleyMVC.Models.Categoria", "Categoria")
                        .WithMany("Jogadores")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
