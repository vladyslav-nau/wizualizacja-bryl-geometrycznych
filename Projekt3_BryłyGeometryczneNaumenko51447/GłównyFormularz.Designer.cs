namespace Projekt3_BryłyGeometryczneNaumenko51447
{
    partial class  GłównyFormularz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CbWybierzBryłęGeometryczną = new System.Windows.Forms.ComboBox();
            this.TbUstałPromieńBryły = new System.Windows.Forms.TrackBar();
            this.TbUstałWysokośćBryły = new System.Windows.Forms.TrackBar();
            this.TbKątNachyfeniaBryłyGeometrycznej = new System.Windows.Forms.TrackBar();
            this.BtnDodajNowąBryłę = new System.Windows.Forms.Button();
            this.PrzyciszKierunekObrotu = new System.Windows.Forms.Button();
            this.BtnUstawNoweAtrybutyGraficzne = new System.Windows.Forms.Button();
            this.BtnWulosujNowePołożenie = new System.Windows.Forms.Button();
            this.PbRysownica = new System.Windows.Forms.PictureBox();
            this.BtnUsuńPierwsząDodanąBryłę = new System.Windows.Forms.Button();
            this.BtnUsuńOstatnioDodanąBryłę = new System.Windows.Forms.Button();
            this.BtnUsuńWybranąBryłę = new System.Windows.Forms.Button();
            this.GbPokazSłajdów = new System.Windows.Forms.GroupBox();
            this.RbManual = new System.Windows.Forms.RadioButton();
            this.RbZegarowy = new System.Windows.Forms.RadioButton();
            this.PrzyciskWłączSlajder = new System.Windows.Forms.Button();
            this.TbNumerBryły = new System.Windows.Forms.TextBox();
            this.BtnNastępny = new System.Windows.Forms.Button();
            this.BtnPoprzedni = new System.Windows.Forms.Button();
            this.BtnWyłączSlajderPokazuBryłGeometrycznych = new System.Windows.Forms.Button();
            this.GbKryteriaPokazuBryłGeometrycznych = new System.Windows.Forms.GroupBox();
            this.RbPolePowierzchni = new System.Windows.Forms.RadioButton();
            this.RbObiętość = new System.Windows.Forms.RadioButton();
            this.RbWysokość = new System.Windows.Forms.RadioButton();
            this.TimerObrotów = new System.Windows.Forms.Timer(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NudStopieńWielokątaPodstałyBryły = new System.Windows.Forms.NumericUpDown();
            this.TimerSlajdera = new System.Windows.Forms.Timer(this.components);
            this.LblPromieńBryły = new System.Windows.Forms.Label();
            this.LblWysokośćBryły = new System.Windows.Forms.Label();
            this.LblStopieńWielokątaPostawyBryły = new System.Windows.Forms.Label();
            this.LblKątNachyleniaBryłyGeometrycznej = new System.Windows.Forms.Label();
            this.NudNumerUsuwanejBryły = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelkaBryła = new System.Windows.Forms.Panel();
            this.panelkaSlajdy = new System.Windows.Forms.Panel();
            this.panelkaUsuń = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PrzyciskPobraćObrazek = new System.Windows.Forms.Button();
            this.autor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TbUstałPromieńBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbUstałWysokośćBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbKątNachyfeniaBryłyGeometrycznej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRysownica)).BeginInit();
            this.GbPokazSłajdów.SuspendLayout();
            this.GbKryteriaPokazuBryłGeometrycznych.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStopieńWielokątaPodstałyBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumerUsuwanejBryły)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelkaBryła.SuspendLayout();
            this.panelkaSlajdy.SuspendLayout();
            this.panelkaUsuń.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbWybierzBryłęGeometryczną
            // 
            this.CbWybierzBryłęGeometryczną.FormattingEnabled = true;
            this.CbWybierzBryłęGeometryczną.Items.AddRange(new object[] {
            "Walec",
            "Stożek"});
            this.CbWybierzBryłęGeometryczną.Location = new System.Drawing.Point(81, 43);
            this.CbWybierzBryłęGeometryczną.Name = "CbWybierzBryłęGeometryczną";
            this.CbWybierzBryłęGeometryczną.Size = new System.Drawing.Size(128, 21);
            this.CbWybierzBryłęGeometryczną.TabIndex = 0;
            this.CbWybierzBryłęGeometryczną.Text = "TYP BRYŁY";
            this.CbWybierzBryłęGeometryczną.SelectedIndexChanged += new System.EventHandler(this.CbWybierzBryłęGeometryczną_SelectedIndexChanged);
            // 
            // TbUstałPromieńBryły
            // 
            this.TbUstałPromieńBryły.AutoSize = false;
            this.TbUstałPromieńBryły.Location = new System.Drawing.Point(81, 72);
            this.TbUstałPromieńBryły.Maximum = 90;
            this.TbUstałPromieńBryły.Minimum = 45;
            this.TbUstałPromieńBryły.Name = "TbUstałPromieńBryły";
            this.TbUstałPromieńBryły.Size = new System.Drawing.Size(128, 21);
            this.TbUstałPromieńBryły.TabIndex = 1;
            this.TbUstałPromieńBryły.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TbUstałPromieńBryły.Value = 75;
            // 
            // TbUstałWysokośćBryły
            // 
            this.TbUstałWysokośćBryły.AutoSize = false;
            this.TbUstałWysokośćBryły.Location = new System.Drawing.Point(81, 101);
            this.TbUstałWysokośćBryły.Maximum = 90;
            this.TbUstałWysokośćBryły.Minimum = 45;
            this.TbUstałWysokośćBryły.Name = "TbUstałWysokośćBryły";
            this.TbUstałWysokośćBryły.Size = new System.Drawing.Size(128, 21);
            this.TbUstałWysokośćBryły.TabIndex = 2;
            this.TbUstałWysokośćBryły.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TbUstałWysokośćBryły.Value = 75;
            // 
            // TbKątNachyfeniaBryłyGeometrycznej
            // 
            this.TbKątNachyfeniaBryłyGeometrycznej.AutoSize = false;
            this.TbKątNachyfeniaBryłyGeometrycznej.Location = new System.Drawing.Point(81, 130);
            this.TbKątNachyfeniaBryłyGeometrycznej.Maximum = 135;
            this.TbKątNachyfeniaBryłyGeometrycznej.Minimum = 45;
            this.TbKątNachyfeniaBryłyGeometrycznej.Name = "TbKątNachyfeniaBryłyGeometrycznej";
            this.TbKątNachyfeniaBryłyGeometrycznej.Size = new System.Drawing.Size(128, 21);
            this.TbKątNachyfeniaBryłyGeometrycznej.TabIndex = 5;
            this.TbKątNachyfeniaBryłyGeometrycznej.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TbKątNachyfeniaBryłyGeometrycznej.Value = 90;
            // 
            // BtnDodajNowąBryłę
            // 
            this.BtnDodajNowąBryłę.Location = new System.Drawing.Point(9, 205);
            this.BtnDodajNowąBryłę.Name = "BtnDodajNowąBryłę";
            this.BtnDodajNowąBryłę.Size = new System.Drawing.Size(200, 25);
            this.BtnDodajNowąBryłę.TabIndex = 6;
            this.BtnDodajNowąBryłę.Text = "Dodaj nową bryłę";
            this.BtnDodajNowąBryłę.UseVisualStyleBackColor = true;
            this.BtnDodajNowąBryłę.Click += new System.EventHandler(this.Przycisk_DodajNowąBryłę_Click);
            // 
            // PrzyciszKierunekObrotu
            // 
            this.PrzyciszKierunekObrotu.Location = new System.Drawing.Point(71, 186);
            this.PrzyciszKierunekObrotu.Name = "PrzyciszKierunekObrotu";
            this.PrzyciszKierunekObrotu.Size = new System.Drawing.Size(96, 37);
            this.PrzyciszKierunekObrotu.TabIndex = 8;
            this.PrzyciszKierunekObrotu.Text = "Zmienić kierunek obroty";
            this.PrzyciszKierunekObrotu.UseVisualStyleBackColor = true;
            this.PrzyciszKierunekObrotu.Click += new System.EventHandler(this.Przycisk_KierunekObrotu_Click);
            // 
            // BtnUstawNoweAtrybutyGraficzne
            // 
            this.BtnUstawNoweAtrybutyGraficzne.Location = new System.Drawing.Point(9, 238);
            this.BtnUstawNoweAtrybutyGraficzne.Name = "BtnUstawNoweAtrybutyGraficzne";
            this.BtnUstawNoweAtrybutyGraficzne.Size = new System.Drawing.Size(96, 40);
            this.BtnUstawNoweAtrybutyGraficzne.TabIndex = 9;
            this.BtnUstawNoweAtrybutyGraficzne.Text = "Wylosuj nowe atrybuty";
            this.BtnUstawNoweAtrybutyGraficzne.UseVisualStyleBackColor = true;
            this.BtnUstawNoweAtrybutyGraficzne.Click += new System.EventHandler(this.Przycisk_UstawNoweAtrybutyGraficzne_Click);
            // 
            // BtnWulosujNowePołożenie
            // 
            this.BtnWulosujNowePołożenie.Location = new System.Drawing.Point(113, 238);
            this.BtnWulosujNowePołożenie.Name = "BtnWulosujNowePołożenie";
            this.BtnWulosujNowePołożenie.Size = new System.Drawing.Size(96, 40);
            this.BtnWulosujNowePołożenie.TabIndex = 10;
            this.BtnWulosujNowePołożenie.Text = "Wylosuj nowe położenie";
            this.BtnWulosujNowePołożenie.UseVisualStyleBackColor = true;
            this.BtnWulosujNowePołożenie.Click += new System.EventHandler(this.Przycisk_WulosujNowePołożenie_Click);
            // 
            // PbRysownica
            // 
            this.PbRysownica.BackColor = System.Drawing.Color.White;
            this.PbRysownica.Location = new System.Drawing.Point(235, 58);
            this.PbRysownica.Name = "PbRysownica";
            this.PbRysownica.Size = new System.Drawing.Size(616, 500);
            this.PbRysownica.TabIndex = 12;
            this.PbRysownica.TabStop = false;
            // 
            // BtnUsuńPierwsząDodanąBryłę
            // 
            this.BtnUsuńPierwsząDodanąBryłę.Location = new System.Drawing.Point(10, 38);
            this.BtnUsuńPierwsząDodanąBryłę.Name = "BtnUsuńPierwsząDodanąBryłę";
            this.BtnUsuńPierwsząDodanąBryłę.Size = new System.Drawing.Size(200, 25);
            this.BtnUsuńPierwsząDodanąBryłę.TabIndex = 13;
            this.BtnUsuńPierwsząDodanąBryłę.Text = "Usuń pierwszą dodaną bryłę";
            this.BtnUsuńPierwsząDodanąBryłę.UseVisualStyleBackColor = true;
            this.BtnUsuńPierwsząDodanąBryłę.Click += new System.EventHandler(this.BtnUsuńPierwsząDodanąBryłę_Click);
            // 
            // BtnUsuńOstatnioDodanąBryłę
            // 
            this.BtnUsuńOstatnioDodanąBryłę.Location = new System.Drawing.Point(10, 71);
            this.BtnUsuńOstatnioDodanąBryłę.Name = "BtnUsuńOstatnioDodanąBryłę";
            this.BtnUsuńOstatnioDodanąBryłę.Size = new System.Drawing.Size(200, 25);
            this.BtnUsuńOstatnioDodanąBryłę.TabIndex = 14;
            this.BtnUsuńOstatnioDodanąBryłę.Text = "Usuń ostatnio dodaną bryłę";
            this.BtnUsuńOstatnioDodanąBryłę.UseVisualStyleBackColor = true;
            this.BtnUsuńOstatnioDodanąBryłę.Click += new System.EventHandler(this.Przycisk_UsuńOstatnioDodanąBryłę_Click);
            // 
            // BtnUsuńWybranąBryłę
            // 
            this.BtnUsuńWybranąBryłę.Location = new System.Drawing.Point(10, 104);
            this.BtnUsuńWybranąBryłę.Name = "BtnUsuńWybranąBryłę";
            this.BtnUsuńWybranąBryłę.Size = new System.Drawing.Size(128, 25);
            this.BtnUsuńWybranąBryłę.TabIndex = 15;
            this.BtnUsuńWybranąBryłę.Text = "Usuń wybraną bryłę";
            this.BtnUsuńWybranąBryłę.UseVisualStyleBackColor = true;
            this.BtnUsuńWybranąBryłę.Click += new System.EventHandler(this.BtnUsuńWybranąBryłę_Click);
            // 
            // GbPokazSłajdów
            // 
            this.GbPokazSłajdów.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GbPokazSłajdów.Controls.Add(this.RbManual);
            this.GbPokazSłajdów.Controls.Add(this.RbZegarowy);
            this.GbPokazSłajdów.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbPokazSłajdów.Location = new System.Drawing.Point(10, 38);
            this.GbPokazSłajdów.Name = "GbPokazSłajdów";
            this.GbPokazSłajdów.Padding = new System.Windows.Forms.Padding(5);
            this.GbPokazSłajdów.Size = new System.Drawing.Size(200, 75);
            this.GbPokazSłajdów.TabIndex = 17;
            this.GbPokazSłajdów.TabStop = false;
            this.GbPokazSłajdów.Text = "Pokaz słajdów";
            // 
            // RbManual
            // 
            this.RbManual.AutoSize = true;
            this.RbManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbManual.Location = new System.Drawing.Point(10, 48);
            this.RbManual.Margin = new System.Windows.Forms.Padding(5);
            this.RbManual.Name = "RbManual";
            this.RbManual.Size = new System.Drawing.Size(59, 17);
            this.RbManual.TabIndex = 1;
            this.RbManual.TabStop = true;
            this.RbManual.Text = "Manual";
            this.RbManual.UseVisualStyleBackColor = true;
            // 
            // RbZegarowy
            // 
            this.RbZegarowy.AutoSize = true;
            this.RbZegarowy.Checked = true;
            this.RbZegarowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbZegarowy.Location = new System.Drawing.Point(10, 23);
            this.RbZegarowy.Margin = new System.Windows.Forms.Padding(5);
            this.RbZegarowy.Name = "RbZegarowy";
            this.RbZegarowy.Size = new System.Drawing.Size(71, 17);
            this.RbZegarowy.TabIndex = 0;
            this.RbZegarowy.TabStop = true;
            this.RbZegarowy.Text = "Zegarowy";
            this.RbZegarowy.UseVisualStyleBackColor = true;
            // 
            // PrzyciskWłączSlajder
            // 
            this.PrzyciskWłączSlajder.Location = new System.Drawing.Point(867, 281);
            this.PrzyciskWłączSlajder.Name = "PrzyciskWłączSlajder";
            this.PrzyciskWłączSlajder.Size = new System.Drawing.Size(200, 25);
            this.PrzyciskWłączSlajder.TabIndex = 18;
            this.PrzyciskWłączSlajder.Text = "Włącz slajder";
            this.PrzyciskWłączSlajder.UseVisualStyleBackColor = true;
            this.PrzyciskWłączSlajder.Click += new System.EventHandler(this.Przycisk_WłączSlajder_Click);
            // 
            // TbNumerBryły
            // 
            this.TbNumerBryły.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbNumerBryły.Location = new System.Drawing.Point(942, 252);
            this.TbNumerBryły.Name = "TbNumerBryły";
            this.TbNumerBryły.Size = new System.Drawing.Size(50, 20);
            this.TbNumerBryły.TabIndex = 19;
            this.TbNumerBryły.Text = "NUMER";
            this.TbNumerBryły.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnNastępny
            // 
            this.BtnNastępny.Location = new System.Drawing.Point(867, 250);
            this.BtnNastępny.Name = "BtnNastępny";
            this.BtnNastępny.Size = new System.Drawing.Size(65, 25);
            this.BtnNastępny.TabIndex = 20;
            this.BtnNastępny.Text = "Następny";
            this.BtnNastępny.UseVisualStyleBackColor = true;
            this.BtnNastępny.Click += new System.EventHandler(this.BtnNastępny_Click);
            // 
            // BtnPoprzedni
            // 
            this.BtnPoprzedni.Location = new System.Drawing.Point(1002, 250);
            this.BtnPoprzedni.Name = "BtnPoprzedni";
            this.BtnPoprzedni.Size = new System.Drawing.Size(65, 25);
            this.BtnPoprzedni.TabIndex = 21;
            this.BtnPoprzedni.Text = "Poprzedni";
            this.BtnPoprzedni.UseVisualStyleBackColor = true;
            this.BtnPoprzedni.Click += new System.EventHandler(this.BtnPoprzedni_Click);
            // 
            // BtnWyłączSlajderPokazuBryłGeometrycznych
            // 
            this.BtnWyłączSlajderPokazuBryłGeometrycznych.Location = new System.Drawing.Point(867, 314);
            this.BtnWyłączSlajderPokazuBryłGeometrycznych.Name = "BtnWyłączSlajderPokazuBryłGeometrycznych";
            this.BtnWyłączSlajderPokazuBryłGeometrycznych.Size = new System.Drawing.Size(200, 25);
            this.BtnWyłączSlajderPokazuBryłGeometrycznych.TabIndex = 22;
            this.BtnWyłączSlajderPokazuBryłGeometrycznych.Text = "Wyłącz slajder";
            this.BtnWyłączSlajderPokazuBryłGeometrycznych.UseVisualStyleBackColor = true;
            this.BtnWyłączSlajderPokazuBryłGeometrycznych.Click += new System.EventHandler(this.Przycisk_WyłączSlajderPokazuBryłGeometrycznych_Click);
            // 
            // GbKryteriaPokazuBryłGeometrycznych
            // 
            this.GbKryteriaPokazuBryłGeometrycznych.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GbKryteriaPokazuBryłGeometrycznych.Controls.Add(this.RbPolePowierzchni);
            this.GbKryteriaPokazuBryłGeometrycznych.Controls.Add(this.RbObiętość);
            this.GbKryteriaPokazuBryłGeometrycznych.Controls.Add(this.RbWysokość);
            this.GbKryteriaPokazuBryłGeometrycznych.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbKryteriaPokazuBryłGeometrycznych.Location = new System.Drawing.Point(10, 121);
            this.GbKryteriaPokazuBryłGeometrycznych.Name = "GbKryteriaPokazuBryłGeometrycznych";
            this.GbKryteriaPokazuBryłGeometrycznych.Padding = new System.Windows.Forms.Padding(5);
            this.GbKryteriaPokazuBryłGeometrycznych.Size = new System.Drawing.Size(200, 100);
            this.GbKryteriaPokazuBryłGeometrycznych.TabIndex = 23;
            this.GbKryteriaPokazuBryłGeometrycznych.TabStop = false;
            this.GbKryteriaPokazuBryłGeometrycznych.Text = "Kryteria pokazu brył geometrycznych";
            // 
            // RbPolePowierzchni
            // 
            this.RbPolePowierzchni.AutoSize = true;
            this.RbPolePowierzchni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbPolePowierzchni.Location = new System.Drawing.Point(10, 73);
            this.RbPolePowierzchni.Margin = new System.Windows.Forms.Padding(5);
            this.RbPolePowierzchni.Name = "RbPolePowierzchni";
            this.RbPolePowierzchni.Size = new System.Drawing.Size(104, 17);
            this.RbPolePowierzchni.TabIndex = 3;
            this.RbPolePowierzchni.TabStop = true;
            this.RbPolePowierzchni.Text = "Pole powierzchni";
            this.RbPolePowierzchni.UseVisualStyleBackColor = true;
            // 
            // RbObiętość
            // 
            this.RbObiętość.AutoSize = true;
            this.RbObiętość.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbObiętość.Location = new System.Drawing.Point(10, 48);
            this.RbObiętość.Margin = new System.Windows.Forms.Padding(5);
            this.RbObiętość.Name = "RbObiętość";
            this.RbObiętość.Size = new System.Drawing.Size(66, 17);
            this.RbObiętość.TabIndex = 2;
            this.RbObiętość.TabStop = true;
            this.RbObiętość.Text = "Obiętość";
            this.RbObiętość.UseVisualStyleBackColor = true;
            // 
            // RbWysokość
            // 
            this.RbWysokość.AutoSize = true;
            this.RbWysokość.Checked = true;
            this.RbWysokość.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RbWysokość.Location = new System.Drawing.Point(10, 23);
            this.RbWysokość.Margin = new System.Windows.Forms.Padding(5);
            this.RbWysokość.Name = "RbWysokość";
            this.RbWysokość.Size = new System.Drawing.Size(74, 17);
            this.RbWysokość.TabIndex = 0;
            this.RbWysokość.TabStop = true;
            this.RbWysokość.Text = "Wysokość";
            this.RbWysokość.UseVisualStyleBackColor = true;
            // 
            // TimerObrotów
            // 
            this.TimerObrotów.Enabled = true;
            this.TimerObrotów.Tick += new System.EventHandler(this.CzasObrotów_Tick);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // NudStopieńWielokątaPodstałyBryły
            // 
            this.NudStopieńWielokątaPodstałyBryły.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudStopieńWielokątaPodstałyBryły.Location = new System.Drawing.Point(81, 166);
            this.NudStopieńWielokątaPodstałyBryły.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.NudStopieńWielokątaPodstałyBryły.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudStopieńWielokątaPodstałyBryły.Name = "NudStopieńWielokątaPodstałyBryły";
            this.NudStopieńWielokątaPodstałyBryły.Size = new System.Drawing.Size(128, 20);
            this.NudStopieńWielokątaPodstałyBryły.TabIndex = 24;
            this.NudStopieńWielokątaPodstałyBryły.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudStopieńWielokątaPodstałyBryły.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimerSlajdera
            // 
            this.TimerSlajdera.Interval = 1000;
            this.TimerSlajdera.Tag = "0";
            this.TimerSlajdera.Tick += new System.EventHandler(this.TimerSlajdera_Tick);
            // 
            // LblPromieńBryły
            // 
            this.LblPromieńBryły.AutoSize = true;
            this.LblPromieńBryły.BackColor = System.Drawing.SystemColors.Control;
            this.LblPromieńBryły.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblPromieńBryły.Location = new System.Drawing.Point(10, 76);
            this.LblPromieńBryły.Margin = new System.Windows.Forms.Padding(3);
            this.LblPromieńBryły.Name = "LblPromieńBryły";
            this.LblPromieńBryły.Size = new System.Drawing.Size(45, 13);
            this.LblPromieńBryły.TabIndex = 25;
            this.LblPromieńBryły.Text = "Promień";
            // 
            // LblWysokośćBryły
            // 
            this.LblWysokośćBryły.AutoSize = true;
            this.LblWysokośćBryły.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblWysokośćBryły.Location = new System.Drawing.Point(10, 105);
            this.LblWysokośćBryły.Margin = new System.Windows.Forms.Padding(3);
            this.LblWysokośćBryły.Name = "LblWysokośćBryły";
            this.LblWysokośćBryły.Size = new System.Drawing.Size(57, 13);
            this.LblWysokośćBryły.TabIndex = 26;
            this.LblWysokośćBryły.Text = "Wysokość";
            // 
            // LblStopieńWielokątaPostawyBryły
            // 
            this.LblStopieńWielokątaPostawyBryły.AutoSize = true;
            this.LblStopieńWielokątaPostawyBryły.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblStopieńWielokątaPostawyBryły.Location = new System.Drawing.Point(10, 163);
            this.LblStopieńWielokątaPostawyBryły.Margin = new System.Windows.Forms.Padding(3);
            this.LblStopieńWielokątaPostawyBryły.Name = "LblStopieńWielokątaPostawyBryły";
            this.LblStopieńWielokątaPostawyBryły.Size = new System.Drawing.Size(52, 26);
            this.LblStopieńWielokątaPostawyBryły.TabIndex = 27;
            this.LblStopieńWielokątaPostawyBryły.Text = "Stopień\r\nwielokąta";
            // 
            // LblKątNachyleniaBryłyGeometrycznej
            // 
            this.LblKątNachyleniaBryłyGeometrycznej.AutoSize = true;
            this.LblKątNachyleniaBryłyGeometrycznej.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblKątNachyleniaBryłyGeometrycznej.Location = new System.Drawing.Point(10, 134);
            this.LblKątNachyleniaBryłyGeometrycznej.Margin = new System.Windows.Forms.Padding(3);
            this.LblKątNachyleniaBryłyGeometrycznej.Name = "LblKątNachyleniaBryłyGeometrycznej";
            this.LblKątNachyleniaBryłyGeometrycznej.Size = new System.Drawing.Size(60, 13);
            this.LblKątNachyleniaBryłyGeometrycznej.TabIndex = 28;
            this.LblKątNachyleniaBryłyGeometrycznej.Text = "Nachylenie";
            // 
            // NudNumerUsuwanejBryły
            // 
            this.NudNumerUsuwanejBryły.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NudNumerUsuwanejBryły.Location = new System.Drawing.Point(145, 106);
            this.NudNumerUsuwanejBryły.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudNumerUsuwanejBryły.Name = "NudNumerUsuwanejBryły";
            this.NudNumerUsuwanejBryły.Size = new System.Drawing.Size(65, 20);
            this.NudNumerUsuwanejBryły.TabIndex = 29;
            this.NudNumerUsuwanejBryły.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Projekt3_BryłyGeometryczneNaumenko51447.Properties.Resources.walec;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bryła";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "BRYŁA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "SLAJDY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelkaBryła
            // 
            this.panelkaBryła.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelkaBryła.BackColor = System.Drawing.SystemColors.Control;
            this.panelkaBryła.Controls.Add(this.TbKątNachyfeniaBryłyGeometrycznej);
            this.panelkaBryła.Controls.Add(this.LblKątNachyleniaBryłyGeometrycznej);
            this.panelkaBryła.Controls.Add(this.CbWybierzBryłęGeometryczną);
            this.panelkaBryła.Controls.Add(this.label1);
            this.panelkaBryła.Controls.Add(this.TbUstałPromieńBryły);
            this.panelkaBryła.Controls.Add(this.TbUstałWysokośćBryły);
            this.panelkaBryła.Controls.Add(this.BtnDodajNowąBryłę);
            this.panelkaBryła.Controls.Add(this.LblStopieńWielokątaPostawyBryły);
            this.panelkaBryła.Controls.Add(this.BtnUstawNoweAtrybutyGraficzne);
            this.panelkaBryła.Controls.Add(this.BtnWulosujNowePołożenie);
            this.panelkaBryła.Controls.Add(this.LblWysokośćBryły);
            this.panelkaBryła.Controls.Add(this.NudStopieńWielokątaPodstałyBryły);
            this.panelkaBryła.Controls.Add(this.LblPromieńBryły);
            this.panelkaBryła.Controls.Add(this.label2);
            this.panelkaBryła.Location = new System.Drawing.Point(9, 270);
            this.panelkaBryła.Name = "panelkaBryła";
            this.panelkaBryła.Padding = new System.Windows.Forms.Padding(5);
            this.panelkaBryła.Size = new System.Drawing.Size(220, 288);
            this.panelkaBryła.TabIndex = 35;
            // 
            // panelkaSlajdy
            // 
            this.panelkaSlajdy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelkaSlajdy.Controls.Add(this.label4);
            this.panelkaSlajdy.Controls.Add(this.GbPokazSłajdów);
            this.panelkaSlajdy.Controls.Add(this.GbKryteriaPokazuBryłGeometrycznych);
            this.panelkaSlajdy.Location = new System.Drawing.Point(857, 12);
            this.panelkaSlajdy.Name = "panelkaSlajdy";
            this.panelkaSlajdy.Padding = new System.Windows.Forms.Padding(5);
            this.panelkaSlajdy.Size = new System.Drawing.Size(220, 232);
            this.panelkaSlajdy.TabIndex = 36;
            // 
            // panelkaUsuń
            // 
            this.panelkaUsuń.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelkaUsuń.Controls.Add(this.label5);
            this.panelkaUsuń.Controls.Add(this.textBox1);
            this.panelkaUsuń.Controls.Add(this.button1);
            this.panelkaUsuń.Controls.Add(this.button2);
            this.panelkaUsuń.Controls.Add(this.NudNumerUsuwanejBryły);
            this.panelkaUsuń.Controls.Add(this.BtnUsuńPierwsząDodanąBryłę);
            this.panelkaUsuń.Controls.Add(this.BtnUsuńOstatnioDodanąBryłę);
            this.panelkaUsuń.Controls.Add(this.BtnUsuńWybranąBryłę);
            this.panelkaUsuń.Location = new System.Drawing.Point(857, 417);
            this.panelkaUsuń.Name = "panelkaUsuń";
            this.panelkaUsuń.Padding = new System.Windows.Forms.Padding(5);
            this.panelkaUsuń.Size = new System.Drawing.Size(220, 141);
            this.panelkaUsuń.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "USUNIENIE BRYŁY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(76, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "NUMER";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Następny";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(136, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Poprzedni";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PrzyciskPobraćObrazek
            // 
            this.PrzyciskPobraćObrazek.Location = new System.Drawing.Point(776, 12);
            this.PrzyciskPobraćObrazek.Name = "PrzyciskPobraćObrazek";
            this.PrzyciskPobraćObrazek.Size = new System.Drawing.Size(75, 40);
            this.PrzyciskPobraćObrazek.TabIndex = 38;
            this.PrzyciskPobraćObrazek.Text = "Pobrać obrazek";
            this.PrzyciskPobraćObrazek.UseVisualStyleBackColor = true;
            this.PrzyciskPobraćObrazek.Click += new System.EventHandler(this.Przycisk_PobraćObrazek_Click);
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(970, 564);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(107, 13);
            this.autor.TabIndex = 39;
            this.autor.Text = "Vladyslav Naumenko";
            // 
            // GłównyFormularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 582);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.PrzyciszKierunekObrotu);
            this.Controls.Add(this.PrzyciskPobraćObrazek);
            this.Controls.Add(this.TbNumerBryły);
            this.Controls.Add(this.panelkaUsuń);
            this.Controls.Add(this.BtnNastępny);
            this.Controls.Add(this.panelkaSlajdy);
            this.Controls.Add(this.BtnPoprzedni);
            this.Controls.Add(this.panelkaBryła);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PbRysownica);
            this.Controls.Add(this.BtnWyłączSlajderPokazuBryłGeometrycznych);
            this.Controls.Add(this.PrzyciskWłączSlajder);
            this.Name = "GłównyFormularz";
            this.Text = "Bryły geometryczne";
            this.Load += new System.EventHandler(this.GłównyFormularz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbUstałPromieńBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbUstałWysokośćBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbKątNachyfeniaBryłyGeometrycznej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRysownica)).EndInit();
            this.GbPokazSłajdów.ResumeLayout(false);
            this.GbPokazSłajdów.PerformLayout();
            this.GbKryteriaPokazuBryłGeometrycznych.ResumeLayout(false);
            this.GbKryteriaPokazuBryłGeometrycznych.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStopieńWielokątaPodstałyBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumerUsuwanejBryły)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelkaBryła.ResumeLayout(false);
            this.panelkaBryła.PerformLayout();
            this.panelkaSlajdy.ResumeLayout(false);
            this.panelkaUsuń.ResumeLayout(false);
            this.panelkaUsuń.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox  CbWybierzBryłęGeometryczną;
        private System.Windows.Forms.TrackBar  TbUstałPromieńBryły;
        private System.Windows.Forms.TrackBar  TbUstałWysokośćBryły;
        private System.Windows.Forms.TrackBar  TbKątNachyfeniaBryłyGeometrycznej;
        private System.Windows.Forms.Button  BtnDodajNowąBryłę;
        private System.Windows.Forms.Button  PrzyciszKierunekObrotu;
        private System.Windows.Forms.Button  BtnUstawNoweAtrybutyGraficzne;
        private System.Windows.Forms.Button  BtnWulosujNowePołożenie;
        private System.Windows.Forms.PictureBox  PbRysownica;
        private System.Windows.Forms.Button  BtnUsuńPierwsząDodanąBryłę;
        private System.Windows.Forms.Button  BtnUsuńOstatnioDodanąBryłę;
        private System.Windows.Forms.Button  BtnUsuńWybranąBryłę;
        private System.Windows.Forms.GroupBox  GbPokazSłajdów;
        private System.Windows.Forms.Button  PrzyciskWłączSlajder;
        private System.Windows.Forms.TextBox  TbNumerBryły;
        private System.Windows.Forms.Button  BtnNastępny;
        private System.Windows.Forms.Button  BtnPoprzedni;
        private System.Windows.Forms.Button  BtnWyłączSlajderPokazuBryłGeometrycznych;
        private System.Windows.Forms.GroupBox  GbKryteriaPokazuBryłGeometrycznych;
        private System.Windows.Forms.RadioButton  RbPolePowierzchni;
        private System.Windows.Forms.RadioButton  RbObiętość;
        private System.Windows.Forms.RadioButton  RbWysokość;
        public System.Windows.Forms.Timer  TimerObrotów;
        private System.Windows.Forms.ErrorProvider  ErrorProvider;
        private System.Windows.Forms.NumericUpDown  NudStopieńWielokątaPodstałyBryły;
        private System.Windows.Forms.RadioButton  RbManual;
        private System.Windows.Forms.RadioButton  RbZegarowy;
        private System.Windows.Forms.Timer  TimerSlajdera;
        private System.Windows.Forms.Label  LblPromieńBryły;
        private System.Windows.Forms.Label  LblWysokośćBryły;
        private System.Windows.Forms.Label  LblStopieńWielokątaPostawyBryły;
        private System.Windows.Forms.Label  LblKątNachyleniaBryłyGeometrycznej;
        private System.Windows.Forms.NumericUpDown  NudNumerUsuwanejBryły;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelkaBryła;
        private System.Windows.Forms.Panel panelkaSlajdy;
        private System.Windows.Forms.Panel panelkaUsuń;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PrzyciskPobraćObrazek;
        private System.Windows.Forms.Label autor;
    }
}

