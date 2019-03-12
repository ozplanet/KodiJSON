using System;
using System.Windows.Forms;

//Get JSOn DATA from https://kodi.wiki/view/JSON-RPC_API/v9

namespace UnitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnitTests.Files unitTests = new UnitTests.Files();
            unitTests.GetDirectoryTest();

        }

    }
}









