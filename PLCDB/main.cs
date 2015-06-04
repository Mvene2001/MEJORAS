using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLCDB
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void abrirVentanaSecundaria(object sender, EventArgs e)
        { 
            ayuda p = new ayuda();
            p.Visible = true;
            this.Dispose(false);
//MANTENER EN IDEAS
        } //dfadsf 

    }
}
