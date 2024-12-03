using ClienteConsola_EngraciaSteeven;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace ClienteConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:9090/api/Clientes";
            ListarElementos(url);

        }
        static void ListarElementos(string url)
        {
            using (HttpClient cliente = new HttpClient())
            {
                using (HttpRequestMessage solicitud = new HttpRequestMessage())
                {
                    solicitud.RequestUri = new Uri(url);
                    solicitud.Method = HttpMethod.Get;
                    //dentro de la solicitud establecemos que la comunicación es en Json
                    solicitud.Headers.Add("Accept", "application/json");
                    //esperamos la respuesta de enviar el mensaje de solicutud 
                    Task<HttpResponseMessage> httpResponse = cliente.SendAsync(solicitud);
                    using (HttpResponseMessage respuesta = httpResponse.Result)
                    {
                        //el contenido lo podemos obtener como stream o texto
                        //y transformarlo a objetos de ser necesario
                        Console.WriteLine(respuesta.ToString());
                        HttpStatusCode codigo = respuesta.StatusCode;
                        Console.WriteLine("Estado {0}", codigo);
                        Console.WriteLine("codigo {0}", (int)codigo);
                        HttpContent contenido = respuesta.Content;
                        Task<string> datos = contenido.ReadAsStringAsync();
                        string cadena = datos.Result;
                        Console.WriteLine(cadena);
                    }
                }
            }
        }

        static void insertarElemento(string url, Cliente cliente)
        {
            using (HttpClient c = new HttpClient())
            {
                using (HttpRequestMessage solicitud = new HttpRequestMessage())
                {
                    solicitud.RequestUri = new Uri(url);
                    solicitud.Method = HttpMethod.Post;
                    //dentro de la solicitud establecemos que la comunicación es en Json
                    solicitud.Headers.Add("Accept", "application/json");
                    var json = Newtonsoft.Json.JsonConvert.SerializeObject(cliente);
                    solicitud.Content = new StringContent(json.ToString(), Encoding.UTF8,
                    "application/json"); ;
                    //esperamos la respuesta de enviar el mensaje de solicutud 
                    Task<HttpResponseMessage> httpResponse = c.SendAsync(solicitud);
                    using (HttpResponseMessage respuesta = httpResponse.Result)
                    {
                        //el contenido lo podemos obtener como stream o texto
                        //y transformarlo a objetos de ser necesario
                        Console.WriteLine(respuesta.ToString());
                        HttpStatusCode codigo = respuesta.StatusCode;
                        Console.WriteLine("Estado {0}", codigo);
                        Console.WriteLine("codigo {0}", (int)codigo);
                        HttpContent contenido = respuesta.Content;
                        Task<string> datos = contenido.ReadAsStringAsync();
                        string cadena = datos.Result;
                        Console.WriteLine(cadena);

                    }
                }
            }
        }
    }
}