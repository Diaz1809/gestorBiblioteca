using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_BIBLIOTECA
{

    public partial class menuPrincipal : Form


    {
        public menuPrincipal()
        {
            InitializeComponent();
            this.Load += new EventHandler(menuPrincipal_Load); // Asocia el evento Load
                                                               // Obtener encargados únicos desde la grilla
            var encargados = new HashSet<string>();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    encargados.Add(fila.Cells[4].Value.ToString());
                }
            }

            // Cargar en comboBox2
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(encargados.ToArray());

            List<string> listaEncargados = new List<string>
{
    "Ana Torres",
    "Luis Gómez",
    "Carlos Ruiz",
    "Patricia Mendoza"
};

            // Cargar en comboBox2
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(listaEncargados.ToArray());



            // LISTA DE ENCARGADOS--------------------

            List<string> listatypesbooks = new List<string>
    {
    "Literatura",
    "Fantasía",
    "Misterio y Suspenso",
    "Aventuras",
    "Biografías",
    "Historia"
};

            // Cargar en comboBox2
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(listaEncargados.ToArray());

            //---------------------------------------------------------------
            //--------------lista de tipos de libros--------------------------
            List<string> tiposDeLibro = new List<string>
{
    "Científico",
    "Literatura",
    "Infantil",
    "Historia",
    "Tecnología"
};

            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(tiposDeLibro.ToArray());

            //-----------------------------------------------------------------
            //----------Lista de clientes-------------------------------------
            List<string> listaClientes = new List<string>
{
    "Juan Pérez",
    "María López",
    "Carlos Ramírez",
    "Lucía Fernández"
};

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(listaClientes.ToArray());

            //--------------------------Lista de estados----------------------------------------
            List<string> listaEstados = new List<string>
{
    "Entregado",
    "Pendiente"
};

            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(listaEstados.ToArray());

            //----------------------------------------------------------------------------------
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 10;
            dataGridView1.Columns[0].Name = "Cliente";
            dataGridView1.Columns[1].Name = "Tipo";
            dataGridView1.Columns[2].Name = "Dni";
            dataGridView1.Columns[3].Name = "Distrito";
            dataGridView1.Columns[4].Name = "Encargado";
            dataGridView1.Columns[5].Name = "Tipo de libro";
            dataGridView1.Columns[6].Name = "Nombre de libro";
            dataGridView1.Columns[7].Name = "Fecha inicio";
            dataGridView1.Columns[8].Name = "Fecha fin";
            dataGridView1.Columns[9].Name = "Estado";


            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BibliotecaSolicitudes");
            string rutaArchivo = Path.Combine(carpeta, "solicitudes.txt");

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    string[] campos = linea.Split('|');
                    if (campos.Length == 10)
                    {
                        dataGridView1.Rows.Add(campos);
                    }
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ReportesHistorico vistaReportes = new ReportesHistorico();
            vistaReportes.Show(); // Abre el formulario de reportes
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void buscar_Click(object sender, EventArgs e)
        {
            string encargadoSeleccionado = comboBox2.SelectedItem?.ToString();
            string tipoLibroSeleccionado = comboBox3.SelectedItem?.ToString();
            string clienteSeleccionado = comboBox1.SelectedItem?.ToString();
            string estadoSeleccionado = comboBox4.SelectedItem?.ToString();

            if (dataGridView1.IsCurrentCellInEditMode)
            {
                dataGridView1.EndEdit();
            }

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;

                bool mostrar = true;

                if (!string.IsNullOrEmpty(encargadoSeleccionado) &&
                    !fila.Cells[4].Value?.ToString().Equals(encargadoSeleccionado, StringComparison.OrdinalIgnoreCase) == true)
                {
                    mostrar = false;
                }

                if (!string.IsNullOrEmpty(tipoLibroSeleccionado) &&
                    !fila.Cells[5].Value?.ToString().Equals(tipoLibroSeleccionado, StringComparison.OrdinalIgnoreCase) == true)
                {
                    mostrar = false;
                }

                if (!string.IsNullOrEmpty(clienteSeleccionado) &&
                    !fila.Cells[0].Value?.ToString().Equals(clienteSeleccionado, StringComparison.OrdinalIgnoreCase) == true)
                {
                    mostrar = false;
                }

                if (!string.IsNullOrEmpty(estadoSeleccionado) &&
                    !fila.Cells[9].Value?.ToString().Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase) == true)
                {
                    mostrar = false;
                }

                fila.Visible = mostrar;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar selección de todos los ComboBox
            comboBox1.SelectedIndex = -1; // Clientes
            comboBox2.SelectedIndex = -1; // Encargados
            comboBox3.SelectedIndex = -1; // Tipos de libro
            comboBox4.SelectedIndex = -1; // Estados

            // Limpiar cualquier texto escrito en los ComboBox (si son editables)
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;

            // Mostrar nuevamente todas las filas de la grilla
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (!fila.IsNewRow)
                {
                    fila.Visible = true;
                }
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            RegistroSolicitud formularioRegistro = new RegistroSolicitud();

            if (formularioRegistro.ShowDialog() == DialogResult.OK)
            {
                Solicitud nueva = formularioRegistro.NuevaSolicitud;

                if (nueva != null)
                {
                    string[] fila = {
                nueva.Cliente,
                nueva.Tipo,
                nueva.Dni,
                nueva.Distrito,
                nueva.Encargado,
                nueva.TipoLibro,
                nueva.NombreLibro,
                nueva.FechaInicio,
                nueva.FechaFin,
                nueva.Estado
            };

                    dataGridView1.Rows.Add(fila);

                    // Carpeta principal
                    string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BibliotecaSolicitudes");
                    Directory.CreateDirectory(carpeta);

                    // Guardar en archivo de registros
                    string rutaArchivo = Path.Combine(carpeta, "solicitudes.txt");
                    string linea = string.Join("|", fila);
                    File.AppendAllText(rutaArchivo, linea + Environment.NewLine);

                    // Carpeta de boletas
                    string carpetaBoletas = Path.Combine(carpeta, "Boletas");
                    Directory.CreateDirectory(carpetaBoletas);

                    // Crear contenido de boleta
                    string contenidoBoleta = $@"
📚 BOLETA DE REGISTRO DE SOLICITUD

Cliente: {nueva.Cliente}
Tipo: {nueva.Tipo}
DNI: {nueva.Dni}
Distrito: {nueva.Distrito}
Encargado: {nueva.Encargado}
Tipo de libro: {nueva.TipoLibro}
Nombre del libro: {nueva.NombreLibro}
Fecha inicio: {nueva.FechaInicio}
Fecha fin: {nueva.FechaFin}
Estado: {nueva.Estado}

Gracias por usar el sistema de biblioteca.
";

                    // Guardar boleta
                    string nombreBoleta = $"boleta_{nueva.Dni}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                    string rutaBoleta = Path.Combine(carpetaBoletas, nombreBoleta);
                    File.WriteAllText(rutaBoleta, contenidoBoleta);

                    // Abrir boleta automáticamente
                    System.Diagnostics.Process.Start("notepad.exe", rutaBoleta);
                }
            }
        }

        private void menuPrincipal_Load_1(object sender, EventArgs e)
        {

        }
    }

}
