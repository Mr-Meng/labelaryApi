using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace labelaryApi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> dpmms = new Dictionary<int, string>();
            dpmms.Add(6, "6 dpmm(152dpi)");
            dpmms.Add(8, "8 dpmm(203dpi)");
            dpmms.Add(12, "12 dpmm(300dpi)");
            dpmms.Add(24, "24 dpmm(600dpi)");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dpmms;
            this.cbx_dpmm.DataSource = bindingSource;
            this.cbx_dpmm.DisplayMember = "Value";
            this.cbx_dpmm.ValueMember = "Key";
            this.cbx_dpmm.SelectedValue = 8;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_zpl.Clear();
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            var zplString = this.txt_zpl.Text.Replace(" ", string.Empty);
            byte[] zpl = Encoding.UTF8.GetBytes(zplString);

            // adjust print density (8dpmm), label width (4 inches), label height (6 inches), and label index (0) as necessary
            var request = (HttpWebRequest)WebRequest.Create(string.Format("http://api.labelary.com/v1/printers/{0}dpmm/labels/{1}x{2}/0/", this.cbx_dpmm.SelectedValue, this.nud_width.Value, this.nud_height.Value));
            request.Method = "POST";
            request.Accept = "image/png"; // omit this line to get PNG images back
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = zpl.Length;

            var requestStream = request.GetRequestStream();
            requestStream.Write(zpl, 0, zpl.Length);
            requestStream.Close();

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();
                var image = Image.FromStream(responseStream);
                this.pictureBox_preview.Image = image;
                responseStream.Close();
            }
            catch (WebException ex)
            {
                Console.WriteLine("Error: {0}", ex.Status);
            }
        }
    }
}
