
namespace Pokedex_C_Sharp
{
    partial class Ventana01
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
            this.descripcionPokemons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descripcionPokemons
            // 
            this.descripcionPokemons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripcionPokemons.BackColor = System.Drawing.Color.Transparent;
            this.descripcionPokemons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionPokemons.ForeColor = System.Drawing.Color.Yellow;
            this.descripcionPokemons.Location = new System.Drawing.Point(172, 64);
            this.descripcionPokemons.Name = "descripcionPokemons";
            this.descripcionPokemons.Size = new System.Drawing.Size(474, 303);
            this.descripcionPokemons.TabIndex = 0;
            this.descripcionPokemons.Text = "label1";
            this.descripcionPokemons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descripcionPokemons.Click += new System.EventHandler(this.descripcionPokemons_Click);
            // 
            // Ventana01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descripcionPokemons);
            this.Name = "Ventana01";
            this.Text = "Ventana01";
            this.Load += new System.EventHandler(this.Ventana01_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label descripcionPokemons;
    }
}