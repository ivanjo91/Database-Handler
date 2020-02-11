namespace BD_FT_FB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearFT = new System.Windows.Forms.Button();
            this.btnInsertBDFT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.txbBD = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnCargarBD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLanzarSql = new System.Windows.Forms.Button();
            this.txbLanzarSql = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearFT
            // 
            this.btnCrearFT.Location = new System.Drawing.Point(12, 26);
            this.btnCrearFT.Name = "btnCrearFT";
            this.btnCrearFT.Size = new System.Drawing.Size(75, 23);
            this.btnCrearFT.TabIndex = 0;
            this.btnCrearFT.Text = "BD --> FT";
            this.btnCrearFT.UseVisualStyleBackColor = true;
            this.btnCrearFT.Click += new System.EventHandler(this.btnCrearFT_Click);
            // 
            // btnInsertBDFT
            // 
            this.btnInsertBDFT.Location = new System.Drawing.Point(12, 81);
            this.btnInsertBDFT.Name = "btnInsertBDFT";
            this.btnInsertBDFT.Size = new System.Drawing.Size(75, 23);
            this.btnInsertBDFT.TabIndex = 1;
            this.btnInsertBDFT.Text = "FT --> BD";
            this.btnInsertBDFT.UseVisualStyleBackColor = true;
            this.btnInsertBDFT.Click += new System.EventHandler(this.btnInsertBDFT_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(271, 147);
            this.dataGridView1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "fichero de texto|*txt";
            this.openFileDialog1.Title = "Copia de seguridad";
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(318, 26);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(119, 22);
            this.btnMostrarTodo.TabIndex = 7;
            this.btnMostrarTodo.Text = "Mostrar Toda la BD";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(461, 26);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(100, 20);
            this.txbServer.TabIndex = 8;
            // 
            // txbBD
            // 
            this.txbBD.Location = new System.Drawing.Point(567, 26);
            this.txbBD.Name = "txbBD";
            this.txbBD.Size = new System.Drawing.Size(100, 20);
            this.txbBD.TabIndex = 9;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(673, 26);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(100, 20);
            this.txbUser.TabIndex = 10;
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(779, 26);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(100, 20);
            this.txbPass.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "BD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(421, 133);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 206);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(697, 133);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(248, 206);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 403);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(144, 442);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // btnCargarBD
            // 
            this.btnCargarBD.Location = new System.Drawing.Point(275, 316);
            this.btnCargarBD.Name = "btnCargarBD";
            this.btnCargarBD.Size = new System.Drawing.Size(75, 23);
            this.btnCargarBD.TabIndex = 22;
            this.btnCargarBD.Text = "Cargar BD";
            this.btnCargarBD.UseVisualStyleBackColor = true;
            this.btnCargarBD.Click += new System.EventHandler(this.btnCargarBD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "BD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password";
            // 
            // btnLanzarSql
            // 
            this.btnLanzarSql.Location = new System.Drawing.Point(318, 80);
            this.btnLanzarSql.Name = "btnLanzarSql";
            this.btnLanzarSql.Size = new System.Drawing.Size(119, 23);
            this.btnLanzarSql.TabIndex = 27;
            this.btnLanzarSql.Text = "Lanzador SQL";
            this.btnLanzarSql.UseVisualStyleBackColor = true;
            this.btnLanzarSql.Click += new System.EventHandler(this.btnLanzarSql_Click);
            // 
            // txbLanzarSql
            // 
            this.txbLanzarSql.Location = new System.Drawing.Point(461, 83);
            this.txbLanzarSql.Name = "txbLanzarSql";
            this.txbLanzarSql.Size = new System.Drawing.Size(418, 20);
            this.txbLanzarSql.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 508);
            this.Controls.Add(this.txbLanzarSql);
            this.Controls.Add(this.btnLanzarSql);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCargarBD);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.txbBD);
            this.Controls.Add(this.txbServer);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnInsertBDFT);
            this.Controls.Add(this.btnCrearFT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearFT;
        private System.Windows.Forms.Button btnInsertBDFT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.TextBox txbBD;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnCargarBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLanzarSql;
        private System.Windows.Forms.TextBox txbLanzarSql;
    }
}

