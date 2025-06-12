using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class addedpriceandfrequencycolumnswithDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Frequency",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1,
                columns: new[] { "Frequency", "Price" },
                values: new object[] { 0, 1000 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2,
                columns: new[] { "Frequency", "Price" },
                values: new object[] { 0, 2000 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 3,
                columns: new[] { "Frequency", "Price" },
                values: new object[] { 0, 5000 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 4,
                columns: new[] { "Frequency", "Price" },
                values: new object[] { 0, 5500 });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 5,
                columns: new[] { "Frequency", "Price" },
                values: new object[] { 0, 6000 });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "Frequency", "Img", "Name", "Price", "Specialization" },
                values: new object[,]
                {
                    { 6, 0, "Images/doctor1.jpg", "Dr. Salah Smith", 3000, "Cardiology" },
                    { 7, 0, "Images/doctor2.jpg", "Dr. Ahmed Ali", 5000, "Pediatrics" },
                    { 8, 0, "Images/doctor4.jpg", "Dr. Ammar Mohammed", 1000, "Dermatology" },
                    { 9, 0, "Images/doctor3.jpg", "Dr. Khaled Lee", 2200, "Orthopedics" },
                    { 10, 0, "Images/doctor5.jpg", "Dr. Lee Clark", 3300, "Neurology" },
                    { 11, 0, "Images/doctor1.jpg", "Dr. Eslam Lee", 1000, "Cardiology" },
                    { 12, 0, "Images/doctor2.jpg", "Dr. Mofid Johnson", 2000, "Pediatrics" },
                    { 13, 0, "Images/doctor4.jpg", "Dr. Omar Ali", 5000, "Dermatology" },
                    { 14, 0, "Images/doctor3.jpg", "Dr. Mahmoud Ismail", 5500, "Orthopedics" },
                    { 15, 0, "Images/doctor5.jpg", "Dr. Ismail mohammed", 6000, "Neurology" },
                    { 16, 0, "Images/doctor1.jpg", "Dr. Smith Simba", 2000, "Cardiology" },
                    { 17, 0, "Images/doctor2.jpg", "Dr. Mosamba Johnson", 7000, "Pediatrics" },
                    { 18, 0, "Images/doctor4.jpg", "Dr. Mousa Davis", 10000, "Dermatology" },
                    { 19, 0, "Images/doctor3.jpg", "Dr. Yaqoub Smith", 6500, "Orthopedics" },
                    { 20, 0, "Images/doctor5.jpg", "Dr. Lee Donald", 6700, "Neurology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Doctors");
        }
    }
}
