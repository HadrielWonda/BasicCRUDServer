﻿// <auto-generated />
namespace Server.Migrations

open System
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion
open Server

[<DbContext(typeof<DataModels.SmthContext>)>]
type SmthContextModelSnapshot() =
    inherit ModelSnapshot()

    override this.BuildModel(modelBuilder: ModelBuilder) =
        modelBuilder
            .HasAnnotation("ProductVersion", "5.0.5")
            |> ignore

        modelBuilder.Entity("Server.DataModels+DbUser", (fun b ->

            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("INTEGER") |> ignore
            b.Property<string>("FirstName")
                .HasColumnType("TEXT") |> ignore
            b.Property<string>("LastName")
                .HasColumnType("TEXT") |> ignore

            b.HasKey("Id") |> ignore

            b.ToTable("Users") |> ignore

        )) |> ignore

