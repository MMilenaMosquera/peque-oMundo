namespace pequeñoMundo.UI
{
    partial class Fight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            txtPayer1 = new TextBox();
            label1 = new Label();
            pgbEnergyPlayer1 = new ProgressBar();
            pgbLifePlayer1 = new ProgressBar();
            pgbAttackPointsPlayer1 = new ProgressBar();
            label2 = new Label();
            pgbEnergyPlayer2 = new ProgressBar();
            pgbLifePlayer2 = new ProgressBar();
            pgbAttackPointsPlayer2 = new ProgressBar();
            btnAtacar = new Button();
            pgbDefencePointsPlayer1 = new ProgressBar();
            pgbDefencePointsPlayer2 = new ProgressBar();
            cmbPayer2 = new ComboBox();
            lblLife = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbItem = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            txtEnvioronment = new TextBox();
            txtDiet = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txtPayer1
            // 
            txtPayer1.Location = new Point(29, 63);
            txtPayer1.Name = "txtPayer1";
            txtPayer1.Size = new Size(165, 27);
            txtPayer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Jugador 1";
            // 
            // pgbEnergyPlayer1
            // 
            pgbEnergyPlayer1.Location = new Point(29, 164);
            pgbEnergyPlayer1.Name = "pgbEnergyPlayer1";
            pgbEnergyPlayer1.Size = new Size(125, 29);
            pgbEnergyPlayer1.TabIndex = 2;
            // 
            // pgbLifePlayer1
            // 
            pgbLifePlayer1.Location = new Point(29, 111);
            pgbLifePlayer1.Name = "pgbLifePlayer1";
            pgbLifePlayer1.Size = new Size(125, 29);
            pgbLifePlayer1.TabIndex = 2;
            pgbLifePlayer1.MouseHover += pgbLifePlayer1_MouseHover;
            // 
            // pgbAttackPointsPlayer1
            // 
            pgbAttackPointsPlayer1.Location = new Point(29, 228);
            pgbAttackPointsPlayer1.Name = "pgbAttackPointsPlayer1";
            pgbAttackPointsPlayer1.Size = new Size(125, 29);
            pgbAttackPointsPlayer1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(695, 29);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Jugador 2";
            // 
            // pgbEnergyPlayer2
            // 
            pgbEnergyPlayer2.Location = new Point(644, 164);
            pgbEnergyPlayer2.Name = "pgbEnergyPlayer2";
            pgbEnergyPlayer2.Size = new Size(125, 29);
            pgbEnergyPlayer2.TabIndex = 2;
            // 
            // pgbLifePlayer2
            // 
            pgbLifePlayer2.Location = new Point(644, 111);
            pgbLifePlayer2.Name = "pgbLifePlayer2";
            pgbLifePlayer2.Size = new Size(125, 29);
            pgbLifePlayer2.TabIndex = 2;
            // 
            // pgbAttackPointsPlayer2
            // 
            pgbAttackPointsPlayer2.Location = new Point(644, 225);
            pgbAttackPointsPlayer2.Name = "pgbAttackPointsPlayer2";
            pgbAttackPointsPlayer2.Size = new Size(125, 29);
            pgbAttackPointsPlayer2.TabIndex = 2;
            // 
            // btnAtacar
            // 
            btnAtacar.Location = new Point(325, 430);
            btnAtacar.Name = "btnAtacar";
            btnAtacar.Size = new Size(94, 29);
            btnAtacar.TabIndex = 3;
            btnAtacar.Text = "ATACAR";
            btnAtacar.UseVisualStyleBackColor = true;
            btnAtacar.Click += btnPelea;
            // 
            // pgbDefencePointsPlayer1
            // 
            pgbDefencePointsPlayer1.Location = new Point(29, 278);
            pgbDefencePointsPlayer1.Name = "pgbDefencePointsPlayer1";
            pgbDefencePointsPlayer1.Size = new Size(125, 29);
            pgbDefencePointsPlayer1.TabIndex = 2;
            // 
            // pgbDefencePointsPlayer2
            // 
            pgbDefencePointsPlayer2.Location = new Point(644, 278);
            pgbDefencePointsPlayer2.Name = "pgbDefencePointsPlayer2";
            pgbDefencePointsPlayer2.Size = new Size(125, 29);
            pgbDefencePointsPlayer2.TabIndex = 2;
            // 
            // cmbPayer2
            // 
            cmbPayer2.FormattingEnabled = true;
            cmbPayer2.Location = new Point(618, 62);
            cmbPayer2.Name = "cmbPayer2";
            cmbPayer2.Size = new Size(151, 28);
            cmbPayer2.TabIndex = 4;
            cmbPayer2.SelectedIndexChanged += cmbPayer2_SelectedIndexChanged;
            // 
            // lblLife
            // 
            lblLife.AutoSize = true;
            lblLife.Location = new Point(325, 120);
            lblLife.Name = "lblLife";
            lblLife.Size = new Size(39, 20);
            lblLife.TabIndex = 5;
            lblLife.Text = "Vida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 173);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 5;
            label4.Text = "Energia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 234);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 5;
            label5.Text = "Ataque";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 287);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Defensa";
            // 
            // cmbItem
            // 
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(119, 485);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(151, 28);
            cmbItem.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(9, 484);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Interactuar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 324);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // txtEnvioronment
            // 
            txtEnvioronment.Location = new Point(29, 324);
            txtEnvioronment.Name = "txtEnvioronment";
            txtEnvioronment.Size = new Size(125, 27);
            txtEnvioronment.TabIndex = 9;
            // 
            // txtDiet
            // 
            txtDiet.Location = new Point(29, 370);
            txtDiet.Name = "txtDiet";
            txtDiet.Size = new Size(125, 27);
            txtDiet.TabIndex = 10;
            // 
            // Fight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 581);
            Controls.Add(txtDiet);
            Controls.Add(txtEnvioronment);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(cmbItem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblLife);
            Controls.Add(cmbPayer2);
            Controls.Add(btnAtacar);
            Controls.Add(pgbDefencePointsPlayer2);
            Controls.Add(pgbAttackPointsPlayer2);
            Controls.Add(pgbLifePlayer2);
            Controls.Add(pgbDefencePointsPlayer1);
            Controls.Add(pgbAttackPointsPlayer1);
            Controls.Add(pgbEnergyPlayer2);
            Controls.Add(pgbLifePlayer1);
            Controls.Add(label2);
            Controls.Add(pgbEnergyPlayer1);
            Controls.Add(label1);
            Controls.Add(txtPayer1);
            Name = "Fight";
            Text = "Fight";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TextBox txtPayer1;
        private Label label1;
        private ProgressBar pgbEnergyPlayer1;
        private ProgressBar pgbLifePlayer1;
        private ProgressBar pgbAttackPointsPlayer1;
        private Label label2;
        private ProgressBar pgbEnergyPlayer2;
        private ProgressBar pgbLifePlayer2;
        private ProgressBar pgbAttackPointsPlayer2;
        private Button btnAtacar;
        private ProgressBar pgbDefencePointsPlayer1;
        private ProgressBar pgbDefencePointsPlayer2;
        private ComboBox cmbPayer2;
        private Label lblLife;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbItem;
        private Button button1;
        private Label label3;
        private TextBox txtEnvioronment;
        private TextBox txtDiet;
    }
}