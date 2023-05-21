namespace db_form
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
            dataGridView1 = new DataGridView();
            tabControl = new TabControl();
            connect = new TabPage();
            label1 = new Label();
            connection_state = new Label();
            disconnect_button = new Button();
            db_info = new Label();
            connect_button = new Button();
            select = new TabPage();
            genre_input = new ComboBox();
            label12 = new Label();
            rating_to_input = new NumericUpDown();
            rating_from_input = new NumericUpDown();
            rating_to = new Label();
            rating_from = new Label();
            film_rating = new Label();
            select_result = new Button();
            title_input = new TextBox();
            film_title = new Label();
            type = new Label();
            choose_type = new ComboBox();
            insert = new TabPage();
            tabControl1 = new TabControl();
            film = new TabPage();
            label30 = new Label();
            insert_film_rating = new NumericUpDown();
            label29 = new Label();
            insert_film_type = new ComboBox();
            insert_film_description = new TextBox();
            label28 = new Label();
            insert_film_button = new Button();
            insert_film_title = new TextBox();
            label24 = new Label();
            label27 = new Label();
            person = new TabPage();
            insert_person_button = new Button();
            insert_person_gender = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            insert_person_name = new TextBox();
            label13 = new Label();
            genre = new TabPage();
            insert_genre_name = new TextBox();
            label18 = new Label();
            label17 = new Label();
            insert_genre_description = new TextBox();
            label16 = new Label();
            insert_genre_button = new Button();
            add_person = new TabPage();
            person_add_film = new ComboBox();
            person_role_add_film = new ComboBox();
            label19 = new Label();
            label22 = new Label();
            label20 = new Label();
            insert_person_film_button = new Button();
            film_add_person = new ComboBox();
            label21 = new Label();
            add_genre = new TabPage();
            genre_add_film = new ComboBox();
            label23 = new Label();
            label25 = new Label();
            insert_genre_film_button = new Button();
            film_add_genre = new ComboBox();
            label26 = new Label();
            update = new TabPage();
            update_film_title = new ComboBox();
            update_film_button = new Button();
            update_film_rating = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            update_film_description = new TextBox();
            label8 = new Label();
            label9 = new Label();
            delete = new TabPage();
            delete_genre_film_button = new Button();
            delete_genre_film = new ComboBox();
            label38 = new Label();
            label39 = new Label();
            delete_film_genre = new ComboBox();
            label40 = new Label();
            delete_person_film_button = new Button();
            delete_person_film = new ComboBox();
            label35 = new Label();
            label36 = new Label();
            delete_film_person = new ComboBox();
            label37 = new Label();
            delete_genre_button = new Button();
            label34 = new Label();
            delete_genre_name = new ComboBox();
            label33 = new Label();
            delete_person_button = new Button();
            label32 = new Label();
            delete_person_name = new ComboBox();
            label31 = new Label();
            delete_film_title = new ComboBox();
            delete_film = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            film_insert = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl.SuspendLayout();
            connect.SuspendLayout();
            select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rating_to_input).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rating_from_input).BeginInit();
            insert.SuspendLayout();
            tabControl1.SuspendLayout();
            film.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)insert_film_rating).BeginInit();
            person.SuspendLayout();
            genre.SuspendLayout();
            add_person.SuspendLayout();
            add_genre.SuspendLayout();
            update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)update_film_rating).BeginInit();
            delete.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLightLight;
            dataGridView1.Location = new Point(36, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1330, 775);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(connect);
            tabControl.Controls.Add(select);
            tabControl.Controls.Add(insert);
            tabControl.Controls.Add(update);
            tabControl.Controls.Add(delete);
            tabControl.Location = new Point(2, -2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1729, 1089);
            tabControl.TabIndex = 1;
            // 
            // connect
            // 
            connect.Controls.Add(label1);
            connect.Controls.Add(connection_state);
            connect.Controls.Add(disconnect_button);
            connect.Controls.Add(db_info);
            connect.Controls.Add(connect_button);
            connect.Location = new Point(8, 46);
            connect.Name = "connect";
            connect.Size = new Size(1713, 1035);
            connect.TabIndex = 3;
            connect.Text = "connect";
            connect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 395);
            label1.Name = "label1";
            label1.Size = new Size(354, 59);
            label1.TabIndex = 4;
            label1.Text = "Connection state:";
            // 
            // connection_state
            // 
            connection_state.AutoSize = true;
            connection_state.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            connection_state.Location = new Point(416, 395);
            connection_state.Name = "connection_state";
            connection_state.Size = new Size(137, 59);
            connection_state.TabIndex = 3;
            connection_state.Text = "label1";
            // 
            // disconnect_button
            // 
            disconnect_button.Location = new Point(293, 237);
            disconnect_button.Name = "disconnect_button";
            disconnect_button.Size = new Size(184, 67);
            disconnect_button.TabIndex = 2;
            disconnect_button.Text = "Disconnect";
            disconnect_button.UseVisualStyleBackColor = true;
            disconnect_button.Click += disconnect_button_Click;
            // 
            // db_info
            // 
            db_info.AutoSize = true;
            db_info.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            db_info.Location = new Point(39, 84);
            db_info.Name = "db_info";
            db_info.Size = new Size(616, 89);
            db_info.TabIndex = 1;
            db_info.Text = "Filmworks database";
            // 
            // connect_button
            // 
            connect_button.Location = new Point(56, 237);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(184, 67);
            connect_button.TabIndex = 0;
            connect_button.Text = "Connect";
            connect_button.UseVisualStyleBackColor = true;
            connect_button.Click += connect_button_Click;
            // 
            // select
            // 
            select.Controls.Add(genre_input);
            select.Controls.Add(label12);
            select.Controls.Add(rating_to_input);
            select.Controls.Add(rating_from_input);
            select.Controls.Add(rating_to);
            select.Controls.Add(rating_from);
            select.Controls.Add(film_rating);
            select.Controls.Add(select_result);
            select.Controls.Add(title_input);
            select.Controls.Add(film_title);
            select.Controls.Add(type);
            select.Controls.Add(choose_type);
            select.Controls.Add(dataGridView1);
            select.Location = new Point(8, 46);
            select.Name = "select";
            select.Padding = new Padding(3);
            select.Size = new Size(1713, 1035);
            select.TabIndex = 0;
            select.Text = "select";
            select.UseVisualStyleBackColor = true;
            // 
            // genre_input
            // 
            genre_input.AutoCompleteMode = AutoCompleteMode.Suggest;
            genre_input.AutoCompleteSource = AutoCompleteSource.CustomSource;
            genre_input.FormattingEnabled = true;
            genre_input.Location = new Point(1426, 675);
            genre_input.Name = "genre_input";
            genre_input.Size = new Size(242, 40);
            genre_input.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1430, 611);
            label12.Name = "label12";
            label12.Size = new Size(138, 32);
            label12.TabIndex = 17;
            label12.Text = "Enter genre";
            // 
            // rating_to_input
            // 
            rating_to_input.DecimalPlaces = 1;
            rating_to_input.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            rating_to_input.Location = new Point(1615, 522);
            rating_to_input.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            rating_to_input.Name = "rating_to_input";
            rating_to_input.Size = new Size(90, 39);
            rating_to_input.TabIndex = 16;
            rating_to_input.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // rating_from_input
            // 
            rating_from_input.DecimalPlaces = 1;
            rating_from_input.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            rating_from_input.Location = new Point(1491, 522);
            rating_from_input.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            rating_from_input.Name = "rating_from_input";
            rating_from_input.Size = new Size(76, 39);
            rating_from_input.TabIndex = 15;
            rating_from_input.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // rating_to
            // 
            rating_to.AutoSize = true;
            rating_to.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rating_to.Location = new Point(1578, 530);
            rating_to.Name = "rating_to";
            rating_to.Size = new Size(31, 25);
            rating_to.TabIndex = 14;
            rating_to.Text = "To";
            // 
            // rating_from
            // 
            rating_from.AutoSize = true;
            rating_from.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            rating_from.Location = new Point(1430, 530);
            rating_from.Name = "rating_from";
            rating_from.Size = new Size(55, 25);
            rating_from.TabIndex = 11;
            rating_from.Text = "From";
            // 
            // film_rating
            // 
            film_rating.AutoSize = true;
            film_rating.Location = new Point(1430, 458);
            film_rating.Name = "film_rating";
            film_rating.Size = new Size(138, 32);
            film_rating.TabIndex = 9;
            film_rating.Text = "Enter rating";
            // 
            // select_result
            // 
            select_result.Location = new Point(1426, 759);
            select_result.Name = "select_result";
            select_result.Size = new Size(150, 46);
            select_result.TabIndex = 6;
            select_result.Text = "Result";
            select_result.UseVisualStyleBackColor = true;
            select_result.Click += select_result_Click;
            // 
            // title_input
            // 
            title_input.Location = new Point(1426, 352);
            title_input.Name = "title_input";
            title_input.Size = new Size(242, 39);
            title_input.TabIndex = 5;
            // 
            // film_title
            // 
            film_title.AutoSize = true;
            film_title.Location = new Point(1426, 289);
            film_title.Name = "film_title";
            film_title.Size = new Size(117, 32);
            film_title.TabIndex = 4;
            film_title.Text = "Enter title";
            // 
            // type
            // 
            type.AutoSize = true;
            type.Location = new Point(1426, 131);
            type.Name = "type";
            type.Size = new Size(148, 32);
            type.TabIndex = 2;
            type.Text = "Choose type";
            // 
            // choose_type
            // 
            choose_type.FormattingEnabled = true;
            choose_type.Items.AddRange(new object[] { "movie", "tv show", "series" });
            choose_type.Location = new Point(1426, 191);
            choose_type.Name = "choose_type";
            choose_type.Size = new Size(242, 40);
            choose_type.TabIndex = 1;
            // 
            // insert
            // 
            insert.Controls.Add(tabControl1);
            insert.Location = new Point(8, 46);
            insert.Name = "insert";
            insert.Padding = new Padding(3);
            insert.Size = new Size(1713, 1035);
            insert.TabIndex = 1;
            insert.Text = "insert";
            insert.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(film);
            tabControl1.Controls.Add(person);
            tabControl1.Controls.Add(genre);
            tabControl1.Controls.Add(add_person);
            tabControl1.Controls.Add(add_genre);
            tabControl1.Location = new Point(6, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1718, 1037);
            tabControl1.TabIndex = 39;
            // 
            // film
            // 
            film.Controls.Add(label30);
            film.Controls.Add(insert_film_rating);
            film.Controls.Add(label29);
            film.Controls.Add(insert_film_type);
            film.Controls.Add(insert_film_description);
            film.Controls.Add(label28);
            film.Controls.Add(insert_film_button);
            film.Controls.Add(insert_film_title);
            film.Controls.Add(label24);
            film.Controls.Add(label27);
            film.Location = new Point(8, 46);
            film.Name = "film";
            film.Size = new Size(1702, 983);
            film.TabIndex = 5;
            film.Text = "film";
            film.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(76, 588);
            label30.Name = "label30";
            label30.Size = new Size(76, 32);
            label30.TabIndex = 37;
            label30.Text = "rating";
            // 
            // insert_film_rating
            // 
            insert_film_rating.DecimalPlaces = 1;
            insert_film_rating.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            insert_film_rating.Location = new Point(76, 634);
            insert_film_rating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            insert_film_rating.Name = "insert_film_rating";
            insert_film_rating.Size = new Size(103, 39);
            insert_film_rating.TabIndex = 36;
            insert_film_rating.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(76, 333);
            label29.Name = "label29";
            label29.Size = new Size(71, 32);
            label29.TabIndex = 35;
            label29.Text = "type*";
            // 
            // insert_film_type
            // 
            insert_film_type.FormattingEnabled = true;
            insert_film_type.Items.AddRange(new object[] { "movie", "tv show", "series" });
            insert_film_type.Location = new Point(76, 382);
            insert_film_type.Name = "insert_film_type";
            insert_film_type.Size = new Size(242, 40);
            insert_film_type.TabIndex = 34;
            // 
            // insert_film_description
            // 
            insert_film_description.Location = new Point(76, 500);
            insert_film_description.Name = "insert_film_description";
            insert_film_description.Size = new Size(417, 39);
            insert_film_description.TabIndex = 31;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(76, 456);
            label28.Name = "label28";
            label28.Size = new Size(132, 32);
            label28.TabIndex = 32;
            label28.Text = "description";
            // 
            // insert_film_button
            // 
            insert_film_button.Location = new Point(76, 775);
            insert_film_button.Name = "insert_film_button";
            insert_film_button.Size = new Size(202, 75);
            insert_film_button.TabIndex = 33;
            insert_film_button.Text = "Insert film";
            insert_film_button.UseVisualStyleBackColor = true;
            insert_film_button.Click += insert_film_button_Click;
            // 
            // insert_film_title
            // 
            insert_film_title.Location = new Point(76, 267);
            insert_film_title.Name = "insert_film_title";
            insert_film_title.Size = new Size(417, 39);
            insert_film_title.TabIndex = 29;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(76, 87);
            label24.Name = "label24";
            label24.Size = new Size(103, 59);
            label24.TabIndex = 28;
            label24.Text = "Film";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(76, 217);
            label27.Name = "label27";
            label27.Size = new Size(65, 32);
            label27.TabIndex = 30;
            label27.Text = "title*";
            // 
            // person
            // 
            person.Controls.Add(insert_person_button);
            person.Controls.Add(insert_person_gender);
            person.Controls.Add(label15);
            person.Controls.Add(label14);
            person.Controls.Add(insert_person_name);
            person.Controls.Add(label13);
            person.Location = new Point(8, 46);
            person.Name = "person";
            person.Padding = new Padding(3);
            person.Size = new Size(1702, 983);
            person.TabIndex = 1;
            person.Text = "person";
            person.UseVisualStyleBackColor = true;
            // 
            // insert_person_button
            // 
            insert_person_button.Location = new Point(83, 514);
            insert_person_button.Name = "insert_person_button";
            insert_person_button.Size = new Size(219, 68);
            insert_person_button.TabIndex = 30;
            insert_person_button.Text = "Insert person";
            insert_person_button.UseVisualStyleBackColor = true;
            // 
            // insert_person_gender
            // 
            insert_person_gender.FormattingEnabled = true;
            insert_person_gender.Items.AddRange(new object[] { "male", "female" });
            insert_person_gender.Location = new Point(83, 411);
            insert_person_gender.Name = "insert_person_gender";
            insert_person_gender.Size = new Size(242, 40);
            insert_person_gender.TabIndex = 29;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(83, 355);
            label15.Name = "label15";
            label15.Size = new Size(90, 32);
            label15.TabIndex = 28;
            label15.Text = "gender";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(83, 214);
            label14.Name = "label14";
            label14.Size = new Size(125, 32);
            label14.TabIndex = 27;
            label14.Text = "full name*";
            // 
            // insert_person_name
            // 
            insert_person_name.Location = new Point(83, 268);
            insert_person_name.Name = "insert_person_name";
            insert_person_name.Size = new Size(417, 39);
            insert_person_name.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(83, 85);
            label13.Name = "label13";
            label13.Size = new Size(151, 59);
            label13.TabIndex = 25;
            label13.Text = "Person";
            // 
            // genre
            // 
            genre.Controls.Add(insert_genre_name);
            genre.Controls.Add(label18);
            genre.Controls.Add(label17);
            genre.Controls.Add(insert_genre_description);
            genre.Controls.Add(label16);
            genre.Controls.Add(insert_genre_button);
            genre.Location = new Point(8, 46);
            genre.Name = "genre";
            genre.Size = new Size(1702, 983);
            genre.TabIndex = 2;
            genre.Text = "genre";
            genre.UseVisualStyleBackColor = true;
            // 
            // insert_genre_name
            // 
            insert_genre_name.Location = new Point(49, 261);
            insert_genre_name.Name = "insert_genre_name";
            insert_genre_name.Size = new Size(417, 39);
            insert_genre_name.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(49, 81);
            label18.Name = "label18";
            label18.Size = new Size(138, 59);
            label18.TabIndex = 25;
            label18.Text = "Genre";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(49, 211);
            label17.Name = "label17";
            label17.Size = new Size(84, 32);
            label17.TabIndex = 27;
            label17.Text = "name*";
            // 
            // insert_genre_description
            // 
            insert_genre_description.Location = new Point(49, 410);
            insert_genre_description.Name = "insert_genre_description";
            insert_genre_description.Size = new Size(417, 39);
            insert_genre_description.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(49, 366);
            label16.Name = "label16";
            label16.Size = new Size(132, 32);
            label16.TabIndex = 29;
            label16.Text = "description";
            // 
            // insert_genre_button
            // 
            insert_genre_button.Location = new Point(49, 543);
            insert_genre_button.Name = "insert_genre_button";
            insert_genre_button.Size = new Size(202, 75);
            insert_genre_button.TabIndex = 30;
            insert_genre_button.Text = "Insert genre";
            insert_genre_button.UseVisualStyleBackColor = true;
            insert_genre_button.Click += insert_genre_button_Click;
            // 
            // add_person
            // 
            add_person.Controls.Add(person_add_film);
            add_person.Controls.Add(person_role_add_film);
            add_person.Controls.Add(label19);
            add_person.Controls.Add(label22);
            add_person.Controls.Add(label20);
            add_person.Controls.Add(insert_person_film_button);
            add_person.Controls.Add(film_add_person);
            add_person.Controls.Add(label21);
            add_person.Location = new Point(8, 46);
            add_person.Name = "add_person";
            add_person.Size = new Size(1702, 983);
            add_person.TabIndex = 3;
            add_person.Text = "add person to film";
            add_person.UseVisualStyleBackColor = true;
            // 
            // person_add_film
            // 
            person_add_film.FormattingEnabled = true;
            person_add_film.Location = new Point(102, 354);
            person_add_film.Name = "person_add_film";
            person_add_film.Size = new Size(242, 40);
            person_add_film.TabIndex = 35;
            // 
            // person_role_add_film
            // 
            person_role_add_film.FormattingEnabled = true;
            person_role_add_film.Items.AddRange(new object[] { "actor", "director", "writer" });
            person_role_add_film.Location = new Point(102, 499);
            person_role_add_film.Name = "person_role_add_film";
            person_role_add_film.Size = new Size(242, 40);
            person_role_add_film.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(84, 65);
            label19.Name = "label19";
            label19.Size = new Size(378, 59);
            label19.TabIndex = 31;
            label19.Text = "Add person to film";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(102, 453);
            label22.Name = "label22";
            label22.Size = new Size(65, 32);
            label22.TabIndex = 37;
            label22.Text = "role*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(102, 170);
            label20.Name = "label20";
            label20.Size = new Size(65, 32);
            label20.TabIndex = 32;
            label20.Text = "film*";
            // 
            // insert_person_film_button
            // 
            insert_person_film_button.Location = new Point(102, 622);
            insert_person_film_button.Name = "insert_person_film_button";
            insert_person_film_button.Size = new Size(277, 71);
            insert_person_film_button.TabIndex = 36;
            insert_person_film_button.Text = "Insert film person";
            insert_person_film_button.UseVisualStyleBackColor = true;
            insert_person_film_button.Click += insert_person_film_button_Click;
            // 
            // film_add_person
            // 
            film_add_person.FormattingEnabled = true;
            film_add_person.Location = new Point(102, 216);
            film_add_person.Name = "film_add_person";
            film_add_person.Size = new Size(242, 40);
            film_add_person.TabIndex = 33;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(102, 308);
            label21.Name = "label21";
            label21.Size = new Size(97, 32);
            label21.TabIndex = 34;
            label21.Text = "person*";
            // 
            // add_genre
            // 
            add_genre.Controls.Add(genre_add_film);
            add_genre.Controls.Add(label23);
            add_genre.Controls.Add(label25);
            add_genre.Controls.Add(insert_genre_film_button);
            add_genre.Controls.Add(film_add_genre);
            add_genre.Controls.Add(label26);
            add_genre.Location = new Point(8, 46);
            add_genre.Name = "add_genre";
            add_genre.Size = new Size(1702, 983);
            add_genre.TabIndex = 4;
            add_genre.Text = "add genre to film";
            add_genre.UseVisualStyleBackColor = true;
            // 
            // genre_add_film
            // 
            genre_add_film.FormattingEnabled = true;
            genre_add_film.Location = new Point(130, 376);
            genre_add_film.Name = "genre_add_film";
            genre_add_film.Size = new Size(242, 40);
            genre_add_film.TabIndex = 43;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(112, 87);
            label23.Name = "label23";
            label23.Size = new Size(357, 59);
            label23.TabIndex = 39;
            label23.Text = "Add genre to film";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(130, 192);
            label25.Name = "label25";
            label25.Size = new Size(65, 32);
            label25.TabIndex = 40;
            label25.Text = "film*";
            // 
            // insert_genre_film_button
            // 
            insert_genre_film_button.Location = new Point(130, 495);
            insert_genre_film_button.Name = "insert_genre_film_button";
            insert_genre_film_button.Size = new Size(277, 71);
            insert_genre_film_button.TabIndex = 44;
            insert_genre_film_button.Text = "Insert film genre";
            insert_genre_film_button.UseVisualStyleBackColor = true;
            insert_genre_film_button.Click += insert_genre_film_button_Click;
            // 
            // film_add_genre
            // 
            film_add_genre.FormattingEnabled = true;
            film_add_genre.Location = new Point(130, 238);
            film_add_genre.Name = "film_add_genre";
            film_add_genre.Size = new Size(242, 40);
            film_add_genre.TabIndex = 41;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(130, 330);
            label26.Name = "label26";
            label26.Size = new Size(86, 32);
            label26.TabIndex = 42;
            label26.Text = "genre*";
            // 
            // update
            // 
            update.Controls.Add(update_film_title);
            update.Controls.Add(update_film_button);
            update.Controls.Add(update_film_rating);
            update.Controls.Add(label11);
            update.Controls.Add(label10);
            update.Controls.Add(update_film_description);
            update.Controls.Add(label8);
            update.Controls.Add(label9);
            update.Location = new Point(8, 46);
            update.Name = "update";
            update.Size = new Size(1713, 1035);
            update.TabIndex = 4;
            update.Text = "update";
            update.UseVisualStyleBackColor = true;
            // 
            // update_film_title
            // 
            update_film_title.FormattingEnabled = true;
            update_film_title.Location = new Point(48, 190);
            update_film_title.Name = "update_film_title";
            update_film_title.Size = new Size(417, 40);
            update_film_title.TabIndex = 42;
            // 
            // update_film_button
            // 
            update_film_button.Location = new Point(48, 578);
            update_film_button.Name = "update_film_button";
            update_film_button.Size = new Size(150, 46);
            update_film_button.TabIndex = 18;
            update_film_button.Text = "Update";
            update_film_button.UseVisualStyleBackColor = true;
            update_film_button.Click += update_film_button_Click;
            // 
            // update_film_rating
            // 
            update_film_rating.DecimalPlaces = 1;
            update_film_rating.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            update_film_rating.Location = new Point(48, 486);
            update_film_rating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            update_film_rating.Name = "update_film_rating";
            update_film_rating.Size = new Size(103, 39);
            update_film_rating.TabIndex = 17;
            update_film_rating.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(48, 439);
            label11.Name = "label11";
            label11.Size = new Size(189, 32);
            label11.TabIndex = 11;
            label11.Text = "Enter new rating";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 269);
            label10.Name = "label10";
            label10.Size = new Size(245, 32);
            label10.TabIndex = 10;
            label10.Text = "Enter new description";
            // 
            // update_film_description
            // 
            update_film_description.Location = new Point(48, 317);
            update_film_description.Multiline = true;
            update_film_description.Name = "update_film_description";
            update_film_description.Size = new Size(417, 80);
            update_film_description.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(48, 58);
            label8.Name = "label8";
            label8.Size = new Size(103, 59);
            label8.TabIndex = 8;
            label8.Text = "Film";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 142);
            label9.Name = "label9";
            label9.Size = new Size(305, 32);
            label9.TabIndex = 7;
            label9.Text = "Enter film title for updating";
            // 
            // delete
            // 
            delete.Controls.Add(delete_genre_film_button);
            delete.Controls.Add(delete_genre_film);
            delete.Controls.Add(label38);
            delete.Controls.Add(label39);
            delete.Controls.Add(delete_film_genre);
            delete.Controls.Add(label40);
            delete.Controls.Add(delete_person_film_button);
            delete.Controls.Add(delete_person_film);
            delete.Controls.Add(label35);
            delete.Controls.Add(label36);
            delete.Controls.Add(delete_film_person);
            delete.Controls.Add(label37);
            delete.Controls.Add(delete_genre_button);
            delete.Controls.Add(label34);
            delete.Controls.Add(delete_genre_name);
            delete.Controls.Add(label33);
            delete.Controls.Add(delete_person_button);
            delete.Controls.Add(label32);
            delete.Controls.Add(delete_person_name);
            delete.Controls.Add(label31);
            delete.Controls.Add(delete_film_title);
            delete.Controls.Add(delete_film);
            delete.Controls.Add(label7);
            delete.Controls.Add(label6);
            delete.Location = new Point(8, 46);
            delete.Name = "delete";
            delete.Size = new Size(1713, 1035);
            delete.TabIndex = 2;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // delete_genre_film_button
            // 
            delete_genre_film_button.Location = new Point(1215, 391);
            delete_genre_film_button.Name = "delete_genre_film_button";
            delete_genre_film_button.Size = new Size(150, 46);
            delete_genre_film_button.TabIndex = 63;
            delete_genre_film_button.Text = "Delete";
            delete_genre_film_button.UseVisualStyleBackColor = true;
            delete_genre_film_button.Click += delete_genre_film_button_Click;
            // 
            // delete_genre_film
            // 
            delete_genre_film.FormattingEnabled = true;
            delete_genre_film.Location = new Point(1215, 313);
            delete_genre_film.Name = "delete_genre_film";
            delete_genre_film.Size = new Size(453, 40);
            delete_genre_film.TabIndex = 62;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label38.Location = new Point(1197, 69);
            label38.Name = "label38";
            label38.Size = new Size(450, 59);
            label38.TabIndex = 58;
            label38.Text = "Delete genre from film";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(1215, 143);
            label39.Name = "label39";
            label39.Size = new Size(65, 32);
            label39.TabIndex = 59;
            label39.Text = "film*";
            // 
            // delete_film_genre
            // 
            delete_film_genre.FormattingEnabled = true;
            delete_film_genre.Location = new Point(1215, 190);
            delete_film_genre.Name = "delete_film_genre";
            delete_film_genre.Size = new Size(453, 40);
            delete_film_genre.TabIndex = 60;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(1215, 259);
            label40.Name = "label40";
            label40.Size = new Size(86, 32);
            label40.TabIndex = 61;
            label40.Text = "genre*";
            // 
            // delete_person_film_button
            // 
            delete_person_film_button.Location = new Point(619, 391);
            delete_person_film_button.Name = "delete_person_film_button";
            delete_person_film_button.Size = new Size(150, 46);
            delete_person_film_button.TabIndex = 57;
            delete_person_film_button.Text = "Delete";
            delete_person_film_button.UseVisualStyleBackColor = true;
            delete_person_film_button.Click += delete_person_film_button_Click;
            // 
            // delete_person_film
            // 
            delete_person_film.FormattingEnabled = true;
            delete_person_film.Location = new Point(619, 313);
            delete_person_film.Name = "delete_person_film";
            delete_person_film.Size = new Size(453, 40);
            delete_person_film.TabIndex = 56;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label35.Location = new Point(601, 69);
            label35.Name = "label35";
            label35.Size = new Size(471, 59);
            label35.TabIndex = 52;
            label35.Text = "Delete person from film";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(619, 143);
            label36.Name = "label36";
            label36.Size = new Size(65, 32);
            label36.TabIndex = 53;
            label36.Text = "film*";
            // 
            // delete_film_person
            // 
            delete_film_person.FormattingEnabled = true;
            delete_film_person.Location = new Point(619, 190);
            delete_film_person.Name = "delete_film_person";
            delete_film_person.Size = new Size(453, 40);
            delete_film_person.TabIndex = 54;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(619, 259);
            label37.Name = "label37";
            label37.Size = new Size(97, 32);
            label37.TabIndex = 55;
            label37.Text = "person*";
            // 
            // delete_genre_button
            // 
            delete_genre_button.Location = new Point(50, 916);
            delete_genre_button.Name = "delete_genre_button";
            delete_genre_button.Size = new Size(184, 46);
            delete_genre_button.TabIndex = 51;
            delete_genre_button.Text = "Delete genre";
            delete_genre_button.UseVisualStyleBackColor = true;
            delete_genre_button.Click += delete_genre_button_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(50, 776);
            label34.Name = "label34";
            label34.Size = new Size(143, 32);
            label34.TabIndex = 50;
            label34.Text = "genre name";
            // 
            // delete_genre_name
            // 
            delete_genre_name.FormattingEnabled = true;
            delete_genre_name.Location = new Point(50, 821);
            delete_genre_name.Name = "delete_genre_name";
            delete_genre_name.Size = new Size(416, 40);
            delete_genre_name.TabIndex = 49;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label33.Location = new Point(49, 684);
            label33.Name = "label33";
            label33.Size = new Size(138, 59);
            label33.TabIndex = 48;
            label33.Text = "Genre";
            // 
            // delete_person_button
            // 
            delete_person_button.Location = new Point(50, 592);
            delete_person_button.Name = "delete_person_button";
            delete_person_button.Size = new Size(184, 46);
            delete_person_button.TabIndex = 47;
            delete_person_button.Text = "Delete person";
            delete_person_button.UseVisualStyleBackColor = true;
            delete_person_button.Click += delete_person_button_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(49, 456);
            label32.Name = "label32";
            label32.Size = new Size(115, 32);
            label32.TabIndex = 46;
            label32.Text = "full name";
            // 
            // delete_person_name
            // 
            delete_person_name.FormattingEnabled = true;
            delete_person_name.Location = new Point(49, 500);
            delete_person_name.Name = "delete_person_name";
            delete_person_name.Size = new Size(417, 40);
            delete_person_name.TabIndex = 45;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(49, 377);
            label31.Name = "label31";
            label31.Size = new Size(151, 59);
            label31.TabIndex = 44;
            label31.Text = "Person";
            // 
            // delete_film_title
            // 
            delete_film_title.FormattingEnabled = true;
            delete_film_title.Location = new Point(49, 190);
            delete_film_title.Name = "delete_film_title";
            delete_film_title.Size = new Size(417, 40);
            delete_film_title.TabIndex = 43;
            // 
            // delete_film
            // 
            delete_film.Location = new Point(49, 288);
            delete_film.Name = "delete_film";
            delete_film.Size = new Size(150, 46);
            delete_film.TabIndex = 6;
            delete_film.Text = "Delete film";
            delete_film.UseVisualStyleBackColor = true;
            delete_film.Click += delete_film_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(49, 69);
            label7.Name = "label7";
            label7.Size = new Size(103, 59);
            label7.TabIndex = 5;
            label7.Text = "Film";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 143);
            label6.Name = "label6";
            label6.Size = new Size(55, 32);
            label6.TabIndex = 4;
            label6.Text = "title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 518);
            label5.Name = "label5";
            label5.Size = new Size(76, 32);
            label5.TabIndex = 27;
            label5.Text = "rating";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 396);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 24;
            label4.Text = "type*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 281);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 23;
            label3.Text = "description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 165);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 21;
            label2.Text = "title*";
            // 
            // film_insert
            // 
            film_insert.AutoSize = true;
            film_insert.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            film_insert.Location = new Point(50, 57);
            film_insert.Name = "film_insert";
            film_insert.Size = new Size(103, 59);
            film_insert.TabIndex = 19;
            film_insert.Text = "Film";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1727, 1085);
            Controls.Add(tabControl);
            MaximumSize = new Size(1753, 1156);
            Name = "Form1";
            Text = "Movies database";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl.ResumeLayout(false);
            connect.ResumeLayout(false);
            connect.PerformLayout();
            select.ResumeLayout(false);
            select.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rating_to_input).EndInit();
            ((System.ComponentModel.ISupportInitialize)rating_from_input).EndInit();
            insert.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            film.ResumeLayout(false);
            film.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)insert_film_rating).EndInit();
            person.ResumeLayout(false);
            person.PerformLayout();
            genre.ResumeLayout(false);
            genre.PerformLayout();
            add_person.ResumeLayout(false);
            add_person.PerformLayout();
            add_genre.ResumeLayout(false);
            add_genre.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)update_film_rating).EndInit();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl;
        private TabPage select;
        private TabPage insert;
        private TabPage connect;
        private TabPage delete;
        private ComboBox choose_type;
        private Label type;
        private Label film_title;
        private Button select_result;
        private TextBox title_input;
        private Button connect_button;
        private Label db_info;
        private Label connection_state;
        private Button disconnect_button;
        private Label label1;
        private Label rating_to;
        private Label rating_from;
        private Label film_rating;
        private NumericUpDown rating_to_input;
        public NumericUpDown rating_from_input;
        private Button delete_film;
        private Label label7;
        private Label label6;
        private TabPage update;
        private Label label10;
        private TextBox update_film_description;
        private Label label8;
        private Label label9;
        private Button update_film_button;
        public NumericUpDown update_film_rating;
        private Label label11;
        private ComboBox genre_input;
        private Label label12;
        private Button insert_person_film_button;
        private ComboBox person_add_film;
        private Label label21;
        private ComboBox film_add_person;
        private Label label20;
        private Label label19;
        private Button insert_genre_button;
        private Label label16;
        private TextBox insert_genre_description;
        private Label label17;
        private TextBox insert_genre_name;
        private Label label18;
        private ComboBox person_role_add_film;
        private Label label22;
        private TabControl tabControl1;
        private TabPage person;
        //private Button insert_film_button;
        private Label label5;
        //public NumericUpDown insert_film_rating;
        //private ComboBox insert_film_type;
        private Label label4;
        private Label label3;
        //private TextBox insert_film_description;
        private Label label2;
        //private TextBox insert_film_title;
        private Label film_insert;
        private Button insert_person_button;
        private ComboBox insert_person_gender;
        private Label label15;
        private Label label14;
        private TextBox insert_person_name;
        private Label label13;
        private TabPage genre;
        private TabPage add_person;
        private TabPage add_genre;
        private ComboBox genre_add_film;
        private Label label23;
        private Label label25;
        private Button insert_genre_film_button;
        private ComboBox film_add_genre;
        private Label label26;
        private TabPage film;
        private TextBox insert_film_description;
        private Label label28;
        private Button insert_film_button;
        private TextBox insert_film_title;
        private Label label24;
        private Label label27;
        private Label label29;
        private ComboBox insert_film_type;
        private Label label30;
        public NumericUpDown insert_film_rating;
        private ComboBox update_film_title;
        private ComboBox delete_film_title;
        private Label label34;
        private ComboBox delete_genre_name;
        private Label label33;
        private Button delete_person_button;
        private Label label32;
        private ComboBox delete_person_name;
        private Label label31;
        private Button delete_genre_button;
        private ComboBox delete_person_film;
        private Label label35;
        private Label label36;
        private ComboBox delete_film_person;
        private Label label37;
        private Button delete_person_film_button;
        private Button delete_genre_film_button;
        private ComboBox delete_genre_film;
        private Label label38;
        private Label label39;
        private ComboBox delete_film_genre;
        private Label label40;
    }
}