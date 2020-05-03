using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nia_Enc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private string filename;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ob = new OpenFileDialog();
            ob.InitialDirectory = "c:\\";
            ob.Filter = "Access files(*.txt)|*.txt";
            ob.FilterIndex = 2;
            ob.RestoreDirectory = true;
            if (ob.ShowDialog() == DialogResult.OK)
            {
                var path = ob.FileName;
                string x = path.ToString();
                this.result.Text = "Choosen file:    " + x;
                filename = x;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string enc = this.enckey.Text;
            int encryption_key = int.Parse(enc);
            if (encryption_key < 0)
            {
                int x = 0 - encryption_key;
                encryption_key = x;
            }
            var engine = Python.CreateEngine();
            string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path_customEncryption = path_directory + "\\file_enc.py";
            var source = engine.CreateScriptSourceFromFile(path_customEncryption);
            var scope = engine.CreateScope();
            source.Execute(scope);
            var custom_encryption = scope.GetVariable("custom_encryption");
            var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
            string res= custom_encryption_instance.file_encryption(filename, encryption_key);
            this.result.Text = "File is successfully encrypted in: " + path_directory + "\\encrypted.txt";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enc = this.enckey.Text;
            int encryption_key = int.Parse(enc);
            if (encryption_key < 0)
            {
                int x = 0 - encryption_key;
                encryption_key = x;
            }
            var engine = Python.CreateEngine();
            string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path_customEncryption = path_directory + "\\file_enc.py";
            var source = engine.CreateScriptSourceFromFile(path_customEncryption);
            var scope = engine.CreateScope();
            source.Execute(scope);
            var custom_encryption = scope.GetVariable("custom_encryption");
            var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
            string res = custom_encryption_instance.file_decryption(filename, encryption_key);
            this.result.Text = "File is successfully encrypted in: " + path_directory + "\\decrypted.txt";
        }
    }
}
