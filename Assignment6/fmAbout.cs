using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class fmAbout : Form
    {
        private int pfvWordsSearched = 0;

        public fmAbout()
        {
            InitializeComponent();
        }

        public int WordsSearched
        {
            get
            {
                return pfvWordsSearched;
            }

            set
            {
                pfvWordsSearched = value;
            }
        }

        private void fmAbout_Load(object sender, EventArgs e)
        {
            int wordAmount = fmMain.wordsSearched;
            lbWordsSearched.Text = $"Words Searched: {wordAmount}";
        }

        private void bnOkay_Click(object sender, EventArgs e)
        {
            //Close this form only
            this.Close();
        }
    }
}
