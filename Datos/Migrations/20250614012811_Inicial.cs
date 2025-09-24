using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoID);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    TareaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.TareaID);
                });

            migrationBuilder.CreateTable(
                name: "Trabajos",
                columns: table => new
                {
                    TrabajoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDispositivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionProblema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabajos", x => x.TrabajoID);
                    table.ForeignKey(
                        name: "FK_Trabajos_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpleadoModelTareaModel",
                columns: table => new
                {
                    EmpleadosEmpleadoID = table.Column<int>(type: "int", nullable: false),
                    TareasTareaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoModelTareaModel", x => new { x.EmpleadosEmpleadoID, x.TareasTareaID });
                    table.ForeignKey(
                        name: "FK_EmpleadoModelTareaModel_Empleados_EmpleadosEmpleadoID",
                        column: x => x.EmpleadosEmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpleadoModelTareaModel_Tareas_TareasTareaID",
                        column: x => x.TareasTareaID,
                        principalTable: "Tareas",
                        principalColumn: "TareaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreciosTarea",
                columns: table => new
                {
                    PrecioTareaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVigencia = table.Column<DateOnly>(type: "date", nullable: false),
                    Monto = table.Column<float>(type: "real", nullable: false),
                    TareaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreciosTarea", x => x.PrecioTareaID);
                    table.ForeignKey(
                        name: "FK_PreciosTarea_Tareas_TareaID",
                        column: x => x.TareaID,
                        principalTable: "Tareas",
                        principalColumn: "TareaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpleadoModelTrabajoModel",
                columns: table => new
                {
                    EmpleadosEmpleadoID = table.Column<int>(type: "int", nullable: false),
                    TrabajosTrabajoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoModelTrabajoModel", x => new { x.EmpleadosEmpleadoID, x.TrabajosTrabajoID });
                    table.ForeignKey(
                        name: "FK_EmpleadoModelTrabajoModel_Empleados_EmpleadosEmpleadoID",
                        column: x => x.EmpleadosEmpleadoID,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpleadoModelTrabajoModel_Trabajos_TrabajosTrabajoID",
                        column: x => x.TrabajosTrabajoID,
                        principalTable: "Trabajos",
                        principalColumn: "TrabajoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TareaModelTrabajoModel",
                columns: table => new
                {
                    TareasTareaID = table.Column<int>(type: "int", nullable: false),
                    TrabajosTrabajoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TareaModelTrabajoModel", x => new { x.TareasTareaID, x.TrabajosTrabajoID });
                    table.ForeignKey(
                        name: "FK_TareaModelTrabajoModel_Tareas_TareasTareaID",
                        column: x => x.TareasTareaID,
                        principalTable: "Tareas",
                        principalColumn: "TareaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TareaModelTrabajoModel_Trabajos_TrabajosTrabajoID",
                        column: x => x.TrabajosTrabajoID,
                        principalTable: "Trabajos",
                        principalColumn: "TrabajoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpleadoModelTareaModel_TareasTareaID",
                table: "EmpleadoModelTareaModel",
                column: "TareasTareaID");

            migrationBuilder.CreateIndex(
                name: "IX_EmpleadoModelTrabajoModel_TrabajosTrabajoID",
                table: "EmpleadoModelTrabajoModel",
                column: "TrabajosTrabajoID");

            migrationBuilder.CreateIndex(
                name: "IX_PreciosTarea_TareaID",
                table: "PreciosTarea",
                column: "TareaID");

            migrationBuilder.CreateIndex(
                name: "IX_TareaModelTrabajoModel_TrabajosTrabajoID",
                table: "TareaModelTrabajoModel",
                column: "TrabajosTrabajoID");

            migrationBuilder.CreateIndex(
                name: "IX_Trabajos_ClienteID",
                table: "Trabajos",
                column: "ClienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpleadoModelTareaModel");

            migrationBuilder.DropTable(
                name: "EmpleadoModelTrabajoModel");

            migrationBuilder.DropTable(
                name: "PreciosTarea");

            migrationBuilder.DropTable(
                name: "TareaModelTrabajoModel");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Trabajos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
