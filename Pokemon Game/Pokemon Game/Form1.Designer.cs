using System;

namespace Pokemon_Game
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
            this.Lizadon = new System.Windows.Forms.Button();
            this.Def = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Attack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Ourname = new System.Windows.Forms.TextBox();
            this.OurHP = new System.Windows.Forms.TextBox();
            this.EnemyHP = new System.Windows.Forms.TextBox();
            this.Enemyname = new System.Windows.Forms.TextBox();
            this.gyrados = new System.Windows.Forms.Button();
            this.backpack = new System.Windows.Forms.GroupBox();
            this.Lucario = new System.Windows.Forms.Button();
            this.tysomething = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.You_win = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.backpack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lizadon
            // 
            this.Lizadon.Location = new System.Drawing.Point(11, 21);
            this.Lizadon.Name = "Lizadon";
            this.Lizadon.Size = new System.Drawing.Size(211, 46);
            this.Lizadon.TabIndex = 6;
            this.Lizadon.Text = "Gylados";
            this.Lizadon.UseVisualStyleBackColor = true;
            this.Lizadon.Click += new System.EventHandler(this.button1_Click);
            // 
            // Def
            // 
            this.Def.Location = new System.Drawing.Point(6, 73);
            this.Def.Name = "Def";
            this.Def.Size = new System.Drawing.Size(211, 46);
            this.Def.TabIndex = 7;
            this.Def.Text = "Defense";
            this.Def.UseVisualStyleBackColor = true;
            this.Def.Click += new System.EventHandler(this.Def_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "Heal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(6, 177);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(211, 46);
            this.Change.TabIndex = 9;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Def);
            this.groupBox1.Controls.Add(this.Attack);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Change);
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 240);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comand";
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(6, 21);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(211, 46);
            this.Attack.TabIndex = 10;
            this.Attack.Text = "Attacks";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(683, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 240);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comand";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "Attacks";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(211, 46);
            this.button6.TabIndex = 7;
            this.button6.Text = "Defense";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(211, 46);
            this.button7.TabIndex = 8;
            this.button7.Text = "Heal";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 177);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(211, 46);
            this.button8.TabIndex = 9;
            this.button8.Text = "Change";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Ourname
            // 
            this.Ourname.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ourname.Location = new System.Drawing.Point(246, 84);
            this.Ourname.Multiline = true;
            this.Ourname.Name = "Ourname";
            this.Ourname.Size = new System.Drawing.Size(184, 45);
            this.Ourname.TabIndex = 14;
            // 
            // OurHP
            // 
            this.OurHP.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurHP.Location = new System.Drawing.Point(246, 157);
            this.OurHP.Multiline = true;
            this.OurHP.Name = "OurHP";
            this.OurHP.Size = new System.Drawing.Size(184, 45);
            this.OurHP.TabIndex = 15;
            // 
            // EnemyHP
            // 
            this.EnemyHP.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyHP.Location = new System.Drawing.Point(493, 157);
            this.EnemyHP.Multiline = true;
            this.EnemyHP.Name = "EnemyHP";
            this.EnemyHP.Size = new System.Drawing.Size(184, 45);
            this.EnemyHP.TabIndex = 17;
            // 
            // Enemyname
            // 
            this.Enemyname.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemyname.Location = new System.Drawing.Point(493, 84);
            this.Enemyname.Multiline = true;
            this.Enemyname.Name = "Enemyname";
            this.Enemyname.Size = new System.Drawing.Size(184, 45);
            this.Enemyname.TabIndex = 16;
            // 
            // gyrados
            // 
            this.gyrados.Location = new System.Drawing.Point(11, 73);
            this.gyrados.Name = "gyrados";
            this.gyrados.Size = new System.Drawing.Size(211, 46);
            this.gyrados.TabIndex = 11;
            this.gyrados.Text = "Lizadon";
            this.gyrados.UseVisualStyleBackColor = true;
            this.gyrados.Click += new System.EventHandler(this.gyrados_Click);
            // 
            // backpack
            // 
            this.backpack.Controls.Add(this.Lucario);
            this.backpack.Controls.Add(this.tysomething);
            this.backpack.Controls.Add(this.Lizadon);
            this.backpack.Controls.Add(this.gyrados);
            this.backpack.Location = new System.Drawing.Point(246, 287);
            this.backpack.Name = "backpack";
            this.backpack.Size = new System.Drawing.Size(228, 240);
            this.backpack.TabIndex = 13;
            this.backpack.TabStop = false;
            this.backpack.Text = "Backpack";
            this.backpack.Visible = false;
            // 
            // Lucario
            // 
            this.Lucario.Location = new System.Drawing.Point(11, 125);
            this.Lucario.Name = "Lucario";
            this.Lucario.Size = new System.Drawing.Size(211, 46);
            this.Lucario.TabIndex = 12;
            this.Lucario.Text = "Lucario";
            this.Lucario.UseVisualStyleBackColor = true;
            this.Lucario.Click += new System.EventHandler(this.Lucario_Click);
            // 
            // tysomething
            // 
            this.tysomething.Location = new System.Drawing.Point(11, 177);
            this.tysomething.Name = "tysomething";
            this.tysomething.Size = new System.Drawing.Size(211, 46);
            this.tysomething.TabIndex = 13;
            this.tysomething.Text = "Tyranitar";
            this.tysomething.UseVisualStyleBackColor = true;
            this.tysomething.Click += new System.EventHandler(this.tysomething_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Pokemon_Game.Properties.Resources.lizadon;
            this.pictureBox2.Location = new System.Drawing.Point(683, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // You_win
            // 
            this.You_win.BackColor = System.Drawing.Color.Snow;
            this.You_win.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.You_win.Dock = System.Windows.Forms.DockStyle.Top;
            this.You_win.Enabled = false;
            this.You_win.Font = new System.Drawing.Font("Agency FB", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.You_win.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.You_win.Location = new System.Drawing.Point(0, 0);
            this.You_win.Multiline = true;
            this.You_win.Name = "You_win";
            this.You_win.Size = new System.Drawing.Size(928, 64);
            this.You_win.TabIndex = 19;
            this.You_win.Text = "You win";
            this.You_win.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.You_win.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 539);
            this.Controls.Add(this.You_win);
            this.Controls.Add(this.backpack);
            this.Controls.Add(this.EnemyHP);
            this.Controls.Add(this.Enemyname);
            this.Controls.Add(this.OurHP);
            this.Controls.Add(this.Ourname);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.backpack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Lizadon;
        private System.Windows.Forms.Button Def;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox Ourname;
        private System.Windows.Forms.TextBox OurHP;
        private System.Windows.Forms.TextBox EnemyHP;
        private System.Windows.Forms.TextBox Enemyname;
        private System.Windows.Forms.Button gyrados;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.GroupBox backpack;
        private System.Windows.Forms.Button Lucario;
        private System.Windows.Forms.Button tysomething;
        private System.Windows.Forms.TextBox You_win;
    }
}

