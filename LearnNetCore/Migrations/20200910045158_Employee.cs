using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnNetCore.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_m_mployee",
                columns: table => new
                {
                    EmpId = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTimeOffset>(nullable: false),
                    UpdateTime = table.Column<DateTimeOffset>(nullable: false),
                    DeleteTime = table.Column<DateTimeOffset>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_m_mployee", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_tb_m_mployee_tb_m_user_EmpId",
                        column: x => x.EmpId,
                        principalTable: "tb_m_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_m_mployee");
        }
    }
}
