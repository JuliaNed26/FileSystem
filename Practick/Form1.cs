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
    public partial class Form1 : Form
    {
        // название не говорящее
        public Form1()
        {
            InitializeComponent();
            Fill();
            
        }


        // модификаторы
        void Fill()
        {
           // вывести все диски, а не только диск Е
            listBox1.DataSource = Directory.GetFileSystemEntries(@"E:\");
        }
        private void listBox1_Click(object sender, EventArgs e)
        {           
            //folderPath will be better
            string addres = listBox1.SelectedItem.ToString();
            //string folderPath = listBox1.Text;
            if (Path.GetExtension(addres) != String.Empty)
            {
               System.Diagnostics.Process.Start(addres);
            }
            else
            { 
                listBox1.DataSource = Directory.GetFileSystemEntries(addres);
            }
        }    
    }
}
