using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_DO.Migrations
{
    public partial class tasktodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "ToDoTask");

            migrationBuilder.CreateTable(
                name: "ToDoItem",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItem", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_ToDoItem_ToDoTask_TaskId",
                        column: x => x.TaskId,
                        principalTable: "ToDoTask",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItem_TaskId",
                table: "ToDoItem",
                column: "TaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoItem");

            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "ToDoTask",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
