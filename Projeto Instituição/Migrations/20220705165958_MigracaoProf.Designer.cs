﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoInstituição;

namespace ProjetoInstituição.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220705165958_MigracaoProf")]
    partial class MigracaoProf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ProjetoInstituição.Entidades.Instituicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("INTITUICAO");
                });

            modelBuilder.Entity("ProjetoInstituição.Entidades.Professor", b =>
                {
                    b.Property<int>("IdProf")
                        .HasColumnType("int");

                    b.Property<string>("Instituicao")
                        .HasColumnType("text");

                    b.Property<string>("Materias")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.ToTable("PROFESSOR");
                });
#pragma warning restore 612, 618
        }
    }
}
