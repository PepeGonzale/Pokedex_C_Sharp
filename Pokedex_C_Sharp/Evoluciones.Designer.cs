
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
            this.label1 = new System.Windows.Forms.Label();
            this.evolucionPokemons = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(479, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // evolucionPokemons
            // 
            this.evolucionPokemons.Location = new System.Drawing.Point(141, 102);
            this.evolucionPokemons.Name = "evolucionPokemons";
            this.evolucionPokemons.Size = new System.Drawing.Size(93, 89);
            this.evolucionPokemons.TabIndex = 1;
            this.evolucionPokemons.Text = "label2";
            this.evolucionPokemons.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 220);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Evoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.evolucionPokemons);
            this.Controls.Add(this.label1);
            this.Name = "Evoluciones";
            this.Text = "Evoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label evolucionPokemons;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}