using ColegioColombia.Cliente.ServicioBienvenida;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ColegioColombia.Cliente
{
    internal class Program
    {
        private static void Main()
        {
            ObtenerAlumnosWcf();
            CrearAlumno().Wait();
            ConsultarAlumnos().Wait();

            Console.ReadLine();
        }

        private static HttpClient ObtenerCliente()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:58012/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        private static async Task ConsultarAlumnos()
        {
            HttpClient client = ObtenerCliente();
            using (client)
            {
                HttpResponseMessage res = await client.GetAsync("api/Alumnos");
                res.EnsureSuccessStatusCode();

                if (res.IsSuccessStatusCode)
                {
                    List<Alumno> alumnos = await res.Content.ReadAsAsync<List<Alumno>>();
                    Console.WriteLine("");
                    Console.WriteLine("---------------------Invocando Método GET------------------------");
                    Console.WriteLine("");
                    foreach (var alumno in alumnos)
                    {
                        Console.WriteLine($"Id: {alumno.Id} - Nombre: {alumno.Nombre} - Apellido: {alumno.Apellido}");
                    }
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("");
                }
            }
        }

        private static async Task CrearAlumno()
        {
            HttpClient client = ObtenerCliente();
            using (client)
            {
                Alumno alumno = new Alumno
                {
                    Nombre = "Juan",
                    Apellido = "Rodriguez",
                    Cedula = 15478475689,
                    Grado = 11,
                    Grupo = "11C"
                };

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("------------------Invocando Método Post--------------------");

                HttpResponseMessage res = await client.PostAsJsonAsync("api/Alumnos", alumno);
                res.EnsureSuccessStatusCode();

                if (res.IsSuccessStatusCode)
                {
                    Console.WriteLine("------------------Alumno Creado Exitosamente--------------------");
                    Console.WriteLine("");
                }
            }
        }

        private static void ObtenerAlumnosWcf()
        {
            ServicioBienvenidaClient client = new ServicioBienvenidaClient();
            int idAlumnoConsulta = 1;

            ServicioBienvenida.Alumno alumno = client.ConsultarAlumno(idAlumnoConsulta);

            client.Close();

            Console.WriteLine("");
            Console.WriteLine("---------------------Invocando Consultar Alumno WCF------------------------");
            Console.WriteLine("");
            Console.WriteLine($"Id: {alumno.Id} - Nombre: {alumno.Nombre} - Apellido: {alumno.Apellido}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
        }
    }
}