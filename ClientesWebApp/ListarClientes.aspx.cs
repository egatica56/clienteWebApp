using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClientesWebApp.Models;

namespace ClientesWebApp
{
    public partial class ListarClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            gvClientes.DataSource = clienteDAO.ListadoClientes();
            gvClientes.DataBind();
        }
    }
}