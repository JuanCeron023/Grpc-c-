using Grpc.Net.Client;
using GrpcService3;
using System.Data;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly Greeter.GreeterClient cliente1;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            ////direccion del grpc service https
            ////cleitne con canal
            var url = "https://localhost:7167";
            var canal = GrpcChannel.ForAddress(url);
            cliente1 = new Greeter.GreeterClient(canal);

            dt = new DataTable();
            dt.Columns.Add("Cedula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Edad");
            dt.Columns.Add("Cuentas bancarias");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 105;
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].Width = 101;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            dt.Clear();
            ///se llama al hellorequest
            /*helloRequest.Name = Nombre;
            helloRequest.Name2 = Nombre2;
            helloRequest.Name3 = Nombre3;
            helloRequest.Edad = string.Concat(Edad);
            helloRequest.Edad2 = string.Concat(Edad2);
            helloRequest.Edad3 = string.Concat(Edad3);
            */

            var requestGuardar = new requestGuardar();
            var resultado = await cliente1.DevolverinformacionAsync(requestGuardar);
            System.Threading.Thread.Sleep(500);

            string[] s = resultado.Message.Split('#');
            for (int i = 0; i < s.Length-1; i++)
            {
                string[] s1 = s[i].Split(',');
                string a1 = s1[0];
                if (!Regex.Match(a1,"^(\r\n)").Success) //por los saltos de lineas
                {
                    a1= "\r\n" + a1;
                }
                a1=a1.Substring(2);

                string a2 = s1[1];
                string a3 = s1[2];
                string a4 = s1[3];
                string a5 = s1[4];
                haceralgo(a1,a2,a3,a4,a5);
            }
        }

        private void haceralgo(string a1,string a2, string a3, string a4, string a5)
        {
            DataRow dr = dt.NewRow();
            dr[0] = a1;
            dr[1] = a2;
            dr[2] = a3;
            dr[3] = a4;
            dr[4] = a5;
            dt.Rows.Add(dr);
        }
        private async Task btnEnviar_ClickAsync(object sender, EventArgs e)
        {}
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            label4.Text = "Cargando";
            string datos = txtNombre.Text + "#" + txtApellido.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string cedula = txtCodigo.Text;

            var requestGuardar = new requestGuardar();
            requestGuardar.MapaData.Add(datos, string.Concat(cedula));
             
            var resultado = await cliente1.GuardarDatosAsync(requestGuardar);
            label4.Text = resultado.Message.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}