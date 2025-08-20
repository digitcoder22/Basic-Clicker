using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int score;
        public Form1()
        {
            InitializeComponent();
            score = 0;
            UpdateScore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score++;
            UpdateScore();
        }
        private void UpdateScore()
        {
            scoreLabel.Text = "" + score.ToString();
        }
        private void scoreLabel_Click(object sender, EventArgs e)
        {
            // This method is intentionally left empty.
            // You can add functionality here if needed.
            // For example, you could display a message box or log the click.
            // but for now, im keeping it empty since i dont need it.
        }
    }
}
