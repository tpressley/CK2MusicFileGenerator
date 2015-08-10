using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CK2MusicFileCreator
{
    public partial class Form1 : Form
    {
        string[] filePaths;
        List<string> fileNames = new List<string>();
        string temporaryString = "";
        string path = AppDomain.CurrentDomain.BaseDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void getFilesButton_Click(object sender, EventArgs e)
        {
            filePaths = Directory.GetFiles(path, "*.ogg");
            for (int i = 0; i < filePaths.Length; i++)
            {
                outputLabel.Text += (filePaths[i] + "\n");
            }

            for (int i = 0; i < filePaths.Length; i++)
            {
                temporaryString = Path.GetFileName(filePaths[i]);
                /*for (int j = 0; j < filePaths[i].Length; j++)
                {
                    if (j > 8)
                    {
                        temporaryString += filePaths[i][j];
                    }
                }*/
                try { fileNames.Add(temporaryString); }
                catch (NullReferenceException) { };
            }
            outputLabel.Text = "";
            try
            {
                for (int i = 0; i < fileNames.Count; i++)
                {
                    { outputLabel.Text += (fileNames[i] + "\n"); }
                
                }
            }
            catch (NullReferenceException) { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateFileButton_Click(object sender, EventArgs e)
        {
            
            if(!(fileNames.Count > 0))
            {
                outputLabel.Text += "Error: no songs found\n";
            }
            else
            {
                //File.CreateText(@"c:\MyDir\songs.txt");
                try
                {
                    TextWriter tw = new StreamWriter(path + "\\songs.txt");
                    for (int i = 0; i < fileNames.Count; i++)
                    {
                        tw.WriteLine("");
                        tw.WriteLine("song = {");
                        tw.WriteLine("	name = \"" + fileNames[i] +"\"");
                        tw.WriteLine("");
                        tw.WriteLine("	chance = {");
                        tw.WriteLine("		modifier = {");
                        tw.WriteLine("			factor = 1");
                        tw.WriteLine("		}		");
                        tw.WriteLine("	}");
                        tw.WriteLine("}");
                        tw.WriteLine("");
                        tw.WriteLine("");
                        tw.WriteLine("");
                    }
                    tw.Close();
                }
                catch (IOException) { };
                
            }
        }
    }
}
