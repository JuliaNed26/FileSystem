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


namespace Practick
{
    public partial class FiieSystemForm : Form
    {
       
        public FiieSystemForm()
        {
            InitializeComponent();
            Fill();
            
        }



        private void Fill()
        {
           // вывести все диски, а не только диск Е
            listBox1.DataSource = Directory.GetFileSystemEntries(@"E:\");
        }
        private void listBox1_Click(object sender, EventArgs e)
        {           
           
            string folderPath = listBox1.SelectedItem.ToString();
            //string folderPath = listBox1.Text;
            if (Path.GetExtension(folderPath) != String.Empty)
            {
                System.Diagnostics.Process.Start(folderPath);
            }
            else
            {
                listBox1.DataSource = Directory.GetFileSystemEntries(folderPath);
            }
        }    
    }
}
