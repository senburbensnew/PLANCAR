using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PLANCARDAO.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNameToSingular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Constats_DemandeUtilisations_DemandeUtilisationId",
                table: "Constats");

            migrationBuilder.DropForeignKey(
                name: "FK_Constats_Dommages_DommageId",
                table: "Constats");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeUtilisations_Institutions_InstitutionId",
                table: "DemandeUtilisations");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeUtilisations_Vehicules_VehiculeId",
                table: "DemandeUtilisations");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeUtilisations_Villes_DestinationId",
                table: "DemandeUtilisations");

            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_Villes_LocalisationId",
                table: "Institutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateurs_Institutions_InstitutionId",
                table: "Utilisateurs");

            migrationBuilder.DropForeignKey(
                name: "FK_Villes_Departements_DepartementId",
                table: "Villes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Villes",
                table: "Villes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicules",
                table: "Vehicules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institutions",
                table: "Institutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dommages",
                table: "Dommages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departements",
                table: "Departements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DemandeUtilisations",
                table: "DemandeUtilisations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Constats",
                table: "Constats");

            migrationBuilder.RenameTable(
                name: "Villes",
                newName: "Ville");

            migrationBuilder.RenameTable(
                name: "Vehicules",
                newName: "Vehicule");

            migrationBuilder.RenameTable(
                name: "Utilisateurs",
                newName: "Utilisateur");

            migrationBuilder.RenameTable(
                name: "Institutions",
                newName: "Institution");

            migrationBuilder.RenameTable(
                name: "Dommages",
                newName: "Dommage");

            migrationBuilder.RenameTable(
                name: "Departements",
                newName: "Departement");

            migrationBuilder.RenameTable(
                name: "DemandeUtilisations",
                newName: "DemandeUtilisation");

            migrationBuilder.RenameTable(
                name: "Constats",
                newName: "Constat");

            migrationBuilder.RenameIndex(
                name: "IX_Villes_DepartementId",
                table: "Ville",
                newName: "IX_Ville_DepartementId");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateurs_InstitutionId",
                table: "Utilisateur",
                newName: "IX_Utilisateur_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_Institutions_LocalisationId",
                table: "Institution",
                newName: "IX_Institution_LocalisationId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeUtilisations_VehiculeId",
                table: "DemandeUtilisation",
                newName: "IX_DemandeUtilisation_VehiculeId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeUtilisations_InstitutionId",
                table: "DemandeUtilisation",
                newName: "IX_DemandeUtilisation_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeUtilisations_DestinationId",
                table: "DemandeUtilisation",
                newName: "IX_DemandeUtilisation_DestinationId");

            migrationBuilder.RenameIndex(
                name: "IX_Constats_DommageId",
                table: "Constat",
                newName: "IX_Constat_DommageId");

            migrationBuilder.RenameIndex(
                name: "IX_Constats_DemandeUtilisationId",
                table: "Constat",
                newName: "IX_Constat_DemandeUtilisationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ville",
                table: "Ville",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicule",
                table: "Vehicule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institution",
                table: "Institution",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dommage",
                table: "Dommage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departement",
                table: "Departement",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DemandeUtilisation",
                table: "DemandeUtilisation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Constat",
                table: "Constat",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Constat_DemandeUtilisation_DemandeUtilisationId",
                table: "Constat",
                column: "DemandeUtilisationId",
                principalTable: "DemandeUtilisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Constat_Dommage_DommageId",
                table: "Constat",
                column: "DommageId",
                principalTable: "Dommage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeUtilisation_Institution_InstitutionId",
                table: "DemandeUtilisation",
                column: "InstitutionId",
                principalTable: "Institution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeUtilisation_Vehicule_VehiculeId",
                table: "DemandeUtilisation",
                column: "VehiculeId",
                principalTable: "Vehicule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeUtilisation_Ville_DestinationId",
                table: "DemandeUtilisation",
                column: "DestinationId",
                principalTable: "Ville",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Institution_Ville_LocalisationId",
                table: "Institution",
                column: "LocalisationId",
                principalTable: "Ville",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Institution_InstitutionId",
                table: "Utilisateur",
                column: "InstitutionId",
                principalTable: "Institution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ville_Departement_DepartementId",
                table: "Ville",
                column: "DepartementId",
                principalTable: "Departement",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Constat_DemandeUtilisation_DemandeUtilisationId",
                table: "Constat");

            migrationBuilder.DropForeignKey(
                name: "FK_Constat_Dommage_DommageId",
                table: "Constat");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeUtilisation_Institution_InstitutionId",
                table: "DemandeUtilisation");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeUtilisation_Vehicule_VehiculeId",
                table: "DemandeUtilisation");

            migrationBuilder.DropForeignKey(
                name: "FK_DemandeUtilisation_Ville_DestinationId",
                table: "DemandeUtilisation");

            migrationBuilder.DropForeignKey(
                name: "FK_Institution_Ville_LocalisationId",
                table: "Institution");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Institution_InstitutionId",
                table: "Utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_Ville_Departement_DepartementId",
                table: "Ville");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ville",
                table: "Ville");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicule",
                table: "Vehicule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institution",
                table: "Institution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dommage",
                table: "Dommage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departement",
                table: "Departement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DemandeUtilisation",
                table: "DemandeUtilisation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Constat",
                table: "Constat");

            migrationBuilder.RenameTable(
                name: "Ville",
                newName: "Villes");

            migrationBuilder.RenameTable(
                name: "Vehicule",
                newName: "Vehicules");

            migrationBuilder.RenameTable(
                name: "Utilisateur",
                newName: "Utilisateurs");

            migrationBuilder.RenameTable(
                name: "Institution",
                newName: "Institutions");

            migrationBuilder.RenameTable(
                name: "Dommage",
                newName: "Dommages");

            migrationBuilder.RenameTable(
                name: "Departement",
                newName: "Departements");

            migrationBuilder.RenameTable(
                name: "DemandeUtilisation",
                newName: "DemandeUtilisations");

            migrationBuilder.RenameTable(
                name: "Constat",
                newName: "Constats");

            migrationBuilder.RenameIndex(
                name: "IX_Ville_DepartementId",
                table: "Villes",
                newName: "IX_Villes_DepartementId");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateur_InstitutionId",
                table: "Utilisateurs",
                newName: "IX_Utilisateurs_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_Institution_LocalisationId",
                table: "Institutions",
                newName: "IX_Institutions_LocalisationId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeUtilisation_VehiculeId",
                table: "DemandeUtilisations",
                newName: "IX_DemandeUtilisations_VehiculeId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeUtilisation_InstitutionId",
                table: "DemandeUtilisations",
                newName: "IX_DemandeUtilisations_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_DemandeUtilisation_DestinationId",
                table: "DemandeUtilisations",
                newName: "IX_DemandeUtilisations_DestinationId");

            migrationBuilder.RenameIndex(
                name: "IX_Constat_DommageId",
                table: "Constats",
                newName: "IX_Constats_DommageId");

            migrationBuilder.RenameIndex(
                name: "IX_Constat_DemandeUtilisationId",
                table: "Constats",
                newName: "IX_Constats_DemandeUtilisationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Villes",
                table: "Villes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicules",
                table: "Vehicules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateurs",
                table: "Utilisateurs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institutions",
                table: "Institutions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dommages",
                table: "Dommages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departements",
                table: "Departements",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DemandeUtilisations",
                table: "DemandeUtilisations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Constats",
                table: "Constats",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Constats_DemandeUtilisations_DemandeUtilisationId",
                table: "Constats",
                column: "DemandeUtilisationId",
                principalTable: "DemandeUtilisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Constats_Dommages_DommageId",
                table: "Constats",
                column: "DommageId",
                principalTable: "Dommages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeUtilisations_Institutions_InstitutionId",
                table: "DemandeUtilisations",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeUtilisations_Vehicules_VehiculeId",
                table: "DemandeUtilisations",
                column: "VehiculeId",
                principalTable: "Vehicules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DemandeUtilisations_Villes_DestinationId",
                table: "DemandeUtilisations",
                column: "DestinationId",
                principalTable: "Villes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_Villes_LocalisationId",
                table: "Institutions",
                column: "LocalisationId",
                principalTable: "Villes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateurs_Institutions_InstitutionId",
                table: "Utilisateurs",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Villes_Departements_DepartementId",
                table: "Villes",
                column: "DepartementId",
                principalTable: "Departements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
