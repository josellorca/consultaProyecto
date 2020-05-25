using Aplicacion_de_administracion.Modelo;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel;
using Aplicacion_de_administracion.Vista;
using Aplicacion_de_administracion.VistaModelo;

namespace Aplicacion_de_administracion.Servicios
{
    
    static class ApiRestService
    {
        static RestClient client = new RestClient();

        public static List<Categoria> Categorias;

        public static List<Productos> Productos;

        public static List<Transportistas> Transportistas { get; set; }

        public static async Task RunAsync()
        {

            try
            {
                client.BaseUrl = new Uri("http://pdam05b.iesdoctorbalmis.info/");
                Categorias = await GetCategorias();
                Productos = await GetProductos();
                Transportistas = await GetTransportistas();
            }
            catch (Exception e)
            {

            }
        }

        public static void Refresh()
        {

            CrearProductoVistaModelo.Categorias = new List<Categoria>(Categorias);
            ModificarCategoriaVistaModelo.Categorias = new List<Categoria>(Categorias);
            ModificarProductoVistaModelo.Categorias = new List<Categoria>(Categorias);
            ModificarProductoVistaModelo.Productos = Productos;
            ModificarTransportistaVistaModelo.Transportistas = Transportistas;
            EliminarCategoriaVistaModelo.Categorias = new System.Collections.ObjectModel.ObservableCollection<Categoria>(Categorias);
            EliminarProductoVistaModelo.ProductosList = new System.Collections.ObjectModel.ObservableCollection<Productos>(Productos);
            EliminarTransportistaVistaModelo.Transportistas = Transportistas;


        }
        //METODOS DE CATEGORIAS
        public static async Task<bool> PostCategoria(Categoria categoria)
        {

            try
            {
                var request = new RestRequest("infotech/categorias", Method.POST);
                request.AddJsonBody(categoria);
                IRestResponse r = await client.ExecutePostAsync(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static async Task<List<Categoria>> GetCategorias()
        {

            try
            {
                var request = new RestRequest("infotech/categorias", Method.GET);
                IRestResponse response = await client.ExecuteGetAsync(request);
                List<Categoria> categorias = new List<Categoria>();
                if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                {
                    JsonSerializer jSerializer = JsonSerializer.Create();
                    using (JsonTextReader jReader = new JsonTextReader(new StringReader(response.Content)))
                    {
                        categorias = (List<Categoria>)jSerializer.Deserialize(jReader, typeof(List<Categoria>));
                        jReader.Close();
                    }

                }
                return categorias;
            }
            catch (Exception e)
            {
                return new List<Categoria>();
            }
        }

        public static async Task<bool> PutCategoria(Categoria categoria)
        {

            try
            {
                var request = new RestRequest("infotech/categorias/" + categoria.IdCategoria, Method.PUT);
                request.AddJsonBody(categoria);
                IRestResponse response = await client.ExecuteAsync(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> DeleteCategoria(int IdCategoria)
        {

            try
            {
                int cantidadProductos = (from producto in Productos where producto.IdCategoria == IdCategoria select producto).Count();
                if (cantidadProductos <= 0)
                {
                    var request = new RestRequest("infotech/categorias/" + IdCategoria, Method.DELETE);
                    IRestResponse response = await client.ExecuteAsync(request);
                    return true;
                }
                return false;
                
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //METODOS DE PRODUCTOS
        public static async Task<List<Productos>> GetProductos()
        {

            try
            {
                var request = new RestRequest("infotech/productos", Method.GET);
                IRestResponse response = await client.ExecuteGetAsync(request);
                List<Productos> productos = new List<Productos>();
                if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                {
                    JsonSerializer jSerializer = JsonSerializer.Create();
                    using (JsonTextReader jReader = new JsonTextReader(new StringReader(response.Content)))
                    {
                        productos = (List<Productos>)jSerializer.Deserialize(jReader, typeof(List<Productos>));
                        jReader.Close();
                    }

                }
                return productos;
            }
            catch (Exception e)
            {
                return new List<Productos>();
            }
        }
        public static async Task<bool> PostProducto(Productos producto)
        {

            try
            {
                var request = new RestRequest("infotech/productos", Method.POST);
                request.AddJsonBody(producto);
                IRestResponse response = await client.ExecuteAsync(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static async Task<bool> PutProducto(Productos producto)
        {

            try
            {
                var request = new RestRequest("infotech/productos/" + producto.IdProducto, Method.PUT);
                request.AddJsonBody(producto);
                IRestResponse response = await client.ExecuteAsync(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static async Task<bool> DeleteProducto(int IdProducto)
        {

            try
            {
                var request = new RestRequest("infotech/productos/" + IdProducto, Method.DELETE);
                IRestResponse response = await client.ExecuteAsync(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //Transportistas
        public static async Task<List<Transportistas>> GetTransportistas()
        {
            try
            {
                var request = new RestRequest("infotech/transportistas", Method.GET);
                IRestResponse response = await client.ExecuteGetAsync(request);
                List<Transportistas> transportistas = new List<Transportistas>();
                if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                {
                    JsonSerializer jSerializer = JsonSerializer.Create();
                    using (JsonTextReader jReader = new JsonTextReader(new StringReader(response.Content)))
                    {
                        transportistas = (List<Transportistas>)jSerializer.Deserialize(jReader, typeof(List<Transportistas>));
                        jReader.Close();
                    }

                }
                return transportistas;
            }
            catch (Exception e)
            {
                return new List<Transportistas>();
            }
        }
        public static async Task<bool> PostTransportista(Transportistas transportistas)
        {

            try
            {
                var request = new RestRequest("infotech/transportistas", Method.POST);
                request.AddJsonBody(transportistas);
                IRestResponse response = await client.ExecuteAsync(request);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static async Task<bool> PutTransportista(Transportistas transportistas)
        {
            try
            {
                var request = new RestRequest("infotech/transportistas/" + transportistas.IdTransportista, Method.PUT);
                request.AddJsonBody(transportistas);
                IRestResponse response = await client.ExecuteAsync(request);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static async Task<bool> DeleteTransportista(Transportistas transportistas)
        {
            try
            {
                var request = new RestRequest("infotech/transportistas/" + transportistas.IdTransportista, Method.DELETE);
                IRestResponse response = await client.ExecuteAsync(request);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
    }
}
