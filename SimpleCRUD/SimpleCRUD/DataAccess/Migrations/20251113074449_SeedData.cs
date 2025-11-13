using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleCRUD.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "DateOfBirth", "Department", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 49, new DateTime(1974, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "MHSN27 MHSN", "+1 1774867925" },
                    { 2, 44, new DateTime(1979, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Management", "Sohel Shaikh", "+1 1280221170" },
                    { 3, 43, new DateTime(1980, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public Relations (PR)", "Mark Johnnah", "+1 6391420937" },
                    { 4, 55, new DateTime(1968, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Assurance (QA)", "JB _", "+1 1634119861" },
                    { 5, 70, new DateTime(1953, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logistics", "hugo sanchez", "+1 7644917715" },
                    { 6, 70, new DateTime(1953, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", "Zabi Rahmani", "+1 5082755411" },
                    { 7, 60, new DateTime(1963, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training and Development", "edimar lopes", "+1 5745426751" },
                    { 8, 43, new DateTime(1980, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Research and Development (R&D)", "Arie melans", "+1 5367480161" },
                    { 9, 53, new DateTime(1970, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Management", "Ziya Çetinkaya", "+1 2379992102" },
                    { 10, 18, new DateTime(2005, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public Relations (PR)", "Thiago Paiva Medeiros", "+1 2495860935" },
                    { 11, 56, new DateTime(1967, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facilities Management", "Thanh Nguyen", "+1 3911316611" },
                    { 12, 39, new DateTime(1984, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Rahul Salokhe", "+1 5182461859" },
                    { 13, 23, new DateTime(2000, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Jing Tarng Loke", "+1 2635917946" },
                    { 14, 36, new DateTime(1987, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources (HR)", "met it", "+1 5049298944" },
                    { 15, 50, new DateTime(1973, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Research and Development (R&D)", "Md.Ariful Islam", "+1 9252292089" },
                    { 16, 47, new DateTime(1976, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legal", "Mo Canada", "+1 1824118974" },
                    { 17, 26, new DateTime(1997, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", "Altanzurkh T", "+1 6395646874" },
                    { 18, 72, new DateTime(1951, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public Relations (PR)", "Mustafa YILDIZ", "+1 1375269492" },
                    { 19, 64, new DateTime(1959, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Assurance (QA)", "Arief Fauzi", "+1 3458476129" },
                    { 20, 72, new DateTime(1951, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "salvador castillo", "+1 4486306495" },
                    { 21, 62, new DateTime(1961, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Training and Development", "Luis TC", "+1 1280221170" },
                    { 22, 32, new DateTime(1991, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Adeel Baig", "+1 6391420937" },
                    { 23, 52, new DateTime(1971, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology (IT)", "Novrita Inkac", "+1 1634119861" },
                    { 24, 57, new DateTime(1966, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Analytics", "Felipe Rodríguez", "+1 7644917715" },
                    { 25, 30, new DateTime(1993, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legal", "Fabian Cebreros", "+1 5082755411" },
                    { 26, 53, new DateTime(1970, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Support", "Alan Michas", "+1 5745426751" },
                    { 27, 66, new DateTime(1957, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", "Lucky D.Bog", "+1 5367480161" },
                    { 28, 55, new DateTime(1968, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Research and Development (R&D)", "Anunu", "+1 2379992102" },
                    { 29, 26, new DateTime(1997, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Management", "KRAK 08", "+1 2495860935" },
                    { 30, 47, new DateTime(1976, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Support", "Boonsit Chanpoempoonpol", "+1 3911316611" },
                    { 31, 44, new DateTime(1979, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business Development", "Danilo Romao", "+1 5182461859" },
                    { 32, 24, new DateTime(1999, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logistics", "User 4571", "+1 2635917946" },
                    { 33, 47, new DateTime(1976, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology (IT)", "Yuri Svyrydov", "+1 5049298944" },
                    { 34, 37, new DateTime(1986, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "Omar Abdelrahim", "+1 9252292089" },
                    { 35, 30, new DateTime(1993, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Assurance (QA)", "ADIAN Jan", "+1 1824118974" },
                    { 36, 20, new DateTime(2003, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Thiago Valim", "+1 6395646874" },
                    { 37, 43, new DateTime(1980, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facilities Management", "ศุภชัย สมพานิช", "+1 1375269492" },
                    { 38, 48, new DateTime(1975, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Support", "ArTWorK211", "+1 3458476129" },
                    { 39, 69, new DateTime(1954, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology (IT)", "Johny Angsana", "+1 4486306495" },
                    { 40, 66, new DateTime(1957, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", "kommineni narendra", "+1 1774867925" },
                    { 41, 52, new DateTime(1971, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "Felipe Ramos", "+1 1280221170" },
                    { 42, 25, new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Operations", "Maroine Chérif", "+1 6391420937" },
                    { 43, 37, new DateTime(1986, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Sana Ullah", "+1 1634119861" },
                    { 44, 50, new DateTime(1973, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Public Relations (PR)", "michel akebo", "+1 7644917715" },
                    { 45, 42, new DateTime(1981, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logistics", "عمر العمودي Omar Al-Amoudi", "+1 5082755411" },
                    { 46, 20, new DateTime(2003, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business Development", "Louay Abdel Maeen", "+1 5745426751" },
                    { 47, 56, new DateTime(1967, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Black-Gold Sarnaut", "+1 5367480161" },
                    { 48, 55, new DateTime(1968, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "gueye abdoulaye", "+1 2379992102" },
                    { 49, 34, new DateTime(1989, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Engineering", "Cristian Ferreira", "+1 2495860935" },
                    { 50, 51, new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "Amir Osama", "+1 3911316611" },
                    { 51, 58, new DateTime(1965, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources (HR)", "Mihai Moisei", "+1 5182461859" },
                    { 52, 18, new DateTime(2005, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "AKHOM ALY", "+1 2635917946" },
                    { 53, 52, new DateTime(1971, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Support", "Banpote Jaruboon", "+1 5049298944" },
                    { 54, 61, new DateTime(1962, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Abdul Razak Abdulai", "+1 9252292089" },
                    { 55, 22, new DateTime(2001, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Management", "ELy moussa", "+1 1824118974" },
                    { 56, 40, new DateTime(1983, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facilities Management", "peter tharwat", "+1 6395646874" },
                    { 57, 38, new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance", "william programer (CLASH OF CLAN)", "+1 1375269492" },
                    { 58, 54, new DateTime(1969, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "Luis Correa", "+1 3458476129" },
                    { 59, 58, new DateTime(1965, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Management", "Michael Chizoba", "+1 4486306495" },
                    { 60, 18, new DateTime(2005, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Assurance (QA)", "Abdul-Rouf Ammar", "+1 1280221170" },
                    { 61, 23, new DateTime(2000, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "Norbert Saint Georges", "+1 6391420937" },
                    { 62, 19, new DateTime(2004, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Research and Development (R&D)", "trieuvnh", "+1 1634119861" },
                    { 63, 60, new DateTime(1963, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Procurement", "Amr Moh", "+1 7644917715" },
                    { 64, 20, new DateTime(2003, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology (IT)", "Ton", "+1 5082755411" },
                    { 65, 66, new DateTime(1957, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quality Assurance (QA)", "Prathamesh Karande", "+1 5745426751" },
                    { 66, 73, new DateTime(1950, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources (HR)", "MarianoT3", "+1 5367480161" },
                    { 67, 34, new DateTime(1989, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Human Resources (HR)", "Rekzon Aborde", "+1 2379992102" },
                    { 68, 43, new DateTime(1980, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology (IT)", "prottoy roy", "+1 2495860935" },
                    { 69, 22, new DateTime(2001, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Product Management", "sahli SAHBI", "+1 3911316611" },
                    { 70, 46, new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administration", "Onur Hos", "+1 5182461859" },
                    { 71, 45, new DateTime(1978, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Analytics", "Armando Villagomez", "+1 2635917946" },
                    { 72, 35, new DateTime(1988, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facilities Management", "Jesus Alberto Roque Ortiz", "+1 5049298944" },
                    { 73, 59, new DateTime(1964, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facilities Management", "Md Shahin Aktar", "+1 9252292089" },
                    { 74, 65, new DateTime(1958, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Customer Support", "Антон Метелёв", "+1 1824118974" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 74);
        }
    }
}
