using SportGym.Data;
using SportGym.DataTransferObject;
using SportGym.Properties;
using SportGym.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGym.GUI
{
    public class Support
    {
        private static Support instance = new Support();
        private DBHelper helper = DBHelper.getDBHelper();
        private string path = "C:\\Fotos Sport Gym\\";


        public static Support GetSupport()
        {
            if (instance == null)
                instance = new Support();
            return instance;
        }

        private string crearDirectorio()
        {
            if (!Directory.Exists(path))//valida que la carpeta no exista
            {
                Directory.CreateDirectory(path);//en caso de no existir se crea 
                return path;
            }
            else
            {
                return path;
            }
        }

        public void cargarFoto(string nombre, PictureBox pic)
        {
            if (Directory.Exists(path) && File.Exists(path + nombre + ".jpg"))//valida que la carpeta no exista
            {
                try
                {
                    pic.Image = Image.FromFile(path + nombre + ".jpg");
                }
                catch (Exception ex)
                {
                    pic.Image = Resources.camera;

                }
            }
        }




        public bool guardarFoto(Image foto, string nombre)
        {
            string path = crearDirectorio();
            if(foto != null)
            {
                try
                {
                    foto.Save(path + nombre + ".jpg", ImageFormat.Jpeg);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        
        public void cargarComboHorarios(ComboBox combo_inicio, ComboBox combo_fin)
        {
            //combo de inicio
            combo_inicio.Items.Add("07:00");
            combo_inicio.Items.Add("08:00");
            combo_inicio.Items.Add("09:00");
            combo_inicio.Items.Add("10:00");
            combo_inicio.Items.Add("11:00");
            combo_inicio.Items.Add("16:00");
            combo_inicio.Items.Add("17:00");
            combo_inicio.Items.Add("18:00");
            combo_inicio.Items.Add("19:00");
            combo_inicio.Items.Add("20:00");
            combo_inicio.Items.Add("21:00");
            //combo de fin
            combo_fin.Items.Add("08:00");
            combo_fin.Items.Add("09:00");
            combo_fin.Items.Add("10:00");
            combo_fin.Items.Add("11:00");
            combo_fin.Items.Add("12:00");
            combo_fin.Items.Add("17:00");
            combo_fin.Items.Add("18:00");
            combo_fin.Items.Add("19:00");
            combo_fin.Items.Add("20:00");
            combo_fin.Items.Add("21:00");
            combo_fin.Items.Add("22:00");
        }


        public bool existeElRespaldo()
        {
            string ruta = "C:\\Respaldo Sport Gym\\" + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year.ToString();
            string excel = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            string rutaFinal = ruta + "\\" + excel;

            return File.Exists(rutaFinal + ".xls");
        }


        public bool respaldoAutomatico()
        {
            string pathRespaldo = "C:\\Respaldo Sport Gym\\Respaldo Base de datos\\";
            string pathArchivo = "C:\\Respaldo Sport Gym\\Respaldo Base de datos\\Respaldo Diario.bak";
            string sp = "SP_Respaldo_Automatico";
   

            if (!Directory.Exists(pathRespaldo))//valida que la carpeta no exista
            {              
                Directory.CreateDirectory(pathRespaldo);//en caso de no existir se crea
                return helper.ejecutarStoredProcedureSinT(sp) == 1;
            }
            else
            {
                if (!File.Exists(pathArchivo))//valida que el archivo no haya sido creado ya
                {
                    return helper.ejecutarStoredProcedureSinT(sp) == 1;
                }
                else
                {
                    try
                    {
                        File.Delete(pathArchivo);
                        return helper.ejecutarStoredProcedureSinT(sp) == 1;
                    }
                    catch(Exception e)
                    {
                        return false;
                    }
                }
            }
        }

        public bool respaldarInfo()
        {
            Service_Inscripcion service = new Service_Inscripcion();
            DateTimeFormatInfo fecha = new System.Globalization.DateTimeFormatInfo();

            // variable para crear o buscar la carpeta donde se va a guardar el respaldo en excel.
            //Dentro de la carpeta Respaldo Sport Gym, se van a crear subCarpetas con el formato: "nombre del mes" "año"
            string ruta = "C:\\Respaldo Sport Gym\\" + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year.ToString();

            //variable para darle nombre al excel con el formato: "dia"-"mes"-"año"
            string excel = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();

            //variable que junta la ruta de la carpeta + la ruta que deberia tener el archivo a crear.
            string rutaFinal = ruta + "\\" + excel;

            IList<DTO_Inscripcion> inscripciones = service.getInscripcionesPorHora("07:00", "22:00");

            if (inscripciones != null && inscripciones.Count > 0)  //Valida que la lista tenga valores para guardar
            {
                if (!Directory.Exists(ruta))//valida que la carpeta no exista
                {
                    Directory.CreateDirectory(ruta);//en caso de no existir se crea            
                    return crearExcel(inscripciones, rutaFinal);

                }
                else
                {
                    if (!File.Exists(rutaFinal + ".xls"))//valida que el archivo no haya sido creado ya
                    {
                        return crearExcel(inscripciones, rutaFinal);
                    }
                    else
                    {
                        try
                        {
                            File.Delete(rutaFinal + ".xls");
                            return crearExcel(inscripciones, rutaFinal);
                        }
                        catch(Exception e)
                        {
                            return false;
                        }
                        
                    }
                }
            }
            else
                return false;
        }

        public void obtenerDatosRespaldo()
        {
            Service_Inscripcion inscripciones = new Service_Inscripcion();
            Service_cuota cuotas = new Service_cuota();
            Service_socio socios = new Service_socio();
        }
        public void crearRespaldoTexto(String ruta)
        {
            if (!File.Exists(ruta))//valida que el archivo no haya sido creado ya
            {
                respaldoEnTexto(null, ruta);
            }
            else
            {
                try
                {
                    File.Delete(ruta);
                    respaldoEnTexto(null, ruta); ;
                }
                catch (Exception e)
                {
                }

            }

        }
        public void respaldoEnTexto(IList<String> lista, String ruta)
        {
        }
        

        public bool guardarEnExcel(IList<DTO_Inscripcion> inscripciones, string rutaFinal)
        {
            try
            {
                crearExcel(inscripciones,rutaFinal);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private bool crearExcel(IList<DTO_Inscripcion> inscripciones, string rutaFinal)
        {
            //try para capturar algun error que pueda suceder al momento de crear y dar formato al Excel
            try
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                hoja_trabajo.Cells[1, "A"] = "Nombre";
                hoja_trabajo.Cells[1, "B"] = "Apellido";
                hoja_trabajo.Cells[1, "C"] = "Vencimiento";
                hoja_trabajo.Cells[1, "D"] = "Estado";
                hoja_trabajo.Cells[1, "E"] = "Fecha Pago";
                hoja_trabajo.Cells[1, "F"] = "Hora Ingreso";
                hoja_trabajo.Cells[1, "G"] = "Hora Egreso";
                hoja_trabajo.Cells[1, "H"] = "Celular";

                int row = 2;
                string seperador="";
                foreach (var item in inscripciones)
                {
                    //cargo los datos en la hoja excel, comenzando desde la fila 2
                    if(row != 2 && !(item.HoraInicio + item.HoraFin).Equals(seperador))//esto es para separar los socios por grupo horario.
                    {
                        hoja_trabajo.Range["A"+row, "H"+row].Interior.ColorIndex = 17;
                        row++;
                        hoja_trabajo.Cells[row, "A"] = item.NombreSocio;
                        hoja_trabajo.Cells[row, "B"] = item.ApellidoSocio;
                        hoja_trabajo.Cells[row, "C"] = item.UltimoVencimiento;
                        hoja_trabajo.Cells[row, "D"] = item.EstadoCuota;
                        hoja_trabajo.Cells[row, "E"] = item.UltimoPago;
                        hoja_trabajo.Cells[row, "F"] = item.HoraInicio;
                        hoja_trabajo.Cells[row, "G"] = item.HoraFin;
                        hoja_trabajo.Cells[row, "H"] = item.Celular;
                        seperador = item.HoraInicio + item.HoraFin;
                        row++;
                    }
                    else
                    {
                        hoja_trabajo.Cells[row, "A"] = item.NombreSocio;
                        hoja_trabajo.Cells[row, "B"] = item.ApellidoSocio;
                        hoja_trabajo.Cells[row, "C"] = item.UltimoVencimiento;
                        hoja_trabajo.Cells[row, "D"] = item.EstadoCuota;
                        hoja_trabajo.Cells[row, "E"] = item.UltimoPago;
                        hoja_trabajo.Cells[row, "F"] = item.HoraInicio;
                        hoja_trabajo.Cells[row, "G"] = item.HoraFin;
                        hoja_trabajo.Cells[row, "H"] = item.Celular;
                        seperador = item.HoraInicio + item.HoraFin;
                        row++;
                    }
                }
            
                //formato para la las columnas y filas de datos
                hoja_trabajo.Range["A1", "H" + (inscripciones.Count) + 1.ToString()].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                hoja_trabajo.Range["A1", "H1"].Font.Bold = true;
                hoja_trabajo.Range["A1", "H1"].Font.Size = 16;
                hoja_trabajo.Range["A1", "H1"].Interior.ColorIndex = 17;
                hoja_trabajo.Range["A2", "H2" + (inscripciones.Count + 1).ToString()].Font.Size = 12;
                hoja_trabajo.Columns.AutoFit();
                //

                //linea que guarda el archivo
                libros_trabajo.SaveAs(rutaFinal, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                //Para guardar con formato xlsx cambia la linea anterior por la siguiente. 
               // libros_trabajo.SaveAs(rutaFinal, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                return true;                
            }
            catch (Exception ex)
            {
                return false;
            }
        }

           
        public bool esUnNumero(string cadena)
        {
            if (String.IsNullOrWhiteSpace(cadena))
            {
                return true;
            }
            else
            {
                try
                {
                    Convert.ToDouble(cadena);
                    return true;
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Error, no ha ingresado un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool esUnNumeroSinAdvertencia(string cadena)
        {
            if(String.IsNullOrWhiteSpace(cadena))
            {
                return true;
            }
            else
            {
                try
                {
                    Convert.ToDouble(cadena);
                    return true;
                }
                catch (FormatException fe)
                {
                    return false;
                }
            }                        
        }
        public void soloLetrasNumeros(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloLetrasNumerosConEspacio(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloLetras(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloNumeros(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }
        public void noEspaciosBlancos(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }


        public void noSimbolos(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        public void soloLetrasNumerosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                        MessageBox.Show("Solo letras o numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        public void soloLetrasConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                        MessageBox.Show("Solo letras o numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void soloNumerosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = true;
                                    MessageBox.Show("Solo numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = true;
                                    }
                                    else
                                    {
                                        e.Handled = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void soloLetrasSiEspacioConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                        MessageBox.Show("Solo letras", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void soloLetrasSiEspacio(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                        MessageBox.Show("Solo letras", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void noEspaciosBlancosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = true;
                            MessageBox.Show("No se permiten espacios en blanco", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
        public void noSimbolosConAdvertencia(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsSymbol(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("No se permiten caracteres especiales", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (char.IsSeparator(e.KeyChar))
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            if (char.IsWhiteSpace(e.KeyChar))
                            {
                                e.Handled = false;
                            }
                            else
                            {
                                if (char.IsLetter(e.KeyChar))
                                {
                                    e.Handled = false;
                                }
                                else
                                {
                                    if (char.IsLetter(e.KeyChar))
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        e.Handled = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }     
    }
}

