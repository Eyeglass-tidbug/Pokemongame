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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Backpack
            this.backpack.Visible = true;
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
            }
            else
            { this.backpack.Visible = false; }
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

        //attack
        private void Attack_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null) { }
            else if (this.Enemy.getHP() == 0)
            {
                this.EnemyHP.Text = "*Enemy Eliminated*";
            }
            else
            {
                if (Enemy.getHP() <= 0)
                {
                    //this.test.Visible = true;
                }
                else
                {
                    // Attack
                    this.Enemy.takeDamage(selectedPokemon.getAttack(), Enemy.getDefense());
                    this.EnemyHP.Text = this.Enemy.getHP().ToString();
                    if (this.Enemy.getHP() <= 0)
                    {
                        this.pictureBox2.Image = null;
                        this.EnemyHP.Text = "*Enemy Eliminated*";
                        this.You_win.Visible = true;
                    }
                    //get Attack
                    this.selectedPokemon.takeDamage(Enemy.getAttack(), selectedPokemon.getDefense());
                    this.OurHP.Text = this.selectedPokemon.getHP().ToString();
                    if (this.selectedPokemon.getHP() <= 0)
                    {
                        this.pictureBox1.Image = null;
                        this.Ourname.Text = "*Eliminated*";
                        this.OurHP.Text = "0";
                    }
                }
                //test why does it not random ??? wtf
                //if (0 > -1) { this.test.Text = "Yes"; } else { this.test.Text = "No"; ; }
            }
        }
        private void Def_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null) { }
            else
            {
                // defend add shild
                //get attack
                //loss shild
                this.selectedPokemon.shild(this.Enemy.getAttack(), this.selectedPokemon.getDefense());
                this.OurHP.Text = this.selectedPokemon.getHP().ToString();
            }
        }
        int item = 3;
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.Image == null) { }
            else
            {
                // Heal
                if (item <=0) { }
                else
                {
                    if (this.selectedPokemon.getHP() <= 0) { }
                    else
                    {
                        this.selectedPokemon.Heal();
                        this.OurHP.Text = this.selectedPokemon.getHP().ToString();

                        item --;
                        //this.You_win.Text = item.ToString();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
