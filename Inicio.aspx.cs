using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Linq;
using System.Web;
using System.Web.UI;


namespace Ejercicio7
{
 
    public partial class Inicio : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEmpleado.Focus();
            error.Visible = false;
            
        }

        protected void verificarEmpleado(object sender, EventArgs e)
        {
            String[] empleados = new string[] { "F11", "F12", "F13", "F14", "F15", "F16", "F17", "F18", "F19", "F20" };
            String elemento = txtEmpleado.Text.ToUpper();
            ;
            if (!Validar(empleados, elemento))
            {
                error.Visible = true;
                error.InnerText = "El empleado no existe, intente de nuevo";
                txtEmpleado.Text = "";
                txtEmpleado.Focus();
            }
            else
            {
                txtImporte.Focus();
            }

        }

        private Boolean Validar(string[] empleados, string elemento)
        {
            int i;
            for (i = 0; i < empleados.Length && !empleados[i].Equals(elemento,StringComparison.OrdinalIgnoreCase); i++) ;
            if (i == empleados.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void calcularImporte(object sender, EventArgs e)
        {
            ViewState["iva"] = ((Convert.ToInt32(txtImporte.Text) * 21) / 100);
            txtIVA.Text =ViewState["iva"].ToString() +"€";
            ViewState["total"] = Convert.ToInt32(ViewState["iva"]) + Convert.ToInt32(txtImporte.Text);
            txtTotal.Text = (Convert.ToInt32(ViewState["total"])).ToString("c");
            txtRecibido.Focus();

        }

        protected void cambios(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtRecibido.Text)< Convert.ToInt32(ViewState["total"]))
            {
                error.Visible = true;
                error.InnerText = "El monto recibido no es suficiente para pagar el total de la deuda";
                txtRecibido.Text = "";
                txtRecibido.Focus();
            }
            else
            {
                ViewState["camb"] = Convert.ToInt32(txtRecibido.Text) - Convert.ToInt32(ViewState["total"]);
                txtCambios.Text = (Convert.ToInt32(ViewState["camb"])).ToString("c");


                mostrarBilletes(Convert.ToInt32(ViewState["camb"]));


                btnLimpiar.Focus();
            }
            

        }
        protected void mostrarBilletes(int camb)
        {
            
            int[] monedas= new int[]{500,200,100,50,20,10,5,2,1};
            String[] imagenes = new String[] {"../Imagenes/500.jpg", "../Imagenes/200.jpg", "../Imagenes/100.jpg", "../Imagenes/50.jpg", "../Imagenes/20.jpg", "../Imagenes/10.jpg", "../Imagenes/5.jpg", "../Imagenes/2.jpg", "../Imagenes/1.jpg" };
            int[] cambio = new int[monedas.Length];
            int resto = Convert.ToInt32(ViewState["camb"]);

            for (int i = 0; i < monedas.Length; i++)
            {
               cambio[i]= resto / monedas[i];
                if (cambio[i]>0)
                {
                    int m=cambio[i] * monedas[i];
                    resto -= m;

                }
            }

            for (int i = 0; i < cambio.Length; i++)
            {
                int c = cambio[i];
                while (c > 0)
                {
                    Image img = new Image();
                    if (monedas[i]<5)
                    {
                        img.Width = 50;
                        img.Height = 50;
                    }
                    else
                    {
                        img.Width = 100;
                        img.Height = 50;
                    }
                    
                    img.ImageUrl = imagenes[i];
                    img.CssClass="m-2";
                    panelC.Controls.Add(img);
                    c--;
                }
            }

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            error.Visible = false;
            txtEmpleado.Text = "";
            txtImporte.Text = "";
            txtIVA.Text = "";
            txtTotal.Text = "";
            txtRecibido.Text = "";
            txtCambios.Text= "";
            txtEmpleado.Focus();
        }
    }
    

    
}