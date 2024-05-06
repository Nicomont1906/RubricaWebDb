using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace montaspro.nicolo._4i.rubricaWebDb.Migrations
{
    /// <inheritdoc />
    public partial class AggiuntaEmailOK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Persone",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Persone");
        }
    }
}
