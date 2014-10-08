using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBaseWCF_ConsumeClient.MyBaseService;
using System.ServiceModel;

namespace MyBaseWCF_ConsumeClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyBaseService.Service1Client client = new Service1Client();
            client.ClientCredentials.UserName.UserName = "userOne";
            client.ClientCredentials.UserName.Password = "password1";


            MyBaseService.Employee Employee = client.GetEmployee(2);
            if (Employee.IsActive)
            {
                textBox1.Text = Employee.EmployeeName;
            }

            MyBaseService.EmployeeMessage message = new EmployeeMessage();
            message.IsActive = true;
            message.EmployeeName = "Sunil";

            
            

            //IService1 service = System.ServiceModel.ChannelFactory<IService1Channel>.CreateChannel(wshttpBinding, address);
            //MyBaseWCF_ConsumeClient.MyBaseService.EmployeeData data =  service.GetEmployeeMessage(message);





            string test = client.GetEmployeeMessage(true, "Sunil");
            //MyBaseService.EmployeeData data =
            if (Employee.IsActive)
            {
                textBox1.Text = Employee.EmployeeName;
            }

           
            //textBox1.Text = client.GetData(1);
        }
    }
}
