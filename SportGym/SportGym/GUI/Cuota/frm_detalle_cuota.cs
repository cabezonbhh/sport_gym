using SportGym.DataTransferObject;
using SportGym.Interface;
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
    public partial class frm_detalle_cuota : Form
    {
        private int cod;
        private Service_cuota service = null;
        private DTO_Cuota seleccionado = null;
        private Form principal = null;
        public frm_detalle_cuota(int cod,Form principal)
        {
            InitializeComponent();
            this.cod = cod;
            service = new Service_cuota();
            this.principal = principal;
        }

        private void frm_detalle_cuota_Load(object sender, EventArgs e)
        {
            seleccionado = service.getUltimaCuota(cod);
            if(seleccionado != null)
            {
                dtp_fecha_inicio.Value = Convert.ToDateTime(seleccionado.FechaInicio.ToString());
                dtp_fecha_vto.Value = Convert.ToDateTime(seleccionado.FechaFin.ToString());
                txt_monto.Text = seleccionado.Monto;
            }
            else
            {
                dtp_fecha_inicio.Value = DateTime.Now;
                dtp_fecha_vto.Value =  DateTime.Now;
                txt_monto.Text = "N/D";
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(dtp_fecha_inicio.Value != null && dtp_fecha_vto.Value != null && !String.IsNullOrWhiteSpace(txt_monto.Text) && Support.GetSupport().esUnNumero(txt_monto.Text) == true)
            {
                DTO_Cuota nuevo = new DTO_Cuota();
                nuevo.FechaInicio = dtp_fecha_inicio.Value.ToString();
                nuevo.FechaFin = dtp_fecha_vto.Value.ToString();
                nuevo.Monto = txt_monto.Text;
                nuevo.NroCuota = seleccionado.NroCuota;
                bool respuesta = service.actualizarCuota(nuevo);
                if(respuesta == true)
                {
                    IForm frm_p = principal as IForm;
                    frm_p.actualizarDatos();
                    MessageBox.Show("Cuota modificado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al modificar la cuota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Support.GetSupport().soloNumeros(sender,e);
        }

        private void dtp_fecha_inicio_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_fecha_inicio.Value != null)
            {
                dtp_fecha_vto.Value = dtp_fecha_inicio.Value.AddMonths(1);
            }
        }

        //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_estadisticas);

    }
}
