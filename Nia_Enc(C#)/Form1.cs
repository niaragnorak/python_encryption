using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;

namespace Nia_Enc
{
    public partial class entry_page : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox onestring;
        private TextBox threestring;
        private TextBox fourstring;
        private TextBox twostring;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox oneencryption;
        private TextBox threeencryption;
        private TextBox twoencryption;
        private Button oneencrypt;
        private Button fourencrypt;
        private Button threeencrypt;
        private Button twoencrypt;
        private PictureBox pictureBox1;
        private Label label11;
        private CheckBox decryptone;
        private CheckBox decryptfour;
        private CheckBox decryptthree;
        private CheckBox decryptwo;
        private Label encryptedstring;
        private CheckBox chooseencryptedstringabove;
        private CheckBox enterencryptedstring;
        private Label label14;
        private TextBox onedeckey;
        private TextBox threedeckey;
        private TextBox twodeckey;
        private Label label15;
        private TextBox todecrypt;
        private Label label13;
        private Button Decrypt;
        private Label label16;
        private Label label17;
        private Label date;
        private Label time;
        private Timer timer1;
        private IContainer components;
        private Label label18;
        private Label decryptedstring;
        private Button button1;
        private Button button2;
        private PictureBox Logo_Nia;

        public entry_page()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entry_page));
            this.Logo_Nia = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.onestring = new System.Windows.Forms.TextBox();
            this.threestring = new System.Windows.Forms.TextBox();
            this.fourstring = new System.Windows.Forms.TextBox();
            this.twostring = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.oneencryption = new System.Windows.Forms.TextBox();
            this.threeencryption = new System.Windows.Forms.TextBox();
            this.twoencryption = new System.Windows.Forms.TextBox();
            this.oneencrypt = new System.Windows.Forms.Button();
            this.fourencrypt = new System.Windows.Forms.Button();
            this.threeencrypt = new System.Windows.Forms.Button();
            this.twoencrypt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.decryptone = new System.Windows.Forms.CheckBox();
            this.decryptfour = new System.Windows.Forms.CheckBox();
            this.decryptthree = new System.Windows.Forms.CheckBox();
            this.decryptwo = new System.Windows.Forms.CheckBox();
            this.encryptedstring = new System.Windows.Forms.Label();
            this.chooseencryptedstringabove = new System.Windows.Forms.CheckBox();
            this.enterencryptedstring = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.onedeckey = new System.Windows.Forms.TextBox();
            this.threedeckey = new System.Windows.Forms.TextBox();
            this.twodeckey = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.todecrypt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.decryptedstring = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Nia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo_Nia
            // 
            this.Logo_Nia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logo_Nia.Image = ((System.Drawing.Image)(resources.GetObject("Logo_Nia.Image")));
            this.Logo_Nia.Location = new System.Drawing.Point(558, 12);
            this.Logo_Nia.Name = "Logo_Nia";
            this.Logo_Nia.Size = new System.Drawing.Size(359, 185);
            this.Logo_Nia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo_Nia.TabIndex = 0;
            this.Logo_Nia.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(16, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.Custom Encryption Format\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(463, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.Vigen`ere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(832, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "3.Caesar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(1064, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "4.AES(Advanced Encryption Standard)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter String to Encrypt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Enter String to Encrypt(ALL UPPERCASE)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(720, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter String to Encrypt(Only alphabets)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1179, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter String to Encrypt";
            // 
            // onestring
            // 
            this.onestring.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onestring.ForeColor = System.Drawing.Color.Crimson;
            this.onestring.Location = new System.Drawing.Point(37, 308);
            this.onestring.Name = "onestring";
            this.onestring.Size = new System.Drawing.Size(263, 27);
            this.onestring.TabIndex = 9;
            // 
            // threestring
            // 
            this.threestring.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threestring.ForeColor = System.Drawing.Color.SeaGreen;
            this.threestring.Location = new System.Drawing.Point(741, 308);
            this.threestring.Name = "threestring";
            this.threestring.Size = new System.Drawing.Size(263, 27);
            this.threestring.TabIndex = 10;
            // 
            // fourstring
            // 
            this.fourstring.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourstring.ForeColor = System.Drawing.Color.ForestGreen;
            this.fourstring.Location = new System.Drawing.Point(1150, 367);
            this.fourstring.Name = "fourstring";
            this.fourstring.Size = new System.Drawing.Size(263, 27);
            this.fourstring.TabIndex = 11;
            // 
            // twostring
            // 
            this.twostring.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twostring.ForeColor = System.Drawing.Color.Purple;
            this.twostring.Location = new System.Drawing.Point(384, 308);
            this.twostring.Name = "twostring";
            this.twostring.Size = new System.Drawing.Size(263, 27);
            this.twostring.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(51, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Enter Encryption Key(E.G: 11)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(701, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(376, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "Enter Encryption Key(Integer between 0-25)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(362, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(295, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "Enter Encryption Key(E.G: BIXBY)";
            // 
            // oneencryption
            // 
            this.oneencryption.ForeColor = System.Drawing.Color.DarkBlue;
            this.oneencryption.Location = new System.Drawing.Point(81, 413);
            this.oneencryption.Name = "oneencryption";
            this.oneencryption.Size = new System.Drawing.Size(154, 20);
            this.oneencryption.TabIndex = 17;
            // 
            // threeencryption
            // 
            this.threeencryption.ForeColor = System.Drawing.Color.DarkBlue;
            this.threeencryption.Location = new System.Drawing.Point(785, 413);
            this.threeencryption.Name = "threeencryption";
            this.threeencryption.Size = new System.Drawing.Size(154, 20);
            this.threeencryption.TabIndex = 19;
            // 
            // twoencryption
            // 
            this.twoencryption.ForeColor = System.Drawing.Color.DarkBlue;
            this.twoencryption.Location = new System.Drawing.Point(424, 413);
            this.twoencryption.Name = "twoencryption";
            this.twoencryption.Size = new System.Drawing.Size(154, 20);
            this.twoencryption.TabIndex = 20;
            // 
            // oneencrypt
            // 
            this.oneencrypt.BackColor = System.Drawing.Color.Gold;
            this.oneencrypt.Font = new System.Drawing.Font("hooge 05_53", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneencrypt.ForeColor = System.Drawing.Color.DarkRed;
            this.oneencrypt.Location = new System.Drawing.Point(81, 458);
            this.oneencrypt.Name = "oneencrypt";
            this.oneencrypt.Size = new System.Drawing.Size(154, 57);
            this.oneencrypt.TabIndex = 21;
            this.oneencrypt.Text = "Encrypt";
            this.oneencrypt.UseVisualStyleBackColor = false;
            this.oneencrypt.Click += new System.EventHandler(this.oneencrypt_Click);
            // 
            // fourencrypt
            // 
            this.fourencrypt.BackColor = System.Drawing.Color.Gold;
            this.fourencrypt.Font = new System.Drawing.Font("hooge 05_53", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourencrypt.ForeColor = System.Drawing.Color.DarkRed;
            this.fourencrypt.Location = new System.Drawing.Point(1203, 458);
            this.fourencrypt.Name = "fourencrypt";
            this.fourencrypt.Size = new System.Drawing.Size(154, 57);
            this.fourencrypt.TabIndex = 22;
            this.fourencrypt.Text = "Encrypt";
            this.fourencrypt.UseVisualStyleBackColor = false;
            this.fourencrypt.Click += new System.EventHandler(this.fourencrypt_Click);
            // 
            // threeencrypt
            // 
            this.threeencrypt.BackColor = System.Drawing.Color.Gold;
            this.threeencrypt.Font = new System.Drawing.Font("hooge 05_53", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeencrypt.ForeColor = System.Drawing.Color.DarkRed;
            this.threeencrypt.Location = new System.Drawing.Point(785, 458);
            this.threeencrypt.Name = "threeencrypt";
            this.threeencrypt.Size = new System.Drawing.Size(154, 57);
            this.threeencrypt.TabIndex = 23;
            this.threeencrypt.Text = "Encrypt";
            this.threeencrypt.UseVisualStyleBackColor = false;
            this.threeencrypt.Click += new System.EventHandler(this.threeencrypt_Click);
            // 
            // twoencrypt
            // 
            this.twoencrypt.BackColor = System.Drawing.Color.Gold;
            this.twoencrypt.Font = new System.Drawing.Font("hooge 05_53", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoencrypt.ForeColor = System.Drawing.Color.DarkRed;
            this.twoencrypt.Location = new System.Drawing.Point(424, 458);
            this.twoencrypt.Name = "twoencrypt";
            this.twoencrypt.Size = new System.Drawing.Size(154, 57);
            this.twoencrypt.TabIndex = 24;
            this.twoencrypt.Text = "Encrypt";
            this.twoencrypt.UseVisualStyleBackColor = false;
            this.twoencrypt.Click += new System.EventHandler(this.twoencrypt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 707);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label11.Location = new System.Drawing.Point(361, 661);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(389, 27);
            this.label11.TabIndex = 27;
            this.label11.Text = "Choose Encrypted Format(Choose One):";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // decryptone
            // 
            this.decryptone.AutoSize = true;
            this.decryptone.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptone.ForeColor = System.Drawing.Color.Olive;
            this.decryptone.Location = new System.Drawing.Point(442, 702);
            this.decryptone.Name = "decryptone";
            this.decryptone.Size = new System.Drawing.Size(265, 25);
            this.decryptone.TabIndex = 28;
            this.decryptone.Text = "Custom Encryption Format";
            this.decryptone.UseVisualStyleBackColor = true;
            this.decryptone.CheckedChanged += new System.EventHandler(this.decryptone_CheckedChanged);
            // 
            // decryptfour
            // 
            this.decryptfour.AutoSize = true;
            this.decryptfour.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptfour.ForeColor = System.Drawing.Color.Olive;
            this.decryptfour.Location = new System.Drawing.Point(442, 814);
            this.decryptfour.Name = "decryptfour";
            this.decryptfour.Size = new System.Drawing.Size(64, 25);
            this.decryptfour.TabIndex = 29;
            this.decryptfour.Text = "AES";
            this.decryptfour.UseVisualStyleBackColor = true;
            this.decryptfour.CheckedChanged += new System.EventHandler(this.decryptfour_CheckedChanged);
            // 
            // decryptthree
            // 
            this.decryptthree.AutoSize = true;
            this.decryptthree.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptthree.ForeColor = System.Drawing.Color.Olive;
            this.decryptthree.Location = new System.Drawing.Point(442, 774);
            this.decryptthree.Name = "decryptthree";
            this.decryptthree.Size = new System.Drawing.Size(91, 25);
            this.decryptthree.TabIndex = 30;
            this.decryptthree.Text = "Caesar";
            this.decryptthree.UseVisualStyleBackColor = true;
            this.decryptthree.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // decryptwo
            // 
            this.decryptwo.AutoSize = true;
            this.decryptwo.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptwo.ForeColor = System.Drawing.Color.Olive;
            this.decryptwo.Location = new System.Drawing.Point(442, 739);
            this.decryptwo.Name = "decryptwo";
            this.decryptwo.Size = new System.Drawing.Size(118, 25);
            this.decryptwo.TabIndex = 31;
            this.decryptwo.Text = "Vigen`ere";
            this.decryptwo.UseVisualStyleBackColor = true;
            this.decryptwo.CheckedChanged += new System.EventHandler(this.decryptwo_CheckedChanged);
            // 
            // encryptedstring
            // 
            this.encryptedstring.AutoSize = true;
            this.encryptedstring.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedstring.ForeColor = System.Drawing.Color.Navy;
            this.encryptedstring.Location = new System.Drawing.Point(719, 581);
            this.encryptedstring.Name = "encryptedstring";
            this.encryptedstring.Size = new System.Drawing.Size(171, 25);
            this.encryptedstring.TabIndex = 32;
            this.encryptedstring.Text = "*(Encrypted String)";
            // 
            // chooseencryptedstringabove
            // 
            this.chooseencryptedstringabove.AutoSize = true;
            this.chooseencryptedstringabove.ForeColor = System.Drawing.Color.Blue;
            this.chooseencryptedstringabove.Location = new System.Drawing.Point(1180, 702);
            this.chooseencryptedstringabove.Name = "chooseencryptedstringabove";
            this.chooseencryptedstringabove.Size = new System.Drawing.Size(177, 17);
            this.chooseencryptedstringabove.TabIndex = 33;
            this.chooseencryptedstringabove.Text = "Choose Encrypted String Above";
            this.chooseencryptedstringabove.UseVisualStyleBackColor = true;
            // 
            // enterencryptedstring
            // 
            this.enterencryptedstring.AutoSize = true;
            this.enterencryptedstring.ForeColor = System.Drawing.Color.Blue;
            this.enterencryptedstring.Location = new System.Drawing.Point(1183, 745);
            this.enterencryptedstring.Name = "enterencryptedstring";
            this.enterencryptedstring.Size = new System.Drawing.Size(132, 17);
            this.enterencryptedstring.TabIndex = 34;
            this.enterencryptedstring.Text = "Enter Encrypted String";
            this.enterencryptedstring.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(806, 661);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(261, 24);
            this.label14.TabIndex = 35;
            this.label14.Text = "Enter Encryption Key(E.G: 34)";
            // 
            // onedeckey
            // 
            this.onedeckey.ForeColor = System.Drawing.Color.DarkBlue;
            this.onedeckey.Location = new System.Drawing.Point(810, 707);
            this.onedeckey.Name = "onedeckey";
            this.onedeckey.Size = new System.Drawing.Size(154, 20);
            this.onedeckey.TabIndex = 36;
            // 
            // threedeckey
            // 
            this.threedeckey.ForeColor = System.Drawing.Color.DarkBlue;
            this.threedeckey.Location = new System.Drawing.Point(810, 779);
            this.threedeckey.Name = "threedeckey";
            this.threedeckey.Size = new System.Drawing.Size(154, 20);
            this.threedeckey.TabIndex = 37;
            // 
            // twodeckey
            // 
            this.twodeckey.ForeColor = System.Drawing.Color.DarkBlue;
            this.twodeckey.Location = new System.Drawing.Point(810, 745);
            this.twodeckey.Name = "twodeckey";
            this.twodeckey.Size = new System.Drawing.Size(154, 20);
            this.twodeckey.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(1121, 661);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(282, 24);
            this.label15.TabIndex = 39;
            this.label15.Text = "Choose Which String to Decrypt:";
            // 
            // todecrypt
            // 
            this.todecrypt.Font = new System.Drawing.Font("MS Outlook", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.todecrypt.Location = new System.Drawing.Point(1124, 776);
            this.todecrypt.Name = "todecrypt";
            this.todecrypt.Size = new System.Drawing.Size(289, 27);
            this.todecrypt.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(464, 585);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 21);
            this.label13.TabIndex = 41;
            this.label13.Text = "Encrypted String:";
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Orchid;
            this.Decrypt.Font = new System.Drawing.Font("hooge 05_53", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.Color.DarkRed;
            this.Decrypt.Location = new System.Drawing.Point(807, 910);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(154, 57);
            this.Decrypt.TabIndex = 42;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.OliveDrab;
            this.label16.Location = new System.Drawing.Point(1064, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 25);
            this.label16.TabIndex = 43;
            this.label16.Text = "DATE:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.OliveDrab;
            this.label17.Location = new System.Drawing.Point(1064, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 25);
            this.label17.TabIndex = 44;
            this.label17.Text = "TIME:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Crimson;
            this.date.Location = new System.Drawing.Point(1180, 45);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 31);
            this.date.TabIndex = 45;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Crimson;
            this.time.Location = new System.Drawing.Point(1180, 84);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 31);
            this.time.TabIndex = 46;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Brown;
            this.label18.Location = new System.Drawing.Point(512, 853);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(219, 31);
            this.label18.TabIndex = 47;
            this.label18.Text = "Decrypted String:";
            // 
            // decryptedstring
            // 
            this.decryptedstring.AutoSize = true;
            this.decryptedstring.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedstring.ForeColor = System.Drawing.Color.Navy;
            this.decryptedstring.Location = new System.Drawing.Point(777, 840);
            this.decryptedstring.Name = "decryptedstring";
            this.decryptedstring.Size = new System.Drawing.Size(319, 47);
            this.decryptedstring.TabIndex = 48;
            this.decryptedstring.Text = "*(Decrypted String)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("hooge 05_53", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1069, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 57);
            this.button1.TabIndex = 49;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("hooge 05_53", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(1150, 910);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 57);
            this.button2.TabIndex = 50;
            this.button2.Text = "*Encrypt Files*";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // entry_page
            // 
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1633, 995);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decryptedstring);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.todecrypt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.twodeckey);
            this.Controls.Add(this.threedeckey);
            this.Controls.Add(this.onedeckey);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.enterencryptedstring);
            this.Controls.Add(this.chooseencryptedstringabove);
            this.Controls.Add(this.encryptedstring);
            this.Controls.Add(this.decryptwo);
            this.Controls.Add(this.decryptthree);
            this.Controls.Add(this.decryptfour);
            this.Controls.Add(this.decryptone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.twoencrypt);
            this.Controls.Add(this.threeencrypt);
            this.Controls.Add(this.fourencrypt);
            this.Controls.Add(this.oneencrypt);
            this.Controls.Add(this.twoencryption);
            this.Controls.Add(this.threeencryption);
            this.Controls.Add(this.oneencryption);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.twostring);
            this.Controls.Add(this.fourstring);
            this.Controls.Add(this.threestring);
            this.Controls.Add(this.onestring);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo_Nia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "entry_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.entry_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_Nia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void entry_page_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.date.Text = now.ToShortDateString();
            this.time.Text = now.ToShortTimeString();
        }
        private string dec;
        private void EncryptAesManaged(string raw)
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string    
                    byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
                    // Print encrypted string    
                    //Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
                    // Decrypt the bytes to a string.    
                    string dec1 = DecryptString1(encrypted, aes.Key, aes.IV);
                    dec = raw;
                    // Print decrypted string. It should be same as raw data    
                    string res = System.Text.Encoding.UTF8.GetString(encrypted);
                    this.encryptedstring.Text = res;

                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            //Console.ReadKey();
        }
        private static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return encrypted;
        }
        private static string DecryptString1(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        private void oneencrypt_Click(object sender, EventArgs e)
        {
            string encrypt_text = this.onestring.Text;
            string enc = this.oneencryption.Text;
            int encryption_key = int.Parse(enc);
            var engine = Python.CreateEngine();
            string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path_customEncryption = path_directory + "\\custom_encryption.py";
            var source = engine.CreateScriptSourceFromFile(path_customEncryption);
            var scope = engine.CreateScope();
            source.Execute(scope);
            var custom_encryption= scope.GetVariable("custom_encryption");
            var custom_encryption_instance= engine.Operations.CreateInstance(custom_encryption);
            var encrypted = custom_encryption_instance.Encryption(encrypt_text, encryption_key);
            this.encryptedstring.Text = encrypted;
        }
        private void demo()
        {
            var engine = Python.CreateEngine();
            string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path_customEncryption = path_directory + "\\custom_encryption.py";
            var source = engine.CreateScriptSourceFromFile(path_customEncryption);
            var scope = engine.CreateScope();
            source.Execute(scope);
            var classCalculator = scope.GetVariable("calculator");
            //initializing class
            var calculatorInstance = engine.Operations.CreateInstance(classCalculator);
            Console.WriteLine("From Iron Python");
            Console.WriteLine("5 + 10 = {0}", calculatorInstance.add(5, 10));
            Console.WriteLine("5++ = {0}", calculatorInstance.increment(5));
            string addv = calculatorInstance.add(5, 10);
            this.encryptedstring.Text = addv;
            /*//Create engine
            var engine = Python.CreateEngine();
            //provide script and argument
            string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path_customEncryption = path_directory + "\\custom_encryption.py";
            var source = engine.CreateScriptSourceFromFile(path_customEncryption);
            /*
             * var argv=new List<string>();
             * argv.add("");
             * argv.Add("ajnvapov");
             * argv.Add("dknvfrvj");
             * engine.GetSysModule().SetVariable("argv",argv);
             */

            /*//Output redirect
            var eIO = engine.Runtime.IO;
            var errors = new MemoryStream();
            eIO.SetErrorOutput(errors, Encoding.Default);
            eIO.SetErrorOutput(errors, Encoding.Default);

            var results = new MemoryStream();
            eIO.SetOutput(results, Encoding.Default);
            //execute script

            var scope = engine.CreateScope();
            scope.Engine.Execute(source.ToString());

            //display output
            Console.WriteLine("err:");
            Console.WriteLine((errors.ToArray()));
            Console.WriteLine();
            Console.WriteLine("Resuts");
            Console.WriteLine((results.ToArray()));
            */
        }

        private void fourencrypt_Click(object sender, EventArgs e)
        {
            string encrypt_text = this.onestring.Text;
            EncryptAesManaged(encrypt_text);
            
        }

        private void threeencrypt_Click(object sender, EventArgs e)
        {
            string encrypt_text = this.threestring.Text;
            string enc = this.threeencryption.Text;
            int encryption_key = int.Parse(enc);
            var engine = Python.CreateEngine();
            string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path_customEncryption = path_directory + "\\caesar.py";
            var source = engine.CreateScriptSourceFromFile(path_customEncryption);
            var scope = engine.CreateScope();
            source.Execute(scope);
            var custom_encryption = scope.GetVariable("caesar");
            var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
            var encrypted = custom_encryption_instance.encrypt(encrypt_text, encryption_key);
            this.encryptedstring.Text = encrypted;
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (decryptone.Checked)
            {
                string enckey1 = this.onedeckey.Text;
                int encryption_key1 = int.Parse(enckey1);
                if (chooseencryptedstringabove.Checked)
                {
                    string enc1 = this.encryptedstring.Text;
                    this.todecrypt.Text = enc1;
                    var engine = Python.CreateEngine();
                    string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var path_customEncryption = path_directory + "\\custom_encryption.py";
                    var source = engine.CreateScriptSourceFromFile(path_customEncryption);
                    var scope = engine.CreateScope();
                    source.Execute(scope);
                    var custom_encryption = scope.GetVariable("custom_encryption");
                    var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
                    var decrypted1 = custom_encryption_instance.decryption(enc1, encryption_key1);
                    this.decryptedstring.Text = decrypted1;
                }else if (enterencryptedstring.Checked)
                {
                    string enc1 = this.todecrypt.Text;
                    //this.todecrypt.Text = enc1;
                    var engine = Python.CreateEngine();
                    string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var path_customEncryption = path_directory + "\\custom_encryption.py";
                    var source = engine.CreateScriptSourceFromFile(path_customEncryption);
                    var scope = engine.CreateScope();
                    source.Execute(scope);
                    var custom_encryption = scope.GetVariable("custom_encryption");
                    var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
                    var decrypted1 = custom_encryption_instance.decryption(enc1, encryption_key1);
                    this.decryptedstring.Text = decrypted1;
                }
            }
            else if (decryptfour.Checked)
            {
                if (chooseencryptedstringabove.Checked)
                {
                    this.decryptedstring.Text = this.fourstring.Text;

                }
                else if (enterencryptedstring.Checked)
                {
                    this.decryptedstring.Text = this.fourstring.Text;
                }
            }
            else if (decryptthree.Checked)
            {
                string enckey1 = this.threedeckey.Text;
                int encryption_key1 = 26-int.Parse(enckey1);
                if (chooseencryptedstringabove.Checked)
                {
                    string enc1 = this.encryptedstring.Text;
                    this.todecrypt.Text = enc1;
                    var engine = Python.CreateEngine();
                    string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var path_customEncryption = path_directory + "\\caesar.py";
                    var source = engine.CreateScriptSourceFromFile(path_customEncryption);
                    var scope = engine.CreateScope();
                    source.Execute(scope);
                    var custom_encryption = scope.GetVariable("caesar");
                    var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
                    var decrypted1 = custom_encryption_instance.encrypt(enc1, encryption_key1);
                    this.decryptedstring.Text = decrypted1;
                }
                else if (enterencryptedstring.Checked)
                {
                    string enc1 = this.todecrypt.Text;
                    //this.todecrypt.Text = enc1;
                    var engine = Python.CreateEngine();
                    string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var path_customEncryption = path_directory + "\\caesar.py";
                    var source = engine.CreateScriptSourceFromFile(path_customEncryption);
                    var scope = engine.CreateScope();
                    source.Execute(scope);
                    var custom_encryption = scope.GetVariable("caesar");
                    var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
                    var decrypted1 = custom_encryption_instance.encrypt(enc1, encryption_key1);
                    this.decryptedstring.Text = decrypted1;
                }
            }
            else if (decryptwo.Checked)
            {
                string enckey1 = this.twodeckey.Text;
                enckey1.ToUpper();
                if (chooseencryptedstringabove.Checked)
                {
                    string enc1 = this.encryptedstring.Text;
                    this.todecrypt.Text = enc1;
                    var engine = Python.CreateEngine();
                    string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var path_customEncryption = path_directory + "\\vigenere.py";
                    var source = engine.CreateScriptSourceFromFile(path_customEncryption);
                    var scope = engine.CreateScope();
                    source.Execute(scope);
                    var custom_encryption = scope.GetVariable("vigenere");
                    var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
                    //var key1 = custom_encryption_instance.generateKey(enc1, enckey1);
                    //string key = key1.ToString();
                    var decrypted1 = custom_encryption_instance.originalText(enc1, vigenerekey);
                    this.decryptedstring.Text = decrypted1;
                }
                else if (enterencryptedstring.Checked)
                {
                    string enc1 = this.todecrypt.Text;
                    //this.todecrypt.Text = enc1;
                    var engine = Python.CreateEngine();
                    string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    var path_customEncryption = path_directory + "\\vigenere.py";
                    var source = engine.CreateScriptSourceFromFile(path_customEncryption);
                    var scope = engine.CreateScope();
                    source.Execute(scope);
                    var custom_encryption = scope.GetVariable("vigenere");
                    var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
                    //var key1 = custom_encryption_instance.generateKey(enc1, enckey1);
                    //string key = key1.ToString();
                    var decrypted1 = custom_encryption_instance.originalText(enc1, vigenerekey);
                    this.decryptedstring.Text = decrypted1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private string vigenerekey;
        private void twoencrypt_Click(object sender, EventArgs e)
        {
            string encrypt_text = this.twostring.Text;
            string enc = this.twoencryption.Text;
            enc.ToUpper();
            var engine = Python.CreateEngine();
            string path_directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path_customEncryption = path_directory + "\\vigenere.py";
            var source = engine.CreateScriptSourceFromFile(path_customEncryption);
            var scope = engine.CreateScope();
            source.Execute(scope);
            var custom_encryption = scope.GetVariable("vigenere");
            var custom_encryption_instance = engine.Operations.CreateInstance(custom_encryption);
            string key= custom_encryption_instance.generateKey(encrypt_text, enc);
            vigenerekey = key;
            var encrypted = custom_encryption_instance.cipherText(encrypt_text, key);
            this.encryptedstring.Text = encrypted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj1 = new Form2();
            obj1.Show();
            //this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void decryptfour_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void decryptone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void decryptwo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
