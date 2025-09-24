using Datos;
using Modelos;
using System.Data;
using System.Numerics;

namespace Controladores
{
    public class ClienteController
    {
        private readonly ClienteRepository _repo;

        public ClienteController()
        {
            _repo = new ClienteRepository();
        }
        public DataTable GetAll()
        {
            DataTable dtClientes = new DataTable();
            dtClientes.Columns.Add("ClienteID", typeof(int));
            dtClientes.Columns.Add("Nombre", typeof(string));
            dtClientes.Columns.Add("Telefono", typeof(string));
            dtClientes.Columns.Add("Email", typeof(string));

            List<ClienteModel> clientes = _repo.GetAll();
            foreach (ClienteModel c in clientes)
            {
                dtClientes.Rows.Add(c.ClienteID, c.Nombre, c.Telefono, c.Email);
            }
            return dtClientes;
        }
        public ClienteModel GetOne(int id)
        {
            return _repo.GetOne(id);
        }
        public DataTable GetClientesPorNombre(string nombre)
        {
            DataTable dtClientes = new DataTable();
            if (nombre != null)
            {
                dtClientes.Columns.Add("ClienteID", typeof(int));
                dtClientes.Columns.Add("Nombre", typeof(string));
                dtClientes.Columns.Add("Telefono", typeof(string));
                dtClientes.Columns.Add("Email", typeof(string));

                List<ClienteModel> clientes = _repo.GetClientesPorNombre(nombre);
                foreach (ClienteModel c in clientes)
                {
                    dtClientes.Rows.Add(c.ClienteID, c.Nombre, c.Telefono, c.Email);
                }
                return dtClientes;
            }
            else return this.GetAll();
        }
        public void Registrar(string nombre, string tel, string email)
        {
            ClienteModel cliente = new ClienteModel();
            cliente.Nombre = nombre;
            cliente.Telefono = tel;
            cliente.Email = email;

            _repo.Insert(cliente);
        }
        public void Modificar(int id, string nombre, string tel, string email)
        {
            _repo.Update(id, nombre, tel, email);
        }
        public void Eliminar(int id)
        {
            _repo.Delete(id);
        }

    }
}
