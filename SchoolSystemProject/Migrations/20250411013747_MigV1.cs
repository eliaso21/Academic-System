using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolSystemProject.Migrations
{
    /// <inheritdoc />
    public partial class MigV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    St_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    St_FName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    St_LName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    St_Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.St_ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CrsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CrsDuration = table.Column<int>(type: "int", nullable: true),
                    DeptID = table.Column<int>(type: "int", nullable: false),
                    InsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CrsID);
                });

            migrationBuilder.CreateTable(
                name: "Std_Courses",
                columns: table => new
                {
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Std_Courses", x => new { x.StdID, x.CrsID });
                    table.ForeignKey(
                        name: "FK_Std_Courses_Courses_CrsID",
                        column: x => x.CrsID,
                        principalTable: "Courses",
                        principalColumn: "CrsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Std_Courses_Students_StdID",
                        column: x => x.StdID,
                        principalTable: "Students",
                        principalColumn: "St_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crs_Sessions",
                columns: table => new
                {
                    CrsSID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsID = table.Column<int>(type: "int", nullable: true),
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crs_Sessions", x => x.CrsSID);
                    table.ForeignKey(
                        name: "FK_Crs_Sessions_Courses_CrsID",
                        column: x => x.CrsID,
                        principalTable: "Courses",
                        principalColumn: "CrsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrsSessionAtts",
                columns: table => new
                {
                    CrsSAID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrsSessionID = table.Column<int>(type: "int", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrsSessionAtts", x => x.CrsSAID);
                    table.ForeignKey(
                        name: "FK_CrsSessionAtts_Crs_Sessions_CrsSessionID",
                        column: x => x.CrsSessionID,
                        principalTable: "Crs_Sessions",
                        principalColumn: "CrsSID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrsSessionAtts_Students_StdID",
                        column: x => x.StdID,
                        principalTable: "Students",
                        principalColumn: "St_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Dept_Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ManagerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsFName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    InsLName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Dept_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InsID);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dept_ID",
                        column: x => x.Dept_ID,
                        principalTable: "Departments",
                        principalColumn: "Dept_ID");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Dept_ID", "Dept_Location", "Dept_Name", "ManagerID" },
                values: new object[,]
                {
                    { 1, "Ismailia Branch Building, 2nd Floor", "SD", null },
                    { 2, "Ismailia Branch Building, 2nd Floor", "UI", null },
                    { 3, "Ismailia Branch Building, 2nd Floor", "Cloud", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "St_ID", "St_FName", "St_LName", "St_Phone" },
                values: new object[,]
                {
                    { 1, "Mohamed", "Abdelsadek", "01555384156" },
                    { 2, "Ammar", "Atef", "01289658512" },
                    { 3, "Ahmed", "Nasr", "01123659863" },
                    { 4, "Youssef", "Abdelgawad", "010301456852" },
                    { 5, "Abdelrahman", "Eletr", "01147845632" },
                    { 6, "Ahmed", "Elsakka", "01214568122" },
                    { 7, "Omar", "Shanshan", "01010487861" },
                    { 8, "Abdallah", "Khaled", "01123659866" },
                    { 9, "Mohamed", "Ghareeb", "01155440123" },
                    { 10, "Sayed", "Abdelhafiz", "01550507768" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InsID", "Dept_ID", "InsFName", "InsLName", "Phone", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "Mohamed", "Elmalaky", "01016297668", 6000m },
                    { 2, 1, "Beshoy", "Emad", "01004190041", 10000m },
                    { 3, 2, "Mando", "Saad", "01550507768", 3000m },
                    { 4, 1, "Mohamed", "Elhadary", "01010556101", 2000m },
                    { 5, 2, "Yasmin", "Raeis", "01004117122", 6000m },
                    { 6, 3, "Yaser", "Arafat", "01100488122", 9000m }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CrsID", "CrsDuration", "CrsName", "DeptID", "InsID" },
                values: new object[,]
                {
                    { 1, 2, "HTML", 2, 3 },
                    { 2, 2, "CSS", 2, 3 },
                    { 3, 2, "JS", 1, 1 },
                    { 4, 2, "OOP", 1, 1 },
                    { 5, 2, "Bootstrap", 1, 4 },
                    { 6, 2, "OS", 1, 2 },
                    { 7, 2, "Network", 2, 2 },
                    { 8, 2, "JAVA", 2, 3 },
                    { 9, 2, ".NET", 1, 1 },
                    { 10, 2, "Kotlin", 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "Crs_Sessions",
                columns: new[] { "CrsSID", "CrsID", "Date", "InsID", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Intro to HTML" },
                    { 2, 2, new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Intro to CSS" },
                    { 3, 3, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Intro to JS" },
                    { 4, 4, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Intro to OOP" },
                    { 5, 5, new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Intro to Bootstrap" },
                    { 6, 10, new DateTime(2025, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Intro to Kotlin" }
                });

            migrationBuilder.InsertData(
                table: "Std_Courses",
                columns: new[] { "CrsID", "StdID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 6, 4 },
                    { 10, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 6, 5 },
                    { 7, 5 }
                });

            migrationBuilder.InsertData(
                table: "CrsSessionAtts",
                columns: new[] { "CrsSAID", "CrsSessionID", "Grade", "Notes", "StdID" },
                values: new object[,]
                {
                    { 1, 1, null, "", 1 },
                    { 2, 2, null, "", 1 },
                    { 3, 3, null, "", 1 },
                    { 4, 5, null, "", 2 },
                    { 5, 4, null, "", 2 },
                    { 6, 1, null, "", 3 },
                    { 7, 2, null, "", 4 },
                    { 8, 6, null, "", 4 },
                    { 9, 6, null, "", 5 },
                    { 10, 3, null, "", 5 },
                    { 11, 2, null, "", 5 },
                    { 12, 1, null, "", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeptID",
                table: "Courses",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InsID",
                table: "Courses",
                column: "InsID");

            migrationBuilder.CreateIndex(
                name: "IX_Crs_Sessions_CrsID",
                table: "Crs_Sessions",
                column: "CrsID");

            migrationBuilder.CreateIndex(
                name: "IX_Crs_Sessions_InsID",
                table: "Crs_Sessions",
                column: "InsID");

            migrationBuilder.CreateIndex(
                name: "IX_CrsSessionAtts_CrsSessionID",
                table: "CrsSessionAtts",
                column: "CrsSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_CrsSessionAtts_StdID",
                table: "CrsSessionAtts",
                column: "StdID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID",
                unique: true,
                filter: "[ManagerID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Std_Courses_CrsID",
                table: "Std_Courses",
                column: "CrsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DeptID",
                table: "Courses",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "Dept_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InsID",
                table: "Courses",
                column: "InsID",
                principalTable: "Instructors",
                principalColumn: "InsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Crs_Sessions_Instructors_InsID",
                table: "Crs_Sessions",
                column: "InsID",
                principalTable: "Instructors",
                principalColumn: "InsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments",
                column: "ManagerID",
                principalTable: "Instructors",
                principalColumn: "InsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "CrsSessionAtts");

            migrationBuilder.DropTable(
                name: "Std_Courses");

            migrationBuilder.DropTable(
                name: "Crs_Sessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
