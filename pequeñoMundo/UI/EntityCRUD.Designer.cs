namespace pequeñoMundo
{
    partial class EntityCRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnCreateEntity = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaxEnergy = new TextBox();
            label6 = new Label();
            txtMaxLife = new TextBox();
            label7 = new Label();
            txtAttackPoints = new TextBox();
            label8 = new Label();
            txtDefensePoints = new TextBox();
            label9 = new Label();
            txtAttackRange = new TextBox();
            cmbIKingdom = new ComboBox();
            cmbIDiet = new ComboBox();
            dgvEntity = new DataGridView();
            txtEntities = new TextBox();
            chckListBoxEnvironment = new CheckedListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnCreateEntity);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 62);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(241, 22);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDeleteEntity_Click;
            // 
            // button2
            // 
            button2.Location = new Point(131, 22);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpdateEntity_Click;
            // 
            // btnCreateEntity
            // 
            btnCreateEntity.Location = new Point(18, 22);
            btnCreateEntity.Name = "btnCreateEntity";
            btnCreateEntity.Size = new Size(94, 29);
            btnCreateEntity.TabIndex = 0;
            btnCreateEntity.Text = "Crear";
            btnCreateEntity.UseVisualStyleBackColor = true;
            btnCreateEntity.Click += btnCreateEntity_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 99);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 132);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Reino";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 175);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Terreno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 270);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 1;
            label4.Text = "Dieta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 306);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 1;
            label5.Text = "Energia Maxima";
            // 
            // txtMaxEnergy
            // 
            txtMaxEnergy.Location = new Point(190, 299);
            txtMaxEnergy.Name = "txtMaxEnergy";
            txtMaxEnergy.Size = new Size(151, 27);
            txtMaxEnergy.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 342);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 1;
            label6.Text = "Vida Máxima";
            // 
            // txtMaxLife
            // 
            txtMaxLife.Location = new Point(190, 335);
            txtMaxLife.Name = "txtMaxLife";
            txtMaxLife.Size = new Size(151, 27);
            txtMaxLife.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 378);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 1;
            label7.Text = "Puntos de Ataque";
            // 
            // txtAttackPoints
            // 
            txtAttackPoints.Location = new Point(190, 371);
            txtAttackPoints.Name = "txtAttackPoints";
            txtAttackPoints.Size = new Size(151, 27);
            txtAttackPoints.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(42, 419);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 1;
            label8.Text = "Puntos Defensa";
            // 
            // txtDefensePoints
            // 
            txtDefensePoints.Location = new Point(190, 412);
            txtDefensePoints.Name = "txtDefensePoints";
            txtDefensePoints.Size = new Size(151, 27);
            txtDefensePoints.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 460);
            label9.Name = "label9";
            label9.Size = new Size(125, 20);
            label9.TabIndex = 1;
            label9.Text = "Rango de Ataque";
            // 
            // txtAttackRange
            // 
            txtAttackRange.Location = new Point(190, 453);
            txtAttackRange.Name = "txtAttackRange";
            txtAttackRange.Size = new Size(151, 27);
            txtAttackRange.TabIndex = 2;
            // 
            // cmbIKingdom
            // 
            cmbIKingdom.FormattingEnabled = true;
            cmbIKingdom.Location = new Point(190, 129);
            cmbIKingdom.Name = "cmbIKingdom";
            cmbIKingdom.Size = new Size(151, 28);
            cmbIKingdom.TabIndex = 3;
            // 
            // cmbIDiet
            // 
            cmbIDiet.FormattingEnabled = true;
            cmbIDiet.Location = new Point(190, 262);
            cmbIDiet.Name = "cmbIDiet";
            cmbIDiet.Size = new Size(151, 28);
            cmbIDiet.TabIndex = 3;
            // 
            // dgvEntity
            // 
            dgvEntity.BackgroundColor = SystemColors.ActiveCaption;
            dgvEntity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntity.GridColor = SystemColors.ActiveCaption;
            dgvEntity.Location = new Point(402, 92);
            dgvEntity.Name = "dgvEntity";
            dgvEntity.RowHeadersWidth = 51;
            dgvEntity.RowTemplate.DividerHeight = 1;
            dgvEntity.RowTemplate.Height = 29;
            dgvEntity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntity.Size = new Size(913, 329);
            dgvEntity.TabIndex = 4;
            dgvEntity.SelectionChanged += dgvEntity_SelectionChanged;
            // 
            // txtEntities
            // 
            txtEntities.Location = new Point(402, 35);
            txtEntities.Name = "txtEntities";
            txtEntities.Size = new Size(369, 27);
            txtEntities.TabIndex = 2;
            // 
            // chckListBoxEnvironment
            // 
            chckListBoxEnvironment.FormattingEnabled = true;
            chckListBoxEnvironment.Location = new Point(190, 175);
            chckListBoxEnvironment.Name = "chckListBoxEnvironment";
            chckListBoxEnvironment.Size = new Size(151, 70);
            chckListBoxEnvironment.TabIndex = 5;
            // 
            // EntityCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 539);
            Controls.Add(chckListBoxEnvironment);
            Controls.Add(dgvEntity);
            Controls.Add(cmbIDiet);
            Controls.Add(cmbIKingdom);
            Controls.Add(txtAttackRange);
            Controls.Add(label9);
            Controls.Add(txtDefensePoints);
            Controls.Add(label8);
            Controls.Add(txtAttackPoints);
            Controls.Add(label7);
            Controls.Add(txtMaxLife);
            Controls.Add(label6);
            Controls.Add(txtMaxEnergy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEntities);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EntityCRUD";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEntity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button btnCreateEntity;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaxEnergy;
        private Label label6;
        private TextBox txtMaxLife;
        private Label label7;
        private TextBox txtAttackPoints;
        private Label label8;
        private TextBox txtDefensePoints;
        private Label label9;
        private TextBox txtAttackRange;
        private ComboBox cmbIKingdom;
        private ComboBox cmbIDiet;
        private DataGridView dgvEntity;
        private TextBox txtEntities;
        private CheckedListBox chckListBoxEnvironment;
    }
}