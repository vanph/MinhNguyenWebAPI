using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelloWorldApp.Models;
using Newtonsoft.Json;
using RestSharp;

namespace HelloWorldApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "http://helloworldapi.com/api/values/GetPersons";//endpoint
            
            var client = new RestClient(url);
            var request = new RestRequest();
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var persons = JsonConvert.DeserializeObject(content);
            dataGridView1.DataSource = persons;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var url = "http://helloworldapi.com/api/product/GetProducts";//endpoint

            var client = new RestClient(url);
            var request = new RestRequest();
            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var products = JsonConvert.DeserializeObject<List<Product>>(content);
            dataGridView1.DataSource = products;
        }
    }
}
