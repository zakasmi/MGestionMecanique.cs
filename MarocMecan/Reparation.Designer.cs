namespace MarocMecan
{
    partial class Reparation
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
            this.BTN_Rechercher = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Ajouter_Reparation = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.DGV1_Reparation = new System.Windows.Forms.DataGridView();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.List_ID_Materiel = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_Date_Retour_Reparation = new System.Windows.Forms.DateTimePicker();
            this.DTP_Dtae_Envoie_Reparation = new System.Windows.Forms.DateTimePicker();
            this.TB_Id_Preparation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_id_piece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Montant_Reparation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_id_materiel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Observation_Reparation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Afficher_2date = new System.Windows.Forms.Button();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_ExportHTMl = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1_Reparation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Rechercher
            // 
            this.BTN_Rechercher.Location = new System.Drawing.Point(384, 202);
            this.BTN_Rechercher.Name = "BTN_Rechercher";
            this.BTN_Rechercher.Size = new System.Drawing.Size(92, 23);
            this.BTN_Rechercher.TabIndex = 2;
            this.BTN_Rechercher.Text = "Rechercher";
            this.BTN_Rechercher.UseVisualStyleBackColor = true;
            this.BTN_Rechercher.Click += new System.EventHandler(this.BTN_Rechercher_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(148, 202);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(92, 23);
            this.BTN_Supprimer.TabIndex = 3;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Ajouter_Reparation
            // 
            this.BTN_Ajouter_Reparation.Location = new System.Drawing.Point(30, 202);
            this.BTN_Ajouter_Reparation.Name = "BTN_Ajouter_Reparation";
            this.BTN_Ajouter_Reparation.Size = new System.Drawing.Size(92, 23);
            this.BTN_Ajouter_Reparation.TabIndex = 4;
            this.BTN_Ajouter_Reparation.Text = "Ajouter";
            this.BTN_Ajouter_Reparation.UseVisualStyleBackColor = true;
            this.BTN_Ajouter_Reparation.Click += new System.EventHandler(this.BTN_Ajouter_Reparation_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(266, 202);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(92, 23);
            this.BTN_Modifier.TabIndex = 2;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // DGV1_Reparation
            // 
            this.DGV1_Reparation.AllowUserToAddRows = false;
            this.DGV1_Reparation.AllowUserToDeleteRows = false;
            this.DGV1_Reparation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1_Reparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1_Reparation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV1_Reparation.Location = new System.Drawing.Point(0, 516);
            this.DGV1_Reparation.Name = "DGV1_Reparation";
            this.DGV1_Reparation.ReadOnly = true;
            this.DGV1_Reparation.Size = new System.Drawing.Size(878, 146);
            this.DGV1_Reparation.TabIndex = 5;
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Location = new System.Drawing.Point(7, 318);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(92, 23);
            this.BTN_Debut.TabIndex = 4;
            this.BTN_Debut.Text = "<<";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Location = new System.Drawing.Point(129, 318);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(92, 23);
            this.BTN_Suivant.TabIndex = 4;
            this.BTN_Suivant.Text = ">";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // List_ID_Materiel
            // 
            this.List_ID_Materiel.FormattingEnabled = true;
            this.List_ID_Materiel.Location = new System.Drawing.Point(701, 26);
            this.List_ID_Materiel.Name = "List_ID_Materiel";
            this.List_ID_Materiel.Size = new System.Drawing.Size(137, 199);
            this.List_ID_Materiel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DTP_Date_Retour_Reparation);
            this.groupBox1.Controls.Add(this.DTP_Dtae_Envoie_Reparation);
            this.groupBox1.Controls.Add(this.TB_Id_Preparation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TB_id_piece);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Montant_Reparation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TB_id_materiel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TB_Observation_Reparation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DTP_Date_Retour_Reparation
            // 
            this.DTP_Date_Retour_Reparation.CustomFormat = "dd-MM-yyyy";
            this.DTP_Date_Retour_Reparation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Date_Retour_Reparation.Location = new System.Drawing.Point(473, 17);
            this.DTP_Date_Retour_Reparation.Name = "DTP_Date_Retour_Reparation";
            this.DTP_Date_Retour_Reparation.Size = new System.Drawing.Size(113, 20);
            this.DTP_Date_Retour_Reparation.TabIndex = 4;
            // 
            // DTP_Dtae_Envoie_Reparation
            // 
            this.DTP_Dtae_Envoie_Reparation.CustomFormat = "dd-MM-yyyy";
            this.DTP_Dtae_Envoie_Reparation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_Dtae_Envoie_Reparation.Location = new System.Drawing.Point(149, 123);
            this.DTP_Dtae_Envoie_Reparation.Name = "DTP_Dtae_Envoie_Reparation";
            this.DTP_Dtae_Envoie_Reparation.Size = new System.Drawing.Size(136, 20);
            this.DTP_Dtae_Envoie_Reparation.TabIndex = 4;
            this.DTP_Dtae_Envoie_Reparation.Value = new System.DateTime(2017, 5, 9, 1, 42, 9, 0);
            // 
            // TB_Id_Preparation
            // 
            this.TB_Id_Preparation.Location = new System.Drawing.Point(122, 17);
            this.TB_Id_Preparation.Name = "TB_Id_Preparation";
            this.TB_Id_Preparation.Size = new System.Drawing.Size(121, 20);
            this.TB_Id_Preparation.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dtae Envoie Reparation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Montant Reparation";
            // 
            // TB_id_piece
            // 
            this.TB_id_piece.Location = new System.Drawing.Point(122, 52);
            this.TB_id_piece.Name = "TB_id_piece";
            this.TB_id_piece.Size = new System.Drawing.Size(121, 20);
            this.TB_id_piece.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "id piece";
            // 
            // TB_Montant_Reparation
            // 
            this.TB_Montant_Reparation.Location = new System.Drawing.Point(473, 52);
            this.TB_Montant_Reparation.Name = "TB_Montant_Reparation";
            this.TB_Montant_Reparation.Size = new System.Drawing.Size(121, 20);
            this.TB_Montant_Reparation.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Observation Reparation";
            // 
            // TB_id_materiel
            // 
            this.TB_id_materiel.Location = new System.Drawing.Point(122, 88);
            this.TB_id_materiel.Name = "TB_id_materiel";
            this.TB_id_materiel.Size = new System.Drawing.Size(121, 20);
            this.TB_id_materiel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date Retour Reparation";
            // 
            // TB_Observation_Reparation
            // 
            this.TB_Observation_Reparation.Location = new System.Drawing.Point(473, 88);
            this.TB_Observation_Reparation.Name = "TB_Observation_Reparation";
            this.TB_Observation_Reparation.Size = new System.Drawing.Size(121, 20);
            this.TB_Observation_Reparation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Reparation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suivant";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Afficher_2date
            // 
            this.Afficher_2date.Location = new System.Drawing.Point(329, 255);
            this.Afficher_2date.Name = "Afficher_2date";
            this.Afficher_2date.Size = new System.Drawing.Size(171, 23);
            this.Afficher_2date.TabIndex = 2;
            this.Afficher_2date.Text = "Afficher Reparation Entre 2 date";
            this.Afficher_2date.UseVisualStyleBackColor = true;
            this.Afficher_2date.Click += new System.EventHandler(this.Afficher_2date_Click);
            // 
            // DTP2
            // 
            this.DTP2.CustomFormat = "dd-MM-yyyy";
            this.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP2.Location = new System.Drawing.Point(186, 258);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(113, 20);
            this.DTP2.TabIndex = 8;
            // 
            // DTP1
            // 
            this.DTP1.CustomFormat = "dd-MM-yyyy";
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP1.Location = new System.Drawing.Point(20, 258);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(136, 20);
            this.DTP1.TabIndex = 9;
            this.DTP1.Value = new System.DateTime(2017, 5, 9, 1, 42, 9, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Histogramme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Premier";
            // 
            // BTN_ExportHTMl
            // 
            this.BTN_ExportHTMl.Location = new System.Drawing.Point(533, 324);
            this.BTN_ExportHTMl.Name = "BTN_ExportHTMl";
            this.BTN_ExportHTMl.Size = new System.Drawing.Size(142, 23);
            this.BTN_ExportHTMl.TabIndex = 2;
            this.BTN_ExportHTMl.Text = "Export HTML";
            this.BTN_ExportHTMl.UseVisualStyleBackColor = true;
            this.BTN_ExportHTMl.Click += new System.EventHandler(this.BTN_ExportHTMl_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(514, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Afficher Reparation Entre 2 date";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 360);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(878, 150);
            this.crystalReportViewer1.TabIndex = 10;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Reparation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 662);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.DTP2);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.List_ID_Materiel);
            this.Controls.Add(this.DGV1_Reparation);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_ExportHTMl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Afficher_2date);
            this.Controls.Add(this.BTN_Rechercher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.BTN_Ajouter_Reparation);
            this.Name = "Reparation";
            this.Text = "Reparation";
            this.Load += new System.EventHandler(this.Reparation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1_Reparation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Rechercher;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Ajouter_Reparation;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.DataGridView DGV1_Reparation;
        private System.Windows.Forms.Button BTN_Debut;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.ListBox List_ID_Materiel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_Id_Preparation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_id_piece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Montant_Reparation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_id_materiel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Observation_Reparation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_Date_Retour_Reparation;
        private System.Windows.Forms.DateTimePicker DTP_Dtae_Envoie_Reparation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Afficher_2date;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_ExportHTMl;
        private System.Windows.Forms.Button button3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}