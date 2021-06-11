
namespace CS028HodinyTimer
{
    partial class HodinyTimerForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rizeniAktualizaceButton = new System.Windows.Forms.Button();
            this.hodinyLabel = new System.Windows.Forms.Label();
            this.aktualizaceTimer = new System.Windows.Forms.Timer(this.components);
            this.intervalScrollBar = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rizeniAktualizaceButton
            // 
            this.rizeniAktualizaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rizeniAktualizaceButton.Location = new System.Drawing.Point(190, 181);
            this.rizeniAktualizaceButton.Name = "rizeniAktualizaceButton";
            this.rizeniAktualizaceButton.Size = new System.Drawing.Size(286, 44);
            this.rizeniAktualizaceButton.TabIndex = 0;
            this.rizeniAktualizaceButton.Text = "spustit aktualizaci";
            this.rizeniAktualizaceButton.UseVisualStyleBackColor = true;
            this.rizeniAktualizaceButton.Click += new System.EventHandler(this.rizeniAktualizaceButton_Click);
            // 
            // hodinyLabel
            // 
            this.hodinyLabel.AutoSize = true;
            this.hodinyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hodinyLabel.Location = new System.Drawing.Point(184, 107);
            this.hodinyLabel.Name = "hodinyLabel";
            this.hodinyLabel.Size = new System.Drawing.Size(292, 31);
            this.hodinyLabel.TabIndex = 1;
            this.hodinyLabel.Text = "aktuální datum a čas: ?";
            // 
            // aktualizaceTimer
            // 
            this.aktualizaceTimer.Tick += new System.EventHandler(this.aktualizaceTimer_Tick);
            // 
            // intervalScrollBar
            // 
            this.intervalScrollBar.Location = new System.Drawing.Point(190, 323);
            this.intervalScrollBar.Maximum = 5000;
            this.intervalScrollBar.Minimum = 10;
            this.intervalScrollBar.Name = "intervalScrollBar";
            this.intervalScrollBar.Size = new System.Drawing.Size(286, 19);
            this.intervalScrollBar.TabIndex = 2;
            this.intervalScrollBar.Value = 10;
            this.intervalScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            
            // 
            // HodinyTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalScrollBar);
            this.Controls.Add(this.hodinyLabel);
            this.Controls.Add(this.rizeniAktualizaceButton);
            this.Name = "HodinyTimerForm";
            this.Text = "CS028 Hodiny - Vojtěch Hladík";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rizeniAktualizaceButton;
        private System.Windows.Forms.Label hodinyLabel;
        private System.Windows.Forms.Timer aktualizaceTimer;
        private System.Windows.Forms.HScrollBar intervalScrollBar;
        private System.Windows.Forms.Label label1;
    }
}

