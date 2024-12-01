using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PLANCARDAO.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Libelle = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dommages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Description = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dommages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Couleur = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DateService = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Immatriculation = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsAssuranceEnRegle = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    IsVehiculeVole = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Marque = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Modele = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    StatutVehicule = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Villes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Libelle = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DepartementId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villes_Departements_DepartementId",
                        column: x => x.DepartementId,
                        principalTable: "Departements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Adresse = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EmailResponsable = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Nom = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NomResponsable = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Telephone = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TelephoneResponsable = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LocalisationId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institutions_Villes_LocalisationId",
                        column: x => x.LocalisationId,
                        principalTable: "Villes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DemandeUtilisations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NoDemande = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DateDemande = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DebutUtilisation = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    FinUtilisation = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DestinationId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DescriptionDestination = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    InstitutionId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    VehiculeId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    StatutDemande = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Commentaire = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemandeUtilisations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DemandeUtilisations_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DemandeUtilisations_Vehicules_VehiculeId",
                        column: x => x.VehiculeId,
                        principalTable: "Vehicules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DemandeUtilisations_Villes_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Villes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Privilege = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    StatutCompte = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    InstitutionId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Constats",
                columns: table => new
                {
                    Id = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DemandeUtilisationId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DateEffectue = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EffectuePar = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LocalisationPhotos = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TypeConstat = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DommageId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Constats_DemandeUtilisations_DemandeUtilisationId",
                        column: x => x.DemandeUtilisationId,
                        principalTable: "DemandeUtilisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Constats_Dommages_DommageId",
                        column: x => x.DommageId,
                        principalTable: "Dommages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Constats_DemandeUtilisationId",
                table: "Constats",
                column: "DemandeUtilisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Constats_DommageId",
                table: "Constats",
                column: "DommageId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeUtilisations_DestinationId",
                table: "DemandeUtilisations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeUtilisations_InstitutionId",
                table: "DemandeUtilisations",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_DemandeUtilisations_VehiculeId",
                table: "DemandeUtilisations",
                column: "VehiculeId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_LocalisationId",
                table: "Institutions",
                column: "LocalisationId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_InstitutionId",
                table: "Utilisateurs",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Villes_DepartementId",
                table: "Villes",
                column: "DepartementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constats");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "DemandeUtilisations");

            migrationBuilder.DropTable(
                name: "Dommages");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "Villes");

            migrationBuilder.DropTable(
                name: "Departements");
        }
    }
}
