#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RMS.Infrastructure.Migrations;

/// <inheritdoc />
public partial class CreateInitialize : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "Customer",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy",
                        NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                FullName = table.Column<string>("character varying(100)", maxLength: 100, nullable: false),
                Email = table.Column<string>("character varying(100)", maxLength: 100, nullable: false),
                Address = table.Column<string>("text", nullable: true),
                PhoneNumber = table.Column<string>("character varying(100)", maxLength: 100, nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Customer", x => x.Id); });

        migrationBuilder.CreateTable(
            "MenuItem",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy",
                        NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Name = table.Column<string>("character varying(100)", maxLength: 100, nullable: false),
                Description = table.Column<string>("character varying(256)", maxLength: 256, nullable: false),
                Price = table.Column<decimal>("numeric(18,2)", precision: 18, scale: 2, nullable: false),
                Category = table.Column<string>("text", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_MenuItem", x => x.Id); });

        migrationBuilder.CreateTable(
            "ReservationTable",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy",
                        NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Number = table.Column<int>("integer", nullable: false),
                Capacity = table.Column<int>("integer", nullable: false),
                Status = table.Column<string>("text", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_ReservationTable", x => x.Id); });

        migrationBuilder.CreateTable(
            "RoleClaims",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false),
                RoleId = table.Column<string>("text", nullable: true),
                ClaimType = table.Column<string>("text", nullable: true),
                ClaimValue = table.Column<string>("text", nullable: true)
            },
            constraints: table => { });

        migrationBuilder.CreateTable(
            "Roles",
            table => new
            {
                Id = table.Column<string>("text", nullable: true),
                Name = table.Column<string>("text", nullable: true),
                NormalizedName = table.Column<string>("text", nullable: true),
                ConcurrencyStamp = table.Column<string>("text", nullable: true)
            },
            constraints: table => { });

        migrationBuilder.CreateTable(
            "UserClaims",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false),
                UserId = table.Column<string>("text", nullable: true),
                ClaimType = table.Column<string>("text", nullable: true),
                ClaimValue = table.Column<string>("text", nullable: true)
            },
            constraints: table => { });

        migrationBuilder.CreateTable(
            "UserLogins",
            table => new
            {
                LoginProvider = table.Column<string>("text", nullable: false),
                ProviderKey = table.Column<string>("text", nullable: false),
                ProviderDisplayName = table.Column<string>("text", nullable: true),
                UserId = table.Column<string>("text", nullable: true)
            },
            constraints: table => { });

        migrationBuilder.CreateTable(
            "UserRoles",
            table => new
            {
                UserId = table.Column<string>("text", nullable: true),
                RoleId = table.Column<string>("text", nullable: true)
            },
            constraints: table => { });

        migrationBuilder.CreateTable(
            "Users",
            table => new
            {
                Id = table.Column<string>("text", nullable: false),
                UserName = table.Column<string>("text", nullable: true),
                NormalizedUserName = table.Column<string>("text", nullable: true),
                Email = table.Column<string>("text", nullable: true),
                NormalizedEmail = table.Column<string>("text", nullable: true),
                EmailConfirmed = table.Column<bool>("boolean", nullable: false),
                PasswordHash = table.Column<string>("text", nullable: true),
                SecurityStamp = table.Column<string>("text", nullable: true),
                ConcurrencyStamp = table.Column<string>("text", nullable: true),
                PhoneNumber = table.Column<string>("text", nullable: true),
                PhoneNumberConfirmed = table.Column<bool>("boolean", nullable: false),
                TwoFactorEnabled = table.Column<bool>("boolean", nullable: false),
                LockoutEnd = table.Column<DateTimeOffset>("timestamp with time zone", nullable: true),
                LockoutEnabled = table.Column<bool>("boolean", nullable: false),
                AccessFailedCount = table.Column<int>("integer", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Users", x => x.Id); });

        migrationBuilder.CreateTable(
            "UserTokens",
            table => new
            {
                UserId = table.Column<string>("text", nullable: true),
                LoginProvider = table.Column<string>("text", nullable: false),
                Name = table.Column<string>("text", nullable: false),
                Value = table.Column<string>("text", nullable: true)
            },
            constraints: table => { });

        migrationBuilder.CreateTable(
            "Order",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy",
                        NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                OrderTime = table.Column<DateTime>("timestamp with time zone", nullable: false),
                Location = table.Column<string>("character varying(100)", maxLength: 100, nullable: false),
                TotalPrice = table.Column<decimal>("numeric(18,2)", precision: 18, scale: 2, nullable: false),
                Type = table.Column<string>("text", nullable: false),
                CustomerId = table.Column<int>("integer", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Order", x => x.Id);
                table.ForeignKey(
                    "FK_Order_Customer_CustomerId",
                    x => x.CustomerId,
                    "Customer",
                    "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            "Reservation",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy",
                        NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                ReservedDate = table.Column<DateTime>("timestamp with time zone", nullable: false),
                NumberOfGuests = table.Column<int>("integer", nullable: false),
                CustomerId = table.Column<int>("integer", nullable: false),
                ReservationTableId = table.Column<int>("integer", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Reservation", x => x.Id);
                table.ForeignKey(
                    "FK_Reservation_Customer_CustomerId",
                    x => x.CustomerId,
                    "Customer",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_Reservation_ReservationTable_ReservationTableId",
                    x => x.ReservationTableId,
                    "ReservationTable",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "OrderItem",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy",
                        NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Count = table.Column<double>("double precision", nullable: false),
                Status = table.Column<string>("text", nullable: false),
                MenuItemId = table.Column<int>("integer", nullable: false),
                OrderId = table.Column<int>("integer", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_OrderItem", x => x.Id);
                table.ForeignKey(
                    "FK_OrderItem_MenuItem_MenuItemId",
                    x => x.MenuItemId,
                    "MenuItem",
                    "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    "FK_OrderItem_Order_OrderId",
                    x => x.OrderId,
                    "Order",
                    "Id");
            });

        migrationBuilder.CreateTable(
            "Payment",
            table => new
            {
                Id = table.Column<int>("integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy",
                        NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                PaymentDate = table.Column<DateTime>("timestamp with time zone", nullable: false),
                PaymentAmount = table.Column<decimal>("numeric(18,2)", precision: 18, scale: 2, nullable: false),
                Type = table.Column<string>("text", nullable: false),
                Status = table.Column<string>("text", nullable: false),
                OrderId = table.Column<int>("integer", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Payment", x => x.Id);
                table.ForeignKey(
                    "FK_Payment_Order_OrderId",
                    x => x.OrderId,
                    "Order",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            "IX_Order_CustomerId",
            "Order",
            "CustomerId");

        migrationBuilder.CreateIndex(
            "IX_OrderItem_MenuItemId",
            "OrderItem",
            "MenuItemId");

        migrationBuilder.CreateIndex(
            "IX_OrderItem_OrderId",
            "OrderItem",
            "OrderId");

        migrationBuilder.CreateIndex(
            "IX_Payment_OrderId",
            "Payment",
            "OrderId",
            unique: true);

        migrationBuilder.CreateIndex(
            "IX_Reservation_CustomerId",
            "Reservation",
            "CustomerId");

        migrationBuilder.CreateIndex(
            "IX_Reservation_ReservationTableId",
            "Reservation",
            "ReservationTableId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "OrderItem");

        migrationBuilder.DropTable(
            "Payment");

        migrationBuilder.DropTable(
            "Reservation");

        migrationBuilder.DropTable(
            "RoleClaims");

        migrationBuilder.DropTable(
            "Roles");

        migrationBuilder.DropTable(
            "UserClaims");

        migrationBuilder.DropTable(
            "UserLogins");

        migrationBuilder.DropTable(
            "UserRoles");

        migrationBuilder.DropTable(
            "Users");

        migrationBuilder.DropTable(
            "UserTokens");

        migrationBuilder.DropTable(
            "MenuItem");

        migrationBuilder.DropTable(
            "Order");

        migrationBuilder.DropTable(
            "ReservationTable");

        migrationBuilder.DropTable(
            "Customer");
    }
}