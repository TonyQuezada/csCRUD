namespace ProyectoBases
{
    partial class FENAL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewGrid_bt = new System.Windows.Forms.Button();
            this.RFC_tx = new System.Windows.Forms.TextBox();
            this.Nombre_tx = new System.Windows.Forms.TextBox();
            this.Edad_tx = new System.Windows.Forms.TextBox();
            this.IdActividad_tx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Insertar_bt = new System.Windows.Forms.Button();
            this.Modificar_bt = new System.Windows.Forms.Button();
            this.borrar_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewGrid_bt
            // 
            this.ViewGrid_bt.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewGrid_bt.ForeColor = System.Drawing.Color.Black;
            this.ViewGrid_bt.Location = new System.Drawing.Point(631, 575);
            this.ViewGrid_bt.Name = "ViewGrid_bt";
            this.ViewGrid_bt.Size = new System.Drawing.Size(90, 33);
            this.ViewGrid_bt.TabIndex = 0;
            this.ViewGrid_bt.Text = "Ver";
            this.ViewGrid_bt.UseVisualStyleBackColor = true;
            this.ViewGrid_bt.Click += new System.EventHandler(this.ViewGrid_bt_Click);
            // 
            // RFC_tx
            // 
            this.RFC_tx.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFC_tx.Location = new System.Drawing.Point(836, 278);
            this.RFC_tx.Name = "RFC_tx";
            this.RFC_tx.Size = new System.Drawing.Size(100, 27);
            this.RFC_tx.TabIndex = 2;
            this.RFC_tx.TextChanged += new System.EventHandler(this.RFC_tx_TextChanged);
            // 
            // Nombre_tx
            // 
            this.Nombre_tx.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_tx.Location = new System.Drawing.Point(836, 343);
            this.Nombre_tx.Name = "Nombre_tx";
            this.Nombre_tx.Size = new System.Drawing.Size(100, 27);
            this.Nombre_tx.TabIndex = 3;
            this.Nombre_tx.TextChanged += new System.EventHandler(this.Nombre_tx_TextChanged);
            // 
            // Edad_tx
            // 
            this.Edad_tx.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad_tx.Location = new System.Drawing.Point(836, 408);
            this.Edad_tx.Name = "Edad_tx";
            this.Edad_tx.Size = new System.Drawing.Size(100, 27);
            this.Edad_tx.TabIndex = 4;
            this.Edad_tx.TextChanged += new System.EventHandler(this.Edad_tx_TextChanged);
            // 
            // IdActividad_tx
            // 
            this.IdActividad_tx.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdActividad_tx.Location = new System.Drawing.Point(836, 473);
            this.IdActividad_tx.Name = "IdActividad_tx";
            this.IdActividad_tx.Size = new System.Drawing.Size(100, 27);
            this.IdActividad_tx.TabIndex = 5;
            this.IdActividad_tx.TextChanged += new System.EventHandler(this.IdActividad_tx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(730, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(701, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(724, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(676, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID Actividad";
            // 
            // Insertar_bt
            // 
            this.Insertar_bt.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertar_bt.ForeColor = System.Drawing.Color.Black;
            this.Insertar_bt.Location = new System.Drawing.Point(738, 575);
            this.Insertar_bt.Name = "Insertar_bt";
            this.Insertar_bt.Size = new System.Drawing.Size(90, 33);
            this.Insertar_bt.TabIndex = 6;
            this.Insertar_bt.Text = "Insertar";
            this.Insertar_bt.UseVisualStyleBackColor = true;
            this.Insertar_bt.Click += new System.EventHandler(this.Insertar_bt_Click);
            // 
            // Modificar_bt
            // 
            this.Modificar_bt.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_bt.ForeColor = System.Drawing.Color.Black;
            this.Modificar_bt.Location = new System.Drawing.Point(845, 575);
            this.Modificar_bt.Name = "Modificar_bt";
            this.Modificar_bt.Size = new System.Drawing.Size(90, 33);
            this.Modificar_bt.TabIndex = 7;
            this.Modificar_bt.Text = "Modificar";
            this.Modificar_bt.UseVisualStyleBackColor = true;
            this.Modificar_bt.Click += new System.EventHandler(this.Modificar_bt_Click);
            // 
            // borrar_bt
            // 
            this.borrar_bt.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar_bt.ForeColor = System.Drawing.Color.Black;
            this.borrar_bt.Location = new System.Drawing.Point(952, 575);
            this.borrar_bt.Name = "borrar_bt";
            this.borrar_bt.Size = new System.Drawing.Size(90, 33);
            this.borrar_bt.TabIndex = 8;
            this.borrar_bt.Text = "Eliminar";
            this.borrar_bt.UseVisualStyleBackColor = true;
            this.borrar_bt.Click += new System.EventHandler(this.borrar_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Product Sans", 41.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = "FERIA NACIONAL DEL LIBRO DE LEÓN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Product Sans", 20F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(665, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "SISTEMA DE ALTAS Y BAJAS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Product Sans", 20F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(638, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 34);
            this.label7.TabIndex = 9;
            this.label7.Text = "PARA EL PERSONAL DE LA FERIA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(8)))), ((int)(((byte)(130)))));
            this.panel1.Location = new System.Drawing.Point(40, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 458);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FENAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(172)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1110, 636);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrar_bt);
            this.Controls.Add(this.Modificar_bt);
            this.Controls.Add(this.Insertar_bt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdActividad_tx);
            this.Controls.Add(this.Edad_tx);
            this.Controls.Add(this.Nombre_tx);
            this.Controls.Add(this.RFC_tx);
            this.Controls.Add(this.ViewGrid_bt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FENAL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ViewGrid_bt;
        private System.Windows.Forms.TextBox RFC_tx;
        private System.Windows.Forms.TextBox Nombre_tx;
        private System.Windows.Forms.TextBox Edad_tx;
        private System.Windows.Forms.TextBox IdActividad_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Insertar_bt;
        private System.Windows.Forms.Button Modificar_bt;
        private System.Windows.Forms.Button borrar_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}

