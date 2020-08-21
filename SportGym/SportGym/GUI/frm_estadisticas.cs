using SportGym.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGym.GUI
{
    public partial class frm_estadisticas : Form
    {
        Service_estadisticas service;
        public frm_estadisticas()
        {
            InitializeComponent();
            service = new Service_estadisticas();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            cargarDatos();   
        }

        private void cargarDatos()
        {
            lbl_socios_activos.Text += " " + service.getSociosActivos();
            lbl_cuotas_vencidas.Text += " " + service.getSociosVencidos();
            lbl_ingresos_estimados.Text += " $" + service.getIngresosEstimados();
            lbl_ingresos_actuales.Text += " $" + service.getIngresosReales();
        }
    }
}
