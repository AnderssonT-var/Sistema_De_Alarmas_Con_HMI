
namespace Alarma_HMI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboBoxMinuto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxSirena = new System.Windows.Forms.ComboBox();
            this.BotonAñadir = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonBorrar = new System.Windows.Forms.Button();
            this.BotonAbrir = new System.Windows.Forms.Button();
            this.TextoUbicacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboPuertos = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LabelReloj = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxHora = new System.Windows.Forms.ComboBox();
            this.LabelAlarmas = new System.Windows.Forms.Label();
            this.LabelInfo = new System.Windows.Forms.Label();
            this.LabelAux = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxMinuto
            // 
            this.ComboBoxMinuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMinuto.FormattingEnabled = true;
            this.ComboBoxMinuto.Items.AddRange(new object[] {
            "",
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.ComboBoxMinuto.Location = new System.Drawing.Point(175, 46);
            this.ComboBoxMinuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxMinuto.Name = "ComboBoxMinuto";
            this.ComboBoxMinuto.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxMinuto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "MINUTOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "SIRENA";
            // 
            // ComboBoxSirena
            // 
            this.ComboBoxSirena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxSirena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSirena.FormattingEnabled = true;
            this.ComboBoxSirena.Items.AddRange(new object[] {
            "",
            "1) Escuela",
            "2) Colegio"});
            this.ComboBoxSirena.Location = new System.Drawing.Point(305, 46);
            this.ComboBoxSirena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxSirena.Name = "ComboBoxSirena";
            this.ComboBoxSirena.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxSirena.TabIndex = 8;
            // 
            // BotonAñadir
            // 
            this.BotonAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAñadir.Location = new System.Drawing.Point(479, 22);
            this.BotonAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonAñadir.Name = "BotonAñadir";
            this.BotonAñadir.Size = new System.Drawing.Size(125, 49);
            this.BotonAñadir.TabIndex = 10;
            this.BotonAñadir.Text = "AÑADIR";
            this.BotonAñadir.UseVisualStyleBackColor = true;
            this.BotonAñadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datos
            // 
            this.Datos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col2,
            this.Col3,
            this.Col4});
            this.Datos.Location = new System.Drawing.Point(21, 225);
            this.Datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datos.Name = "Datos";
            this.Datos.RowHeadersWidth = 51;
            this.Datos.RowTemplate.Height = 24;
            this.Datos.Size = new System.Drawing.Size(385, 334);
            this.Datos.TabIndex = 11;
            this.Datos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellClick);
            // 
            // Col2
            // 
            this.Col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col2.DefaultCellStyle = dataGridViewCellStyle10;
            this.Col2.HeaderText = "HORA";
            this.Col2.MinimumWidth = 6;
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Width = 75;
            // 
            // Col3
            // 
            this.Col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col3.DefaultCellStyle = dataGridViewCellStyle11;
            this.Col3.HeaderText = "MINUTOS";
            this.Col3.MinimumWidth = 6;
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 98;
            // 
            // Col4
            // 
            this.Col4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Col4.DefaultCellStyle = dataGridViewCellStyle12;
            this.Col4.HeaderText = "SIRENA";
            this.Col4.MinimumWidth = 6;
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            this.Col4.Width = 86;
            // 
            // BotonBorrar
            // 
            this.BotonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBorrar.Location = new System.Drawing.Point(458, 498);
            this.BotonBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonBorrar.Name = "BotonBorrar";
            this.BotonBorrar.Size = new System.Drawing.Size(125, 49);
            this.BotonBorrar.TabIndex = 12;
            this.BotonBorrar.Text = "BORRAR";
            this.BotonBorrar.UseVisualStyleBackColor = true;
            this.BotonBorrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonAbrir
            // 
            this.BotonAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAbrir.Location = new System.Drawing.Point(457, 21);
            this.BotonAbrir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonAbrir.Name = "BotonAbrir";
            this.BotonAbrir.Size = new System.Drawing.Size(125, 49);
            this.BotonAbrir.TabIndex = 13;
            this.BotonAbrir.Text = "ABRIR";
            this.BotonAbrir.UseVisualStyleBackColor = true;
            this.BotonAbrir.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextoUbicacion
            // 
            this.TextoUbicacion.Location = new System.Drawing.Point(149, 14);
            this.TextoUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.TextoUbicacion.Name = "TextoUbicacion";
            this.TextoUbicacion.Size = new System.Drawing.Size(285, 22);
            this.TextoUbicacion.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "UBICACION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "PUERTO: ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ComboPuertos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TextoUbicacion);
            this.panel1.Controls.Add(this.BotonAbrir);
            this.panel1.Location = new System.Drawing.Point(11, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 88);
            this.panel1.TabIndex = 18;
            // 
            // ComboPuertos
            // 
            this.ComboPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPuertos.FormattingEnabled = true;
            this.ComboPuertos.Items.AddRange(new object[] {
            "",
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.ComboPuertos.Location = new System.Drawing.Point(148, 48);
            this.ComboPuertos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboPuertos.Name = "ComboPuertos";
            this.ComboPuertos.Size = new System.Drawing.Size(123, 24);
            this.ComboPuertos.TabIndex = 18;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // LabelReloj
            // 
            this.LabelReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReloj.Location = new System.Drawing.Point(435, 225);
            this.LabelReloj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelReloj.Name = "LabelReloj";
            this.LabelReloj.Size = new System.Drawing.Size(161, 44);
            this.LabelReloj.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "HORA";
            // 
            // ComboBoxHora
            // 
            this.ComboBoxHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxHora.FormattingEnabled = true;
            this.ComboBoxHora.Items.AddRange(new object[] {
            "",
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.ComboBoxHora.Location = new System.Drawing.Point(46, 46);
            this.ComboBoxHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxHora.Name = "ComboBoxHora";
            this.ComboBoxHora.Size = new System.Drawing.Size(123, 24);
            this.ComboBoxHora.TabIndex = 1;
            // 
            // LabelAlarmas
            // 
            this.LabelAlarmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlarmas.Location = new System.Drawing.Point(18, 192);
            this.LabelAlarmas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAlarmas.Name = "LabelAlarmas";
            this.LabelAlarmas.Size = new System.Drawing.Size(388, 31);
            this.LabelAlarmas.TabIndex = 25;
            this.LabelAlarmas.Text = "TABLA DE ALARMAS INGRESADAS";
            // 
            // LabelInfo
            // 
            this.LabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfo.Location = new System.Drawing.Point(435, 303);
            this.LabelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInfo.Name = "LabelInfo";
            this.LabelInfo.Size = new System.Drawing.Size(161, 65);
            this.LabelInfo.TabIndex = 26;
            // 
            // LabelAux
            // 
            this.LabelAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAux.Location = new System.Drawing.Point(435, 386);
            this.LabelAux.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAux.Name = "LabelAux";
            this.LabelAux.Size = new System.Drawing.Size(161, 79);
            this.LabelAux.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LabelAlarmas);
            this.panel2.Controls.Add(this.LabelAux);
            this.panel2.Controls.Add(this.ComboBoxHora);
            this.panel2.Controls.Add(this.LabelInfo);
            this.panel2.Controls.Add(this.ComboBoxMinuto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.LabelReloj);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.ComboBoxSirena);
            this.panel2.Controls.Add(this.BotonBorrar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Datos);
            this.panel2.Controls.Add(this.BotonAñadir);
            this.panel2.Location = new System.Drawing.Point(511, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 578);
            this.panel2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "SISTEMA ANMI";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxMinuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxSirena;
        private System.Windows.Forms.Button BotonAñadir;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Button BotonBorrar;
        private System.Windows.Forms.Button BotonAbrir;
        private System.Windows.Forms.TextBox TextoUbicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox ComboPuertos;
        private System.Windows.Forms.Label LabelReloj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxHora;
        private System.Windows.Forms.Label LabelAlarmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.Label LabelInfo;
        private System.Windows.Forms.Label LabelAux;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

