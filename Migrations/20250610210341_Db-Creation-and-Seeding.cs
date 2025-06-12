using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class DbCreationandSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "Img", "Name", "Specialization" },
                values: new object[,]
                {
                    { 1, "Images/doctor1.jpg", "Dr. John Smith", "Cardiology" },
                    { 2, "Images/doctor2.jpg", "Dr. Sarah Johnson", "Pediatrics" },
                    { 3, "Images/doctor4.jpg", "Dr. Emily Davis", "Dermatology" },
                    { 4, "Images/doctor3.jpg", "Dr. Michael Lee", "Orthopedics" },
                    { 5, "Images/doctor5.jpg", "Dr. William Clark", "Neurology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
