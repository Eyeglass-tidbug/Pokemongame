using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Pokemon_Game
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon Enemy;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new gyrados());
            pokemons.Add(new lizadon());
            pokemons.Add(new Tyranitar());
            pokemons.Add(new Locario());

            this.Enemy = new deoxy();
            this.pictureBox2.Image = this.Enemy.getImage();
            this.Enemyname.Text = this.Enemy.getName();
            this.EnemyHP.Text = this.Enemy.getHP().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.Ourname.Text = selectedPokemon.getName();
            this.OurHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.Ourname.Text = "*Eliminated*";
                this.OurHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
            else
            { this.backpack.Visible = false; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Backpack
            this.backpack.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enemyname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gyrados_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.Ourname.Text = selectedPokemon.getName();
            this.OurHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.Ourname.Text = "*Eliminated*";
                this.OurHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
            else
            { this.backpack.Visible = false; }
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            // Attack
            int dmg = this.selectedPokemon.getAttack() - this.Enemy.getDefense();
            this.test.Text = dmg.ToString();

        }

        private void Def_Click(object sender, EventArgs e)
        {
            // defend
            int getDefense = this.selectedPokemon.getDefense() + 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Heal
            int getHeal = this.selectedPokemon.getHP() + 50;
            this.OurHP.Text = getHeal.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Lucario_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.Ourname.Text = selectedPokemon.getName();
            this.OurHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.Ourname.Text = "*Eliminated*";
                this.OurHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
            else
            { this.backpack.Visible = false; }
        }

        private void tysomething_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.Ourname.Text = selectedPokemon.getName();
            this.OurHP.Text = selectedPokemon.getHP().ToString();
            if (selectedPokemon.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.Ourname.Text = "*Eliminated*";
                this.OurHP.Text = "0";
                this.selectedPokemon.getAttack();
            }
            else
            { this.backpack.Visible = false; }
        }
    }
}
