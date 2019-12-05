using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    ConductingLeader = table.Column<string>(nullable: true),
                    OpeningSong = table.Column<string>(nullable: true),
                    SacramentSong = table.Column<string>(nullable: true),
                    ClosingSong = table.Column<string>(nullable: true),
                    IntermediateSong = table.Column<string>(nullable: true),
                    OpeningPrayer = table.Column<string>(nullable: true),
                    ClosingPrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetingID);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingID = table.Column<int>(nullable: false),
                    SpeakerName = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Speaker_Meeting_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meeting",
                        principalColumn: "MeetingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_MeetingID",
                table: "Speaker",
                column: "MeetingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
