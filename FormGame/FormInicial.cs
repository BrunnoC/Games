using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FormGame
{
    public partial class FormInicial : DevExpress.XtraEditors.XtraForm
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormPedraPapelTesoura pedraPapelTesoura = new FormPedraPapelTesoura();
            pedraPapelTesoura.ShowDialog();
        }
    }
}