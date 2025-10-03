# Gestor de Tienda de Reparación de PC

Aplicación de escritorio diseñada para gestionar clientes, empleados, tareas y trabajos de reparación de una tienda de servicios técnicos.  
Permite llevar un control ordenado de los dispositivos ingresados, los problemas reportados, las tareas realizadas y la gestión de usuarios con diferentes roles.  

---

## Características

### Gestión de usuarios y seguridad
- Inicio de sesión con credenciales seguras.
- Hash y verificación de contraseñas.
- Manejo de roles:
  - **Administrador**: acceso completo, gestión de empleados, clientes y reportes.
  - **Técnico**: acceso limitado, solo puede gestionar sus tareas y modificar sus propios datos.

### Gestión de clientes y empleados
- Alta, baja y modificación de clientes.
- Administración de empleados con control exclusivo por parte del administrador.

### Gestión de trabajos y tareas
- Creación y asignación de trabajos de reparación a clientes.
- Registro de tareas asociadas a cada trabajo, con sus costos.
- Cálculo automático del monto total de cada reparación.

### Informes y reportes
- Informe de demanda de trabajos.

### Impresión de tickets
- Generación de tickets en PDF/impresión con:
  - Datos del cliente.
  - Dispositivo.
  - Problema detallado.
  - Listado de tareas con sus montos.
  - Total del trabajo.

---

## Tecnologías utilizadas

- **Lenguaje de programación:** C#  
- **Plataforma:** .NET 8  
- **Interfaz gráfica (UI):** Windows Forms  
- **ORM:** Entity Framework Core (Code First)  
- **Base de datos:** SQL Server LocalDB  
- **Otros:** System.Drawing (para impresión de tickets)  