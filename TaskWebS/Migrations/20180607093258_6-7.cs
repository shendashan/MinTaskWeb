using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TaskWebS.Migrations
{
    public partial class _67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskErrors",
                columns: table => new
                {
                    TaskErrorId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    DeleteUserId = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    TaskErrorCurrentTime = table.Column<DateTime>(nullable: false),
                    TaskErrorMessage = table.Column<string>(maxLength: 500, nullable: true),
                    TaskErrorName = table.Column<string>(maxLength: 50, nullable: true),
                    TaskErrorTag = table.Column<string>(maxLength: 30, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskErrors", x => x.TaskErrorId);
                });

            migrationBuilder.CreateTable(
                name: "TaskTags",
                columns: table => new
                {
                    TaskTagId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    DeleteUserId = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    TaskTagName = table.Column<string>(maxLength: 12, nullable: true),
                    TaskTagRemark = table.Column<string>(maxLength: 120, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTags", x => x.TaskTagId);
                });

            migrationBuilder.CreateTable(
                name: "TaskUsers",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    DeleteUserId = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<long>(nullable: false),
                    UserLoginName = table.Column<string>(maxLength: 16, nullable: true),
                    UserName = table.Column<string>(maxLength: 16, nullable: true),
                    UserPhone = table.Column<string>(maxLength: 36, nullable: true),
                    UserPwd = table.Column<string>(maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskUsers", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "TaskTables",
                columns: table => new
                {
                    TaskId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    DeleteUserId = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    TagId = table.Column<long>(nullable: false),
                    TaskName = table.Column<string>(maxLength: 36, nullable: true),
                    TaskRemark = table.Column<string>(maxLength: 250, nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTables", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_TaskTables_TaskTags_TagId",
                        column: x => x.TagId,
                        principalTable: "TaskTags",
                        principalColumn: "TaskTagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskAndUsers",
                columns: table => new
                {
                    UserAndTaskId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    DeleteUserId = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    TaskId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAndUsers", x => x.UserAndTaskId);
                    table.ForeignKey(
                        name: "FK_TaskAndUsers_TaskTables_TaskId",
                        column: x => x.TaskId,
                        principalTable: "TaskTables",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskAndUsers_TaskUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "TaskUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskMessages",
                columns: table => new
                {
                    TaskMessageId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateUserId = table.Column<long>(nullable: false),
                    DeleteTime = table.Column<DateTime>(nullable: false),
                    DeleteUserId = table.Column<long>(nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    MessageContent = table.Column<string>(maxLength: 250, nullable: true),
                    TaskId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateUserId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskMessages", x => x.TaskMessageId);
                    table.ForeignKey(
                        name: "FK_TaskMessages_TaskTables_TaskId",
                        column: x => x.TaskId,
                        principalTable: "TaskTables",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskMessages_TaskUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "TaskUsers",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskAndUsers_TaskId",
                table: "TaskAndUsers",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAndUsers_UserId",
                table: "TaskAndUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskMessages_TaskId",
                table: "TaskMessages",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskMessages_UserId",
                table: "TaskMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTables_TagId",
                table: "TaskTables",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskAndUsers");

            migrationBuilder.DropTable(
                name: "TaskErrors");

            migrationBuilder.DropTable(
                name: "TaskMessages");

            migrationBuilder.DropTable(
                name: "TaskTables");

            migrationBuilder.DropTable(
                name: "TaskUsers");

            migrationBuilder.DropTable(
                name: "TaskTags");
        }
    }
}
