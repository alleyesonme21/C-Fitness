using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitness.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                columns: new[] { "Name", "Target" },
                values: new object[] { "Diamond Pushups", "Arms" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                column: "Name",
                value: "Yoga Pushups");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                columns: new[] { "Name", "Target" },
                values: new object[] { "Bicep Curls", "Arms" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                columns: new[] { "Name", "Target" },
                values: new object[] { "Tricep Kickbacks", "Arms" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                columns: new[] { "Difficulty", "Name", "Target" },
                values: new object[] { "Hard", "Pullups", "Arms" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                column: "Name",
                value: "Arm Circles");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Calories", "Difficulty", "Name", "Target", "Type" },
                values: new object[,]
                {
                    { 27, 20, "Hard", "Lunge Jumps", "Cardio", "Strength" },
                    { 26, 20, "Easy", "Fly Jacks", "Cardio", "Strength" },
                    { 25, 20, "Easy", "Jumping Jacks", "Cardio", "Strength" },
                    { 24, 20, "Medium", "Hip Thrusts", "Glutes", "Strength" },
                    { 23, 20, "Medium", "Frog Kicks", "Glutes", "Strength" },
                    { 22, 20, "Medium", "Fire Hydrants", "Glutes", "Strength" },
                    { 21, 20, "Medium", "Glute Kickbacks", "Glutes", "Strength" },
                    { 19, 20, "Medium", "Lunges", "Legs", "Strength" },
                    { 18, 20, "Medium", "Lunges", "Legs", "Strength" },
                    { 15, 20, "Medium", "Side Plank", "Abs", "Strength" },
                    { 16, 20, "Medium", "Sumo Squats", "Legs", "Strength" },
                    { 28, 20, "Medium", "Mountain Climbers", "Cardio", "Strength" },
                    { 14, 20, "Medium", "Oblique Crunches", "Abs", "Strength" },
                    { 13, 20, "Medium", "Russian Twist", "Abs", "Strength" },
                    { 12, 20, "Medium", "100's", "Abs", "Strength" },
                    { 11, 20, "Medium", "Star Crunches", "Abs", "Strength" },
                    { 10, 20, "Medium", "Bicycle Crunches", "Abs", "Strength" },
                    { 9, 20, "Medium", "Plank", "Abs", "Strength" },
                    { 8, 20, "Medium", "Situps", "Abs", "Strength" },
                    { 17, 20, "Medium", "Squats- Narrow Stance", "Legs", "Strength" },
                    { 29, 20, "Hard", "High-Knees", "Cardio", "Strength" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2,
                columns: new[] { "Name", "Target" },
                values: new object[] { "Sumo Squats", "Legs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3,
                column: "Name",
                value: "Bicep Curls");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4,
                columns: new[] { "Name", "Target" },
                values: new object[] { "Situps", "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5,
                columns: new[] { "Name", "Target" },
                values: new object[] { "Plank", "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6,
                columns: new[] { "Difficulty", "Name", "Target" },
                values: new object[] { "Medium", "Squats", "Legs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7,
                column: "Name",
                value: "Tricep Kickbacks");
        }
    }
}
