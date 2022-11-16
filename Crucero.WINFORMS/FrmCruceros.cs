using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmCruceros : Form
    {
        #region Constructores

        public FrmCruceros()
        {
            InitializeComponent();

            dtgCruceros.AutoGenerateColumns = false;
            dtgCruceros.DataSource = Cruceros.ListadoCruceros;
        }

        #endregion
    }
}
