using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Database.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieRatings_User_UserId",
                table: "MovieRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 33 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 118 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 106 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 129 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 48 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 64 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 133 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 37 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 113 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 58 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 46 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 64 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 109 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 122 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 133 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 77 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 79 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 110 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 112 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 130 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 134 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 138 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 29 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 73 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 65 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 104 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 19 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 75 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 91 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 93 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 115 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 55 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 89 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 105 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 19 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 42 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 60 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 136 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 131 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 138 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 47 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 26 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 28 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 29 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 70 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 96 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, 13 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, 75 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, 94 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, 97 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 19, 56 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 19, 99 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, 49 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, 51 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, 57 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, 36 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, 108 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 22, 47 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 22, 80 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 22, 96 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, 61 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, 69 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 24, 37 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 24, 101 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 24, 114 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 41 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 85 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 93 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 129 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, 45 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, 72 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, 97 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, 120 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, 60 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, 140 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 30 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 30, 108 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 30, 135 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 81 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 82 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 102 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 32, 116 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 33, 82 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 34, 25 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 34, 109 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 35, 17 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 36, 53 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 14 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 38, 105 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 39, 16 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 39, 44 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 39, 70 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 39, 104 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 39, 117 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 41, 83 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 41, 136 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 42, 35 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 42, 42 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 42, 54 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 43, 18 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 43, 28 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 44, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 44, 51 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 44, 57 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 44, 113 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 44, 139 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 45, 27 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 45, 122 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 59 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 106 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 107 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 47, 15 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 47, 88 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 48, 34 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 46 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 120 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 50, 139 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 50, 140 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 51, 12 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 51, 20 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 51, 88 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 51, 103 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 12 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 56 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 71 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 38 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 43 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 52 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 63 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 134 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 54, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 54, 132 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 55, 21 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 55, 68 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 56, 76 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 56, 111 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 56, 123 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 57, 13 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 57, 26 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 86 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 95 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 115 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 59, 36 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 59, 79 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 77 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 86 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 90 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 124 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 61, 49 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 61, 80 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 34 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 74 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 121 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 63, 40 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 63, 45 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 64, 14 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 64, 85 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 65, 39 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 65, 125 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 66, 18 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 66, 32 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 66, 100 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 67, 62 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 67, 107 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 67, 131 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 68, 24 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 68, 128 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 69, 111 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 70, 118 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 70, 124 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 67 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 72 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 84 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 94 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 121 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 73, 20 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 73, 43 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 52 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 53 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 84 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 100 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 75, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 75, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 75, 40 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 75, 123 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 76, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 78, 66 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 78, 67 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 31 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 119 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 137 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 80, 68 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 80, 71 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 80, 76 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 81, 23 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 81, 59 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 81, 65 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 11 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 38 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 58 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 95 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 126 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 84, 92 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 85, 22 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 85, 62 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 85, 98 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 85, 126 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 85, 137 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 86, 127 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 22 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 23 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 31 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 50 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 110 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 125 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 88, 69 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 16 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 78 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 98 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 112 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 127 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 130 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 90, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 90, 21 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 90, 55 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 90, 81 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 90, 101 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 50 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 66 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 91 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 119 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 92, 24 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 92, 54 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 92, 63 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 92, 102 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 93, 35 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 93, 44 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 93, 48 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 93, 117 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 94, 32 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 94, 90 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 95, 25 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 95, 27 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 95, 30 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 95, 74 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 95, 89 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 96, 33 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 96, 41 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 96, 87 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 96, 99 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 96, 135 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 97, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 97, 39 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 97, 73 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 97, 78 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 97, 128 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 98, 83 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 98, 103 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 98, 132 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 99, 92 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 99, 116 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 11, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 12, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 15, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 17, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 18, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 20, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 22, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 26, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 29, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 30, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 31, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 33, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 34, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 34, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 34, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 35, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 36, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 36, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 36, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 39, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 39, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 39, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 41, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 42, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 42, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 45, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 45, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 46, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 47, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 47, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 48, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 48, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 48, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 49, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 49, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 50, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 50, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 50, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 51, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 53, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 54, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 55, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 55, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 56, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 56, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 58, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 58, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 58, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 58, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 59, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 60, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 60, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 60, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 61, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 61, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 62, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 63, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 63, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 64, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 64, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 65, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 65, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 66, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 67, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 67, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 68, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 68, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 69, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 70, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 70, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 70, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 71, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 71, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 73, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 75, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 76, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 78, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 78, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 78, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 79, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 79, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 81, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 81, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 82, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 82, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 83, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 83, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 84, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 84, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 87, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 87, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 88, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 89, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 89, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 89, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 92, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 93, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 93, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 94, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 94, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 95, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 95, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 95, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 97, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 99, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 101, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 101, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 102, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 102, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 103, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 103, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 103, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 103, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 105, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 106, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 108, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 110, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 111, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 112, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 113, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 113, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 113, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 113, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 113, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 114, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 114, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 115, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 115, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 116, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 116, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 117, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 118, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 118, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 119, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 119, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 120, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 120, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 120, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 121, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 121, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 122, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 125, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 125, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 125, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 126, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 128, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 129, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 129, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 130, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 130, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 132, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 132, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 132, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 133, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 134, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 134, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 134, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 134, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 136, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 138, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 138, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 139, 7 });

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 52, 1 },
                    { 59, 90 },
                    { 99, 90 },
                    { 12, 91 },
                    { 71, 91 },
                    { 13, 92 },
                    { 64, 92 },
                    { 94, 93 },
                    { 95, 93 },
                    { 28, 94 },
                    { 37, 94 },
                    { 68, 95 },
                    { 21, 95 },
                    { 46, 96 },
                    { 98, 96 },
                    { 30, 89 },
                    { 62, 97 },
                    { 91, 98 },
                    { 26, 98 },
                    { 94, 99 },
                    { 48, 99 },
                    { 16, 100 },
                    { 89, 100 },
                    { 60, 101 },
                    { 76, 101 },
                    { 87, 102 },
                    { 54, 102 },
                    { 52, 103 },
                    { 73, 103 },
                    { 6, 104 },
                    { 45, 104 },
                    { 36, 97 },
                    { 63, 89 },
                    { 29, 88 },
                    { 26, 88 },
                    { 89, 72 },
                    { 73, 72 },
                    { 73, 73 },
                    { 88, 73 },
                    { 38, 74 },
                    { 37, 74 },
                    { 77, 75 },
                    { 71, 75 },
                    { 87, 76 },
                    { 72, 76 },
                    { 86, 77 },
                    { 75, 77 },
                    { 11, 78 },
                    { 43, 78 },
                    { 12, 79 },
                    { 44, 79 },
                    { 9, 80 },
                    { 66, 87 },
                    { 14, 86 },
                    { 19, 86 },
                    { 24, 85 },
                    { 49, 85 },
                    { 62, 84 },
                    { 49, 105 },
                    { 29, 84 },
                    { 58, 83 },
                    { 41, 82 },
                    { 79, 82 },
                    { 89, 81 },
                    { 25, 81 },
                    { 32, 80 },
                    { 83, 83 },
                    { 74, 71 },
                    { 82, 105 },
                    { 82, 106 },
                    { 37, 125 },
                    { 49, 126 },
                    { 79, 126 },
                    { 3, 127 },
                    { 54, 127 },
                    { 35, 128 },
                    { 69, 128 },
                    { 81, 129 },
                    { 59, 129 },
                    { 76, 130 },
                    { 32, 130 },
                    { 23, 131 },
                    { 75, 131 },
                    { 93, 132 },
                    { 17, 125 },
                    { 49, 132 },
                    { 65, 133 },
                    { 68, 134 },
                    { 15, 134 },
                    { 69, 135 },
                    { 83, 135 },
                    { 70, 136 },
                    { 18, 136 },
                    { 4, 137 },
                    { 25, 137 },
                    { 72, 138 },
                    { 4, 139 },
                    { 9, 139 },
                    { 87, 140 },
                    { 13, 140 },
                    { 49, 133 },
                    { 53, 124 },
                    { 15, 124 },
                    { 64, 123 },
                    { 84, 107 },
                    { 10, 107 },
                    { 20, 108 },
                    { 54, 108 },
                    { 76, 109 },
                    { 16, 109 },
                    { 46, 110 },
                    { 62, 110 },
                    { 55, 111 },
                    { 91, 111 },
                    { 94, 112 },
                    { 29, 112 },
                    { 77, 113 },
                    { 20, 113 },
                    { 51, 114 },
                    { 51, 115 },
                    { 1, 115 },
                    { 42, 123 },
                    { 85, 122 },
                    { 88, 122 },
                    { 83, 121 },
                    { 89, 121 },
                    { 22, 120 },
                    { 79, 106 },
                    { 12, 120 },
                    { 36, 118 },
                    { 40, 118 },
                    { 69, 117 },
                    { 14, 117 },
                    { 15, 116 },
                    { 34, 116 },
                    { 83, 119 },
                    { 16, 71 },
                    { 59, 119 },
                    { 67, 70 },
                    { 15, 19 },
                    { 21, 19 },
                    { 16, 20 },
                    { 25, 21 },
                    { 88, 21 },
                    { 52, 22 },
                    { 53, 22 },
                    { 5, 23 },
                    { 58, 23 },
                    { 18, 24 },
                    { 81, 24 },
                    { 14, 25 },
                    { 13, 25 },
                    { 90, 26 },
                    { 98, 18 },
                    { 31, 26 },
                    { 99, 28 },
                    { 58, 28 },
                    { 70, 29 },
                    { 35, 29 },
                    { 71, 30 },
                    { 56, 30 },
                    { 82, 31 },
                    { 53, 31 },
                    { 82, 32 },
                    { 7, 32 },
                    { 37, 33 },
                    { 91, 33 },
                    { 64, 34 },
                    { 3, 34 },
                    { 76, 27 },
                    { 30, 18 },
                    { 98, 17 },
                    { 88, 17 },
                    { 16, 70 },
                    { 32, 2 },
                    { 87, 2 },
                    { 47, 3 },
                    { 82, 3 },
                    { 35, 4 },
                    { 44, 4 },
                    { 46, 5 },
                    { 63, 5 },
                    { 62, 6 },
                    { 52, 6 },
                    { 2, 7 },
                    { 34, 7 },
                    { 16, 8 },
                    { 46, 8 },
                    { 78, 9 },
                    { 66, 9 },
                    { 71, 16 },
                    { 27, 16 },
                    { 39, 15 },
                    { 61, 15 },
                    { 82, 14 },
                    { 1, 14 },
                    { 5, 35 },
                    { 91, 13 },
                    { 97, 12 },
                    { 82, 12 },
                    { 12, 11 },
                    { 62, 11 },
                    { 79, 10 },
                    { 84, 10 },
                    { 17, 13 },
                    { 17, 35 },
                    { 83, 27 },
                    { 58, 36 },
                    { 80, 54 },
                    { 15, 54 },
                    { 23, 55 },
                    { 26, 55 },
                    { 98, 56 },
                    { 41, 56 },
                    { 42, 57 },
                    { 13, 57 },
                    { 82, 58 },
                    { 62, 58 },
                    { 84, 59 },
                    { 34, 59 },
                    { 58, 60 },
                    { 41, 60 },
                    { 31, 36 },
                    { 4, 62 },
                    { 33, 62 },
                    { 71, 69 },
                    { 43, 69 },
                    { 58, 68 },
                    { 63, 68 },
                    { 79, 67 },
                    { 13, 67 },
                    { 33, 53 },
                    { 15, 66 },
                    { 82, 65 },
                    { 35, 65 },
                    { 90, 64 },
                    { 8, 64 },
                    { 50, 63 },
                    { 87, 63 },
                    { 68, 66 },
                    { 81, 53 },
                    { 52, 61 },
                    { 76, 52 },
                    { 96, 52 },
                    { 68, 37 },
                    { 54, 38 },
                    { 74, 38 },
                    { 60, 39 },
                    { 29, 39 },
                    { 92, 40 },
                    { 58, 40 },
                    { 73, 41 },
                    { 20, 41 },
                    { 68, 42 },
                    { 49, 43 },
                    { 95, 43 },
                    { 88, 44 },
                    { 50, 37 },
                    { 49, 42 },
                    { 99, 45 },
                    { 16, 51 },
                    { 94, 51 },
                    { 14, 50 },
                    { 12, 44 },
                    { 45, 49 },
                    { 6, 49 },
                    { 72, 48 },
                    { 17, 50 },
                    { 34, 48 },
                    { 60, 47 },
                    { 50, 47 },
                    { 80, 46 },
                    { 29, 46 },
                    { 71, 45 }
                });

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 2, 6 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 2 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 8, 2 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 12, 3 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 13, 7 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 4 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 6 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 8 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 17, 5 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 19, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 20, 5 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 22, 5 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 22, 7 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 23, 6 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 8 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 6 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 8 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 29, 5 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 4 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 6 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 38, 1 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 41, 4 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 42, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 43, 3 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 2 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 7 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 45, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 46, 8 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 48, 8 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 49, 4 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 52, 7 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 54, 2 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 55, 4 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 62, 6 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 64, 3 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 64, 6 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 65, 5 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 65, 7 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 66, 4 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 67, 2 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 70, 1 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 71, 3 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 1 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 2 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 73, 1 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 73, 7 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 77, 8 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 78, 4 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 3 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 4 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 81, 6 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 81, 8 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 82, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 85, 7 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 86, 7 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 3 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 91, 5 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 93, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 94, 8 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 95, 5 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 96, 3 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 96, 4 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 97, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 98, 3 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 99, 2 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 101, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 103, 1 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 104, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 108, 4 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 108, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 110, 1 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 112, 4 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 114, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 115, 7 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 118, 4 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 122, 8 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 5 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 6 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 8 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 7 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 130, 7 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 131, 3 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 131, 6 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 131, 8 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 134, 4 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 135, 5 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 136, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 3 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 139, 6 },
                column: "Rating",
                value: 0);

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "MovieId", "UserId", "Rating" },
                values: new object[,]
                {
                    { 86, 2, 4 },
                    { 107, 8, 5 },
                    { 44, 1, 3 },
                    { 43, 2, 0 },
                    { 40, 1, 5 },
                    { 90, 5, 5 },
                    { 132, 7, 4 },
                    { 88, 3, 3 },
                    { 26, 7, 0 },
                    { 116, 8, 4 },
                    { 36, 6, 5 },
                    { 100, 2, 4 },
                    { 27, 5, 4 },
                    { 97, 2, 3 },
                    { 88, 5, 3 },
                    { 111, 7, 3 },
                    { 109, 6, 1 },
                    { 120, 5, 0 },
                    { 27, 4, 2 },
                    { 85, 3, 2 },
                    { 37, 5, 0 },
                    { 24, 4, 0 },
                    { 4, 6, 3 },
                    { 58, 6, 3 },
                    { 135, 7, 0 },
                    { 49, 7, 0 },
                    { 44, 6, 5 },
                    { 118, 3, 0 },
                    { 111, 1, 0 },
                    { 53, 8, 3 },
                    { 15, 7, 0 },
                    { 107, 1, 2 },
                    { 84, 2, 5 },
                    { 129, 6, 0 },
                    { 34, 3, 5 },
                    { 69, 8, 5 },
                    { 118, 7, 1 },
                    { 99, 8, 5 },
                    { 114, 8, 2 },
                    { 63, 4, 1 },
                    { 10, 4, 2 },
                    { 75, 1, 5 },
                    { 80, 5, 1 },
                    { 68, 3, 0 },
                    { 29, 6, 4 },
                    { 63, 1, 0 },
                    { 102, 7, 4 },
                    { 19, 1, 4 },
                    { 25, 3, 2 },
                    { 94, 3, 4 },
                    { 40, 3, 3 },
                    { 8, 1, 3 },
                    { 135, 8, 3 },
                    { 83, 6, 5 },
                    { 126, 6, 3 },
                    { 85, 1, 3 },
                    { 122, 4, 2 },
                    { 79, 7, 5 },
                    { 40, 8, 3 },
                    { 21, 1, 5 },
                    { 130, 2, 0 },
                    { 69, 5, 5 },
                    { 24, 5, 1 },
                    { 108, 3, 1 },
                    { 95, 6, 1 },
                    { 91, 8, 5 },
                    { 104, 1, 5 },
                    { 114, 3, 3 },
                    { 120, 4, 2 },
                    { 62, 3, 5 },
                    { 10, 8, 4 },
                    { 119, 6, 3 },
                    { 77, 2, 3 },
                    { 127, 2, 3 },
                    { 28, 5, 5 },
                    { 38, 6, 4 },
                    { 13, 8, 1 },
                    { 76, 2, 5 },
                    { 82, 4, 1 },
                    { 118, 6, 5 },
                    { 16, 7, 4 },
                    { 116, 1, 1 },
                    { 16, 6, 1 },
                    { 22, 4, 4 },
                    { 102, 4, 1 },
                    { 13, 6, 5 },
                    { 16, 1, 3 },
                    { 46, 2, 5 },
                    { 65, 6, 1 },
                    { 27, 1, 1 },
                    { 116, 6, 4 },
                    { 45, 4, 5 },
                    { 13, 3, 3 },
                    { 43, 5, 0 },
                    { 38, 7, 4 },
                    { 87, 2, 1 },
                    { 3, 6, 3 },
                    { 76, 1, 0 },
                    { 43, 1, 5 },
                    { 136, 7, 4 },
                    { 105, 3, 1 },
                    { 6, 4, 2 },
                    { 112, 3, 4 },
                    { 37, 1, 0 },
                    { 80, 1, 5 },
                    { 46, 6, 4 },
                    { 137, 1, 5 },
                    { 26, 4, 2 },
                    { 23, 7, 1 },
                    { 59, 5, 2 },
                    { 124, 8, 0 },
                    { 67, 5, 2 },
                    { 44, 5, 3 },
                    { 129, 7, 2 },
                    { 75, 6, 0 },
                    { 137, 6, 3 },
                    { 90, 1, 2 },
                    { 136, 5, 0 },
                    { 74, 3, 3 },
                    { 125, 5, 5 },
                    { 28, 7, 4 },
                    { 124, 6, 3 },
                    { 21, 4, 5 },
                    { 8, 7, 4 },
                    { 19, 6, 0 },
                    { 7, 6, 5 },
                    { 16, 2, 1 },
                    { 59, 6, 2 },
                    { 127, 7, 0 },
                    { 58, 7, 4 },
                    { 25, 2, 2 },
                    { 119, 4, 4 },
                    { 91, 7, 2 },
                    { 59, 3, 5 },
                    { 4, 5, 5 },
                    { 9, 8, 0 },
                    { 100, 5, 1 },
                    { 20, 8, 2 },
                    { 138, 7, 2 },
                    { 93, 3, 4 },
                    { 109, 7, 3 },
                    { 92, 6, 4 },
                    { 89, 3, 1 },
                    { 133, 5, 0 },
                    { 111, 8, 1 },
                    { 66, 3, 1 },
                    { 36, 5, 4 },
                    { 90, 6, 0 },
                    { 25, 1, 0 },
                    { 109, 3, 4 },
                    { 102, 1, 4 },
                    { 105, 5, 0 },
                    { 26, 1, 4 },
                    { 130, 5, 1 },
                    { 9, 5, 0 },
                    { 112, 6, 1 },
                    { 48, 6, 4 },
                    { 31, 3, 4 },
                    { 51, 7, 0 },
                    { 98, 5, 0 },
                    { 109, 2, 1 },
                    { 87, 4, 1 },
                    { 112, 1, 0 },
                    { 73, 5, 1 },
                    { 122, 2, 5 },
                    { 58, 4, 1 },
                    { 66, 8, 0 },
                    { 126, 1, 3 },
                    { 50, 6, 5 },
                    { 42, 6, 0 },
                    { 57, 4, 2 },
                    { 119, 2, 3 },
                    { 32, 6, 0 },
                    { 124, 2, 0 },
                    { 29, 4, 0 },
                    { 53, 4, 0 },
                    { 43, 7, 2 },
                    { 77, 7, 5 },
                    { 109, 4, 0 },
                    { 1, 6, 3 },
                    { 59, 4, 5 },
                    { 74, 1, 3 },
                    { 123, 2, 3 },
                    { 20, 7, 2 },
                    { 78, 3, 4 },
                    { 115, 1, 2 },
                    { 135, 6, 5 },
                    { 72, 7, 3 },
                    { 30, 3, 4 },
                    { 52, 3, 2 },
                    { 61, 2, 1 },
                    { 95, 2, 0 },
                    { 21, 2, 3 },
                    { 5, 2, 4 },
                    { 53, 1, 5 },
                    { 73, 2, 5 },
                    { 90, 7, 2 },
                    { 77, 5, 1 },
                    { 48, 1, 2 },
                    { 34, 7, 2 },
                    { 2, 3, 3 },
                    { 13, 2, 0 },
                    { 99, 5, 3 },
                    { 6, 1, 5 },
                    { 28, 3, 3 },
                    { 138, 5, 3 },
                    { 102, 6, 2 },
                    { 2, 5, 1 },
                    { 39, 5, 5 },
                    { 10, 7, 5 },
                    { 100, 6, 5 },
                    { 139, 3, 1 },
                    { 68, 1, 0 },
                    { 124, 1, 5 },
                    { 13, 5, 3 },
                    { 6, 3, 1 },
                    { 12, 6, 2 },
                    { 74, 6, 3 },
                    { 99, 3, 3 },
                    { 61, 4, 2 },
                    { 41, 3, 3 },
                    { 113, 4, 0 },
                    { 3, 2, 0 },
                    { 124, 5, 2 },
                    { 51, 1, 3 },
                    { 137, 4, 5 },
                    { 110, 7, 0 },
                    { 126, 7, 0 },
                    { 38, 3, 5 },
                    { 21, 3, 2 },
                    { 121, 6, 2 },
                    { 90, 8, 1 },
                    { 139, 1, 2 },
                    { 55, 7, 1 },
                    { 101, 6, 4 },
                    { 47, 6, 1 },
                    { 128, 3, 4 },
                    { 57, 3, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "oIR2F+qEUYtQR+gaCiTuosYf7XKtcglMT9CWV3mJ28A=", new byte[] { 156, 28, 133, 30, 216, 105, 163, 25, 34, 26, 99, 163, 36, 139, 19, 180 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "CeGOD1LFRWR3uhF4shVbg55APXYXsMHa7hukWxvOzDM=", new byte[] { 224, 206, 10, 151, 214, 109, 233, 28, 168, 183, 43, 100, 251, 160, 181, 187 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ml3C2ApzCR3UuCq5OVWZQPVGn0vxBpKCfwuhUA7kGYc=", new byte[] { 130, 6, 204, 69, 205, 93, 63, 124, 81, 253, 15, 53, 211, 26, 229, 161 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "RG98IiZk6KlWyVs87MrbM3yvpxlyhD5eEUW7cmcPUkQ=", new byte[] { 25, 156, 150, 91, 119, 182, 71, 141, 237, 245, 60, 248, 248, 253, 196, 71 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kyviRtp7r1JYBo8JgLvq+wM2aaUw53SUMb95IZd4ZkM=", new byte[] { 85, 155, 92, 87, 107, 218, 53, 89, 77, 9, 101, 57, 141, 189, 141, 126 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "IkYDglwmjwJtQh3+mi8P//yYOIih/JM1A3OB/rSddqM=", new byte[] { 102, 143, 1, 59, 67, 171, 97, 54, 227, 20, 145, 77, 29, 81, 30, 15 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "HLFEGu1UuRTxAURvKo+pU0z2CYM4VTdtGYjA0+1l2Kg=", new byte[] { 23, 219, 82, 203, 12, 94, 218, 30, 143, 128, 241, 168, 246, 209, 47, 72 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "W1s+s9Q9rGkJyLGIdhzCVzwgYjIf/Sgd8jUAjrcLShI=", new byte[] { 202, 173, 5, 1, 172, 211, 177, 67, 94, 95, 80, 223, 77, 36, 152, 18 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "BR80A+l1BKWfcClE9zEFHoUcUnfZg8G5OCquELyFpOQ=", new byte[] { 140, 88, 204, 253, 0, 40, 52, 44, 253, 132, 151, 58, 26, 163, 213, 122 } });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRatings_Users_UserId",
                table: "MovieRatings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieRatings_Users_UserId",
                table: "MovieRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 115 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 34 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 127 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 62 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 137 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 139 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 35 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 49 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 104 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 32 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 64 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 80 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, 139 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, 107 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, 78 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 44 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 79 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 91 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, 120 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 25 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 57 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 67 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 92 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, 140 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 25 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 50 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 86 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, 117 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 19 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 54 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 66 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 116 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 124 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, 134 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 20 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 51 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 70 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 71 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 100 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, 109 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 13 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 35 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 50 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, 125 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, 24 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, 136 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 19, 86 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, 41 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, 108 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, 113 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, 19 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, 95 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 22, 120 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, 55 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, 131 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 24, 85 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 21 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 81 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, 137 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 26, 55 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 26, 88 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 26, 98 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, 16 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, 94 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 39 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 46 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 84 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 88 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 29, 112 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 30, 18 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 30, 89 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 26 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 31, 36 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 32, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 32, 80 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 32, 130 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 33, 53 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 33, 62 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 34, 48 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 34, 59 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 34, 116 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 35, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 35, 29 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 35, 65 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 35, 128 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 36, 97 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 36, 118 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 33 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 74 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 94 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 37, 125 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 38, 74 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 39, 15 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 40, 118 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 41, 56 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 41, 60 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 41, 82 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 42, 57 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 42, 123 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 43, 69 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 43, 78 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 44, 4 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 44, 79 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 45, 49 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 45, 104 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 8 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 96 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 46, 110 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 47, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 48, 99 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 42 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 43 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 85 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 105 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 126 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 132 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 49, 133 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 50, 37 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 50, 47 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 50, 63 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 51, 114 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 51, 115 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 22 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 61 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 52, 103 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 22 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 31 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 53, 124 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 54, 38 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 54, 102 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 54, 108 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 54, 127 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 55, 111 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 56, 30 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 23 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 28 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 36 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 40 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 60 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 68 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 58, 83 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 59, 90 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 59, 119 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 59, 129 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 39 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 47 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 60, 101 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 61, 15 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 6 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 11 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 58 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 84 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 97 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 62, 110 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 63, 5 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 63, 68 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 63, 89 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 64, 34 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 64, 92 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 64, 123 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 65, 133 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 66, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 66, 87 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 67, 70 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 68, 37 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 68, 42 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 68, 66 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 68, 95 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 68, 134 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 69, 117 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 69, 128 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 69, 135 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 70, 29 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 70, 136 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 16 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 30 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 45 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 69 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 75 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 71, 91 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 48 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 76 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 72, 138 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 73, 41 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 73, 72 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 73, 73 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 73, 103 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 38 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 74, 71 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 75, 77 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 75, 131 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 76, 27 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 76, 52 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 76, 101 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 76, 109 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 76, 130 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 77, 75 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 77, 113 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 78, 9 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 67 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 82 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 106 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 79, 126 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 80, 46 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 80, 54 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 81, 24 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 81, 53 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 81, 129 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 3 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 12 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 14 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 31 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 32 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 58 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 65 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 105 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 82, 106 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 27 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 83 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 119 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 121 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 83, 135 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 84, 10 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 84, 59 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 84, 107 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 85, 122 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 86, 77 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 63 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 76 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 102 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 87, 140 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 88, 17 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 88, 21 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 88, 44 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 88, 73 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 88, 122 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 72 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 81 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 100 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 89, 121 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 90, 26 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 90, 64 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 13 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 33 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 98 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 91, 111 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 92, 40 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 93, 132 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 94, 51 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 94, 93 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 94, 99 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 94, 112 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 95, 43 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 95, 93 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 96, 52 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 97, 12 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 98, 17 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 98, 18 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 98, 56 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 98, 96 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 99, 28 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 99, 45 });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 99, 90 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 13, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 19, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 21, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 23, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 24, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 28, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 28, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 29, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 30, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 31, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 32, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 34, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 36, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 38, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 38, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 41, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 42, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 43, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 43, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 43, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 45, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 46, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 46, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 47, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 48, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 49, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 50, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 51, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 52, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 53, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 53, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 55, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 57, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 57, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 58, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 58, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 58, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 59, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 59, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 59, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 59, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 61, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 62, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 63, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 63, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 65, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 66, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 66, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 67, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 68, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 68, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 69, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 69, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 73, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 74, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 74, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 75, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 76, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 76, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 77, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 77, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 79, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 82, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 83, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 84, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 85, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 87, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 87, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 88, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 88, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 89, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 91, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 91, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 92, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 93, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 94, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 95, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 97, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 99, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 99, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 99, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 100, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 100, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 100, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 101, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 102, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 102, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 102, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 102, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 104, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 105, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 105, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 107, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 107, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 108, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 109, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 109, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 109, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 109, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 109, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 110, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 111, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 111, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 111, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 112, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 112, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 112, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 113, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 114, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 114, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 115, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 116, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 116, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 116, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 118, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 118, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 118, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 119, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 119, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 119, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 120, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 120, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 121, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 122, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 122, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 125, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 126, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 126, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 126, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 127, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 127, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 128, 3 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 129, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 129, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 130, 2 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 130, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 132, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 133, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 135, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 135, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 135, 8 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 136, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 136, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 4 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 6 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 138, 5 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 138, 7 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 139, 1 });

            migrationBuilder.DeleteData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 139, 3 });

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 99, 1 },
                    { 94, 90 },
                    { 91, 91 },
                    { 11, 91 },
                    { 84, 92 },
                    { 99, 92 },
                    { 25, 93 },
                    { 11, 93 },
                    { 72, 94 },
                    { 18, 94 },
                    { 83, 95 },
                    { 58, 95 },
                    { 22, 96 },
                    { 17, 96 },
                    { 27, 97 },
                    { 60, 90 },
                    { 18, 97 },
                    { 89, 98 },
                    { 19, 99 },
                    { 96, 99 },
                    { 74, 100 },
                    { 66, 100 },
                    { 24, 101 },
                    { 90, 101 },
                    { 31, 102 },
                    { 92, 102 },
                    { 51, 103 },
                    { 98, 103 },
                    { 39, 104 },
                    { 10, 104 },
                    { 13, 105 },
                    { 85, 98 },
                    { 13, 89 },
                    { 95, 89 },
                    { 51, 88 },
                    { 27, 72 },
                    { 72, 72 },
                    { 8, 73 },
                    { 97, 73 },
                    { 62, 74 },
                    { 95, 74 },
                    { 18, 75 },
                    { 11, 75 },
                    { 56, 76 },
                    { 80, 76 },
                    { 7, 77 },
                    { 60, 77 },
                    { 97, 78 },
                    { 59, 79 },
                    { 7, 79 },
                    { 61, 80 },
                    { 22, 80 },
                    { 47, 88 },
                    { 96, 87 },
                    { 58, 86 },
                    { 60, 86 },
                    { 25, 85 },
                    { 64, 85 },
                    { 38, 105 },
                    { 72, 84 },
                    { 41, 83 },
                    { 98, 83 },
                    { 31, 82 },
                    { 33, 82 },
                    { 90, 81 },
                    { 31, 81 },
                    { 74, 84 },
                    { 2, 106 },
                    { 46, 106 },
                    { 46, 107 },
                    { 65, 125 },
                    { 83, 126 },
                    { 85, 126 },
                    { 89, 127 },
                    { 86, 127 },
                    { 97, 128 },
                    { 68, 128 },
                    { 2, 129 },
                    { 25, 129 },
                    { 89, 130 },
                    { 7, 130 },
                    { 67, 131 },
                    { 15, 131 },
                    { 98, 132 },
                    { 54, 132 },
                    { 6, 133 },
                    { 3, 133 },
                    { 28, 140 },
                    { 50, 140 },
                    { 44, 139 },
                    { 50, 139 },
                    { 7, 138 },
                    { 15, 138 },
                    { 87, 125 },
                    { 79, 137 },
                    { 14, 136 },
                    { 41, 136 },
                    { 30, 135 },
                    { 96, 135 },
                    { 53, 134 },
                    { 7, 134 },
                    { 85, 137 },
                    { 52, 71 },
                    { 60, 124 },
                    { 75, 123 },
                    { 67, 107 },
                    { 30, 108 },
                    { 21, 108 },
                    { 6, 109 },
                    { 34, 109 },
                    { 7, 110 },
                    { 87, 110 },
                    { 69, 111 },
                    { 56, 111 },
                    { 89, 112 },
                    { 7, 112 },
                    { 4, 113 },
                    { 44, 113 },
                    { 24, 114 },
                    { 11, 115 },
                    { 58, 115 },
                    { 32, 116 },
                    { 56, 123 },
                    { 45, 122 },
                    { 6, 122 },
                    { 62, 121 },
                    { 72, 121 },
                    { 27, 120 },
                    { 70, 124 },
                    { 49, 120 },
                    { 79, 119 },
                    { 1, 118 },
                    { 70, 118 },
                    { 93, 117 },
                    { 39, 117 },
                    { 99, 116 },
                    { 91, 119 },
                    { 80, 71 },
                    { 89, 78 },
                    { 39, 70 },
                    { 11, 19 },
                    { 51, 20 },
                    { 73, 20 },
                    { 90, 21 },
                    { 55, 21 },
                    { 85, 22 },
                    { 87, 22 },
                    { 87, 23 },
                    { 81, 23 },
                    { 92, 24 },
                    { 68, 24 },
                    { 95, 25 },
                    { 34, 25 },
                    { 57, 26 },
                    { 17, 26 },
                    { 45, 27 },
                    { 95, 27 },
                    { 48, 34 },
                    { 62, 34 },
                    { 96, 33 },
                    { 1, 33 },
                    { 66, 32 },
                    { 94, 32 },
                    { 14, 19 },
                    { 87, 31 },
                    { 29, 30 },
                    { 95, 30 },
                    { 8, 29 },
                    { 17, 29 },
                    { 17, 70 },
                    { 43, 28 },
                    { 79, 31 },
                    { 93, 35 },
                    { 66, 18 },
                    { 6, 17 },
                    { 58, 2 },
                    { 52, 2 },
                    { 46, 3 },
                    { 44, 3 },
                    { 24, 4 },
                    { 41, 4 },
                    { 75, 5 },
                    { 90, 5 },
                    { 36, 6 },
                    { 97, 6 },
                    { 54, 7 },
                    { 37, 7 },
                    { 8, 8 },
                    { 72, 8 },
                    { 31, 9 },
                    { 75, 9 },
                    { 76, 10 },
                    { 35, 17 },
                    { 39, 16 },
                    { 89, 16 },
                    { 10, 15 },
                    { 47, 15 },
                    { 37, 14 },
                    { 43, 18 },
                    { 64, 14 },
                    { 57, 13 },
                    { 51, 12 },
                    { 52, 12 },
                    { 83, 11 },
                    { 8, 11 },
                    { 74, 10 },
                    { 18, 13 },
                    { 42, 35 },
                    { 17, 28 },
                    { 21, 36 },
                    { 42, 54 },
                    { 13, 55 },
                    { 90, 55 },
                    { 19, 56 },
                    { 52, 56 },
                    { 44, 57 },
                    { 20, 57 },
                    { 5, 58 },
                    { 83, 58 },
                    { 46, 59 },
                    { 81, 59 },
                    { 14, 60 },
                    { 59, 36 },
                    { 23, 61 },
                    { 92, 54 },
                    { 85, 62 },
                    { 92, 63 },
                    { 53, 63 },
                    { 6, 64 },
                    { 3, 64 },
                    { 10, 65 },
                    { 81, 65 },
                    { 91, 66 },
                    { 78, 66 },
                    { 78, 67 },
                    { 72, 67 },
                    { 55, 68 },
                    { 80, 68 },
                    { 23, 69 },
                    { 88, 69 },
                    { 67, 62 },
                    { 36, 53 },
                    { 28, 60 },
                    { 53, 52 },
                    { 24, 37 },
                    { 74, 53 },
                    { 83, 38 },
                    { 53, 38 },
                    { 97, 39 },
                    { 65, 39 },
                    { 63, 40 },
                    { 75, 40 },
                    { 25, 41 },
                    { 96, 41 },
                    { 42, 42 },
                    { 14, 42 },
                    { 53, 43 },
                    { 73, 43 },
                    { 93, 44 },
                    { 4, 37 },
                    { 63, 45 },
                    { 74, 52 },
                    { 44, 51 },
                    { 20, 51 },
                    { 91, 50 },
                    { 87, 50 },
                    { 39, 44 },
                    { 61, 49 },
                    { 20, 49 },
                    { 93, 48 },
                    { 22, 47 },
                    { 16, 47 },
                    { 6, 46 },
                    { 49, 46 },
                    { 27, 45 },
                    { 3, 48 }
                });

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 2, 6 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 4, 2 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 8, 2 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 12, 3 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 13, 7 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 4 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 14, 8 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 17, 5 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 19, 8 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 20, 5 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 22, 5 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 22, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 23, 6 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 6 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 25, 8 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 6 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 27, 8 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 29, 5 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 4 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 37, 7 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 38, 1 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 40, 6 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 41, 4 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 42, 8 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 43, 3 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 2 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 44, 7 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 45, 7 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 46, 8 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 48, 8 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 49, 4 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 52, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 54, 2 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 55, 4 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 62, 6 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 64, 3 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 64, 6 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 65, 5 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 65, 7 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 66, 4 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 67, 2 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 70, 1 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 71, 3 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 1 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 72, 2 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 73, 1 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 73, 7 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 77, 8 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 78, 4 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 3 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 80, 4 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 81, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 81, 8 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 82, 6 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 85, 7 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 86, 7 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 90, 3 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 91, 5 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 93, 7 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 94, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 95, 5 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 96, 3 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 96, 4 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 97, 8 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 98, 3 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 99, 2 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 101, 7 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 103, 1 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 104, 6 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 108, 4 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 108, 8 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 110, 1 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 112, 4 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 114, 7 },
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 115, 7 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 118, 4 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 122, 8 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 5 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 6 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 123, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 124, 7 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 130, 7 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 131, 3 },
                column: "Rating",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 131, 6 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 131, 8 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 134, 4 },
                column: "Rating",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 135, 5 },
                column: "Rating",
                value: 5);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 136, 8 },
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 137, 3 },
                column: "Rating",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MovieRatings",
                keyColumns: new[] { "MovieId", "UserId" },
                keyValues: new object[] { 139, 6 },
                column: "Rating",
                value: 1);

            migrationBuilder.InsertData(
                table: "MovieRatings",
                columns: new[] { "MovieId", "UserId", "Rating" },
                values: new object[,]
                {
                    { 31, 5, 1 },
                    { 88, 4, 0 },
                    { 29, 7, 4 },
                    { 138, 1, 5 },
                    { 113, 1, 1 },
                    { 95, 7, 1 },
                    { 60, 8, 4 },
                    { 42, 3, 5 },
                    { 55, 6, 1 },
                    { 21, 7, 5 },
                    { 47, 5, 5 },
                    { 36, 7, 4 },
                    { 118, 5, 3 },
                    { 25, 5, 1 },
                    { 117, 2, 5 },
                    { 133, 1, 2 },
                    { 16, 4, 2 },
                    { 113, 7, 1 },
                    { 11, 7, 0 },
                    { 15, 4, 1 },
                    { 54, 3, 3 },
                    { 120, 1, 2 },
                    { 103, 8, 1 },
                    { 61, 5, 2 },
                    { 45, 3, 1 },
                    { 137, 7, 3 },
                    { 60, 4, 3 },
                    { 5, 6, 4 },
                    { 73, 6, 3 },
                    { 46, 3, 2 },
                    { 62, 7, 4 },
                    { 114, 2, 4 },
                    { 103, 6, 2 },
                    { 22, 6, 0 },
                    { 103, 5, 0 },
                    { 93, 4, 1 },
                    { 69, 6, 5 },
                    { 72, 3, 3 },
                    { 115, 8, 0 },
                    { 110, 2, 0 },
                    { 75, 2, 4 },
                    { 76, 5, 5 },
                    { 119, 8, 3 },
                    { 5, 7, 3 },
                    { 82, 5, 0 },
                    { 84, 6, 5 },
                    { 115, 6, 1 },
                    { 28, 8, 0 },
                    { 134, 3, 4 },
                    { 9, 1, 5 },
                    { 15, 1, 1 },
                    { 119, 3, 4 },
                    { 29, 8, 0 },
                    { 23, 1, 3 },
                    { 83, 4, 5 },
                    { 89, 1, 4 },
                    { 3, 5, 4 },
                    { 100, 1, 1 },
                    { 87, 3, 5 },
                    { 5, 1, 1 },
                    { 49, 8, 3 },
                    { 12, 8, 5 },
                    { 83, 3, 4 },
                    { 138, 2, 3 },
                    { 134, 2, 0 },
                    { 39, 8, 1 },
                    { 3, 8, 3 },
                    { 26, 5, 4 },
                    { 44, 3, 2 },
                    { 22, 1, 2 },
                    { 39, 1, 5 },
                    { 7, 2, 2 },
                    { 15, 6, 5 },
                    { 3, 4, 3 },
                    { 125, 6, 2 },
                    { 116, 4, 3 },
                    { 65, 4, 3 },
                    { 56, 1, 5 },
                    { 2, 4, 1 },
                    { 52, 1, 3 },
                    { 124, 3, 2 },
                    { 32, 4, 3 },
                    { 34, 6, 0 },
                    { 105, 8, 0 },
                    { 47, 7, 5 },
                    { 129, 3, 2 },
                    { 108, 5, 4 },
                    { 12, 1, 1 },
                    { 132, 5, 0 },
                    { 55, 5, 4 },
                    { 83, 8, 3 },
                    { 102, 2, 5 },
                    { 114, 6, 4 },
                    { 15, 2, 1 },
                    { 75, 3, 4 },
                    { 35, 8, 2 },
                    { 80, 7, 5 },
                    { 62, 1, 3 },
                    { 81, 5, 2 },
                    { 63, 6, 1 },
                    { 137, 8, 4 },
                    { 68, 7, 1 },
                    { 50, 1, 5 },
                    { 58, 8, 2 },
                    { 1, 3, 5 },
                    { 34, 8, 3 },
                    { 61, 3, 4 },
                    { 60, 6, 1 },
                    { 40, 2, 0 },
                    { 79, 6, 3 },
                    { 45, 8, 0 },
                    { 14, 5, 5 },
                    { 12, 5, 2 },
                    { 113, 5, 1 },
                    { 24, 3, 3 },
                    { 122, 1, 4 },
                    { 123, 7, 5 },
                    { 82, 2, 1 },
                    { 94, 6, 2 },
                    { 95, 8, 5 },
                    { 132, 1, 2 },
                    { 139, 7, 4 },
                    { 4, 8, 4 },
                    { 111, 4, 1 },
                    { 42, 5, 2 },
                    { 27, 7, 1 },
                    { 2, 2, 0 },
                    { 87, 5, 4 },
                    { 128, 7, 5 },
                    { 72, 6, 5 },
                    { 24, 6, 3 },
                    { 31, 8, 0 },
                    { 14, 7, 4 },
                    { 68, 6, 1 },
                    { 87, 1, 4 },
                    { 36, 8, 2 },
                    { 70, 2, 5 },
                    { 88, 2, 0 },
                    { 58, 2, 5 },
                    { 9, 6, 5 },
                    { 136, 3, 1 },
                    { 50, 2, 3 },
                    { 50, 3, 4 },
                    { 101, 5, 4 },
                    { 134, 5, 0 },
                    { 66, 5, 0 },
                    { 34, 2, 0 },
                    { 14, 2, 5 },
                    { 48, 3, 2 },
                    { 116, 2, 1 },
                    { 112, 2, 3 },
                    { 63, 2, 5 },
                    { 48, 5, 4 },
                    { 103, 2, 5 },
                    { 48, 4, 5 },
                    { 67, 8, 0 },
                    { 125, 1, 2 },
                    { 113, 8, 4 },
                    { 95, 4, 0 },
                    { 81, 4, 1 },
                    { 120, 2, 1 },
                    { 39, 4, 3 },
                    { 67, 3, 1 },
                    { 118, 1, 5 },
                    { 64, 8, 0 },
                    { 49, 1, 4 },
                    { 101, 1, 5 },
                    { 71, 6, 3 },
                    { 102, 5, 3 },
                    { 47, 3, 4 },
                    { 59, 7, 2 },
                    { 30, 1, 2 },
                    { 40, 5, 1 },
                    { 72, 4, 4 },
                    { 89, 6, 4 },
                    { 84, 8, 4 },
                    { 56, 8, 3 },
                    { 82, 1, 4 },
                    { 70, 6, 2 },
                    { 78, 5, 0 },
                    { 78, 2, 4 },
                    { 90, 2, 0 },
                    { 106, 3, 2 },
                    { 71, 5, 5 },
                    { 41, 1, 3 },
                    { 53, 6, 1 },
                    { 15, 8, 0 },
                    { 94, 4, 3 },
                    { 33, 5, 2 },
                    { 6, 6, 5 },
                    { 137, 5, 2 },
                    { 79, 3, 2 },
                    { 129, 5, 4 },
                    { 7, 3, 1 },
                    { 126, 2, 2 },
                    { 11, 5, 3 },
                    { 78, 6, 1 },
                    { 1, 2, 4 },
                    { 90, 4, 1 },
                    { 120, 8, 1 },
                    { 31, 1, 3 },
                    { 70, 7, 4 },
                    { 58, 1, 0 },
                    { 125, 3, 4 },
                    { 28, 2, 3 },
                    { 100, 4, 0 },
                    { 97, 1, 2 },
                    { 12, 2, 0 },
                    { 9, 7, 2 },
                    { 17, 4, 5 },
                    { 65, 8, 4 },
                    { 64, 7, 5 },
                    { 45, 2, 0 },
                    { 58, 5, 4 },
                    { 45, 6, 5 },
                    { 3, 7, 0 },
                    { 113, 3, 4 },
                    { 20, 6, 1 },
                    { 132, 8, 1 },
                    { 97, 3, 1 },
                    { 130, 6, 3 },
                    { 36, 1, 0 },
                    { 86, 1, 0 },
                    { 93, 5, 0 },
                    { 66, 1, 0 },
                    { 92, 1, 1 },
                    { 101, 8, 1 },
                    { 33, 7, 3 },
                    { 121, 2, 3 },
                    { 50, 5, 0 },
                    { 130, 4, 3 },
                    { 99, 1, 1 },
                    { 4, 3, 3 },
                    { 37, 3, 2 },
                    { 28, 1, 4 },
                    { 24, 7, 5 },
                    { 55, 3, 5 },
                    { 30, 4, 1 },
                    { 39, 7, 0 },
                    { 60, 1, 2 },
                    { 89, 8, 0 },
                    { 51, 6, 1 },
                    { 56, 3, 3 },
                    { 40, 4, 3 },
                    { 134, 1, 2 },
                    { 18, 6, 3 },
                    { 121, 8, 5 },
                    { 80, 2, 1 },
                    { 15, 3, 2 },
                    { 80, 8, 0 },
                    { 34, 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "g/wWNcQVaPSAg6JHp/2ZvNFwy6eBoYBAnpfAvnORvUg=", new byte[] { 162, 60, 74, 138, 175, 56, 97, 254, 205, 244, 122, 192, 113, 30, 152, 158 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7S//YRyHZvPiUwDRm8iuEL3kb/Jf0kstbTIE06HNI6I=", new byte[] { 42, 100, 102, 176, 75, 83, 60, 104, 134, 243, 100, 33, 120, 122, 159, 0 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "1NT78fYXr13yFhQ7ML1sRE7Xvq1wMe7SxKnc29CKc+c=", new byte[] { 171, 235, 97, 6, 199, 97, 215, 225, 141, 117, 202, 184, 53, 236, 111, 235 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "4BauvwWvnKzVOYUWABtOFZZ1sZjgjyo0L77GdRPzQMY=", new byte[] { 218, 40, 95, 132, 157, 23, 94, 20, 43, 248, 221, 129, 23, 209, 20, 3 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "O577bZovjfHhUwqEZ1xz/GGbATZUGrSZK3C2oZm8FKg=", new byte[] { 158, 47, 31, 145, 153, 178, 208, 115, 124, 177, 81, 25, 15, 251, 159, 157 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "x4FrV2LtpJAqZ+iaU8l+zaXOHVc6GTzqEIzCM5YsJbo=", new byte[] { 141, 151, 222, 33, 1, 76, 194, 237, 175, 46, 61, 217, 189, 31, 57, 130 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "cIdvoRkMQPoPhP9iIkJ3iSKX3hJHBXYIHuZePjBIeRc=", new byte[] { 15, 113, 251, 46, 111, 88, 243, 52, 113, 200, 246, 100, 72, 55, 153, 217 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "87ZbTwa7wSYLoLe2ubSQWOsgkgUtFBHQvGc9ncIRrQQ=", new byte[] { 68, 174, 224, 53, 235, 230, 181, 181, 66, 214, 5, 222, 200, 76, 147, 7 } });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "pm/kFXcQIQxG/XBq2fITexEEWrrU5ceA4QapZYq8VHM=", new byte[] { 182, 62, 216, 51, 94, 67, 46, 172, 110, 122, 52, 96, 109, 56, 237, 158 } });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieRatings_User_UserId",
                table: "MovieRatings",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
