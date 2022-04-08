using Grpc.Core;
using GrpcService3;
using System.Text.RegularExpressions;

namespace GrpcService3.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        List<T> mapa= new List<T>();
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }
        public override Task<replyTodo> GuardarDatos(requestGuardar request, ServerCallContext context)
        {
            string nombre="";
            string apellido="";
            string cedula="";
            string edad="";
            string cuentasBancarias="";
            foreach (KeyValuePair<string, string> entry in request.MapaData)
            {
                string x1=entry.Key;
                string[] s5 = x1.Split('#');
                nombre = s5[0];
                apellido = s5[1];
                cedula = entry.Value;
            }
            //T person1 = new T(nombre, apellido, cedula, edad, cuentasBancarias);
            //mapa.Add(person1);
            // string text = System.IO.File.ReadAllText(@"C:\rmi\write.txt");
            // System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            string text = System.IO.File.ReadAllText(@"C:\rmi\write.txt");
            string[] s = text.Split('#');
            List<T> varios = new List<T>();
            string x0 = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                string[] s1 = s[i].Split(',');
                string a1 = s1[0];
                if (!Regex.Match(a1, "^(\r\n)").Success) //por los saltos de lineas
                {
                    a1 = "\r\n" + a1;
                }
                a1 = a1.Substring(2);
                string a2 = s1[1];
                string a3 = s1[2];
                string a4 = s1[3];
                string a5 = s1[4];
                T persona = new T(a1, a2, a3, a4, a5);
                varios.Add(persona);
            }
            T person1 = null;
            foreach (T personl1 in varios)
            {
                if (personl1.cedula == cedula)
                {
                    person1 = personl1;
                    break;
                }
            }
            if (person1 != null)
            {
                x0 = "Ya existe la cedula";
            }
            else
            {
                var task = ExampleAsync(cedula + "," + nombre + "," + apellido + ", " + ", " + "#");
                task.Wait();
                x0 = "Guardado exitoso";
            }


            string x = x0;
            return Task.FromResult(new replyTodo
            {
                Message = x
            }); 
    }
        public static async Task ExampleAsync(string a0)
        {
            using StreamWriter file = new(@"C:\rmi\write.txt", append: true);
            await file.WriteLineAsync(a0);
        }
        public static async Task ExEscribir(string a0)
        {
            await File.WriteAllTextAsync(@"C:\rmi\write.txt", a0);
        }

        ////////////////////////////////////////////////////////////////////////////
        public override Task<replyTodo> Devolverinformacion(requestGuardar request, ServerCallContext context)
        {
            string text = System.IO.File.ReadAllText(@"C:\rmi\write.txt");
           
            return Task.FromResult(new replyTodo
            {
                Message = text
            });
        }
         ///////////////////////////////////////////
        public override Task<replyTodo> AgregarInformacion(requestAgregar request, ServerCallContext context)
        {
            string text = System.IO.File.ReadAllText(@"C:\rmi\write.txt");
            string[] s = text.Split('#');
            List<T> varios = new List<T>();
            for (int i = 0; i < s.Length - 1; i++)
            {
                string[] s1 = s[i].Split(',');
                string a1 = s1[0];
                if (!Regex.Match(a1, "^(\r\n)").Success) //por los saltos de lineas
                {
                    a1 = "\r\n" + a1;
                }
                a1 = a1.Substring(2);
                string a2 = s1[1];
                string a3 = s1[2];
                string a4 = s1[3];
                string a5 = s1[4];
                T persona = new T(a1,a2,a3,a4,a5);
                varios.Add(persona);
            }
            string x0 = "";
            string cedula = "";
            string edad = "";
            string cuentasBancarias = "";
            string x = request.Otros;

            //
            byte[] bytes = request.Archivos.ToByteArray();
            string resultadou = System.Text.Encoding.UTF8.GetString(bytes);
            //Console.WriteLine(resultadou);
            //

            string[] s3 = x.Split('#');
            cedula = s3[0];
            edad = s3[1];
            cuentasBancarias = s3[2];

            string texto1 = "";

            T person1 = null;
            foreach (T personl1 in varios)
            {
                if (personl1.cedula == cedula)
                {
                    person1 = personl1;
                    break;
                }
            }
            if (person1 == null)
            {
                x0 = "No existe la cedula";
            }
            else
            {
                foreach (T personl in varios)
                {
                    if (personl.cedula.Equals(cedula))
                    {
                        personl.edad = edad;
                        personl.cuentasBancarias = cuentasBancarias;
                    }
                    texto1 += personl.cedula + "," + personl.nombre + "," +
                        personl.apellido + "," + personl.edad + "," + personl.cuentasBancarias + "#\r\n";
                }
                x0 = "Guardado exitoso";
                var task = ExEscribir(texto1);
                task.Wait();

            }

            return Task.FromResult(new replyTodo
            {
                Message = x0
            });
        }
    }

  


    internal class T
    {
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? cedula { get; set; }
        public string? edad { get; set; }
        public string? cuentasBancarias { get; set; }

        public T(string cedula, string nombre, string apellido, string edad, string cuentasBancarias)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.cuentasBancarias = cuentasBancarias;
        }
    }
}

/*
  string[] s = text.Split('#');
            for (int i = 0; i < s.Length; i++)
            {
                string[] s1 = s[i].Split(',');
                string a1 = s1[0];
                string a2 = s1[1];
                string a3 = s1[2];
                string a4 = s1[3];
                string a5 = s1[4];
            }

            string x = "";
            foreach (T entry in mapa)
            {
                x += entry.nombre+",";
                x += entry.apellido + ",";
                x += entry.cedula + ",";
                x += entry.edad + ",";
                x += entry.cuentasBancarias;
                x += "#";
            }
  */