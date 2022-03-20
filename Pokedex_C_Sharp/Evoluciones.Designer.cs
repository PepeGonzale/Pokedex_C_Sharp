
namespace Pokedex_C_Sharp
{
    partial class Evoluciones
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
            this.movimiento2Pokemon = new System.Windows.Forms.Label();
            this.movimiento1Pokemon = new System.Windows.Forms.Label();
            this.habitatPokemon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movimiento2Pokemon
            // 
            this.movimiento2Pokemon.BackColor = System.Drawing.Color.Transparent;
            this.movimiento2Pokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento2Pokemon.Location = new System.Drawing.Point(477, 73);
            this.movimiento2Pokemon.Name = "movimiento2Pokemon";
            this.movimiento2Pokemon.Size = new System.Drawing.Size(243, 106);
            this.movimiento2Pokemon.TabIndex = 0;
            this.movimiento2Pokemon.Click += new System.EventHandler(this.label1_Click);
            // 
            // movimiento1Pokemon
            // 
            this.movimiento1Pokemon.BackColor = System.Drawing.Color.Transparent;
            this.movimiento1Pokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento1Pokemon.Location = new System.Drawing.Point(115, 73);
            this.movimiento1Pokemon.Name = "movimiento1Pokemon";
            this.movimiento1Pokemon.Size = new System.Drawing.Size(224, 106);
            this.movimiento1Pokemon.TabIndex = 1;
            this.movimiento1Pokemon.Click += new System.EventHandler(this.label2_Click);
            // 
            // habitatPokemon
            // 
            this.habitatPokemon.BackColor = System.Drawing.Color.Transparent;
            this.habitatPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitatPokemon.Location = new System.Drawing.Point(295, 350);
            this.habitatPokemon.Name = "habitatPokemon";
            this.habitatPokemon.Size = new System.Drawing.Size(210, 76);
            this.habitatPokemon.TabIndex = 2;
            // 
            // Evoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pokedex_C_Sharp.Properties.Resources.fondoo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.habitatPokemon);
            this.Controls.Add(this.movimiento1Pokemon);
            this.Controls.Add(this.movimiento2Pokemon);
            this.Name = "Evoluciones";
            this.Text = "Evoluciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label movimiento2Pokemon;
        private System.Windows.Forms.Label movimiento1Pokemon;
        private System.Windows.Forms.Label habitatPokemon;
    }
}