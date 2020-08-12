using SportGym.DataTransferObject;
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

namespace SportGym.GUI.Cuota
{
    public partial class frm_historial_pagos : Form
    {
        private int socio_seleccionado;
        Service_cuota service = null;
        public frm_historial_pagos(int nroSocio, string nombre)
        {
            InitializeComponent();
            service = new Service_cuota();
            socio_seleccionado = nroSocio;
            this.Text = nombre;
        }

        private void llenarGrilla()
        {
            IList<DTO_Cuota> lista = service.getCuotasPorSocio(socio_seleccionado);
            if (lista != null)
            {
                foreach (DTO_Cuota dto in lista)
                {
                    dgv_cuotas.Rows.Add(new Object[]
                            {
                                dto.NroCuota,
                                dto.FechaPago,
                                dto.Monto,
                                dto.FechaInicio,
                                dto.FechaFin
                            }
                        );
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_historial_pagos_Load(object sender, EventArgs e)
        {

            llenarGrilla();           
        }
    }
}
