using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gold
{
    public partial class TextBoxForGrid : UserControl
    {
        public TextBoxForGrid()
        {
            InitializeComponent();
        }

        private void txtArticalDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            Loan l = new Loan();
            TextBoxForGrid txtGrid = new TextBoxForGrid();
            l.gvArticelsSold.Controls.Add(txtGrid);
        }
    }
}
