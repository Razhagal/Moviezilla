using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moviezilla.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoviesAndActors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Actor Identifier"),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Actor Full Name"),
                    short_bio = table.Column<string>(type: "character varying(1500)", maxLength: 1500, nullable: true, comment: "Actor Bio"),
                    image_url = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true, comment: "Actor Picture Url"),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_actors", x => x.id);
                },
                comment: "Actor in the system");

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Movie Identifier"),
                    title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Movie Title"),
                    genre = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, comment: "Movie Genre"),
                    rating = table.Column<float>(type: "real", nullable: false, defaultValue: 0f, comment: "Movie Rating"),
                    description = table.Column<string>(type: "character varying(2500)", maxLength: 2500, nullable: false, comment: "Movie Full Description"),
                    short_description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false, comment: "Movie Short Description"),
                    release_date = table.Column<DateOnly>(type: "date", nullable: false, comment: "Movie Release Date"),
                    director_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Movie Director"),
                    duration = table.Column<int>(type: "integer", nullable: false, comment: "Movie Duration"),
                    image_url = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true, comment: "Movie Poster Image Url"),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_movies", x => x.id);
                    table.CheckConstraint("ck_movie_duration", "duration >= 1");
                    table.CheckConstraint("ck_movie_rating", "rating >= 0 AND rating <= 10");
                },
                comment: "Movie in the system");

            migrationBuilder.CreateTable(
                name: "movies_actors",
                columns: table => new
                {
                    movie_id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Movie Identifier"),
                    actor_id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Actor Identifier"),
                    character_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Name of the  character played by the Actor")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_movies_actors", x => new { x.movie_id, x.actor_id });
                    table.ForeignKey(
                        name: "fk_movies_actors_actors_actor_id",
                        column: x => x.actor_id,
                        principalTable: "actors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_movies_actors_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Movies and Actors Joint Table");

            migrationBuilder.CreateIndex(
                name: "ix_movies_actors_actor_id",
                table: "movies_actors",
                column: "actor_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies_actors");

            migrationBuilder.DropTable(
                name: "actors");

            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
