using Grpc.Net.Client;
using GrpcService3;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Greeter.GreeterClient cliente1;
        private readonly ILogger<IndexModel> _logger;


        ////////lista de propiedades

        [BindProperty]
        public string Nombre { get; set; }
        public string Mensaje { get; set; }

        [BindProperty]
        public string Nombre2 { get; set; }

        [BindProperty]
        public string Nombre3 { get; set; }

        [BindProperty]
        public int Edad { get; set; }

        [BindProperty]
        public int Edad2 { get; set; }

        [BindProperty]
        public int Edad3 { get; set; }

        [BindProperty]
        public string otros { get; set; }


        public IndexModel(ILogger<IndexModel> logger)


        {
            ////direccion del grpc service https
            ////cleitne con canal
            var url = "https://localhost:5001";
            var canal = GrpcChannel.ForAddress(url);
            cliente1 = new Greeter.GreeterClient(canal);

            _logger = logger;
        }

        public void OnGet()
        {

        }

        // void serivia tambien y quitar async y await
        public async Task OnPost()
        {
            ///se llama al hellorequest
            var helloRequest = new HelloRequest2();
            /*helloRequest.Name = Nombre;
            helloRequest.Name2 = Nombre2;
            helloRequest.Name3 = Nombre3;
            helloRequest.Edad = string.Concat(Edad);
            helloRequest.Edad2 = string.Concat(Edad2);
            helloRequest.Edad3 = string.Concat(Edad3);
            */

            


            var resultado = await cliente1.metodo2Async(helloRequest);

            Mensaje = resultado.Message;
        }

    }
}