namespace Utils
{
    public static class DataGridViewHelper //static para no tener que crear constructores
    {
        public static void AgregarBotonEditarEliminar(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "Editar",
                    Name = "btnEditar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnEditar);
            }
            if (!dgv.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
                {
                    HeaderText = "Eliminar",
                    Name = "btnEliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnEliminar);
            }
        }
        public static void AgregarBotonEliminar(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
                {
                    HeaderText = "Eliminar",
                    Name = "btnEliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnEliminar);
            }
        }

        public static void AgregarBotonEditar(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("btnEditar"))
            {
                DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn
                {
                    HeaderText = "Editar",
                    Name = "btnEditar",
                    Text = "Editar",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnEditar);
            }
        }
        public static void AgregarBotonGenerarTicket(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("btnGenerarTicket"))
            {
                DataGridViewButtonColumn btnGenerarTicket = new DataGridViewButtonColumn
                {
                    HeaderText = "Ticket",
                    Name = "btnGenerarTicket",
                    Text = "Generar Ticket",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnGenerarTicket);
            }
        }
        public static void AgregarBotonVerTareas(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("Ver Tareas"))
            {
                DataGridViewButtonColumn btnVerTareas = new DataGridViewButtonColumn
                {
                    HeaderText = "Tareas",
                    Name = "btnVerTareas",
                    Text = "Ver Tareas",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnVerTareas);
            }
        }
        public static void AgregarBotonVerTrabajos(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("Ver Trabajos"))
            {
                DataGridViewButtonColumn btnVerTrabajos = new DataGridViewButtonColumn
                {
                    HeaderText = "Trabajos",
                    Name = "btnVerTrabajos",
                    Text = "Ver Trabajos",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnVerTrabajos);
            }
        }
        public static void AgregarBotonVerEmpleados(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("Ver Empleados"))
            {
                DataGridViewButtonColumn btnVerEmpleados = new DataGridViewButtonColumn
                {
                    HeaderText = "Empleados",
                    Name = "btnVerEmpleados",
                    Text = "Ver Empleados",
                    UseColumnTextForButtonValue = true
                };
                dgv.Columns.Add(btnVerEmpleados);
            }
        }

    }
}
