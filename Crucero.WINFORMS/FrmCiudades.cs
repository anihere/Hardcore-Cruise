using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmCiudades : Form
    {
        #region Constructores

        public FrmCiudades()
        {
            InitializeComponent();

            dtgCiudades.AutoGenerateColumns = false;
            dtgCiudades.DataSource = Ciudades.ListadoCiudades;

            dtgCiudades.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion
    }
}
