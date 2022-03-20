
using System;

namespace Pokedex_C_Sharp
{
    partial class VentanaPrincipal
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
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.nombrePokemons = new System.Windows.Forms.Label();
            this.alturaPokemon = new System.Windows.Forms.Label();
            this.pesoPokemon = new System.Windows.Forms.Label();
            this.habilidadPokemon = new System.Windows.Forms.Label();
            this.especiePokemon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.movimiento2Pokemon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.Image = global::Pokedex_C_Sharp.Properties.Resources.pokedex1;
            this.left.Location = new System.Drawing.Point(236, 414);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(46, 37);
            this.left.TabIndex = 1;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.button1_Click);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.right.Cursor = System.Windows.Forms.Cursors.Default;
            this.right.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.right.Location = new System.Drawing.Point(288, 414);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(51, 37);
            this.right.TabIndex = 2;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // nombrePokemons
            // 
            this.nombrePokemons.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemons.ForeColor = System.Drawing.Color.Yellow;
            this.nombrePokemons.Location = new System.Drawing.Point(245, 9);
            this.nombrePokemons.Name = "nombrePokemons";
            this.nombrePokemons.Size = new System.Drawing.Size(200, 81);
            this.nombrePokemons.TabIndex = 4;
            this.nombrePokemons.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nombrePokemons.Click += new System.EventHandler(this.nombrePokemons_Click);
            // 
            // alturaPokemon
            // 
            this.alturaPokemon.BackColor = System.Drawing.Color.Black;
            this.alturaPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaPokemon.ForeColor = System.Drawing.Color.Yellow;
            this.alturaPokemon.Location = new System.Drawing.Point(407, 404);
            this.alturaPokemon.Name = "alturaPokemon";
            this.alturaPokemon.Size = new System.Drawing.Size(157, 79);
            this.alturaPokemon.TabIndex = 5;
            this.alturaPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alturaPokemon.Click += new System.EventHandler(this.alturaPokemon_Click);
            // 
            // pesoPokemon
            // 
            this.pesoPokemon.BackColor = System.Drawing.Color.Black;
            this.pesoPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoPokemon.ForeColor = System.Drawing.Color.Yellow;
            this.pesoPokemon.Location = new System.Drawing.Point(570, 404);
            this.pesoPokemon.Name = "pesoPokemon";
            this.pesoPokemon.Size = new System.Drawing.Size(152, 79);
            this.pesoPokemon.TabIndex = 7;
            this.pesoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pesoPokemon.Click += new System.EventHandler(this.pesoPokemon_Click);
            // 
            // habilidadPokemon
            // 
            this.habilidadPokemon.BackColor = System.Drawing.Color.Transparent;
            this.habilidadPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidadPokemon.Location = new System.Drawing.Point(476, 287);
            this.habilidadPokemon.Name = "habilidadPokemon";
            this.habilidadPokemon.Size = new System.Drawing.Size(147, 74);
            this.habilidadPokemon.TabIndex = 8;
            this.habilidadPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.habilidadPokemon.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // especiePokemon
            // 
            this.especiePokemon.BackColor = System.Drawing.Color.Transparent;
            this.especiePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especiePokemon.ForeColor = System.Drawing.Color.Yellow;
            this.especiePokemon.Location = new System.Drawing.Point(476, 164);
            this.especiePokemon.Name = "especiePokemon";
            this.especiePokemon.Size = new System.Drawing.Size(152, 30);
            this.especiePokemon.TabIndex = 9;
            this.especiePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.especiePokemon.Click += new System.EventHandler(this.especiePokemon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 17);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // movimiento2Pokemon
            // 
            this.movimiento2Pokemon.Location = new System.Drawing.Point(103, 389);
            this.movimiento2Pokemon.Name = "movimiento2Pokemon";
            this.movimiento2Pokemon.Size = new System.Drawing.Size(54, 17);
            this.movimiento2Pokemon.TabIndex = 11;
            this.movimiento2Pokemon.UseVisualStyleBackColor = true;
            this.movimiento2Pokemon.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 161);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pokedex_C_Sharp.Properties.Resources.pokedex1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 532);
            this.Controls.Add(this.movimiento2Pokemon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.especiePokemon);
            this.Controls.Add(this.habilidadPokemon);
            this.Controls.Add(this.pesoPokemon);
            this.Controls.Add(this.alturaPokemon);
            this.Controls.Add(this.nombrePokemons);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void nombrePokemons_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Label nombrePokemons;
        private System.Windows.Forms.Label alturaPokemon;
        private System.Windows.Forms.Label pesoPokemon;
        private System.Windows.Forms.Label habilidadPokemon;
        private System.Windows.Forms.Label especiePokemon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button movimiento2Pokemon;
    }
}

