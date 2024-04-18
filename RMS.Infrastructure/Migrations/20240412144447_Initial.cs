﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RMS.Infrastructure.Migrations;

/// <inheritdoc />
public partial class Initial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Customer",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                Address = table.Column<string>(type: "text", nullable: true),
                PhoneNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Customer", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "MenuItem",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                Description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                Price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                Category = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MenuItem", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Reservation",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                NumberOfGuests = table.Column<int>(type: "integer", nullable: false),
                CustomerId = table.Column<int>(type: "integer", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Reservation", x => x.Id);
                table.ForeignKey(
                    name: "FK_Reservation_Customer_CustomerId",
                    column: x => x.CustomerId,
                    principalTable: "Customer",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Order",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                OrderTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                Location = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                TotalPrice = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                Type = table.Column<string>(type: "text", nullable: false),
                CustomerId = table.Column<int>(type: "integer", nullable: false),
                TableId = table.Column<int>(type: "integer", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Order", x => x.Id);
                table.ForeignKey(
                    name: "FK_Order_Customer_CustomerId",
                    column: x => x.CustomerId,
                    principalTable: "Customer",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });

        migrationBuilder.CreateTable(
            name: "OrderItem",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                MenuItemId = table.Column<int>(type: "integer", nullable: false),
                Count = table.Column<double>(type: "double precision", nullable: false),
                Status = table.Column<string>(type: "text", nullable: false),
                OrderId = table.Column<int>(type: "integer", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_OrderItem", x => x.Id);
                table.ForeignKey(
                    name: "FK_OrderItem_MenuItem_MenuItemId",
                    column: x => x.MenuItemId,
                    principalTable: "MenuItem",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
                table.ForeignKey(
                    name: "FK_OrderItem_Order_OrderId",
                    column: x => x.OrderId,
                    principalTable: "Order",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "Payment",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                PaymentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                PaymentAmount = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                Type = table.Column<string>(type: "text", nullable: false),
                Status = table.Column<string>(type: "text", nullable: false),
                OrderId = table.Column<int>(type: "integer", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Payment", x => x.Id);
                table.ForeignKey(
                    name: "FK_Payment_Order_OrderId",
                    column: x => x.OrderId,
                    principalTable: "Order",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Table",
            columns: table => new
            {
                Id = table.Column<int>(type: "integer", nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                Number = table.Column<int>(type: "integer", nullable: false),
                Capacity = table.Column<int>(type: "integer", nullable: false),
                Status = table.Column<string>(type: "text", nullable: false),
                OrderId = table.Column<int>(type: "integer", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Table", x => x.Id);
                table.ForeignKey(
                    name: "FK_Table_Order_OrderId",
                    column: x => x.OrderId,
                    principalTable: "Order",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateIndex(
            name: "IX_Order_CustomerId",
            table: "Order",
            column: "CustomerId");

        migrationBuilder.CreateIndex(
            name: "IX_Order_TableId",
            table: "Order",
            column: "TableId");

        migrationBuilder.CreateIndex(
            name: "IX_OrderItem_MenuItemId",
            table: "OrderItem",
            column: "MenuItemId");

        migrationBuilder.CreateIndex(
            name: "IX_OrderItem_OrderId",
            table: "OrderItem",
            column: "OrderId");

        migrationBuilder.CreateIndex(
            name: "IX_Payment_OrderId",
            table: "Payment",
            column: "OrderId",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_Reservation_CustomerId",
            table: "Reservation",
            column: "CustomerId");

        migrationBuilder.CreateIndex(
            name: "IX_Table_OrderId",
            table: "Table",
            column: "OrderId");

        migrationBuilder.AddForeignKey(
            name: "FK_Order_Table_TableId",
            table: "Order",
            column: "TableId",
            principalTable: "Table",
            principalColumn: "Id",
            onDelete: ReferentialAction.Restrict);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Order_Customer_CustomerId",
            table: "Order");

        migrationBuilder.DropForeignKey(
            name: "FK_Order_Table_TableId",
            table: "Order");

        migrationBuilder.DropTable(
            name: "OrderItem");

        migrationBuilder.DropTable(
            name: "Payment");

        migrationBuilder.DropTable(
            name: "Reservation");

        migrationBuilder.DropTable(
            name: "MenuItem");

        migrationBuilder.DropTable(
            name: "Customer");

        migrationBuilder.DropTable(
            name: "Table");

        migrationBuilder.DropTable(
            name: "Order");
    }
}
