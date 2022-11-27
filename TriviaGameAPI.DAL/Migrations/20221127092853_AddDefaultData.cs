using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TriviaGameAPI.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Actor" },
                    { 2, "Art" },
                    { 3, "Animal" },
                    { 4, "City" },
                    { 5, "Country" },
                    { 6, "Clothing" },
                    { 7, "Drink" },
                    { 8, "Science" },
                    { 9, "Sport" },
                    { 10, "Vehicle" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CharacterColor", "ConnectionId", "GameplayRoomId", "IsGameOrganizer", "LastGameDate", "Name", "Score" },
                values: new object[,]
                {
                    { 1, null, null, null, false, new DateTime(2022, 10, 4, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3249), "Player0", 347 },
                    { 2, null, null, null, false, new DateTime(2022, 10, 16, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3258), "Player1", 659 },
                    { 3, null, null, null, true, new DateTime(2022, 10, 18, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3259), "Player2", 599 },
                    { 4, null, null, null, true, new DateTime(2022, 10, 14, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3261), "Player3", 152 },
                    { 5, null, null, null, true, new DateTime(2022, 11, 12, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3263), "Player4", 533 },
                    { 6, null, null, null, true, new DateTime(2022, 10, 17, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3265), "Player5", 230 },
                    { 7, null, null, null, true, new DateTime(2022, 10, 10, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3267), "Player6", 281 },
                    { 8, null, null, null, true, new DateTime(2022, 11, 7, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3269), "Player7", 292 },
                    { 9, null, null, null, false, new DateTime(2022, 10, 11, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3271), "Player8", 347 },
                    { 10, null, null, null, false, new DateTime(2022, 11, 7, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3273), "Player9", 541 },
                    { 11, null, null, null, true, new DateTime(2022, 10, 29, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3275), "Player10", 613 },
                    { 12, null, null, null, true, new DateTime(2022, 9, 29, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3277), "Player11", 577 },
                    { 13, null, null, null, false, new DateTime(2022, 10, 7, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3278), "Player12", 277 },
                    { 14, null, null, null, false, new DateTime(2022, 9, 30, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3280), "Player13", 310 },
                    { 15, null, null, null, false, new DateTime(2022, 11, 13, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3282), "Player14", 612 },
                    { 16, null, null, null, false, new DateTime(2022, 11, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3284), "Player15", 601 },
                    { 17, null, null, null, false, new DateTime(2022, 10, 17, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3286), "Player16", 153 },
                    { 18, null, null, null, true, new DateTime(2022, 10, 19, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3287), "Player17", 265 },
                    { 19, null, null, null, false, new DateTime(2022, 11, 3, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3289), "Player18", 543 },
                    { 20, null, null, null, true, new DateTime(2022, 11, 25, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3291), "Player19", 668 },
                    { 21, null, null, null, false, new DateTime(2022, 11, 15, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3292), "Player20", 616 },
                    { 22, null, null, null, false, new DateTime(2022, 11, 10, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3294), "Player21", 96 },
                    { 23, null, null, null, false, new DateTime(2022, 10, 5, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3296), "Player22", 5 },
                    { 24, null, null, null, false, new DateTime(2022, 10, 1, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3297), "Player23", 97 },
                    { 25, null, null, null, true, new DateTime(2022, 11, 20, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3299), "Player24", 538 },
                    { 26, null, null, null, false, new DateTime(2022, 11, 13, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3300), "Player25", 236 },
                    { 27, null, null, null, false, new DateTime(2022, 11, 14, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3302), "Player26", 246 },
                    { 28, null, null, null, false, new DateTime(2022, 10, 29, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3304), "Player27", 577 },
                    { 29, null, null, null, true, new DateTime(2022, 10, 7, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3306), "Player28", 86 },
                    { 30, null, null, null, true, new DateTime(2022, 11, 6, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3308), "Player29", 497 },
                    { 31, null, null, null, true, new DateTime(2022, 11, 2, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3309), "Player30", 266 },
                    { 32, null, null, null, false, new DateTime(2022, 11, 24, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3311), "Player31", 154 },
                    { 33, null, null, null, false, new DateTime(2022, 11, 16, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3313), "Player32", 427 },
                    { 34, null, null, null, true, new DateTime(2022, 10, 16, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3315), "Player33", 50 },
                    { 35, null, null, null, false, new DateTime(2022, 10, 30, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3346), "Player34", 517 },
                    { 36, null, null, null, true, new DateTime(2022, 10, 14, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3348), "Player35", 567 },
                    { 37, null, null, null, true, new DateTime(2022, 10, 12, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3350), "Player36", 507 },
                    { 38, null, null, null, true, new DateTime(2022, 10, 9, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3351), "Player37", 277 },
                    { 39, null, null, null, false, new DateTime(2022, 11, 7, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3353), "Player38", 648 },
                    { 40, null, null, null, false, new DateTime(2022, 11, 19, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3355), "Player39", 609 },
                    { 41, null, null, null, true, new DateTime(2022, 10, 25, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3357), "Player40", 551 },
                    { 42, null, null, null, false, new DateTime(2022, 11, 8, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3358), "Player41", 491 },
                    { 43, null, null, null, false, new DateTime(2022, 11, 10, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3360), "Player42", 646 },
                    { 44, null, null, null, false, new DateTime(2022, 10, 8, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3362), "Player43", 136 },
                    { 45, null, null, null, false, new DateTime(2022, 10, 28, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3364), "Player44", 698 },
                    { 46, null, null, null, false, new DateTime(2022, 10, 3, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3365), "Player45", 488 },
                    { 47, null, null, null, true, new DateTime(2022, 10, 11, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3367), "Player46", 699 },
                    { 48, null, null, null, false, new DateTime(2022, 11, 21, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3369), "Player47", 544 },
                    { 49, null, null, null, false, new DateTime(2022, 10, 25, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3371), "Player48", 497 },
                    { 50, null, null, null, false, new DateTime(2022, 11, 11, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3373), "Player49", 454 },
                    { 51, null, null, null, false, new DateTime(2022, 10, 21, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3374), "Player50", 564 },
                    { 52, null, null, null, false, new DateTime(2022, 11, 25, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3376), "Player51", 426 },
                    { 53, null, null, null, false, new DateTime(2022, 9, 28, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3377), "Player52", 679 },
                    { 54, null, null, null, false, new DateTime(2022, 11, 21, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3379), "Player53", 338 },
                    { 55, null, null, null, true, new DateTime(2022, 11, 7, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3381), "Player54", 503 },
                    { 56, null, null, null, false, new DateTime(2022, 11, 15, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3383), "Player55", 442 },
                    { 57, null, null, null, false, new DateTime(2022, 10, 21, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3384), "Player56", 425 },
                    { 58, null, null, null, true, new DateTime(2022, 10, 14, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3386), "Player57", 139 },
                    { 59, null, null, null, false, new DateTime(2022, 10, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3388), "Player58", 87 },
                    { 60, null, null, null, false, new DateTime(2022, 10, 13, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3389), "Player59", 547 },
                    { 61, null, null, null, false, new DateTime(2022, 11, 15, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3391), "Player60", 159 },
                    { 62, null, null, null, false, new DateTime(2022, 10, 19, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3393), "Player61", 89 },
                    { 63, null, null, null, false, new DateTime(2022, 11, 9, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3394), "Player62", 392 },
                    { 64, null, null, null, true, new DateTime(2022, 10, 7, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3396), "Player63", 393 },
                    { 65, null, null, null, false, new DateTime(2022, 10, 27, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3398), "Player64", 2 },
                    { 66, null, null, null, false, new DateTime(2022, 10, 5, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3399), "Player65", 193 },
                    { 67, null, null, null, false, new DateTime(2022, 11, 20, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3401), "Player66", 313 },
                    { 68, null, null, null, false, new DateTime(2022, 11, 12, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3403), "Player67", 10 },
                    { 69, null, null, null, false, new DateTime(2022, 10, 23, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3404), "Player68", 589 },
                    { 70, null, null, null, true, new DateTime(2022, 11, 13, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3406), "Player69", 607 },
                    { 71, null, null, null, false, new DateTime(2022, 10, 22, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3408), "Player70", 145 },
                    { 72, null, null, null, false, new DateTime(2022, 11, 5, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3409), "Player71", 548 },
                    { 73, null, null, null, false, new DateTime(2022, 10, 23, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3411), "Player72", 362 },
                    { 74, null, null, null, false, new DateTime(2022, 10, 3, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3412), "Player73", 500 },
                    { 75, null, null, null, true, new DateTime(2022, 10, 8, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3414), "Player74", 363 },
                    { 76, null, null, null, false, new DateTime(2022, 10, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3416), "Player75", 562 },
                    { 77, null, null, null, true, new DateTime(2022, 10, 9, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3418), "Player76", 662 },
                    { 78, null, null, null, false, new DateTime(2022, 10, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3420), "Player77", 542 },
                    { 79, null, null, null, false, new DateTime(2022, 11, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3421), "Player78", 611 },
                    { 80, null, null, null, true, new DateTime(2022, 9, 29, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3423), "Player79", 691 },
                    { 81, null, null, null, false, new DateTime(2022, 11, 23, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3425), "Player80", 429 },
                    { 82, null, null, null, false, new DateTime(2022, 9, 30, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3426), "Player81", 40 },
                    { 83, null, null, null, false, new DateTime(2022, 11, 13, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3428), "Player82", 534 },
                    { 84, null, null, null, false, new DateTime(2022, 10, 17, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3430), "Player83", 394 },
                    { 85, null, null, null, false, new DateTime(2022, 10, 18, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3431), "Player84", 244 },
                    { 86, null, null, null, true, new DateTime(2022, 10, 14, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3433), "Player85", 309 },
                    { 87, null, null, null, false, new DateTime(2022, 10, 31, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3435), "Player86", 338 },
                    { 88, null, null, null, false, new DateTime(2022, 10, 22, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3436), "Player87", 674 },
                    { 89, null, null, null, false, new DateTime(2022, 11, 25, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3438), "Player88", 672 },
                    { 90, null, null, null, true, new DateTime(2022, 10, 12, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3440), "Player89", 239 },
                    { 91, null, null, null, false, new DateTime(2022, 11, 15, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3441), "Player90", 210 },
                    { 92, null, null, null, false, new DateTime(2022, 11, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3443), "Player91", 699 },
                    { 93, null, null, null, false, new DateTime(2022, 11, 8, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3445), "Player92", 520 },
                    { 94, null, null, null, false, new DateTime(2022, 11, 4, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3446), "Player93", 505 },
                    { 95, null, null, null, false, new DateTime(2022, 9, 29, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3448), "Player94", 171 },
                    { 96, null, null, null, false, new DateTime(2022, 10, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3450), "Player95", 28 },
                    { 97, null, null, null, true, new DateTime(2022, 10, 1, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3452), "Player96", 529 },
                    { 98, null, null, null, false, new DateTime(2022, 10, 29, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3453), "Player97", 135 },
                    { 99, null, null, null, true, new DateTime(2022, 11, 26, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3455), "Player98", 460 },
                    { 100, null, null, null, false, new DateTime(2022, 11, 18, 9, 28, 52, 864, DateTimeKind.Utc).AddTicks(3456), "Player99", 284 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
