using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppEFCoreWithRepoPattern.Migrations
{
    /// <inheritdoc />
    public partial class newcol_phno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhNo",
                table: "Students",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_PhNo",
                table: "Students",
                column: "PhNo",
                unique: true,
                filter: "[PhNo] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_PhNo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhNo",
                table: "Students");
        }
    }
}
