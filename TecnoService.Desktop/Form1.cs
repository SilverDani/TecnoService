using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnoService.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {
            //Volver a llenar
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            
        }

        //private async Task btnIngresar_Click(object sender, EventArgs e)
        //{
        //    //using HttpClient client = new HttpClient();
        //    //client.BaseAddress = new Uri("Https://localhost:7151/");

        //    //var marcaDto = new { Nombre = txtMarca.Text };
        //    //var marcaCont = new StringContent(JsonConvert.SerializeObject(marcaDto), Encoding.UTF8, "application/json");
        //    //var marcaRes = await client.PostAsync("api/Marca", marcaCont);

        //    //if (!marcaRes.IsSuccessStatusCode)
        //    //{
        //    //    MessageBox.Show("Error al Crear la Marca");
        //    //    return;
        //    //}

        //    //var marcaData = JsonConvert.DeserializeObject<dynamic>(await marcaRes.ReadAsStringAsync());
        //}

        //========================================================
    }
}
