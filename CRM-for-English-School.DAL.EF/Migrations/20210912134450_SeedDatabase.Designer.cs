﻿// <auto-generated />
using System;
using CRM_for_English_School.DAL.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRM_for_English_School.DAL.EF.Migrations
{
    [DbContext(typeof(EnglishSchoolContext))]
    [Migration("20210912134450_SeedDatabase")]
    partial class SeedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnglishLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpectedStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "English for Adults",
                            EnglishLevel = 1,
                            ExpectedStartDate = new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "English for Business",
                            EnglishLevel = 2,
                            ExpectedStartDate = new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CurrentEnglishLevel")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Requests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 23,
                            Email = "IvanIvanov@gmail.com",
                            FirstName = "Иван",
                            LastName = "Иванов",
                            MiddleName = "Иванович",
                            PhoneNumber = "+375(29)888-88-88",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            Email = "PetrPetrov@gmail.com",
                            FirstName = "Петр",
                            LastName = "Петров",
                            MiddleName = "Петрович",
                            PhoneNumber = "+375(33)454-44-55",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Age = 22,
                            Email = "OlgaSinicina@gmail.com",
                            FirstName = "Ольга",
                            LastName = "Синицина",
                            MiddleName = "Дмитриевна",
                            PhoneNumber = "+375(33)776-54-32",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Age = 23,
                            Email = "DariaVasnecova@gmail.com",
                            FirstName = "Дарья",
                            LastName = "Васнецова",
                            MiddleName = "Петровна",
                            PhoneNumber = "+375(29)447-12-64",
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Age = 25,
                            Email = "SergeiKurablev@gmail.com",
                            FirstName = "Сергей",
                            LastName = "Кураблев",
                            MiddleName = "Иванович",
                            PhoneNumber = "+375(29)987-16-48",
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            Age = 23,
                            Email = "IrinaEgorova@gmail.com",
                            FirstName = "Ирина",
                            LastName = "Егорова",
                            MiddleName = "Владимировна",
                            PhoneNumber = "+375(29)875-65-32",
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            Age = 21,
                            Email = "IgorUrigoev@gmail.com",
                            FirstName = "Игорь",
                            LastName = "Уригоев",
                            MiddleName = "Александрович",
                            PhoneNumber = "+375(29)129-45-78",
                            Status = 0
                        },
                        new
                        {
                            Id = 8,
                            Age = 27,
                            Email = "KateAltova@gmail.com",
                            FirstName = "Екатерина",
                            LastName = "Альтова",
                            MiddleName = "Станиславовна",
                            PhoneNumber = "+375(29)852-36-14",
                            Status = 0
                        },
                        new
                        {
                            Id = 9,
                            Age = 25,
                            Email = "SvetlanaZalikova@gmail.com",
                            FirstName = "Светлана",
                            LastName = "Заликова",
                            MiddleName = "Викторовна",
                            PhoneNumber = "+375(29)752-86-19",
                            Status = 0
                        },
                        new
                        {
                            Id = 10,
                            Age = 24,
                            Email = "DmitriKrilov@gmail.com",
                            FirstName = "Дмитрий",
                            LastName = "Крылов",
                            MiddleName = "Иванович",
                            PhoneNumber = "+375(29)782-22-19",
                            Status = 0
                        },
                        new
                        {
                            Id = 11,
                            Age = 22,
                            Email = "AndleiBurkin@gmail.com",
                            FirstName = "Андрей",
                            LastName = "Буркин",
                            MiddleName = "Петрович",
                            PhoneNumber = "+375(29)982-76-78",
                            Status = 0
                        },
                        new
                        {
                            Id = 12,
                            Age = 32,
                            Email = "SergeiZnakov@gmail.com",
                            FirstName = "Сергей",
                            LastName = "Знаков",
                            MiddleName = "Степанович",
                            PhoneNumber = "+375(29)181-29-92",
                            Status = 0
                        },
                        new
                        {
                            Id = 13,
                            Age = 23,
                            Email = "StepanHoroshigin@gmail.com",
                            FirstName = "Степан",
                            LastName = "Хорошигин",
                            MiddleName = "Григорьевич",
                            PhoneNumber = "+375(29)455-62-38",
                            Status = 0
                        },
                        new
                        {
                            Id = 14,
                            Age = 29,
                            Email = "VictoriaKlim@gmail.com",
                            FirstName = "Виктория",
                            LastName = "Клим",
                            MiddleName = "Андреевна",
                            PhoneNumber = "+375(29)842-97-31",
                            Status = 0
                        },
                        new
                        {
                            Id = 15,
                            Age = 26,
                            Email = "FedorKurabenko@gmail.com",
                            FirstName = "Федор",
                            LastName = "Курабенко",
                            MiddleName = "Ильич",
                            PhoneNumber = "+375(29)872-96-42",
                            Status = 0
                        },
                        new
                        {
                            Id = 16,
                            Age = 30,
                            Email = "GalinaKlimenko@gmail.com",
                            FirstName = "Галина",
                            LastName = "Клименко",
                            MiddleName = "Федоровна",
                            PhoneNumber = "+375(29)149-75-63",
                            Status = 0
                        });
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CurrentEnglishLevel")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("GroupdId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.StudentsGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnglishLevel")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentsGroups");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraduatedFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainSpecialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 35,
                            Degree = 1,
                            Email = "SvetlanaFedorova@gmail.com",
                            FirstName = "Светлана",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Федорова",
                            MainSpecialization = "Теоретическая и прикладная лингвистика",
                            MiddleName = "Георгиевна",
                            PhoneNumber = "+375(29)654-45-67"
                        },
                        new
                        {
                            Id = 2,
                            Age = 29,
                            Degree = 0,
                            Email = "KateKalinina@gmail.com",
                            FirstName = "Екатерина",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Калинина",
                            MainSpecialization = "Современные иностранные языки",
                            MiddleName = "Викторовна",
                            PhoneNumber = "+375(33)151-16-19"
                        },
                        new
                        {
                            Id = 3,
                            Age = 27,
                            Degree = 0,
                            Email = "IrinaStupco@gmail.com",
                            FirstName = "Ирина",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Ступко",
                            MainSpecialization = "Современные иностранные языки",
                            MiddleName = "Андреевна",
                            PhoneNumber = "+375(33)742-86-95"
                        },
                        new
                        {
                            Id = 4,
                            Age = 31,
                            Degree = 1,
                            Email = "KseniaFursina@gmail.com",
                            FirstName = "Ксения",
                            GraduatedFrom = "МГЛУ",
                            LastName = "Фурсина",
                            MainSpecialization = "Теоретическая и прикладная лингвистика",
                            MiddleName = "Петровна",
                            PhoneNumber = "+375(33)87565-41"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Student", b =>
                {
                    b.HasOne("CRM_for_English_School.BLL.Entities.StudentsGroup", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.StudentsGroup", b =>
                {
                    b.HasOne("CRM_for_English_School.BLL.Entities.Teacher", "Teacher")
                        .WithMany("Groups")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.StudentsGroup", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("CRM_for_English_School.BLL.Entities.Teacher", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
