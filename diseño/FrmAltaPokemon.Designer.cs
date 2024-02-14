namespace diseño
{
    partial class FrmAltaPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaPokemon));
            this.gbxPokemon = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDebilidad = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbxAltaPokemon = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxPokemon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPokemon
            // 
            this.gbxPokemon.Controls.Add(this.label2);
            this.gbxPokemon.Controls.Add(this.label1);
            this.gbxPokemon.Controls.Add(this.cbxDebilidad);
            this.gbxPokemon.Controls.Add(this.cbxTipo);
            this.gbxPokemon.Controls.Add(this.txtUrlImagen);
            this.gbxPokemon.Controls.Add(this.txtDescripcion);
            this.gbxPokemon.Controls.Add(this.txtNumero);
            this.gbxPokemon.Controls.Add(this.txtNombre);
            this.gbxPokemon.Controls.Add(this.lblUrlImagen);
            this.gbxPokemon.Controls.Add(this.lblDescripcion);
            this.gbxPokemon.Controls.Add(this.lblNumero);
            this.gbxPokemon.Controls.Add(this.lblNombre);
            this.gbxPokemon.Location = new System.Drawing.Point(12, 12);
            this.gbxPokemon.Name = "gbxPokemon";
            this.gbxPokemon.Size = new System.Drawing.Size(431, 196);
            this.gbxPokemon.TabIndex = 0;
            this.gbxPokemon.TabStop = false;
            this.gbxPokemon.Text = "POKEMON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DEBILIDAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TIPO";
            // 
            // cbxDebilidad
            // 
            this.cbxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDebilidad.FormattingEnabled = true;
            this.cbxDebilidad.Location = new System.Drawing.Point(242, 150);
            this.cbxDebilidad.Name = "cbxDebilidad";
            this.cbxDebilidad.Size = new System.Drawing.Size(168, 21);
            this.cbxDebilidad.TabIndex = 9;
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(43, 150);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(168, 21);
            this.cbxTipo.TabIndex = 8;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(242, 97);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(168, 20);
            this.txtUrlImagen.TabIndex = 7;
            
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(43, 97);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(168, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(242, 45);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(168, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(43, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(239, 81);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(71, 13);
            this.lblUrlImagen.TabIndex = 3;
            this.lblUrlImagen.Text = "URLIMAGEN";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(40, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(239, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "NUMERO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE";
            // 
            // pbxAltaPokemon
            // 
            this.pbxAltaPokemon.BackColor = System.Drawing.Color.White;
            this.pbxAltaPokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxAltaPokemon.BackgroundImage")));
            this.pbxAltaPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAltaPokemon.Location = new System.Drawing.Point(12, 214);
            this.pbxAltaPokemon.Name = "pbxAltaPokemon";
            this.pbxAltaPokemon.Size = new System.Drawing.Size(431, 281);
            this.pbxAltaPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltaPokemon.TabIndex = 1;
            this.pbxAltaPokemon.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(13, 501);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 33);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(290, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 548);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxAltaPokemon);
            this.Controls.Add(this.gbxPokemon);
            this.Name = "FrmAltaPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Pokemon";
            this.Load += new System.EventHandler(this.FrmAltaPokemon_Load);
            this.gbxPokemon.ResumeLayout(false);
            this.gbxPokemon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltaPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPokemon;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDebilidad;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.PictureBox pbxAltaPokemon;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}