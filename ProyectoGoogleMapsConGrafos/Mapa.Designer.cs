namespace ProyectoGoogleMapsConGrafos
{
    partial class Mapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapa));
            this.btnLlegar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtNombreVertice = new System.Windows.Forms.TextBox();
            this.lblNombreVertice = new System.Windows.Forms.Label();
            this.btnBucarVerice = new System.Windows.Forms.Button();
            this.textDatosVerticeBuscado = new System.Windows.Forms.RichTextBox();
            this.btnIrVerticer = new System.Windows.Forms.Button();
            this.btnCerraApp = new System.Windows.Forms.Button();
            this.btnVerVerticesAdyacentes = new System.Windows.Forms.Button();
            this.btnVerArco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlegar
            // 
            this.btnLlegar.BackColor = System.Drawing.Color.Orange;
            this.btnLlegar.FlatAppearance.BorderSize = 0;
            this.btnLlegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlegar.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlegar.ForeColor = System.Drawing.Color.Snow;
            this.btnLlegar.Location = new System.Drawing.Point(6, 421);
            this.btnLlegar.Name = "btnLlegar";
            this.btnLlegar.Size = new System.Drawing.Size(252, 40);
            this.btnLlegar.TabIndex = 7;
            this.btnLlegar.Text = "Camino corto";
            this.btnLlegar.UseVisualStyleBackColor = false;
            this.btnLlegar.Click += new System.EventHandler(this.btnLlegar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Orange;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(266, -1);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(641, 505);
            this.gMapControl1.TabIndex = 16;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.Load += new System.EventHandler(this.GMapControl1_Load);
            // 
            // txtNombreVertice
            // 
            this.txtNombreVertice.Location = new System.Drawing.Point(6, 31);
            this.txtNombreVertice.Name = "txtNombreVertice";
            this.txtNombreVertice.Size = new System.Drawing.Size(254, 20);
            this.txtNombreVertice.TabIndex = 18;
            // 
            // lblNombreVertice
            // 
            this.lblNombreVertice.AutoSize = true;
            this.lblNombreVertice.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVertice.Location = new System.Drawing.Point(2, 9);
            this.lblNombreVertice.Name = "lblNombreVertice";
            this.lblNombreVertice.Size = new System.Drawing.Size(129, 19);
            this.lblNombreVertice.TabIndex = 19;
            this.lblNombreVertice.Text = "Ingrese el vertice:";
            this.lblNombreVertice.Click += new System.EventHandler(this.LblNombreVertice_Click);
            // 
            // btnBucarVerice
            // 
            this.btnBucarVerice.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBucarVerice.FlatAppearance.BorderSize = 0;
            this.btnBucarVerice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBucarVerice.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBucarVerice.ForeColor = System.Drawing.Color.Snow;
            this.btnBucarVerice.Location = new System.Drawing.Point(133, 57);
            this.btnBucarVerice.Name = "btnBucarVerice";
            this.btnBucarVerice.Size = new System.Drawing.Size(125, 76);
            this.btnBucarVerice.TabIndex = 20;
            this.btnBucarVerice.Text = "Buscar Vertice";
            this.btnBucarVerice.UseVisualStyleBackColor = false;
            this.btnBucarVerice.Click += new System.EventHandler(this.btnBucarVerice_Click);
            // 
            // textDatosVerticeBuscado
            // 
            this.textDatosVerticeBuscado.BackColor = System.Drawing.SystemColors.Control;
            this.textDatosVerticeBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDatosVerticeBuscado.ForeColor = System.Drawing.Color.Orange;
            this.textDatosVerticeBuscado.Location = new System.Drawing.Point(6, 139);
            this.textDatosVerticeBuscado.Name = "textDatosVerticeBuscado";
            this.textDatosVerticeBuscado.Size = new System.Drawing.Size(252, 169);
            this.textDatosVerticeBuscado.TabIndex = 21;
            this.textDatosVerticeBuscado.Text = "";
            // 
            // btnIrVerticer
            // 
            this.btnIrVerticer.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnIrVerticer.FlatAppearance.BorderSize = 0;
            this.btnIrVerticer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrVerticer.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrVerticer.ForeColor = System.Drawing.Color.Snow;
            this.btnIrVerticer.Location = new System.Drawing.Point(5, 57);
            this.btnIrVerticer.Name = "btnIrVerticer";
            this.btnIrVerticer.Size = new System.Drawing.Size(124, 76);
            this.btnIrVerticer.TabIndex = 22;
            this.btnIrVerticer.Text = "Ver vertice";
            this.btnIrVerticer.UseVisualStyleBackColor = false;
            this.btnIrVerticer.Click += new System.EventHandler(this.btnIrVerticer_Click);
            // 
            // btnCerraApp
            // 
            this.btnCerraApp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCerraApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerraApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerraApp.ForeColor = System.Drawing.Color.White;
            this.btnCerraApp.Location = new System.Drawing.Point(6, 467);
            this.btnCerraApp.Name = "btnCerraApp";
            this.btnCerraApp.Size = new System.Drawing.Size(252, 37);
            this.btnCerraApp.TabIndex = 23;
            this.btnCerraApp.Text = "Salir";
            this.btnCerraApp.UseVisualStyleBackColor = false;
            this.btnCerraApp.Click += new System.EventHandler(this.btnCerraApp_Click);
            // 
            // btnVerVerticesAdyacentes
            // 
            this.btnVerVerticesAdyacentes.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVerVerticesAdyacentes.FlatAppearance.BorderSize = 0;
            this.btnVerVerticesAdyacentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerVerticesAdyacentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerVerticesAdyacentes.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVerticesAdyacentes.ForeColor = System.Drawing.Color.Snow;
            this.btnVerVerticesAdyacentes.Location = new System.Drawing.Point(4, 314);
            this.btnVerVerticesAdyacentes.Name = "btnVerVerticesAdyacentes";
            this.btnVerVerticesAdyacentes.Size = new System.Drawing.Size(125, 101);
            this.btnVerVerticesAdyacentes.TabIndex = 24;
            this.btnVerVerticesAdyacentes.Text = "Vertices Adyacentes";
            this.btnVerVerticesAdyacentes.UseVisualStyleBackColor = false;
            this.btnVerVerticesAdyacentes.Click += new System.EventHandler(this.btnVerVerticesAdyacentes_Click);
            this.btnVerVerticesAdyacentes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnVerVerticesAdyacentes_MouseMove);
            // 
            // btnVerArco
            // 
            this.btnVerArco.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVerArco.FlatAppearance.BorderSize = 0;
            this.btnVerArco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArco.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArco.ForeColor = System.Drawing.Color.Snow;
            this.btnVerArco.Location = new System.Drawing.Point(134, 314);
            this.btnVerArco.Name = "btnVerArco";
            this.btnVerArco.Size = new System.Drawing.Size(124, 101);
            this.btnVerArco.TabIndex = 25;
            this.btnVerArco.Text = "Ver Arco";
            this.btnVerArco.UseVisualStyleBackColor = false;
            this.btnVerArco.Click += new System.EventHandler(this.btnVerArco_Click);
            // 
            // Mapa
            // 
            this.AllowDrop = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(906, 509);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerArco);
            this.Controls.Add(this.btnVerVerticesAdyacentes);
            this.Controls.Add(this.btnCerraApp);
            this.Controls.Add(this.btnIrVerticer);
            this.Controls.Add(this.textDatosVerticeBuscado);
            this.Controls.Add(this.btnBucarVerice);
            this.Controls.Add(this.lblNombreVertice);
            this.Controls.Add(this.txtNombreVertice);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLlegar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLlegar;
        private System.Windows.Forms.Label label2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.TextBox txtNombreVertice;
        private System.Windows.Forms.Label lblNombreVertice;
        private System.Windows.Forms.Button btnBucarVerice;
        private System.Windows.Forms.RichTextBox textDatosVerticeBuscado;
        private System.Windows.Forms.Button btnIrVerticer;
        private System.Windows.Forms.Button btnCerraApp;
        private System.Windows.Forms.Button btnVerVerticesAdyacentes;
        private System.Windows.Forms.Button btnVerArco;
    }
}

