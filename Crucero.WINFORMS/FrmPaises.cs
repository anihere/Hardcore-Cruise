using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmPaises : Form
    {
        #region Constructores

        public FrmPaises()
        {
            InitializeComponent();

            dtgPaises.AutoGenerateColumns = false;
            dtgPaises.DataSource = Paises.ListadoPaises;

            dtgPaises.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion
    }
}
