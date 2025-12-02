migrationBuilder.CreateTable(
name: "Completions",
columns: table => new
{
CompletionId = table.Column<int>(nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
CompletionDate = table.Column<DateTime>(nullable: false),
Result = table.Column<string>(nullable: false),
EnrollmentId = table.Column<int>(nullable: false)
},
constraints: table =>
{
table.PrimaryKey("PK_Completions", x => x.CompletionId);
table.ForeignKey(
name: "FK_Completions_Enrollments_EnrollmentId",
column: x => x.EnrollmentId,
principalTable: "Enrollments",
principalColumn: "EnrollmentId",
onDelete: ReferentialAction.Cascade);
});