using System.Windows.Forms;

using Crucero.ReglasNegocio;

namespace Crucero.WINFORMS
{
    public partial class FrmUsuarios : Form
    {
        #region Constructores

        public FrmUsuarios()
        {
            InitializeComponent();

            dtgUsuarios.AutoGenerateColumns = false;
            dtgUsuarios.DataSource = Usuarios.ListadoUsuarios;
        }

        #endregion
    }
}
