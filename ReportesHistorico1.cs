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
    public partial class ReportesHistorico1 : UserControl
    {
        public ReportesHistorico1()
        {
            InitializeComponent();
            var datos = new List<string[]>
    {
         new [] {"1","Ezequiel","Matemáticas","12345678","San Juan de Lurigancho","Gustavo Quino","10/06/2022","20/06/2022"},
    new [] {"2","Jeison","Historia","12345678","San Juan de Lurigancho","Julio Bazán","20/11/2022","30/11/2022"},
    new [] {"3","Stefano","Física","12345678","San Juan de Lurigancho","Luis Pérez","10/06/2022","20/06/2022"},
    new [] {"4","Ian","Literatura","12345678","San Juan de Lurigancho","Marta Silva","20/11/2022","30/11/2022"},

    // ====== 6 REGISTROS DE ESTE MES (NOVIEMBRE 2025) ======
    new [] {"5","Carlos","Matemáticas","78451236","SJL","Luis Pérez","02/11/2025","12/11/2025"},
    new [] {"6","Alonso","Biología","70234511","SJL","Marta Silva","05/11/2025","15/11/2025"},
    new [] {"7","Valeria","Historia","76543210","SJL","Julio Bazán","07/11/2025","17/11/2025"},
    new [] {"8","Camila","Física","72345198","SJL","Luis Pérez","10/11/2025","20/11/2025"},
    new [] {"9","Sebastián","Literatura","78965412","SJL","Gustavo Quino","12/11/2025","22/11/2025"},
    new [] {"10","Romina","Matemáticas","73014269","SJL","Marta Silva","14/11/2025","24/11/2025"},

    // ====== 7 REGISTROS DEL MES PASADO (OCTUBRE 2025) ======
    new [] {"11","Gustavo","Biología","70321458","SJL","Luis Pérez","02/10/2025","12/10/2025"},
    new [] {"12","Daniel","Historia","74851230","SJL","Julio Bazán","04/10/2025","14/10/2025"},
    new [] {"13","Lucía","Física","79123456","SJL","Marta Silva","06/10/2025","16/10/2025"},
    new [] {"14","Paolo","Literatura","71234598","SJL","Gustavo Quino","08/10/2025","18/10/2025"},
    new [] {"15","Alejandra","Matemáticas","75412369","SJL","Luis Pérez","10/10/2025","20/10/2025"},
    new [] {"16","Manuel","Biología","74589612","SJL","Julio Bazán","12/10/2025","22/10/2025"},
    new [] {"17","Fiorella","Historia","78912345","SJL","Marta Silva","14/10/2025","24/10/2025"},

    // ====== REGISTROS ANTIGUOS (2023 Y 2022) ======
    new [] {"18","Rodrigo","Matemáticas","70239845","SJL","Luis Pérez","05/01/2023","15/01/2023"},
    new [] {"19","María","Historia","78123450","SJL","Julio Bazán","20/03/2023","30/03/2023"},
    new [] {"20","Andrés","Física","72145309","SJL","Marta Silva","10/05/2023","20/05/2023"},
    new [] {"21","Renzo","Literatura","73124580","SJL","Gustavo Quino","12/02/2022","22/02/2022"},
    new [] {"22","Carla","Biología","71239854","SJL","Luis Pérez","18/04/2022","28/04/2022"},
    new [] {"23","Antonella","Historia","75231489","SJL","Julio Bazán","05/08/2022","15/08/2022"},
    new [] {"24","Marcos","Física","70984521","SJL","Marta Silva","22/10/2022","01/11/2022"},
};

            foreach (var fila in datos)
                dataGridView1.Rows.Add(fila);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ReportesHistorico1_Load(object sender, EventArgs e)
        {
            
        }


    }
}
