using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shopping.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class seedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Category 2", "description 2", "https://img.freepik.com/vetores-gratis/laptop-com-icone-de-codigo-isometrico-de-programa-desenvolvimento-de-software-e-aplicacoes-de-programacao-neon-escuro_39422-971.jpg?w=900&t=st=1685310716~exp=1685311316~hmac=3cd629e566448fc8a3763222d3d91716ce22747d805a80c51c4c403bd1f1980e", "Name 2", 79.9m },
                    { 3L, "Category 3", "description 3", "https://img.freepik.com/vetores-gratis/ilustracao-do-conceito-de-digitacao-de-codigo_114360-3581.jpg?w=740&t=st=1685310825~exp=1685311425~hmac=973fd53fa3054f2deee21284d6197659915e0cb63215cbf7125daa2689ee1ac7", "Name 3", 79.9m },
                    { 4L, "Category 4", "description 4", "https://img.freepik.com/psd-premium/psd-de-maquete-de-sacola-de-compras-em-um-apartamento-moderno_53876-137778.jpg?w=996", "Name 4", 79.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
