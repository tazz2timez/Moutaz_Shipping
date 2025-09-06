using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLibraray.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MessageTemplate = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Level = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "Date", nullable: true),
                    Exception = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KiloMeterRate = table.Column<double>(type: "float", nullable: true),
                    KilooGramRate = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbCarriers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CarrierName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCarriers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbCarriers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbCarriers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbCountries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CountryAname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CountryEname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCountries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbCountries_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbCountries_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbPaymentMethods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    MethdAname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MethodEname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Commission = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbPaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbPaymentMethods_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbPaymentMethods_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbShippingTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ShippingTypeAname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShippingTypeEname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShippingFactor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbShippingTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbShippingTypes_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbShippingTypes_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbSubscriptionPackages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    PackageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ShippimentCount = table.Column<int>(type: "int", nullable: false),
                    NumberOfKiloMeters = table.Column<double>(type: "float", nullable: false),
                    TotalWeight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbSubscriptionPackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbSubscriptionPackages_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbSubscriptionPackages_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbCities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    CityAname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CityEname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbCities_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbCities_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbCities_TbCountries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "TbCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbUserSubscriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUserSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbUserSubscriptions_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbUserSubscriptions_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbUserSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbUserSubscriptions_TbSubscriptionPackages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "TbSubscriptionPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbUserReceivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUserReceivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbUserReceivers_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbUserReceivers_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbUserReceivers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbUserReceivers_TbCities_CityId",
                        column: x => x.CityId,
                        principalTable: "TbCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbUserSenders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUserSenders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbUserSenders_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbUserSenders_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbUserSenders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbUserSenders_TbCities_CityId",
                        column: x => x.CityId,
                        principalTable: "TbCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbShippments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ShippingDate = table.Column<DateTime>(type: "Date", nullable: false),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    PackageValue = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ShippingRate = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    PaymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrackingNumber = table.Column<double>(type: "float", nullable: true),
                    ReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbShippments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbShippments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbShippments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbShippments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbShippments_TbPaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "TbPaymentMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TbShippments_TbShippingTypes_ShippingTypeId",
                        column: x => x.ShippingTypeId,
                        principalTable: "TbShippingTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbShippments_TbUserReceivers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "TbUserReceivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbShippments_TbUserSenders_SenderId",
                        column: x => x.SenderId,
                        principalTable: "TbUserSenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbShippmentStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentState = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "Date", nullable: true),
                    ShippmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CarrierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbShippmentStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbShippmentStatuses_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbShippmentStatuses_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TbShippmentStatuses_TbCarriers_CarrierId",
                        column: x => x.CarrierId,
                        principalTable: "TbCarriers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbShippmentStatuses_TbShippments_ShippmentId",
                        column: x => x.ShippmentId,
                        principalTable: "TbShippments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TbCarriers_CreatedBy",
                table: "TbCarriers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbCarriers_UpdatedBy",
                table: "TbCarriers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbCities_CountryId",
                table: "TbCities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TbCities_CreatedBy",
                table: "TbCities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbCities_UpdatedBy",
                table: "TbCities",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbCountries_CreatedBy",
                table: "TbCountries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbCountries_UpdatedBy",
                table: "TbCountries",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbPaymentMethods_CreatedBy",
                table: "TbPaymentMethods",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbPaymentMethods_UpdatedBy",
                table: "TbPaymentMethods",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippingTypes_CreatedBy",
                table: "TbShippingTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippingTypes_UpdatedBy",
                table: "TbShippingTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippments_CreatedBy",
                table: "TbShippments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippments_PaymentMethodId",
                table: "TbShippments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippments_ReceiverId",
                table: "TbShippments",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippments_SenderId",
                table: "TbShippments",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippments_ShippingTypeId",
                table: "TbShippments",
                column: "ShippingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippments_UpdatedBy",
                table: "TbShippments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippments_UserId",
                table: "TbShippments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippmentStatuses_CarrierId",
                table: "TbShippmentStatuses",
                column: "CarrierId");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippmentStatuses_CreatedBy",
                table: "TbShippmentStatuses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippmentStatuses_ShippmentId",
                table: "TbShippmentStatuses",
                column: "ShippmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TbShippmentStatuses_UpdatedBy",
                table: "TbShippmentStatuses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbSubscriptionPackages_CreatedBy",
                table: "TbSubscriptionPackages",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbSubscriptionPackages_UpdatedBy",
                table: "TbSubscriptionPackages",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserReceivers_CityId",
                table: "TbUserReceivers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserReceivers_CreatedBy",
                table: "TbUserReceivers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserReceivers_UpdatedBy",
                table: "TbUserReceivers",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserReceivers_UserId",
                table: "TbUserReceivers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSenders_CityId",
                table: "TbUserSenders",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSenders_CreatedBy",
                table: "TbUserSenders",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSenders_UpdatedBy",
                table: "TbUserSenders",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSenders_UserId",
                table: "TbUserSenders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSubscriptions_CreatedBy",
                table: "TbUserSubscriptions",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSubscriptions_PackageId",
                table: "TbUserSubscriptions",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSubscriptions_UpdatedBy",
                table: "TbUserSubscriptions",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TbUserSubscriptions_UserId",
                table: "TbUserSubscriptions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "TbSettings");

            migrationBuilder.DropTable(
                name: "TbShippmentStatuses");

            migrationBuilder.DropTable(
                name: "TbUserSubscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TbCarriers");

            migrationBuilder.DropTable(
                name: "TbShippments");

            migrationBuilder.DropTable(
                name: "TbSubscriptionPackages");

            migrationBuilder.DropTable(
                name: "TbPaymentMethods");

            migrationBuilder.DropTable(
                name: "TbShippingTypes");

            migrationBuilder.DropTable(
                name: "TbUserReceivers");

            migrationBuilder.DropTable(
                name: "TbUserSenders");

            migrationBuilder.DropTable(
                name: "TbCities");

            migrationBuilder.DropTable(
                name: "TbCountries");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
