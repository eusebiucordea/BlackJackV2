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
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            //this.MaximumSize = new Size(500, 500);
            //this.MinimumSize = new Size(500, 500);
            this.CenterToScreen();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (form2.Created == false)
                form2 = new Form2(this);
            form2.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
