using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlissQuestions.API.Migrations
{
    public partial class initialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ThumbUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Question = table.Column<string>(type: "TEXT", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Choices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Choice = table.Column<string>(type: "TEXT", nullable: false),
                    Votes = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Choices_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 1, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 2, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 3, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 4, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 5, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 6, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 7, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 8, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 9, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "ImageUrl", "PublishedAt", "Question", "ThumbUrl" },
                values: new object[] { 10, "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)", new DateTime(2015, 8, 5, 8, 40, 51, 620, DateTimeKind.Unspecified), "Favorite programming language?", "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)" });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 1, "Swift", 1, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 2, "Python", 1, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 3, "Objective-C", 1, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 4, "Ruby", 1, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 5, "Swift", 2, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 6, "Python", 2, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 7, "Objective-C", 2, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 8, "Ruby", 2, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 9, "Swift", 3, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 10, "Python", 3, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 11, "Objective-C", 3, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 12, "Ruby", 3, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 13, "Swift", 4, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 14, "Python", 4, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 15, "Objective-C", 4, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 16, "Ruby", 4, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 17, "Swift", 5, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 18, "Python", 5, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 19, "Objective-C", 5, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 20, "Ruby", 5, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 21, "Swift", 6, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 22, "Python", 6, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 23, "Objective-C", 6, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 24, "Ruby", 6, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 25, "Swift", 7, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 26, "Python", 7, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 27, "Objective-C", 7, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 28, "Ruby", 7, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 29, "Swift", 8, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 30, "Python", 8, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 31, "Objective-C", 8, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 32, "Ruby", 8, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 33, "Swift", 9, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 34, "Python", 9, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 35, "Objective-C", 9, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 36, "Ruby", 9, 256 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 37, "Swift", 10, 2048 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 38, "Python", 10, 1024 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 39, "Objective-C", 10, 512 });

            migrationBuilder.InsertData(
                table: "Choices",
                columns: new[] { "Id", "Choice", "QuestionId", "Votes" },
                values: new object[] { 40, "Ruby", 10, 256 });

            migrationBuilder.CreateIndex(
                name: "IX_Choices_QuestionId",
                table: "Choices",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
