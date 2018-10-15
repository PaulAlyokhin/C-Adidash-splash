using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxLearn.License;

namespace GenerateLicense
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            string productID = this.productID.Text;
            //var expiredate = this.expiredate.Text;
            string productKey = "";
            var manager = new FoxLearn.License.KeyManager(productID);
            KeyValuesClass ky = new KeyValuesClass()
            {
                Type = LicenseType.FULL,
                Header = Convert.ToByte(9),
                Footer = Convert.ToByte(6),
                ProductCode = (byte)1,
                Edition = Edition.ENTERPRISE,
                Version = 1
            };
            if(manager.GenerateKey(ky, ref productKey))
            {
                this.licensekey.Text = "ERROR";
            }
            this.licensekey.Text = productKey;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productID.Text = ComputerInfo.GetComputerId();
        }
    }
}
