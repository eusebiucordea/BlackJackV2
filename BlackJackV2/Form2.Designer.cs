
namespace BlackJackV2
{
    partial class Form2
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
            this.btn_back = new System.Windows.Forms.Button();
            this.pbcarte1_player = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pbcarte2_player = new System.Windows.Forms.PictureBox();
            this.pbcarte1_dealer = new System.Windows.Forms.PictureBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.label_sumaplayer = new System.Windows.Forms.Label();
            this.label_timer = new System.Windows.Forms.Label();
            this.label_sumadealer = new System.Windows.Forms.Label();
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stand = new System.Windows.Forms.Button();
            this.btn_deal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_double = new System.Windows.Forms.Button();
            this.label_bani = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label_bet = new System.Windows.Forms.Label();
            this.btn_bet100 = new System.Windows.Forms.Button();
            this.btn_bet50 = new System.Windows.Forms.Button();
            this.btn_bet25 = new System.Windows.Forms.Button();
            this.btn_bet10 = new System.Windows.Forms.Button();
            this.btn_bet5 = new System.Windows.Forms.Button();
            this.btn_clearbet = new System.Windows.Forms.Button();
            this.btn_allin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarte1_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarte2_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarte1_dealer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(1279, 11);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 34);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pbcarte1_player
            // 
            this.pbcarte1_player.BackColor = System.Drawing.Color.White;
            this.pbcarte1_player.Location = new System.Drawing.Point(576, 464);
            this.pbcarte1_player.Margin = new System.Windows.Forms.Padding(2);
            this.pbcarte1_player.Name = "pbcarte1_player";
            this.pbcarte1_player.Size = new System.Drawing.Size(90, 120);
            this.pbcarte1_player.TabIndex = 1;
            this.pbcarte1_player.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.Location = new System.Drawing.Point(1365, 11);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(62, 34);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pbcarte2_player
            // 
            this.pbcarte2_player.BackColor = System.Drawing.Color.White;
            this.pbcarte2_player.Location = new System.Drawing.Point(670, 464);
            this.pbcarte2_player.Margin = new System.Windows.Forms.Padding(2);
            this.pbcarte2_player.Name = "pbcarte2_player";
            this.pbcarte2_player.Size = new System.Drawing.Size(90, 120);
            this.pbcarte2_player.TabIndex = 3;
            this.pbcarte2_player.TabStop = false;
            // 
            // pbcarte1_dealer
            // 
            this.pbcarte1_dealer.BackColor = System.Drawing.Color.White;
            this.pbcarte1_dealer.Location = new System.Drawing.Point(586, 65);
            this.pbcarte1_dealer.Margin = new System.Windows.Forms.Padding(2);
            this.pbcarte1_dealer.Name = "pbcarte1_dealer";
            this.pbcarte1_dealer.Size = new System.Drawing.Size(90, 120);
            this.pbcarte1_dealer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcarte1_dealer.TabIndex = 4;
            this.pbcarte1_dealer.TabStop = false;
            // 
            // btn_help
            // 
            this.btn_help.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_help.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_help.Location = new System.Drawing.Point(1193, 11);
            this.btn_help.Margin = new System.Windows.Forms.Padding(2);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(82, 34);
            this.btn_help.TabIndex = 6;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // label_sumaplayer
            // 
            this.label_sumaplayer.AutoSize = true;
            this.label_sumaplayer.BackColor = System.Drawing.Color.Transparent;
            this.label_sumaplayer.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sumaplayer.Location = new System.Drawing.Point(373, 452);
            this.label_sumaplayer.Name = "label_sumaplayer";
            this.label_sumaplayer.Size = new System.Drawing.Size(166, 27);
            this.label_sumaplayer.TabIndex = 7;
            this.label_sumaplayer.Text = "Suma player : ";
            this.label_sumaplayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.BackColor = System.Drawing.Color.Transparent;
            this.label_timer.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.Location = new System.Drawing.Point(373, 479);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(154, 27);
            this.label_timer.TabIndex = 8;
            this.label_timer.Text = "Timp Ramas : ";
            // 
            // label_sumadealer
            // 
            this.label_sumadealer.AutoSize = true;
            this.label_sumadealer.BackColor = System.Drawing.Color.Transparent;
            this.label_sumadealer.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sumadealer.Location = new System.Drawing.Point(370, 65);
            this.label_sumadealer.Name = "label_sumadealer";
            this.label_sumadealer.Size = new System.Drawing.Size(169, 27);
            this.label_sumadealer.TabIndex = 9;
            this.label_sumadealer.Text = "Suma dealer : ";
            // 
            // btn_hit
            // 
            this.btn_hit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_hit.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_hit.Location = new System.Drawing.Point(524, 641);
            this.btn_hit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(82, 34);
            this.btn_hit.TabIndex = 10;
            this.btn_hit.Text = "HIT";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stand
            // 
            this.btn_stand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_stand.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stand.Location = new System.Drawing.Point(619, 641);
            this.btn_stand.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stand.Name = "btn_stand";
            this.btn_stand.Size = new System.Drawing.Size(95, 34);
            this.btn_stand.TabIndex = 11;
            this.btn_stand.Text = "STAND";
            this.btn_stand.UseVisualStyleBackColor = true;
            this.btn_stand.Click += new System.EventHandler(this.btn_stand_Click);
            // 
            // btn_deal
            // 
            this.btn_deal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_deal.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_deal.Location = new System.Drawing.Point(619, 603);
            this.btn_deal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deal.Name = "btn_deal";
            this.btn_deal.Size = new System.Drawing.Size(95, 34);
            this.btn_deal.TabIndex = 12;
            this.btn_deal.Text = "DEAL";
            this.btn_deal.UseVisualStyleBackColor = true;
            this.btn_deal.Click += new System.EventHandler(this.btn_deal_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_double
            // 
            this.btn_double.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_double.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_double.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_double.Location = new System.Drawing.Point(727, 641);
            this.btn_double.Margin = new System.Windows.Forms.Padding(2);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(104, 34);
            this.btn_double.TabIndex = 13;
            this.btn_double.Text = "Double";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // label_bani
            // 
            this.label_bani.AutoSize = true;
            this.label_bani.BackColor = System.Drawing.Color.Transparent;
            this.label_bani.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bani.Location = new System.Drawing.Point(373, 506);
            this.label_bani.Name = "label_bani";
            this.label_bani.Size = new System.Drawing.Size(76, 27);
            this.label_bani.TabIndex = 15;
            this.label_bani.Text = "Bani : ";
            // 
            // btn_reset
            // 
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_reset.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_reset.Location = new System.Drawing.Point(1107, 11);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(82, 34);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label_bet
            // 
            this.label_bet.AutoSize = true;
            this.label_bet.BackColor = System.Drawing.Color.Transparent;
            this.label_bet.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bet.Location = new System.Drawing.Point(373, 533);
            this.label_bet.Name = "label_bet";
            this.label_bet.Size = new System.Drawing.Size(63, 27);
            this.label_bet.TabIndex = 17;
            this.label_bet.Text = "Bet : ";
            // 
            // btn_bet100
            // 
            this.btn_bet100.BackColor = System.Drawing.Color.Transparent;
            this.btn_bet100.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_bet100.FlatAppearance.BorderSize = 0;
            this.btn_bet100.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bet100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bet100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bet100.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bet100.ForeColor = System.Drawing.Color.Transparent;
            this.btn_bet100.Image = global::BlackJackV2.Resource1.rosu100;
            this.btn_bet100.Location = new System.Drawing.Point(353, 257);
            this.btn_bet100.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bet100.Name = "btn_bet100";
            this.btn_bet100.Size = new System.Drawing.Size(70, 70);
            this.btn_bet100.TabIndex = 23;
            this.btn_bet100.UseVisualStyleBackColor = false;
            this.btn_bet100.Click += new System.EventHandler(this.btn_bet100_Click);
            // 
            // btn_bet50
            // 
            this.btn_bet50.BackColor = System.Drawing.Color.Transparent;
            this.btn_bet50.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_bet50.FlatAppearance.BorderSize = 0;
            this.btn_bet50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bet50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bet50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bet50.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bet50.ForeColor = System.Drawing.Color.Transparent;
            this.btn_bet50.Image = global::BlackJackV2.Resource1.roz50;
            this.btn_bet50.Location = new System.Drawing.Point(509, 304);
            this.btn_bet50.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bet50.Name = "btn_bet50";
            this.btn_bet50.Size = new System.Drawing.Size(70, 70);
            this.btn_bet50.TabIndex = 24;
            this.btn_bet50.UseVisualStyleBackColor = false;
            this.btn_bet50.Click += new System.EventHandler(this.btn_bet50_Click);
            // 
            // btn_bet25
            // 
            this.btn_bet25.BackColor = System.Drawing.Color.Transparent;
            this.btn_bet25.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_bet25.FlatAppearance.BorderSize = 0;
            this.btn_bet25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bet25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bet25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bet25.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bet25.ForeColor = System.Drawing.Color.Transparent;
            this.btn_bet25.Image = global::BlackJackV2.Resource1.albinchis25;
            this.btn_bet25.Location = new System.Drawing.Point(661, 319);
            this.btn_bet25.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bet25.Name = "btn_bet25";
            this.btn_bet25.Size = new System.Drawing.Size(70, 70);
            this.btn_bet25.TabIndex = 25;
            this.btn_bet25.UseVisualStyleBackColor = false;
            this.btn_bet25.Click += new System.EventHandler(this.btn_bet25_Click);
            // 
            // btn_bet10
            // 
            this.btn_bet10.BackColor = System.Drawing.Color.Transparent;
            this.btn_bet10.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_bet10.FlatAppearance.BorderSize = 0;
            this.btn_bet10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bet10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bet10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bet10.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bet10.ForeColor = System.Drawing.Color.Transparent;
            this.btn_bet10.Image = global::BlackJackV2.Resource1.mov10;
            this.btn_bet10.Location = new System.Drawing.Point(834, 304);
            this.btn_bet10.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bet10.Name = "btn_bet10";
            this.btn_bet10.Size = new System.Drawing.Size(70, 70);
            this.btn_bet10.TabIndex = 26;
            this.btn_bet10.UseVisualStyleBackColor = false;
            this.btn_bet10.Click += new System.EventHandler(this.btn_bet10_Click);
            // 
            // btn_bet5
            // 
            this.btn_bet5.BackColor = System.Drawing.Color.Transparent;
            this.btn_bet5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_bet5.FlatAppearance.BorderSize = 0;
            this.btn_bet5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bet5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bet5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bet5.Font = new System.Drawing.Font("LEMON MILK", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bet5.ForeColor = System.Drawing.Color.Transparent;
            this.btn_bet5.Image = global::BlackJackV2.Resource1.albdes5;
            this.btn_bet5.Location = new System.Drawing.Point(985, 257);
            this.btn_bet5.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bet5.Name = "btn_bet5";
            this.btn_bet5.Size = new System.Drawing.Size(70, 70);
            this.btn_bet5.TabIndex = 27;
            this.btn_bet5.UseVisualStyleBackColor = false;
            this.btn_bet5.Click += new System.EventHandler(this.btn_bet5_Click);
            // 
            // btn_clearbet
            // 
            this.btn_clearbet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_clearbet.Font = new System.Drawing.Font("LEMON MILK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearbet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clearbet.Location = new System.Drawing.Point(231, 229);
            this.btn_clearbet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearbet.Name = "btn_clearbet";
            this.btn_clearbet.Size = new System.Drawing.Size(95, 37);
            this.btn_clearbet.TabIndex = 28;
            this.btn_clearbet.Text = "Clear Bet";
            this.btn_clearbet.UseVisualStyleBackColor = true;
            this.btn_clearbet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_allin
            // 
            this.btn_allin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_allin.Font = new System.Drawing.Font("LEMON MILK", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_allin.Location = new System.Drawing.Point(231, 270);
            this.btn_allin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_allin.Name = "btn_allin";
            this.btn_allin.Size = new System.Drawing.Size(95, 37);
            this.btn_allin.TabIndex = 29;
            this.btn_allin.Text = "ALL-IN";
            this.btn_allin.UseVisualStyleBackColor = true;
            this.btn_allin.Click += new System.EventHandler(this.btn_allin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJackV2.Resource1.background;
            this.ClientSize = new System.Drawing.Size(1434, 711);
            this.ControlBox = false;
            this.Controls.Add(this.btn_allin);
            this.Controls.Add(this.btn_clearbet);
            this.Controls.Add(this.btn_bet5);
            this.Controls.Add(this.btn_bet10);
            this.Controls.Add(this.btn_bet25);
            this.Controls.Add(this.btn_bet50);
            this.Controls.Add(this.btn_bet100);
            this.Controls.Add(this.label_bet);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label_bani);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.btn_deal);
            this.Controls.Add(this.btn_stand);
            this.Controls.Add(this.btn_hit);
            this.Controls.Add(this.label_sumadealer);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label_sumaplayer);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.pbcarte1_dealer);
            this.Controls.Add(this.pbcarte2_player);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pbcarte1_player);
            this.Controls.Add(this.btn_back);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "BlackJackGameV2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcarte1_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarte2_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarte1_dealer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pbcarte1_player;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pbcarte2_player;
        private System.Windows.Forms.PictureBox pbcarte1_dealer;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label label_sumaplayer;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label label_sumadealer;
        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Button btn_stand;
        private System.Windows.Forms.Button btn_deal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_double;
        private System.Windows.Forms.Label label_bani;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label_bet;
        private System.Windows.Forms.Button btn_bet100;
        private System.Windows.Forms.Button btn_bet50;
        private System.Windows.Forms.Button btn_bet25;
        private System.Windows.Forms.Button btn_bet10;
        private System.Windows.Forms.Button btn_bet5;
        private System.Windows.Forms.Button btn_clearbet;
        private System.Windows.Forms.Button btn_allin;
    }
}