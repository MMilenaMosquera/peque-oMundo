using pequeñoMundo.Controllers;
using pequeñoMundo.Data;
using pequeñoMundo.Interactuable;
using pequeñoMundo.Interactuable.Strategy;
using pequeñoMundo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace pequeñoMundo.UI
{
    public partial class Fight : Form
    {
        private EntityRepository entityRepository = new EntityRepository();
        private Entity entityPlayer1;

        Random random = new Random();

        public Fight()
        {
            InitializeComponent();
            ObtenerEntidadAzar();
            cargarComboPayer2();
            cargarCmbItem();

        }

        private void ObtenerEntidadAzar()
        {
            //Entity entityPlayer1 = ControllerEntity.Instance.GetRandomEntity();
            entityPlayer1 = entityRepository.GetRandomEntity();

            txtPayer1.Text = entityPlayer1.NOMBRE;
            pgbEnergyPlayer1.Value = entityPlayer1.CURRENTENERGY;
            pgbLifePlayer1.Value = entityPlayer1.CURRENTLIFE;
            pgbAttackPointsPlayer1.Value = entityPlayer1.ATTACKPOINTS;
            pgbDefencePointsPlayer1.Value = entityPlayer1.DEFENSEPOINTS;
        }


        private void cmbPayer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity entitySelected = (Entity)cmbPayer2.SelectedItem;
            pgbEnergyPlayer2.Value = entitySelected.CURRENTENERGY;
            pgbLifePlayer2.Value = entitySelected.CURRENTLIFE;
            pgbAttackPointsPlayer2.Value = entitySelected.ATTACKPOINTS;
            pgbDefencePointsPlayer2.Value = entitySelected.DEFENSEPOINTS;
        }
        private void cargarComboPayer2()
        {
            // cmbPayer2.DataSource = ControllerEntity.Instance.GetEntities();
            cmbPayer2.DataSource = entityRepository.GetEntities();
            cmbPayer2.SelectedIndex = 0;
            cmbPayer2.DisplayMember = "NOMBRE";
        }

        private void btnPelea(object sender, EventArgs e)
        {
            Entity defender = (Entity)cmbPayer2.SelectedItem;

            ControllerEntity.Instance.Fight(entityPlayer1, defender);
            pgbEnergyPlayer1.Value = entityPlayer1.CURRENTENERGY;
            pgbLifePlayer1.Value = entityPlayer1.CURRENTLIFE;
            pgbAttackPointsPlayer1.Value = entityPlayer1.ATTACKPOINTS;
            pgbDefencePointsPlayer1.Value = entityPlayer1.DEFENSEPOINTS;
            pgbEnergyPlayer2.Value = defender.CURRENTENERGY;
            pgbLifePlayer2.Value = defender.CURRENTLIFE;
            pgbAttackPointsPlayer2.Value = defender.ATTACKPOINTS;
            pgbDefencePointsPlayer2.Value = defender.DEFENSEPOINTS;
        }


        public void updateFields()
        {
            pgbEnergyPlayer1.Value = entityPlayer1.CURRENTENERGY;
            pgbLifePlayer1.Value = entityPlayer1.CURRENTLIFE;
            pgbAttackPointsPlayer1.Value = entityPlayer1.ATTACKPOINTS;
            pgbDefencePointsPlayer1.Value = entityPlayer1.DEFENSEPOINTS;

        }

        private void cargarCmbItem()
        {
            cmbItem.Items.Add(new Item(new IncreaseEnergyPoints()));
            cmbItem.Items.Add(new Item(new DecreaseEnergy()));

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)cmbItem.SelectedItem;

            if (selectedItem != null)
            {
                entityPlayer1.UseItem(selectedItem);

                updateFields();

            }

        }

        private void pgbLifePlayer1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show(entityPlayer1.CURRENTLIFE.ToString());
        }
    }




}
