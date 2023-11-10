using pequeñoMundo.Model;
using pequeñoMundo.Controllers;
using pequeñoMundo.Interfaces;
using System.Xml.Linq;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace pequeñoMundo
{
    public partial class EntityCRUD : Form
    {
        private Entity selectedEntity;
        public EntityCRUD()
        {
            InitializeComponent();
            CargarComboBox();

        }

        private void CargarComboBox()
        {
            cmbIKingdom.DataSource = ControllerEntity.Instance.GetKingdoms();
            cmbIKingdom.DisplayMember = "To String";

            chckListBoxEnvironment.DataSource = ControllerEntity.Instance.GetEnviroment();
            chckListBoxEnvironment.DisplayMember = "To String";

            cmbIDiet.DataSource = ControllerEntity.Instance.GetDiet();
            cmbIDiet.DisplayMember = "To String";
        }


        private void CargarEntidadEnDataGridView()
        {
            List<Entity> entities = ControllerEntity.Instance.GetEntities();
            dgvEntity.Columns.Add("Nombre", "Nombre");
            dgvEntity.Columns.Add("Kingdom", "Kingdom");
            dgvEntity.Columns.Add("Environment", "Environment");
            dgvEntity.Columns.Add("Diet", "Diet");
            dgvEntity.Columns.Add("MaxEnergy", "MaxEnergy");
            dgvEntity.Columns.Add("MaxLife", "MaxLife");
            dgvEntity.Columns.Add("AttackPoints", "AttackPoints");
            dgvEntity.Columns.Add("DefensePoints", "DefensePoints");
            dgvEntity.Columns.Add("AttackRange", "AttackRange");
            foreach (Entity ent in entities)
            {
                dgvEntity.Rows.Add(ent.NOMBRE, ent.KINGDOM,ent.NameEnvironment, 
                    ent.DIET, ent.MAXENERGY, ent.MAXLIFE, ent.ATTACKPOINTS, ent.DEFENSEPOINTS, ent.ATTACKPOINTS);

            }


        }
        private void dgvEntity_SelectionChanged(object sender, EventArgs e)
        {
            selectedEntity = GetSelectedEntityFromGrid();

            LoadEntityDataFromGrid();
        }

        private Entity GetSelectedEntityFromGrid()
        {
            if (dgvEntity.SelectedRows.Count > 0)
            {
                int rowIndex = dgvEntity.SelectedRows[0].Index;

                string entityName = dgvEntity.Rows[rowIndex].Cells["Nombre"].Value.ToString();

                selectedEntity = ControllerEntity.Instance.GetEntities().FirstOrDefault(entity => entity.NOMBRE == entityName);

                return selectedEntity;
            }
            return null;
        }
        private void LoadEntityDataFromGrid()
        {

            if (selectedEntity != null)
            {
                txtName.Text = selectedEntity.NOMBRE;
                cmbIKingdom.SelectedItem = selectedEntity.KINGDOM;
                cmbIDiet.SelectedItem = selectedEntity.DIET;
                txtMaxEnergy.Text = selectedEntity.MAXENERGY.ToString();
                txtMaxLife.Text = selectedEntity.MAXLIFE.ToString();
                txtAttackPoints.Text = selectedEntity.ATTACKPOINTS.ToString();
                txtDefensePoints.Text = selectedEntity.DEFENSEPOINTS.ToString();
                txtAttackRange.Text = selectedEntity.ATTACKRANGE.ToString();
                chckListBoxEnvironment.ClearSelected();

                foreach (IEnvironment habitat in selectedEntity.ENVIRONMENT)
                {
                    int index = chckListBoxEnvironment.Items.IndexOf(habitat);
                    if (index >= 0)
                    {
                        chckListBoxEnvironment.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                // IKingdom kingdom = cmbIKingdom.SelectedItem as IKingdom;
                IKingdom kingdom = (IKingdom)cmbIKingdom.SelectedItem;
                // IDiet diet = cmbIDiet.SelectedItem as IDiet;
                IDiet diet = (IDiet)cmbIDiet.SelectedItem;
                List<IEnvironment> environment = HabitatSelectedCheckList();
                int maxEnergy = int.Parse(txtMaxEnergy.Text);
                int maxLife = int.Parse(txtMaxLife.Text);
                int attackPoints = int.Parse(txtAttackPoints.Text);
                int defensePoints = int.Parse(txtDefensePoints.Text);
                int attackRange = int.Parse(txtAttackRange.Text);

                Entity entidad = ControllerEntity.Instance.CreateEntity(name, kingdom, environment, diet, maxEnergy, maxLife, attackPoints, defensePoints, attackRange);
               
                dgvEntity.Rows.Clear();
                CargarEntidadEnDataGridView();

                LimpiarCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdateEntity_Click(object sender, EventArgs e)
        {

            if (selectedEntity != null)
            {
                int id = selectedEntity.ID;
                string name = txtName.Text;
                IKingdom kingdom = (IKingdom)cmbIKingdom.SelectedItem;
                IDiet diet = (IDiet)cmbIDiet.SelectedItem;
                List<IEnvironment> environment = HabitatSelectedCheckList();
                int maxEnergy = int.Parse(txtMaxEnergy.Text);
                int maxLife = int.Parse(txtMaxLife.Text);
                int attackPoints = int.Parse(txtAttackPoints.Text);
                int defensePoints = int.Parse(txtDefensePoints.Text);
                int attackRange = int.Parse(txtAttackRange.Text);
                ControllerEntity.Instance.UpdateEntity(id, name, kingdom, environment, diet, maxEnergy, maxLife, attackPoints, defensePoints, attackRange);
                dgvEntity.Rows.Clear();
                CargarEntidadEnDataGridView();
                LimpiarCampos();
            }
        }

        private void btnDeleteEntity_Click(object sender, EventArgs e)
        {
            if (selectedEntity != null)
            {
                int id = selectedEntity.ID;
                ControllerEntity.Instance.DeleteEntity(id);
                dgvEntity.Rows.Clear();
                CargarEntidadEnDataGridView();
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            txtName.Text = string.Empty;
            cmbIKingdom.SelectedItem = null;
            cmbIDiet.SelectedItem = null;
            txtAttackPoints.Text = "";
            txtAttackRange.Text = "";
            txtDefensePoints.Text = "";
            txtEntities.Text = "";
            txtMaxEnergy.Text = "";
            txtMaxLife.Text = "";
            for (int i = 0; i < chckListBoxEnvironment.Items.Count; i++)
            {
                chckListBoxEnvironment.SetItemChecked(i, false);
            }

        }
        private List<IEnvironment> HabitatSelectedCheckList()
        {
            var environments = new List<IEnvironment>();
            CheckedListBox.CheckedItemCollection selectedItems = chckListBoxEnvironment.CheckedItems;
            foreach (IEnvironment item in selectedItems)
            {
                environments.Add(item);
            }

            return environments;
        }
    }
}
