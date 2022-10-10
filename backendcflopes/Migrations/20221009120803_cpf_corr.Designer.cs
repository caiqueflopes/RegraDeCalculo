﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendcflopes.Data;

namespace backendcflopes.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221009120803_cpf_corr")]
    partial class cpf_corr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("backendcflopes.Models.Acordo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("data_criado")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("data_fechado")
                        .HasColumnType("TEXT");

                    b.Property<int>("id_calculo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_cliente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_contrato")
                        .HasColumnType("INTEGER");

                    b.Property<double>("valor_acordo")
                        .HasColumnType("REAL");

                    b.Property<double>("valor_desconto_acordo")
                        .HasColumnType("REAL");

                    b.Property<double>("valor_juros_acordo")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Acordos");
                });

            modelBuilder.Entity("backendcflopes.Models.Calculo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ativo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("comissao_pasch")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("data_inserido")
                        .HasColumnType("TEXT");

                    b.Property<double>("juros_simples")
                        .HasColumnType("REAL");

                    b.Property<double>("juros_total")
                        .HasColumnType("REAL");

                    b.Property<string>("nome_campanha")
                        .HasColumnType("TEXT");

                    b.Property<double>("porcentagem_desconto_permitido")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Calculos");
                });

            modelBuilder.Entity("backendcflopes.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("data_inserido")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.Property<string>("uf")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("backendcflopes.Models.Contrato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("baixado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("cidade")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("data_inserido")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("data_vencimento")
                        .HasColumnType("TEXT");

                    b.Property<int>("id_cliente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_parcela")
                        .HasColumnType("INTEGER");

                    b.Property<string>("numero_contrato")
                        .HasColumnType("TEXT");

                    b.Property<int>("qtd_parcela")
                        .HasColumnType("INTEGER");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.Property<string>("uf")
                        .HasColumnType("TEXT");

                    b.Property<double>("valor_contrato_cheio")
                        .HasColumnType("REAL");

                    b.Property<double>("valor_contrato_desconto")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Contrato");
                });

            modelBuilder.Entity("backendcflopes.Models.Parcela", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("baixado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("data_inserido")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("data_vencimento_parcela")
                        .HasColumnType("TEXT");

                    b.Property<int>("id_cliente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("id_contrato")
                        .HasColumnType("INTEGER");

                    b.Property<string>("numero_parcela")
                        .HasColumnType("TEXT");

                    b.Property<int>("qtd_parcela")
                        .HasColumnType("INTEGER");

                    b.Property<double>("valor_parcela_cheio")
                        .HasColumnType("REAL");

                    b.Property<double>("valor_parcela_desconto")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Parcela");
                });
#pragma warning restore 612, 618
        }
    }
}
