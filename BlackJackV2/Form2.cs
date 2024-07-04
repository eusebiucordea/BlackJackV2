using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackV2
{
    public partial class Form2 : Form
    {
        int SumPlayerInt = 0, SumDealerInt = 0;
        int bani = 1000, bet = 0, bet_double = 0;
        int stand_verificare = 0;

        //Secundele folosite la timer1
        int sec = 0;

        //Creere pachet de carti + shuffle + clear
        public List<Cards> deck_list = new List<Cards>
        {
            //Inima neagra
            new Cards(){Value = 2, Type = "DoiNegru", Image = "2.png"},
            new Cards(){Value = 3, Type = "TreiNegru", Image = "3.png"},
            new Cards(){Value = 4, Type = "PatruNegru", Image = "4.png"},
            new Cards(){Value = 5, Type = "CinciNegru", Image = "5.png"},
            new Cards(){Value = 6, Type = "SaseNegru", Image = "6.png"},
            new Cards(){Value = 7, Type = "SapteNegru", Image = "7.png"},
            new Cards(){Value = 8, Type = "OptNegru", Image = "8.png"},
            new Cards(){Value = 9, Type = "NouaNegru", Image = "9.png"},
            new Cards(){Value = 10, Type = "ZeceNegru", Image = "10.png"},
            new Cards(){Value = 10, Type = "JuveNegru", Image = "11.png"},
            new Cards(){Value = 10, Type = "DamaNegru", Image = "12.png"},
            new Cards(){Value = 10, Type = "PopaNegru", Image = "13.png"},
            new Cards(){Value = 11, Type = "AsNegru", Image = "1.png"},

            //Inima rosie
            new Cards(){Value = 2, Type = "DoiRosu", Image = "15.png"},
            new Cards(){Value = 3, Type = "TreiRosu", Image = "16.png"},
            new Cards(){Value = 4, Type = "PatruRosu", Image = "17.png"},
            new Cards(){Value = 5, Type = "CinciRosu", Image = "18.png"},
            new Cards(){Value = 6, Type = "SaseRosu", Image = "19.png"},
            new Cards(){Value = 7, Type = "SapteRosu", Image = "20.png"},
            new Cards(){Value = 8, Type = "OptRosu", Image = "21.png"},
            new Cards(){Value = 9, Type = "NouaRosu", Image = "22.png"},
            new Cards(){Value = 10, Type = "ZeceRosu", Image = "23.png"},
            new Cards(){Value = 10, Type = "JuveNegru", Image = "24.png"},
            new Cards(){Value = 10, Type = "DamaNegru", Image = "25.png"},
            new Cards(){Value = 10, Type = "PopaNegru", Image = "26.png"},
            new Cards(){Value = 11, Type = "AsRosu", Image = "14.png"},

            //Romb
            new Cards(){Value = 2, Type = "DoiRomb", Image = "28.png"},
            new Cards(){Value = 3, Type = "TreiRomb", Image = "29.png"},
            new Cards(){Value = 4, Type = "PatruRomb", Image = "30.png"},
            new Cards(){Value = 5, Type = "CinciRomb", Image = "31.png"},
            new Cards(){Value = 6, Type = "SaseRomb", Image = "32.png"},
            new Cards(){Value = 7, Type = "SapteRomb", Image = "33.png"},
            new Cards(){Value = 8, Type = "OptRomb", Image = "34.png"},
            new Cards(){Value = 9, Type = "NouaRomb", Image = "35.png"},
            new Cards(){Value = 10, Type = "ZeceRomb", Image = "36.png"},
            new Cards(){Value = 10, Type = "JuveRomb", Image = "37.png"},
            new Cards(){Value = 10, Type = "DamaRomb", Image = "38.png"},
            new Cards(){Value = 10, Type = "PopaRomb", Image = "39.png"},
            new Cards(){Value = 11, Type = "AsRomb", Image = "27.png"},

            //Trifoi
            new Cards(){Value = 2, Type = "DoiTrifoi", Image = "41.png"},
            new Cards(){Value = 3, Type = "TreiTrifoi", Image = "42.png"},
            new Cards(){Value = 4, Type = "PatruTrifoi", Image = "43.png"},
            new Cards(){Value = 5, Type = "CinciTrifoi", Image = "44.png"},
            new Cards(){Value = 6, Type = "SaseTrifoi", Image = "45.png"},
            new Cards(){Value = 7, Type = "SapteTrifoi", Image = "46.png"},
            new Cards(){Value = 8, Type = "OptTrifoi", Image = "47.png"},
            new Cards(){Value = 9, Type = "NouaTrifoi", Image = "48.png"},
            new Cards(){Value = 10, Type = "ZeceTrifoi", Image = "49.png"},
            new Cards(){Value = 10, Type = "JuveTrifoi", Image = "50.png"},
            new Cards(){Value = 10, Type = "DamaTrifoi", Image = "51.png"},
            new Cards(){Value = 10, Type = "PopaTrifoi", Image = "52.png"},
            new Cards(){Value = 11, Type = "AsTrifoi", Image = "40.png"},
        };

        Player jucator;
        Player dealer;

        Random random = new Random();
        List<PictureBox> pb_player = new List<PictureBox>();
        List<PictureBox> pb_dealer = new List<PictureBox>();
        
        Form1 fereastra_principala;
        public Form2(Form1 f)
        {
            InitializeComponent();
            fereastra_principala = f;
            this.Size = new Size(1450, 750);
            this.MaximumSize = new Size(1450, 750);
            this.MinimumSize = new Size(1450, 750);
            this.CenterToScreen();
            btn_hit.Enabled = false;
            btn_stand.Enabled = false;
            btn_double.Enabled = false;
            jucator = new Player();
            dealer = new Player();
            label_bani.Text = "Bani : " + bani;
            label_bet.Text = "Bet : " + bet;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            fereastra_principala.Show();
            resetGame();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help : \n" +
                "\n" +
                "Scopul jocului este sa ajungi la 21. \n" +
                "Incepe prin folosirea unui bet. \n" +
                "Fiecare jeton reprezinta un numar de bani adica bet-ul. \n" +
                "Clear Bet - sterge suma din bet. \n" +
                "\n" +
                "Apasa butonul Deal pentru inceperea jocului. \n" +
                "Hit - mai primesti inca o carte. \n" +
                "Stand - opreste jocul. \n" +
                "Double - dubleaza bet-ul daca ai bani necesari. \n" +
                "Reset - reseteaza jocul. \n" +
                "Back - te aduce pe fereastra principala. \n"
                , "BlackJack - Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_deal_Click(object sender, EventArgs e)
        {
            btn_deal.Visible = false;


            if (bani <= 0 && bet == 0)
            {
                MessageBox.Show("Te-ai nenorocit nu mai ai bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_hit.Enabled = false;
                btn_double.Enabled = false;
                btn_stand.Enabled = false;
            }

            else if (bet == 0)
            {
                MessageBox.Show("Nu ai pus un bet!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_hit.Enabled = false;
                btn_double.Enabled = false;
                btn_stand.Enabled = false;
                btn_deal.Visible = true;
            }

            else
            {
                btn_hit.Enabled = true;
                btn_double.Enabled = true;
                btn_stand.Enabled = true;

                btn_allin.Visible = false;
                btn_clearbet.Visible = false;
                btn_bet100.Visible = false;
                btn_bet50.Visible = false;
                btn_bet25.Visible = false;
                btn_bet10.Visible = false;
                btn_bet5.Visible = false;

                sec = 10;
                timer1.Start();
                ShuffleDeckList(deck_list);

                //initializare player
                SumPlayerInt = 0;
                int RandomCard1 = SelectRandCard();
                Cards card1 = deck_list[RandomCard1];

                int RandomCard2 = SelectRandCard();
                Cards card2 = deck_list[RandomCard2];


                jucator.AddCards(card1);
                jucator.AddCards(card2);

                pbcarte1_player.ImageLocation = card1.Image;
                pbcarte1_player.SizeMode = PictureBoxSizeMode.StretchImage;

                pbcarte2_player.ImageLocation = card2.Image;
                pbcarte2_player.SizeMode = PictureBoxSizeMode.StretchImage;
                SumPlayerInt = jucator.SumPlayer();

                //initializare dealer
                SumDealerInt = 0;
                int RandomCard3 = SelectRandCard();

                Cards card3 = deck_list[RandomCard3];
                dealer.AddCards(card3);
                pbcarte1_dealer.ImageLocation = card3.Image;
                pbcarte1_dealer.SizeMode = PictureBoxSizeMode.StretchImage;
                SumDealerInt = dealer.SumPlayer();

                label_sumaplayer.Text = "Suma player : " + SumPlayerInt;
                label_sumadealer.Text = "Suma dealer : " + SumDealerInt;

                verifyPlayer();
            }
        }

        private void btn_hit_Click(object sender, EventArgs e)
        {
            btn_double.Enabled = false;
            sec = 10;

            int RandCardHit = SelectRandCard();
            Cards card = deck_list[RandCardHit];
            PictureBox pbhit = new PictureBox();

            pbhit.Width = 92;
            pbhit.Height = 120;
            pbhit.SizeMode = PictureBoxSizeMode.StretchImage;
            pbhit.ImageLocation = card.Image;
            pbhit.Location = new Point(670 + 94 + pb_player.Count * 94, 464);
            this.Controls.Add(pbhit);
            //adauga in lista de control folosit stergerea cartilor la reset 

            jucator.AddCards(card);
            pb_player.Add(pbhit);
            SumPlayerInt = jucator.SumPlayer();

            label_sumaplayer.Text = "Suma player : " + SumPlayerInt;

            verifyPlayer();
        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_hit.Enabled = false;
            btn_stand.Enabled = false;
            btn_double.Enabled = false;

            SumDealerInt = dealer.SumPlayer();

            while (SumDealerInt <= 16)
            {
                int RandCardDealer = SelectRandCard();
                Cards card = deck_list[RandCardDealer];

                PictureBox pbstand = new PictureBox();
                pbstand.Width = 90;
                pbstand.Height = 120;
                pbstand.ImageLocation = card.Image;
                pbstand.SizeMode = PictureBoxSizeMode.StretchImage;
                pbstand.Location = new Point(586 + 94 + pb_dealer.Count * 94, 65);
                this.Controls.Add(pbstand);

                dealer.AddCards(card);
                pb_dealer.Add(pbstand);

                SumDealerInt = dealer.SumPlayer();
                label_sumadealer.Text = "Suma dealer : " + SumDealerInt;
            }

            if (stand_verificare == 0)
                verifyGame();
            else if (stand_verificare == 1)
                verifyGameDouble();
        }

        private void btn_double_Click(object sender, EventArgs e)
        {
            if (bani < bet)
            {
                timer1.Stop();
                MessageBox.Show("Ai prea putini bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Start();
            }
            else
            {
                bet_double = bet;
                bet = bet * 2;
                bani -= bet_double;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;

                stand_verificare = 1;
                int RandCardDouble = SelectRandCard();

                Cards card = deck_list[RandCardDouble];

                PictureBox pbdouble = new PictureBox();
                pbdouble.Width = 92;
                pbdouble.Height = 120;
                pbdouble.SizeMode = PictureBoxSizeMode.StretchImage;
                pbdouble.ImageLocation = card.Image;
                pbdouble.Location = new Point(670 + 94 + pb_player.Count * 94, 464);
                this.Controls.Add(pbdouble);

                jucator.AddCards(card);
                pb_player.Add(pbdouble);
                SumPlayerInt = jucator.SumPlayer();

                label_sumaplayer.Text = "Suma player : " + SumPlayerInt;

                btn_stand.PerformClick();
            }

        }

        private void btn_bet100_Click(object sender, EventArgs e)
        {
            if (bani < 100)
            {

                MessageBox.Show("Ai prea putini bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                bet += 100;
                label_bet.Text = "Bet : " + bet;
                bani -= 100;
                label_bani.Text = "Bani : " + bani;
            }
        }

        private void btn_bet50_Click(object sender, EventArgs e)
        {
            if (bani < 50)
            {

                MessageBox.Show("Ai prea putini bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                bet += 50;
                bani -= 50;
                label_bet.Text = "Bet : " + bet;
                label_bani.Text = "Bani : " + bani;
            }
        }

        private void btn_bet25_Click(object sender, EventArgs e)
        {
            if (bani < 25)
            {

                MessageBox.Show("Ai prea putini bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                bet += 25;
                bani -= 25;
                label_bet.Text = "Bet : " + bet;
                label_bani.Text = "Bani : " + bani;
            }
        }

        private void btn_bet10_Click(object sender, EventArgs e)
        {
            if (bani < 10)
            {
                MessageBox.Show("Ai prea putini bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bet += 10;
                bani -= 10;
                label_bet.Text = "Bet : " + bet;
                label_bani.Text = "Bani : " + bani;
            }
        }

        private void btn_allin_Click(object sender, EventArgs e)
        {
            if(bani <= 0)
            {
                MessageBox.Show("Ai prea putini bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bet += bani;
                label_bet.Text = "Bet : " + bet;
                bani = 0;
                label_bani.Text = "Bani : " + bani;

            }
        }

        private void btn_bet5_Click(object sender, EventArgs e)
        {
            if (bani < 5)
            {
                MessageBox.Show("Ai prea putini bani!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bet += 5;
                bani -= 5;
                label_bet.Text = "Bet : " + bet;
                label_bani.Text = "Bani : " + bani;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bani += bet;
            bet = 0;
            label_bet.Text = "Bet : " + bet;
            label_bani.Text = "Bani : " + bani;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

                resetGame();
                bet = 0;
                label_bet.Text = "Bet : " + bet;
                bani = 1000;
                label_bani.Text = "Bani : " + bani;

        }

        private void verifyPlayer()
        {

            if (SumPlayerInt > 21)
            {
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                timer1.Stop();
                MessageBox.Show("Busted - You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumPlayerInt == 21)
            {
                bani += bet * 2;
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;

                timer1.Stop();
                MessageBox.Show("BlackJack - You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
        }

        private void verifyGame()
        {
            if (SumDealerInt > 21)
            {
                bani += bet * 2;
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;

                MessageBox.Show("BlackJack - You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumDealerInt > 21 && SumPlayerInt > 21)
            {
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("Busted - You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumDealerInt == SumPlayerInt)
            {
                bani += bet;
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("Draw!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumPlayerInt > 21)
            {
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("Busted - You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumPlayerInt < SumDealerInt)
            {
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else
            {
                bani += bet * 2;
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("BlackJack - You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
        }

        private void verifyGameDouble()
        {
            if (SumDealerInt > 21 && SumPlayerInt == 21)
            {
                bani += bet * 2;
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;

                MessageBox.Show("BlackJack - You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumDealerInt > 21 && SumPlayerInt > 21)
            {
                //  bani = bani - (bet * 2);
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("Busted - You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumDealerInt == SumPlayerInt)
            {
                bani += bet;
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("Draw!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumPlayerInt > 21)
            {
                // bani = bani - (bet * 2);
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("Busted - You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else if (SumPlayerInt < SumDealerInt)
            {
                // bani = bani - (bet*2);
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
            else
            {
                bani += bet * 2;
                bet = 0;
                label_bani.Text = "Bani : " + bani;
                label_bet.Text = "Bet : " + bet;
                MessageBox.Show("BlackJack - You win!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
        }

        private void resetGame()
        {
            stand_verificare = 0;
            btn_allin.Visible = true;
            btn_clearbet.Visible = true;
            btn_bet100.Visible = true;
            btn_bet50.Visible = true;
            btn_bet25.Visible = true;
            btn_bet10.Visible = true;
            btn_bet5.Visible = true;


            btn_deal.Visible = true;
            btn_hit.Enabled = false;
            btn_stand.Enabled = false;
            btn_double.Enabled = false;

            SumDealerInt = 0; SumPlayerInt = 0;
            label_sumaplayer.Text = "Suma player : ";
            label_sumadealer.Text = "Suma dealer : ";

            label_timer.Text = "Timp ramas : ";
            timer1.Stop();

            ResetShowCard(pbcarte1_player);
            ResetShowCard(pbcarte2_player);
            ResetShowCard(pbcarte1_dealer);

            foreach (PictureBox pictureBox in pb_player)
            {
                this.Controls.Remove(pictureBox);
            }
            pb_player = new List<PictureBox>();

            foreach (PictureBox pictureBox in pb_dealer)
            {
                this.Controls.Remove(pictureBox);
            }
            pb_dealer = new List<PictureBox>();

            jucator.ClearCards();
            dealer.ClearCards();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_timer.Text = "Timp ramas : " + sec--;
            if (sec == -1)
            {
                btn_stand.PerformClick();
                timer1.Stop();
            }
        }

        public void ResetShowCard(PictureBox pb)
        {
            pb.ImageLocation = "0.png";
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int SelectRandCard()
        {
            int randomcard;
            randomcard = random.Next(0, deck_list.Count);
            return randomcard;
        }

        public void ShuffleDeckList<T>(List<T> list)
            {
                Random random = new Random();
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    T value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
