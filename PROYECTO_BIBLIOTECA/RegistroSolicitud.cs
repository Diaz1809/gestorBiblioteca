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

    public partial class RegistroSolicitud : Form
    {
        public Solicitud NuevaSolicitud { get; private set; } // 👈 Aquí va
        public RegistroSolicitud()
        {
            InitializeComponent();

            // Clientes
            comboBoxCliente.Items.AddRange(new string[] {
        "Juan Pérez", "María López", "Carlos Ramírez", "Lucía Fernández"
    });

            // Tipos de documento
            comboBoxtipodocument.Items.AddRange(new string[] {
        "DNI", "Carnet de extranjería", "Pasaporte"
    });

            // Tipos de cliente
            comboBoxTipoClient.Items.AddRange(new string[] {
        "Estudiante", "Profesor", "Libre", "Universitario"
    });

            // Tipos de libro
            comboBoxTipoLibro.Items.AddRange(new string[] {
        "Historia", "Matemática", "Literatura", "Física"
    });

            // Inicializar nombre de libro vacío
            comboBoxNameLibro.Items.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaSolicitud = new Solicitud
            {
                Cliente = comboBoxCliente.Text,
                Tipo = comboBoxTipoClient.Text,
                Dni = textNroDocument.Text,
                Distrito = "San Juan de Lurigancho", // Puedes hacerlo dinámico si lo agregas como campo
                Encargado = "Julio Bazán", // También puedes hacerlo dinámico
                TipoLibro = comboBoxTipoLibro.Text,
                NombreLibro = comboBoxNameLibro.Text,
                FechaInicio = textFechaInicio.Text,
                FechaFin = textFechaFin.Text,
                Estado = "Pendiente" // O puedes permitir elegirlo
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
            string contenidoBoleta = $@"
📚 BOLETA DE REGISTRO DE SOLICITUD

Cliente: {NuevaSolicitud.Cliente}
Tipo: {NuevaSolicitud.Tipo}
DNI: {NuevaSolicitud.Dni}
Distrito: {NuevaSolicitud.Distrito}
Encargado: {NuevaSolicitud.Encargado}
Tipo de libro: {NuevaSolicitud.TipoLibro}
Nombre del libro: {NuevaSolicitud.NombreLibro}
Fecha inicio: {NuevaSolicitud.FechaInicio}
Fecha fin: {NuevaSolicitud.FechaFin}
Estado: {NuevaSolicitud.Estado}

Gracias por usar el sistema de biblioteca.
";

            // Guardar boleta como archivo
            string nombreArchivo = $"boleta_{NuevaSolicitud.Dni}_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            File.WriteAllText(nombreArchivo, contenidoBoleta);

        }


        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxtipodocument_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNroDocument_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNameLibro.Items.Clear();

            string tipo = comboBoxTipoLibro.SelectedItem?.ToString();

            if (tipo == "Historia")
            {
                comboBoxNameLibro.Items.AddRange(new string[] {
            "Chavín de Huántar", "Preincas", "La historia del faraón"
        });
            }
            else if (tipo == "Matemática")
            {
                comboBoxNameLibro.Items.AddRange(new string[] {
            "Ecuaciones", "Suma", "Resta", "Álgebra básica"
        });
            }
            else if (tipo == "Literatura")
            {
                comboBoxNameLibro.Items.AddRange(new string[] {
            "Don Quijote", "Cien años de soledad", "La casa de los espíritus"
        });
            }
            else if (tipo == "Física")
            {
                comboBoxNameLibro.Items.AddRange(new string[] {
            "Mecánica clásica", "Termodinámica", "Electromagnetismo"
        });
            }
        }


        private void comboBoxNameLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textFechaInicio_TextChanged(object sender, EventArgs e)
        {
            ValidarFechas();
        }

        private void textFechaFin_TextChanged(object sender, EventArgs e)
        {
            ValidarFechas();
        }

        private void ValidarFechas()
        {
            DateTime fechaInicio, fechaFin;

            bool inicioValido = DateTime.TryParseExact(textFechaInicio.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaInicio);
            bool finValido = DateTime.TryParseExact(textFechaFin.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaFin);

            if (!inicioValido || !finValido)
            {
                // Puedes mostrar un mensaje o cambiar el color del campo
                return;
            }

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha fin no puede ser menor que la fecha inicio.");
                textFechaFin.Text = "";
            }

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha inicio no puede ser mayor que la fecha fin.");
                textFechaInicio.Text = "";
            }
        }


    }

}
