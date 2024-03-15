namespace ControlsTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "ONE PIECE", "ECHIRO ODA", "SHONEN" }, -1, Color.Empty, Color.Empty, new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "BLEACH", "TITE KUBO", "SHONEN" }, -1, Color.Empty, Color.Empty, new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0));
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "DRAGON BALL", "AKIRA TORIYAMA", "SHONEN" }, -1, Color.Empty, Color.Empty, new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode1 = new TreeNode("BLEACH");
            TreeNode treeNode2 = new TreeNode("ONE PIECE");
            TreeNode treeNode3 = new TreeNode("DRAGON BALL");
            TreeNode treeNode4 = new TreeNode("SHONEN", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("DEATH NOTE");
            TreeNode treeNode6 = new TreeNode("BERSERK");
            TreeNode treeNode7 = new TreeNode("VINLAND SAGA");
            TreeNode treeNode8 = new TreeNode("SEINEN", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("ANIME", new TreeNode[] { treeNode4, treeNode8 });
            button1 = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            listView1 = new ListView();
            headerAnime = new ColumnHeader();
            headerAutor = new ColumnHeader();
            headerType = new ColumnHeader();
            maskedTextBox1 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            radiobutton = new RadioButton();
            richTextBox1 = new RichTextBox();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            radioButton2 = new RadioButton();
            monthCalendar1 = new MonthCalendar();
            notifyIcon1 = new NotifyIcon(components);
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(24, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "BANKAI";
            toolTip1.SetToolTip(button1, "PULSA EL BOTON\r\n");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Location = new Point(24, 68);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "BLEACH>>>>>>>narutozzz";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "GOJO SATORUOU", "RYOMEN FRADKUNA", "YUTA OKKOTSU" });
            comboBox1.Location = new Point(365, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(567, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 28);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 27);
            label1.TabIndex = 5;
            label1.Text = "SAVE SOUL SOCIETY KUROSAKI ICHIGO";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(252, 182);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(279, 26);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "BEST SCENE IN THE WHOLE ANIME";
            linkLabel1.UseCompatibleTextRendering = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "KUROSAKI ICHIGO", "KUCHIKI BYAKUYA", "ZARAKI KENPANCHI" });
            listBox1.Location = new Point(24, 207);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Columns.AddRange(new ColumnHeader[] { headerAnime, headerAutor, headerType });
            listView1.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.HideSelection = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.LabelEdit = true;
            listView1.Location = new Point(12, 318);
            listView1.Name = "listView1";
            listView1.Size = new Size(290, 120);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // headerAnime
            // 
            headerAnime.Text = "ANIME";
            // 
            // headerAutor
            // 
            headerAutor.Text = "AUTOR";
            // 
            // headerType
            // 
            headerType.Text = "TYPE";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F);
            maskedTextBox1.Location = new Point(159, 222);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(80, 29);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = SystemColors.MenuBar;
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Font = new Font("Microsoft PhagsPa", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(359, 307);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 33);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(793, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ActiveBorder;
            progressBar1.Location = new Point(334, 346);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 32);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 12;
            // 
            // radiobutton
            // 
            radiobutton.AutoSize = true;
            radiobutton.Cursor = Cursors.Hand;
            radiobutton.FlatAppearance.CheckedBackColor = Color.Lime;
            radiobutton.FlatStyle = FlatStyle.Flat;
            radiobutton.Location = new Point(489, 232);
            radiobutton.Name = "radiobutton";
            radiobutton.Size = new Size(43, 19);
            radiobutton.TabIndex = 13;
            radiobutton.TabStop = true;
            radiobutton.Text = "YES";
            radiobutton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.OrangeRed;
            richTextBox1.Location = new Point(763, 318);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(211, 96);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "MI CORAZON ENCANTADO VIBRA POR EL POLVO DE ESPERANZA Y MAGIA\nDEL UNIVERSO QUE AMBICIONAN TODOS POSEER";
            // 
            // toolTip1
            // 
            toolTip1.BackColor = SystemColors.Highlight;
            toolTip1.ForeColor = SystemColors.Highlight;
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Microsoft PhagsPa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            treeView1.Location = new Point(567, 131);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo4";
            treeNode1.Text = "BLEACH";
            treeNode2.Name = "Nodo5";
            treeNode2.Text = "ONE PIECE";
            treeNode3.Name = "Nodo6";
            treeNode3.Text = "DRAGON BALL";
            treeNode4.Name = "Nodo1";
            treeNode4.Text = "SHONEN";
            treeNode5.Name = "Nodo3";
            treeNode5.Text = "DEATH NOTE";
            treeNode6.Name = "Nodo7";
            treeNode6.Text = "BERSERK";
            treeNode7.Name = "Nodo8";
            treeNode7.Text = "VINLAND SAGA";
            treeNode8.Name = "Nodo2";
            treeNode8.Text = "SEINEN";
            treeNode9.Name = "Nodo0";
            treeNode9.Text = "ANIME";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode9 });
            treeView1.Size = new Size(170, 77);
            treeView1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 59);
            label2.Name = "label2";
            label2.Size = new Size(187, 18);
            label2.TabIndex = 17;
            label2.Text = "SELECT YOUR CHARACTER:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BorderStyle = BorderStyle.None;
            checkedListBox1.Cursor = Cursors.Hand;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "ZANKA NO TACHI", "SAKASHIMA YOKOSHIMA HAPPOFUSAGARI", "HAKA NO TOGAME", "KAMISHIRI NO YARI" });
            checkedListBox1.Location = new Point(24, 107);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(260, 72);
            checkedListBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(165, 201);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 19;
            label3.Text = "Birthdate:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(422, 211);
            label4.Name = "label4";
            label4.Size = new Size(238, 18);
            label4.TabIndex = 20;
            label4.Text = "ICHIGO IS BETTER THAN NARUTO?";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.FlatAppearance.CheckedBackColor = Color.Lime;
            radioButton2.FlatStyle = FlatStyle.Flat;
            radioButton2.Location = new Point(489, 257);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(42, 19);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "NO";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(503, 307);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 22;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(788, 283);
            label5.Name = "label5";
            label5.Size = new Size(186, 18);
            label5.TabIndex = 23;
            label5.Text = "LYRICS OF THE BEST SONG";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(339, 286);
            label6.Name = "label6";
            label6.Size = new Size(95, 18);
            label6.TabIndex = 24;
            label6.Text = "FILL THE BAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(986, 499);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(radioButton2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(treeView1);
            Controls.Add(richTextBox1);
            Controls.Add(radiobutton);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(maskedTextBox1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private ListView listView1;
        private ColumnHeader headerAnime;
        private ColumnHeader headerType;
        private Label label5;
        private Label label6;
        private ColumnHeader headerAutor;
        private MaskedTextBox maskedTextBox1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton radiobutton;
        private RichTextBox richTextBox1;
        private ToolTip toolTip1;
        private TreeView treeView1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private Label label4;
        private RadioButton radioButton2;
        private MonthCalendar monthCalendar1;
        private NotifyIcon notifyIcon1;
    }
}
