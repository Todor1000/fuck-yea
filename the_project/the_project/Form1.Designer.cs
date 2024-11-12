namespace the_project
{
    partial class Start
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
            this.Quizquest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMeth = new System.Windows.Forms.Button();
            this.btnGeo = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.btnHis = new System.Windows.Forms.Button();
            this.btnHisFig = new System.Windows.Forms.Button();
            this.btnProg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Quizquest
            // 
            this.Quizquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quizquest.Location = new System.Drawing.Point(194, 21);
            this.Quizquest.Name = "Quizquest";
            this.Quizquest.Size = new System.Drawing.Size(357, 90);
            this.Quizquest.TabIndex = 0;
            this.Quizquest.Text = "Welcome to fun Quizes for education";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Topic";
            // 
            // btnMeth
            // 
            this.btnMeth.Location = new System.Drawing.Point(164, 157);
            this.btnMeth.Name = "btnMeth";
            this.btnMeth.Size = new System.Drawing.Size(178, 106);
            this.btnMeth.TabIndex = 2;
            this.btnMeth.Text = "Meth";
            this.btnMeth.UseVisualStyleBackColor = true;
            this.btnMeth.Click += new System.EventHandler(this.btnMeth_Click);
            // 
            // btnGeo
            // 
            this.btnGeo.Location = new System.Drawing.Point(460, 157);
            this.btnGeo.Name = "btnGeo";
            this.btnGeo.Size = new System.Drawing.Size(164, 106);
            this.btnGeo.TabIndex = 3;
            this.btnGeo.Text = "Geography";
            this.btnGeo.UseVisualStyleBackColor = true;
            this.btnGeo.Click += new System.EventHandler(this.btnGeo_Click);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(601, 21);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(164, 106);
            this.Random.TabIndex = 4;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // btnHis
            // 
            this.btnHis.Location = new System.Drawing.Point(35, 295);
            this.btnHis.Name = "btnHis";
            this.btnHis.Size = new System.Drawing.Size(178, 106);
            this.btnHis.TabIndex = 5;
            this.btnHis.Text = "History";
            this.btnHis.UseVisualStyleBackColor = true;
            this.btnHis.Click += new System.EventHandler(this.btnHis_Click);
            // 
            // btnHisFig
            // 
            this.btnHisFig.Location = new System.Drawing.Point(314, 295);
            this.btnHisFig.Name = "btnHisFig";
            this.btnHisFig.Size = new System.Drawing.Size(178, 106);
            this.btnHisFig.TabIndex = 6;
            this.btnHisFig.Text = "Historical Figures";
            this.btnHisFig.UseVisualStyleBackColor = true;
            this.btnHisFig.Click += new System.EventHandler(this.btnHisFig_Click);
            // 
            // btnProg
            // 
            this.btnProg.Location = new System.Drawing.Point(587, 295);
            this.btnProg.Name = "btnProg";
            this.btnProg.Size = new System.Drawing.Size(178, 106);
            this.btnProg.TabIndex = 7;
            this.btnProg.Text = "programing C#";
            this.btnProg.UseVisualStyleBackColor = true;
            this.btnProg.Click += new System.EventHandler(this.btnProg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Questions Answered /";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProg);
            this.Controls.Add(this.btnHisFig);
            this.Controls.Add(this.btnHis);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.btnGeo);
            this.Controls.Add(this.btnMeth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quizquest);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Quizquest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMeth;
        private System.Windows.Forms.Button btnGeo;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button btnHis;
        private System.Windows.Forms.Button btnHisFig;
        private System.Windows.Forms.Button btnProg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

