using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace ClientesWebApp.Models
{
    public class ClienteDAO
    {
        //crear cliente para acceder al servicio web 
        //y crear particiones tanto get, post, delete o put
        RestClient client = new RestClient("http://localhost:55681/api/");

        public List<Cliente> ListadoClientes()
        {
            //Creamos una peticion tipo get que apunte a http://localhost:55681/api/clientes
            RestRequest request = new RestRequest("clientes",Method.GET);
            //obtenemos una lista de clientes a partir del request anterior
            IRestResponse<List<Cliente>> response=
                client.Execute<List<Cliente>>(request);
            
            //retornamos la lista de tipo Cliente
            return response.Data;
        }

        public bool AgregarCliente(Cliente cliente)
        {
            RestRequest request = new RestRequest("clientes", Method.POST);

            request.AddJsonBody(cliente);
            //ejecutamos el request enviado por el objeto cliente.
            IRestResponse response = client.Execute(request);
            // si es error 500 quiere decitr que ocurrioun error al crear el cliente
            if(response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                return false;
            }
            //si el codigo es 200 es que el cliente fue agregado correctamente
            if (response.StatusCode == System.Net.HttpStatusCode.OK) { 
                return true;
            }

        return false;

        }
    }
}