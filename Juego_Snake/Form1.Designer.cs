
namespace Juego_Snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Ultimoscore = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.snakeScoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.Continua = new System.Windows.Forms.PictureBox();
            this.Pausa = new System.Windows.Forms.PictureBox();
            this.spaceBarLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Ultimoscore,
            this.toolStripStatusLabel2,
            this.snakeScoreLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Ultimoscore
            // 
            this.Ultimoscore.BackColor = System.Drawing.Color.White;
            this.Ultimoscore.Name = "Ultimoscore";
            this.Ultimoscore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Ultimoscore.Size = new System.Drawing.Size(13, 17);
            this.Ultimoscore.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel2.RightToLeftAutoMirrorImage = true;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel2.Text = "Ultimo puntaje: ";
            // 
            // snakeScoreLabel
            // 
            this.snakeScoreLabel.BackColor = System.Drawing.Color.White;
            this.snakeScoreLabel.Name = "snakeScoreLabel";
            this.snakeScoreLabel.Size = new System.Drawing.Size(13, 17);
            this.snakeScoreLabel.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "Puntaje:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(650, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 423);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.White;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(685, 284);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(100, 31);
            this.salir.TabIndex = 2;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Continua
            // 
            this.Continua.BackColor = System.Drawing.Color.White;
            this.Continua.BackgroundImage = global::Juego_Snake.Properties.Resources.continua;
            this.Continua.Image = ((System.Drawing.Image)(resources.GetObject("Continua.Image")));
            this.Continua.Location = new System.Drawing.Point(688, 232);
            this.Continua.Name = "Continua";
            this.Continua.Size = new System.Drawing.Size(100, 32);
            this.Continua.TabIndex = 1;
            this.Continua.TabStop = false;
            this.Continua.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Pausa
            // 
            this.Pausa.BackColor = System.Drawing.Color.White;
            this.Pausa.BackgroundImage = global::Juego_Snake.Properties.Resources.pause;
            this.Pausa.Image = ((System.Drawing.Image)(resources.GetObject("Pausa.Image")));
            this.Pausa.Location = new System.Drawing.Point(685, 175);
            this.Pausa.Name = "Pausa";
            this.Pausa.Size = new System.Drawing.Size(103, 30);
            this.Pausa.TabIndex = 0;
            this.Pausa.TabStop = false;
            this.Pausa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // spaceBarLabel
            // 
            this.spaceBarLabel.AutoSize = true;
            this.spaceBarLabel.BackColor = System.Drawing.Color.White;
            this.spaceBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceBarLabel.Location = new System.Drawing.Point(164, 9);
            this.spaceBarLabel.Name = "spaceBarLabel";
            this.spaceBarLabel.Size = new System.Drawing.Size(317, 20);
            this.spaceBarLabel.TabIndex = 8;
            this.spaceBarLabel.Text = "Presiona Barra Espaciadora para comenzar";
            this.spaceBarLabel.Click += new System.EventHandler(this.spaceBarLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spaceBarLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Continua);
            this.Controls.Add(this.Pausa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pausa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Pausa;
        private System.Windows.Forms.PictureBox Continua;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Ultimoscore;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel snakeScoreLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label spaceBarLabel;
    }
}

