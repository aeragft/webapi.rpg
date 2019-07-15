using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SkillAndWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Skill_SkillId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Weapon_WeaponId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_Weapon_WeaponId",
                table: "Skill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.RenameTable(
                name: "Weapon",
                newName: "Weapons");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "Skills");

            migrationBuilder.RenameIndex(
                name: "IX_Skill_WeaponId",
                table: "Skills",
                newName: "IX_Skills_WeaponId");

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_WeaponId",
                table: "Characters",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Weapons_WeaponId",
                table: "Characters",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Skills_SkillId",
                table: "Jobs",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Weapons_WeaponId",
                table: "Jobs",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Weapons_WeaponId",
                table: "Skills",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Weapons_WeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Skills_SkillId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Weapons_WeaponId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Weapons_WeaponId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Characters_WeaponId",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Characters");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "Weapon");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skill");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_WeaponId",
                table: "Skill",
                newName: "IX_Skill_WeaponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Skill_SkillId",
                table: "Jobs",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Weapon_WeaponId",
                table: "Jobs",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_Weapon_WeaponId",
                table: "Skill",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
