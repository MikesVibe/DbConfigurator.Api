using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbConfigurator.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Area",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Americas" },
                    { 2, "Central Europe" },
                    { 3, "Growing Markets" },
                    { 4, "Northern Europe" },
                    { 5, "Southern Europe" },
                    { 99, "ANY" }
                });

            migrationBuilder.InsertData(
                table: "BusinessUnit",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "NAO" },
                    { 2, "SAM" },
                    { 3, "GER" },
                    { 4, "CEE" },
                    { 5, "MEK" },
                    { 6, "AFR" },
                    { 7, "IND" },
                    { 8, "APAC" },
                    { 9, "BTN" },
                    { 10, "UK&I" },
                    { 11, "ITA" },
                    { 12, "IBE" },
                    { 13, "FRA" },
                    { 99, "ANY" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryCode", "CountryName" },
                values: new object[,]
                {
                    { 1, "CA", "Canada" },
                    { 2, "GT", "Guatemala" },
                    { 3, "MX", "Mexico" },
                    { 4, "PR", "Puerto Rico" },
                    { 5, "US", "USA" },
                    { 6, "AR", "Argentina" },
                    { 7, "BR", "Brazil" },
                    { 8, "CL", "Chile" },
                    { 9, "CO", "Colombia" },
                    { 10, "PE", "Peru" },
                    { 11, "UY", "Uruguay" },
                    { 12, "VE", "Venezuela" },
                    { 13, "DE", "Germany" },
                    { 14, "PL", "Poland" },
                    { 15, "RU", "Russian Federation" },
                    { 16, "AT", "Austria" },
                    { 17, "BG", "Bulgaria" },
                    { 18, "CH", "Switzerland" },
                    { 19, "CY", "Cyprus" },
                    { 20, "CZ", "Czech Republic" },
                    { 21, "GR", "Greece" },
                    { 22, "HR", "Croatia" },
                    { 23, "HU", "Hungary" },
                    { 24, "IL", "Israel" },
                    { 25, "KZ", "Kasakhstan" },
                    { 26, "RO", "Romania" },
                    { 27, "RS", "Serbia" },
                    { 28, "SK", "Slovakia" },
                    { 29, "UA", "Ukraine" },
                    { 30, "AE", "United Arab Emirates" },
                    { 31, "EG", "Egypt" },
                    { 32, "IR", "Iran" },
                    { 33, "LB", "Lebanon" },
                    { 34, "QA", "Qatar" },
                    { 35, "SA", "Saudi Arabia" },
                    { 36, "TR", "Turkey" },
                    { 37, "BF", "Burkina Faso" },
                    { 38, "BJ", "Benin" },
                    { 39, "CI", "Cote d'Ivoire" },
                    { 40, "DZ", "Algeria" },
                    { 41, "GA", "Gabon" },
                    { 42, "CI", "Ivory Coast" },
                    { 43, "MA", "Morocco" },
                    { 44, "MG", "Madagascar" },
                    { 45, "ML", "Mali" },
                    { 46, "MU", "Mauritius" },
                    { 47, "SN", "Senegal" },
                    { 48, "TN", "Tunisia" },
                    { 49, "ZA", "South Africa" },
                    { 50, "IN", "India" },
                    { 51, "AU", "Australia" },
                    { 52, "CN", "People Rep China" },
                    { 53, "HK", "Hong Kong" },
                    { 54, "ID", "Indonesia" },
                    { 55, "JP", "Japan" },
                    { 56, "KR", "Korea" },
                    { 57, "MY", "Malaysia" },
                    { 58, "NZ", "New Zealand" },
                    { 59, "PH", "Philippines" },
                    { 60, "SG", "Singapore" },
                    { 61, "TH", "Thailand" },
                    { 62, "TW", "Taiwan" },
                    { 63, "BE", "Belgium" },
                    { 64, "DK", "Denmark" },
                    { 65, "EE", "Estonia" },
                    { 66, "FI", "Finland" },
                    { 67, "LT", "Lithuania" },
                    { 68, "LU", "Luxembourg" },
                    { 69, "NL", "Netherlands" },
                    { 70, "NO", "Norway" },
                    { 71, "SE", "Sweden" },
                    { 72, "GB", "United Kingdom" },
                    { 73, "IE", "Ireland" },
                    { 74, "IT", "Italy" },
                    { 75, "AD", "Andorra" },
                    { 76, "ES", "Spain" },
                    { 77, "PT", "Portugal" },
                    { 78, "FR", "France" },
                    { 79, "MA", "Morocco" },
                    { 80, "NC", "New Caledonia" },
                    { 81, "PF", "French Polynesia" },
                    { 99, "ANY", "ANY" }
                });

            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "P1" },
                    { 2, "P2" },
                    { 3, "P3" },
                    { 4, "P4" },
                    { 99, "ANY" }
                });

            migrationBuilder.InsertData(
                table: "Recipient",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Whitney.Soto@company.net", "Whitney", "Soto" },
                    { 2, "Tia.Lynn@company.net", "Tia", "Lynn" },
                    { 3, "Amin.Stevens@company.net", "Amin", "Stevens" },
                    { 4, "Osian.Chambers@company.net", "Osian", "Chambers" },
                    { 5, "Sean.Nguyen@company.net", "Sean", "Nguyen" },
                    { 6, "Fleur.Savage@company.net", "Fleur", "Savage" },
                    { 7, "Leia.Brandt@company.net", "Leia", "Brandt" },
                    { 8, "Issac.Marshall@company.net", "Issac", "Marshall" },
                    { 9, "Eliza.Mcleod@company.net", "Eliza", "Mcleod" },
                    { 10, "Cyrus.Lewis@company.net", "Cyrus", "Lewis" },
                    { 11, "Heather.Daniels@company.net", "Heather", "Daniels" },
                    { 12, "Lorraine.Byrne@company.net", "Lorraine", "Byrne" },
                    { 13, "Neave.Reid@company.net", "Neave", "Reid" },
                    { 14, "Martina.Douglas@company.net", "Martina", "Douglas" },
                    { 15, "Zayd.Donovan@company.net", "Zayd", "Donovan" },
                    { 16, "Halima.Bonilla@company.net", "Halima", "Bonilla" },
                    { 17, "Cordelia.Tucker@company.net", "Cordelia", "Tucker" },
                    { 18, "Orla.Berry@company.net", "Orla", "Berry" },
                    { 19, "Sidney.Golden@company.net", "Sidney", "Golden" },
                    { 20, "Filip.Hardin@company.net", "Filip", "Hardin" },
                    { 21, "Thalia.Terry@company.net", "Thalia", "Terry" },
                    { 22, "Ricardo.Ortega@company.net", "Ricardo", "Ortega" },
                    { 23, "Abbie.Trujillo@company.net", "Abbie", "Trujillo" },
                    { 24, "Bernice.Harper@company.net", "Bernice", "Harper" },
                    { 25, "Taha.Alvarado@company.net", "Taha", "Alvarado" },
                    { 26, "Hazel.Peters@company.net", "Hazel", "Peters" },
                    { 27, "Marilyn.Zuniga@company.net", "Marilyn", "Zuniga" },
                    { 28, "Dhruv.Allison@company.net", "Dhruv", "Allison" },
                    { 29, "Phillip.Bowen@company.net", "Phillip", "Bowen" },
                    { 30, "Flora.Hale@company.net", "Flora", "Hale" },
                    { 31, "Sara.Calhoun@company.net", "Sara", "Calhoun" },
                    { 32, "Julia.Knox@company.net", "Julia", "Knox" },
                    { 33, "Cole.Blake@company.net", "Cole", "Blake" },
                    { 34, "Santiago.Dominguez@company.net", "Santiago", "Dominguez" },
                    { 35, "Dante.Shelton@company.net", "Dante", "Shelton" },
                    { 36, "Safaa.Gregory@company.net", "Safaa", "Gregory" },
                    { 37, "Lydia.Preston@company.net", "Lydia", "Preston" },
                    { 38, "Kyla.Pittman@company.net", "Kyla", "Pittman" },
                    { 39, "Amaya.Gillespie@company.net", "Amaya", "Gillespie" },
                    { 40, "Alannah.Aguirre@company.net", "Alannah", "Aguirre" },
                    { 41, "Morgan.Grimes@company.net", "Morgan", "Grimes" },
                    { 42, "Trystan.Velasquez@company.net", "Trystan", "Velasquez" },
                    { 43, "Jon.Gilbert@company.net", "Jon", "Gilbert" },
                    { 44, "Penny.Mccall@company.net", "Penny", "Mccall" },
                    { 45, "Macauley.Potter@company.net", "Macauley", "Potter" },
                    { 46, "Nathan.Bryant@company.net", "Nathan", "Bryant" },
                    { 47, "Alexia.Cain@company.net", "Alexia", "Cain" },
                    { 48, "Lillian.Miller@company.net", "Lillian", "Miller" },
                    { 49, "Sanaa.Barlow@company.net", "Sanaa", "Barlow" },
                    { 50, "Anna.Nichols@company.net", "Anna", "Nichols" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Area",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BusinessUnit",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipient",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
