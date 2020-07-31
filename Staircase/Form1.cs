using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staircase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           // int n = Convert.ToInt32(Console.ReadLine());

            staircase(Convert.ToInt32(txtBxNumberStaircase.Text));
        }

        // Complete the staircase function below.
        static void staircase(int n)
        {
            string hash = new string('#', n);
            string space = new string(' ', n + 1);
            string holderHash = "";
            string holderSpace = "";
            space = space.Remove(0, 1);
            for (int i = 0; i < n; i++)
            {
                space = space.Remove(0, 1);
                holderSpace = holderSpace + space;
                holderHash = holderHash + hash.Remove(0, hash.Length - 1);
                Console.WriteLine(space + holderHash);
            }
        }
    }
}
