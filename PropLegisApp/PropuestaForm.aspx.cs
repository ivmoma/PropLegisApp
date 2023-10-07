using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace PropLegisApp
{
    public partial class PropuestaForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbtnTipoID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void on_dllProvincia_Changed(object sender, EventArgs e)
        {
            if (ddlProvincia.SelectedItem.Text == "Seleccione")
            {
                ddlCanton.Items.Clear();
                ddlCanton.SelectedItem.Text = " ";
            }
            else if (ddlProvincia.SelectedItem.Text == "San José")
            {
                ddlCanton.Items.Clear();
                ddlCanton.Items.Add("San José");
                ddlCanton.Items.Add("Alajuelita");
                ddlCanton.Items.Add("Coronado");
                ddlCanton.Items.Add("Acosta");
                ddlCanton.Items.Add("Tibas");
                ddlCanton.Items.Add("Mts. Oca");
                ddlCanton.Items.Add("Turrubares");
                ddlCanton.Items.Add("Dota");
                ddlCanton.Items.Add("Curridabat");
                ddlCanton.Items.Add("Perez Zeledón");
                ddlCanton.Items.Add("Escazu");
                ddlCanton.Items.Add("L. Cortez");
                ddlCanton.Items.Add("Puriscal");
                ddlCanton.Items.Add("Tarrazú");
                ddlCanton.Items.Add("Asserí");
                ddlCanton.Items.Add("Mora");
                ddlCanton.Items.Add("Goicoechea");
                ddlCanton.Items.Add("Sta. Ana");
                ddlCanton.Items.Add("Desamparados");
                ddlCanton.Items.Add("Moravia");
            }
            else if (ddlProvincia.SelectedItem.Text == "Heredia")
            {
                ddlCanton.Items.Clear();
                ddlCanton.Items.Add("Heredia");
                ddlCanton.Items.Add("Barva");
                ddlCanton.Items.Add("Sto. Domingo");
                ddlCanton.Items.Add("Sta. Barbara");
                ddlCanton.Items.Add("San Rafael");
                ddlCanton.Items.Add("San Isidro");
                ddlCanton.Items.Add("Belén");
                ddlCanton.Items.Add("Flores");
                ddlCanton.Items.Add("San Pablo");
                ddlCanton.Items.Add("Sarapiquí");
            }
            else if (ddlProvincia.SelectedItem.Text == "Cartago")
            {
                ddlCanton.Items.Clear();
                ddlCanton.Items.Add("Cartago");
                ddlCanton.Items.Add("Paraíso");
                ddlCanton.Items.Add("La Unión");
                ddlCanton.Items.Add("Jiménez");
                ddlCanton.Items.Add("Turrialba");
                ddlCanton.Items.Add("Alvarado");
                ddlCanton.Items.Add("Oreamuno");
                ddlCanton.Items.Add("El Guarco");
            }
            else if (ddlProvincia.SelectedItem.Text == "Alajuela")
            {
                ddlCanton.Items.Clear();
                ddlCanton.Items.Add("Alajuela");
                ddlCanton.Items.Add("Atenas");
                ddlCanton.Items.Add("Grecia");
                ddlCanton.Items.Add("Guatuso");
                ddlCanton.Items.Add("Los Chiles");
                ddlCanton.Items.Add("Naranjo");
                ddlCanton.Items.Add("Orotina");
                ddlCanton.Items.Add("Palmares");
                ddlCanton.Items.Add("Poás");
                ddlCanton.Items.Add("Río Cuarto");
                ddlCanton.Items.Add("San Carlos");
                ddlCanton.Items.Add("San Mateo");
                ddlCanton.Items.Add("San Ramón");
                ddlCanton.Items.Add("Sarchí");
                ddlCanton.Items.Add("Upala");
                ddlCanton.Items.Add("Zarcero");
            }
            else if (ddlProvincia.SelectedItem.Text == "Guanacaste")
            {
                ddlCanton.Items.Clear();
                ddlCanton.Items.Add("Liberia");
                ddlCanton.Items.Add("Nicoya");
                ddlCanton.Items.Add("Santa Cruz");
                ddlCanton.Items.Add("Bagaces");
                ddlCanton.Items.Add("Carrillo");
                ddlCanton.Items.Add("Cañas");
                ddlCanton.Items.Add("Abangares");
                ddlCanton.Items.Add("Tilarán");
                ddlCanton.Items.Add("Nandayure");
                ddlCanton.Items.Add("La Cruz");
                ddlCanton.Items.Add("Hojancha");
            }
            else if (ddlProvincia.SelectedItem.Text == "Puntarenas")
            {
                ddlCanton.Items.Clear();
                ddlCanton.Items.Add("Buenos Aires");
                ddlCanton.Items.Add("Corredores");
                ddlCanton.Items.Add("Coto Brus");
                ddlCanton.Items.Add("Garabito");
                ddlCanton.Items.Add("Golfito");
                ddlCanton.Items.Add("Montes de Oro");
                ddlCanton.Items.Add("Monteverde");
                ddlCanton.Items.Add("Osa");
                ddlCanton.Items.Add("Parrita");
                ddlCanton.Items.Add("Puerto Jiménez");
                ddlCanton.Items.Add("Puntarenas");
                ddlCanton.Items.Add("Quepos");
            }
            else if (ddlProvincia.SelectedItem.Text == "Limón")
            {
                ddlCanton.Items.Clear();
                ddlCanton.Items.Add("Limón");
                ddlCanton.Items.Add("Pococí");
                ddlCanton.Items.Add("Siquírres");
                ddlCanton.Items.Add("Talamanca");
                ddlCanton.Items.Add("Matina");
                ddlCanton.Items.Add("Guácimo");
            }
        }

        protected void OnClick(object sender, EventArgs e)
        {
            // ruta absoluta archivo registro xml
            string ruta = @"C:\ReporteXML\";

            // determina si ruta no existe
            // crea directorio almacenamiento de reporte.xml
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            string archivo = Path.Combine(ruta, "registro.xml");

            // obtiene valores desde formulario
            String tipoID = rbtnTipoID.Text;
            String identificacion = txtID.Text; 
            String nombre = txtNombre.Text;
            String apellidos = txtApellidos.Text;
            String contacto = txtContacto.Text;
            String email = txtEmail.Text;
            String propuesta = txtPropuesta.Text;

            if (!System.IO.File.Exists(archivo))
            {
                XmlWriterSettings xmlWrSettings = new XmlWriterSettings();
                xmlWrSettings.Indent = true;                    // escribe elementos individuales en lineas nuevas e indenta
                xmlWrSettings.NewLineOnAttributes = true;       // antepone a cada atributo nueva linea y un nivel adicional de sangria
                using (XmlWriter xmlWriter = XmlWriter.Create(archivo, xmlWrSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Propuestas");

                    xmlWriter.WriteStartElement("Usuario");
                    xmlWriter.WriteElementString("TipoID", tipoID);
                    xmlWriter.WriteElementString("Identificación", identificacion);
                    xmlWriter.WriteElementString("Nombre", nombre);
                    xmlWriter.WriteElementString("Apellidos", apellidos);
                    xmlWriter.WriteElementString("Telefono", contacto);
                    xmlWriter.WriteElementString("Correo", email);
                    xmlWriter.WriteElementString("Propuesta", propuesta);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xmlDoc = XDocument.Load(archivo);
                XElement raiz = xmlDoc.Element("Propuestas");
                IEnumerable<XElement> filas = raiz.Descendants("Usuario");
                XElement primeraFila = filas.First();
                primeraFila.AddBeforeSelf(
                    new XElement("Usuario"),
                    new XElement("TipoID", tipoID),
                    new XElement("Identificación", identificacion),
                    new XElement("Nombre", nombre),
                    new XElement("Apellidos", apellidos),
                    new XElement("Telefono", contacto),
                    new XElement("Correo", email),
                    new XElement("Propuesta", propuesta));
                xmlDoc.Save(archivo);
            }
        }

        protected void OnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPropuesta.Text = string.Empty;
            ddlProvincia.SelectedIndex = 0;
            ddlCanton.SelectedIndex = 0;
        }
    }
}