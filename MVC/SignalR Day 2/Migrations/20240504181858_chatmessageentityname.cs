using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR_Day_2.Migrations
{
    /// <inheritdoc />
    public partial class chatmessageentityname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "ChatMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "ChatMessages");
        }
    }
}
