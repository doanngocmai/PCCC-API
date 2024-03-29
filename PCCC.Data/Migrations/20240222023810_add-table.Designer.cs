﻿// <auto-generated />
using System;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PCCC.Data;

#nullable disable

namespace PCCC.Data.Migrations
{
    [DbContext(typeof(PcccContext))]
    [Migration("20240222023810_add-table")]
    partial class addtable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PCCC.Data.Entities.ApartmentUser", b =>
                {
                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("ApartmentId")
                        .HasColumnType("integer")
                        .HasColumnName("ApartmentID");

                    b.Property<int>("AreaId")
                        .HasColumnType("integer")
                        .HasColumnName("AreaID");

                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    b.Property<float?>("Latitude")
                        .HasColumnType("real");

                    b.Property<float?>("Longitude")
                        .HasColumnType("real");

                    b.Property<int>("MapId")
                        .HasColumnType("integer")
                        .HasColumnName("MapID");

                    b.ToTable("ApartmentUsers");
                });

            modelBuilder.Entity("PCCC.Data.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.Property<int>("PointAreaId")
                        .HasColumnType("integer")
                        .HasColumnName("PointAreaID");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("PCCC.Data.Entities.Building", b =>
                {
                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.Property<int>("ApartmentUserId")
                        .HasColumnType("integer")
                        .HasColumnName("ApartmentUserID");

                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<int>("FloorCount")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .HasColumnType("character varying");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("PCCC.Data.Entities.Content", b =>
                {
                    b.Property<string>("Color")
                        .HasColumnType("character varying");

                    b.Property<string>("Content1")
                        .HasColumnType("text")
                        .HasColumnName("Content");

                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<string>("Icon")
                        .HasColumnType("character varying");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    b.Property<string>("Image")
                        .HasColumnType("character varying");

                    b.Property<BitArray>("IsActive")
                        .IsRequired()
                        .HasColumnType("bit(1)");

                    b.Property<string>("Link")
                        .HasColumnType("character varying");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("PCCC.Data.Entities.Map", b =>
                {
                    b.Property<int>("AreaId")
                        .HasColumnType("integer")
                        .HasColumnName("AreaID");

                    b.Property<int>("BuiildingId")
                        .HasColumnType("integer")
                        .HasColumnName("BuiildingID");

                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("integer");

                    b.Property<float>("Height")
                        .HasColumnType("real");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    b.Property<string>("Image")
                        .HasColumnType("character varying");

                    b.Property<float>("Length")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<float>("Width")
                        .HasColumnType("real");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("PCCC.Data.Entities.News", b =>
                {
                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    b.Property<string>("Image")
                        .HasColumnType("character varying");

                    b.Property<BitArray>("IsActive")
                        .IsRequired()
                        .HasColumnType("bit(1)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.ToTable("News");
                });

            modelBuilder.Entity("PCCC.Data.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("RoleID");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("UserID");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("PCCC.Data.Entities.PointArea", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("ID");

                    b.Property<int>("X")
                        .HasColumnType("integer");

                    b.Property<int>("Y")
                        .HasColumnType("integer");

                    b.ToTable("PointAreas");
                });

            modelBuilder.Entity("PCCC.Data.Entities.Role", b =>
                {
                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    b.Property<BitArray>("IsActive")
                        .IsRequired()
                        .HasColumnType("bit(1)");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PCCC.Data.Entities.User", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("character varying");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<long?>("ApartmentUserId")
                        .HasColumnType("bigint")
                        .HasColumnName("ApartmentUserID");

                    b.Property<long?>("BuildingId")
                        .HasColumnType("bigint")
                        .HasColumnName("BuildingID");

                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<string>("CreatorUserName")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.Property<string>("FullName")
                        .HasColumnType("character varying");

                    b.Property<string[]>("Gmail")
                        .HasColumnType("character varying(256)[]");

                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    b.Property<int>("IsActive")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("character varying");

                    b.Property<string[]>("Phone")
                        .IsRequired()
                        .HasColumnType("character varying(15)[]");

                    b.Property<bool>("Sex")
                        .HasColumnType("boolean");

                    b.Property<long?>("UpgradeAccId")
                        .HasColumnType("bigint")
                        .HasColumnName("UpgradeAccID");

                    b.Property<string[]>("UserName")
                        .IsRequired()
                        .HasColumnType("character varying(256)[]");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PCCC.Data.Entities.UserRole", b =>
                {
                    b.Property<DateOnly>("CreationTime")
                        .HasColumnType("date");

                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("ID");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("RoleID");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("UserID");

                    b.ToTable("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
