using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Calories", "Difficulty", "Name", "Target", "Type" },
                values: new object[,]
                {
                    { 1, 20, "Medium", "Pushups", "Arms", "Strength" },
                    { 2, 20, "Hard", "Sumo Squats", "Legs", "Strength" },
                    { 3, 20, "Easy", "Bicep Curls", "Arms", "Strength" },
                    { 4, 20, "Easy", "Situps", "Core", "Strength" },
                    { 5, 20, "Hard", "Plank", "Core", "Strength" },
                    { 6, 20, "Medium", "Squats", "Legs", "Strength" },
                    { 7, 20, "Easy", "Tricep Kickbacks", "Arms", "Strength" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7);
        }
    }
}
