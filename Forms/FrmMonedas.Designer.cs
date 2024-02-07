namespace Forms
{
    partial class FrmMonedas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonedas));
            lblCotizacion = new Label();
            lblEuroFila = new Label();
            lblDolarFila = new Label();
            lblPesoFila = new Label();
            tBxCantEuro = new TextBox();
            tBxCantDolar = new TextBox();
            tBxCantPeso = new TextBox();
            btnLock = new Button();
            imgIconos = new ImageList(components);
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            tBxEuroPeso = new TextBox();
            tBxEuroDolar = new TextBox();
            tBxEuroEuro = new TextBox();
            tBxDolarPeso = new TextBox();
            tBxDolarDolar = new TextBox();
            tBxDolarEuro = new TextBox();
            tBxPesoPeso = new TextBox();
            tBxPesoDolar = new TextBox();
            tBxPesoEuro = new TextBox();
            lblEuroCol = new Label();
            lblDolarCol = new Label();
            lblPesoCol = new Label();
            tBxCotizPeso = new TextBox();
            tBxCotizDolar = new TextBox();
            tBxCotizEuro = new TextBox();
            SuspendLayout();
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCotizacion.Location = new Point(108, 12);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(93, 23);
            lblCotizacion.TabIndex = 0;
            lblCotizacion.Text = "Cotización";
            // 
            // lblEuroFila
            // 
            lblEuroFila.AutoSize = true;
            lblEuroFila.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEuroFila.Location = new Point(12, 76);
            lblEuroFila.Name = "lblEuroFila";
            lblEuroFila.Size = new Size(46, 23);
            lblEuroFila.TabIndex = 1;
            lblEuroFila.Text = "Euro";
            // 
            // lblDolarFila
            // 
            lblDolarFila.AutoSize = true;
            lblDolarFila.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDolarFila.Location = new Point(12, 119);
            lblDolarFila.Name = "lblDolarFila";
            lblDolarFila.Size = new Size(54, 23);
            lblDolarFila.TabIndex = 2;
            lblDolarFila.Text = "Dólar";
            // 
            // lblPesoFila
            // 
            lblPesoFila.AutoSize = true;
            lblPesoFila.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPesoFila.Location = new Point(12, 162);
            lblPesoFila.Name = "lblPesoFila";
            lblPesoFila.Size = new Size(45, 23);
            lblPesoFila.TabIndex = 3;
            lblPesoFila.Text = "Peso";
            // 
            // tBxCantEuro
            // 
            tBxCantEuro.Location = new Point(80, 75);
            tBxCantEuro.Name = "tBxCantEuro";
            tBxCantEuro.Size = new Size(110, 27);
            tBxCantEuro.TabIndex = 4;
            // 
            // tBxCantDolar
            // 
            tBxCantDolar.Location = new Point(80, 119);
            tBxCantDolar.Name = "tBxCantDolar";
            tBxCantDolar.Size = new Size(110, 27);
            tBxCantDolar.TabIndex = 5;
            // 
            // tBxCantPeso
            // 
            tBxCantPeso.Location = new Point(80, 162);
            tBxCantPeso.Name = "tBxCantPeso";
            tBxCantPeso.Size = new Size(110, 27);
            tBxCantPeso.TabIndex = 6;
            // 
            // btnLock
            // 
            btnLock.ImageIndex = 0;
            btnLock.ImageList = imgIconos;
            btnLock.Location = new Point(207, 10);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(104, 29);
            btnLock.TabIndex = 7;
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // imgIconos
            // 
            imgIconos.ColorDepth = ColorDepth.Depth32Bit;
            imgIconos.ImageStream = (ImageListStreamer)resources.GetObject("imgIconos.ImageStream");
            imgIconos.TransparentColor = Color.Transparent;
            imgIconos.Images.SetKeyName(0, "009.png");
            imgIconos.Images.SetKeyName(1, "010.png");
            imgIconos.Images.SetKeyName(2, "281.png");
            imgIconos.Images.SetKeyName(3, "276.png");
            imgIconos.Images.SetKeyName(4, "291.png");
            imgIconos.Images.SetKeyName(5, "286.png");
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.ImageIndex = 5;
            btnConvertEuro.ImageList = imgIconos;
            btnConvertEuro.Location = new Point(207, 75);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(104, 29);
            btnConvertEuro.TabIndex = 8;
            btnConvertEuro.UseVisualStyleBackColor = true;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.ImageIndex = 5;
            btnConvertDolar.ImageList = imgIconos;
            btnConvertDolar.Location = new Point(207, 119);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(104, 29);
            btnConvertDolar.TabIndex = 9;
            btnConvertDolar.UseVisualStyleBackColor = true;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.ImageIndex = 5;
            btnConvertPeso.ImageList = imgIconos;
            btnConvertPeso.Location = new Point(207, 162);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(104, 29);
            btnConvertPeso.TabIndex = 10;
            btnConvertPeso.UseVisualStyleBackColor = true;
            // 
            // tBxEuroPeso
            // 
            tBxEuroPeso.Location = new Point(329, 164);
            tBxEuroPeso.Name = "tBxEuroPeso";
            tBxEuroPeso.Size = new Size(147, 27);
            tBxEuroPeso.TabIndex = 13;
            // 
            // tBxEuroDolar
            // 
            tBxEuroDolar.Location = new Point(329, 121);
            tBxEuroDolar.Name = "tBxEuroDolar";
            tBxEuroDolar.Size = new Size(147, 27);
            tBxEuroDolar.TabIndex = 12;
            // 
            // tBxEuroEuro
            // 
            tBxEuroEuro.Location = new Point(329, 77);
            tBxEuroEuro.Name = "tBxEuroEuro";
            tBxEuroEuro.Size = new Size(147, 27);
            tBxEuroEuro.TabIndex = 11;
            // 
            // tBxDolarPeso
            // 
            tBxDolarPeso.Location = new Point(482, 164);
            tBxDolarPeso.Name = "tBxDolarPeso";
            tBxDolarPeso.Size = new Size(147, 27);
            tBxDolarPeso.TabIndex = 16;
            // 
            // tBxDolarDolar
            // 
            tBxDolarDolar.Location = new Point(482, 121);
            tBxDolarDolar.Name = "tBxDolarDolar";
            tBxDolarDolar.Size = new Size(147, 27);
            tBxDolarDolar.TabIndex = 15;
            // 
            // tBxDolarEuro
            // 
            tBxDolarEuro.Location = new Point(482, 77);
            tBxDolarEuro.Name = "tBxDolarEuro";
            tBxDolarEuro.Size = new Size(147, 27);
            tBxDolarEuro.TabIndex = 14;
            // 
            // tBxPesoPeso
            // 
            tBxPesoPeso.Location = new Point(635, 164);
            tBxPesoPeso.Name = "tBxPesoPeso";
            tBxPesoPeso.Size = new Size(147, 27);
            tBxPesoPeso.TabIndex = 19;
            // 
            // tBxPesoDolar
            // 
            tBxPesoDolar.Location = new Point(635, 121);
            tBxPesoDolar.Name = "tBxPesoDolar";
            tBxPesoDolar.Size = new Size(147, 27);
            tBxPesoDolar.TabIndex = 18;
            // 
            // tBxPesoEuro
            // 
            tBxPesoEuro.Location = new Point(635, 77);
            tBxPesoEuro.Name = "tBxPesoEuro";
            tBxPesoEuro.Size = new Size(147, 27);
            tBxPesoEuro.TabIndex = 17;
            // 
            // lblEuroCol
            // 
            lblEuroCol.AutoSize = true;
            lblEuroCol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEuroCol.Location = new Point(385, 51);
            lblEuroCol.Name = "lblEuroCol";
            lblEuroCol.Size = new Size(46, 23);
            lblEuroCol.TabIndex = 20;
            lblEuroCol.Text = "Euro";
            // 
            // lblDolarCol
            // 
            lblDolarCol.AutoSize = true;
            lblDolarCol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDolarCol.Location = new Point(527, 51);
            lblDolarCol.Name = "lblDolarCol";
            lblDolarCol.Size = new Size(54, 23);
            lblDolarCol.TabIndex = 21;
            lblDolarCol.Text = "Dólar";
            // 
            // lblPesoCol
            // 
            lblPesoCol.AutoSize = true;
            lblPesoCol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPesoCol.Location = new Point(684, 51);
            lblPesoCol.Name = "lblPesoCol";
            lblPesoCol.Size = new Size(45, 23);
            lblPesoCol.TabIndex = 22;
            lblPesoCol.Text = "Peso";
            // 
            // tBxCotizPeso
            // 
            tBxCotizPeso.Location = new Point(635, 12);
            tBxCotizPeso.Name = "tBxCotizPeso";
            tBxCotizPeso.Size = new Size(147, 27);
            tBxCotizPeso.TabIndex = 25;
            tBxCotizPeso.Leave += tBxCotizPeso_Leave;
            // 
            // tBxCotizDolar
            // 
            tBxCotizDolar.Location = new Point(482, 12);
            tBxCotizDolar.Name = "tBxCotizDolar";
            tBxCotizDolar.ReadOnly = true;
            tBxCotizDolar.Size = new Size(147, 27);
            tBxCotizDolar.TabIndex = 24;
            tBxCotizDolar.Text = "1";
            // 
            // tBxCotizEuro
            // 
            tBxCotizEuro.Location = new Point(329, 12);
            tBxCotizEuro.Name = "tBxCotizEuro";
            tBxCotizEuro.Size = new Size(147, 27);
            tBxCotizEuro.TabIndex = 23;
            tBxCotizEuro.Leave += tBxCotizEuro_Leave;
            // 
            // FrmMonedas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 203);
            Controls.Add(tBxCotizPeso);
            Controls.Add(tBxCotizDolar);
            Controls.Add(tBxCotizEuro);
            Controls.Add(lblPesoCol);
            Controls.Add(lblDolarCol);
            Controls.Add(lblEuroCol);
            Controls.Add(tBxPesoPeso);
            Controls.Add(tBxPesoDolar);
            Controls.Add(tBxPesoEuro);
            Controls.Add(tBxDolarPeso);
            Controls.Add(tBxDolarDolar);
            Controls.Add(tBxDolarEuro);
            Controls.Add(tBxEuroPeso);
            Controls.Add(tBxEuroDolar);
            Controls.Add(tBxEuroEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(btnLock);
            Controls.Add(tBxCantPeso);
            Controls.Add(tBxCantDolar);
            Controls.Add(tBxCantEuro);
            Controls.Add(lblPesoFila);
            Controls.Add(lblDolarFila);
            Controls.Add(lblEuroFila);
            Controls.Add(lblCotizacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMonedas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCotizacion;
        private Label lblEuroFila;
        private Label lblDolarFila;
        private Label lblPesoFila;
        private TextBox tBxCantEuro;
        private TextBox tBxCantDolar;
        private TextBox tBxCantPeso;
        private Button btnLock;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox tBxEuroPeso;
        private TextBox tBxEuroDolar;
        private TextBox tBxEuroEuro;
        private TextBox tBxDolarPeso;
        private TextBox tBxDolarDolar;
        private TextBox tBxDolarEuro;
        private TextBox tBxPesoPeso;
        private TextBox tBxPesoDolar;
        private TextBox tBxPesoEuro;
        private Label lblEuroCol;
        private Label lblDolarCol;
        private Label lblPesoCol;
        private TextBox tBxCotizPeso;
        private TextBox tBxCotizDolar;
        private TextBox tBxCotizEuro;
        private ImageList imgIconos;
    }
}
