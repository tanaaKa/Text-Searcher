using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Assignment 6
 * By Troy Billsen
 * CIS3343
*/
namespace Assignment6
{
    public partial class fmMain : Form
    {
        private int wordsFound = 0;
        public static int wordsSearched = 0;

        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            // Add text on init
            /*rtbPoem.Text = "Mary had a little lamb\n"
                + "Its fleece was white as snow\n"
                + "And everywhere that Mary went\n"
                + "The lamb was sure to go\n\n"
                + "He followed her to school one day\n"
                + "Which was against the rule\n"
                + "It made the children laugh and play\n"
                + "To see a lamb at shool";*/
            // Using sb/sr
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader("poem.txt"))
            {
                string buf;

                while ((buf = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(buf);
                    sb.AppendLine(buf);
                }
            }
            rtbPoem.Text = sb.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create new about form and show it
            fmAbout a = new Assignment6.fmAbout();
            a.Show();
        }

        private void tsmiFileExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void bnFind_Click(object sender, EventArgs e)
        {
            // set found to 0 for each new search
            wordsFound = 0;
            // Increment words searched'
            wordsSearched++;
            string keyword = tbText.Text;
            int startingLocation = 0;
            // Starting location of loop is index 0 of rtbPoem
            int start = rtbPoem.Text.IndexOf(keyword, startingLocation);
            // Loop to search through text
            while (start >= 0)
            {
                // Change location
                startingLocation = start + 1;
                // Highlight each word
                rtbPoem.Select(start, 1);
                rtbPoem.SelectionLength = keyword.Length;
                rtbPoem.SelectionBackColor = Color.Yellow;
                // Increment words found
                wordsFound++;
                // Update
                start = rtbPoem.Text.IndexOf(keyword, startingLocation);
            }

            // Change status box based on result
            if (wordsFound > 0)
            {
                tsslStatus.Text = $"Found {wordsFound} occurances of {keyword}";
            } else
            {
                tsslStatus.Text = $"No occurances of {keyword} found!";
            }
            
        }
    }
}
