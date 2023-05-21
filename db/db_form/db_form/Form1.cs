using Npgsql;
using System.Data;

namespace db_form
{
    public partial class Form1 : Form
    {
        const string _SERVER = "localhost";
        const string _PORT = "5432";
        const string _DB = "movies_database";
        const string _USER = "postgres";
        const string _PASSWORD = "password";
        //Не получилось разобраться, как в С# выносить переменные окружения, как это делается в python в .env файлы, поэтому вынесла сюда же в отдельные переменные
        Npgsql.NpgsqlConnection conn = new NpgsqlConnection($"Server={_SERVER};Port={_PORT};Database={_DB}; User ID={_USER}; Password={_PASSWORD}");
        public Form1()
        {
            InitializeComponent();
            connection_state.Text = conn.State.ToString();
        }

        public void add_genres_in_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                dataGridView1.DataSource = null;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select name from content.genre";
                NpgsqlDataReader genres = cmd.ExecuteReader();
                genre_input.Items.Clear();
                genre_add_film.Items.Clear();
                delete_genre_name.Items.Clear();
                delete_genre_film.Items.Clear();
                while (genres.Read())
                {
                    genre_input.Items.Add(genres.GetValue(0).ToString());
                    genre_add_film.Items.Add(genres.GetValue(0).ToString());
                    delete_genre_name.Items.Add(genres.GetValue(0).ToString());
                    delete_genre_film.Items.Add(genres.GetValue(0).ToString());
                }
                genre_input.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                genre_input.AutoCompleteSource = AutoCompleteSource.ListItems;
                genres.Close();
            }
        }

        public void add_persons_in_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                dataGridView1.DataSource = null;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select full_name from content.person";
                NpgsqlDataReader persons = cmd.ExecuteReader();
                person_add_film.Items.Clear();
                delete_person_name.Items.Clear();
                delete_person_film.Items.Clear();
                while (persons.Read())
                {
                    person_add_film.Items.Add(persons.GetValue(0).ToString());
                    delete_person_name.Items.Add(persons.GetValue(0).ToString());
                    delete_person_film.Items.Add(persons.GetValue(0).ToString());
                }
                person_add_film.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                person_add_film.AutoCompleteSource = AutoCompleteSource.ListItems;
                persons.Close();
            }
        }

        public void add_films_in_list()
        {
            if (conn.State == ConnectionState.Open)
            {
                dataGridView1.DataSource = null;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select title from content.film_work";
                NpgsqlDataReader films = cmd.ExecuteReader();
                film_add_person.Items.Clear();
                film_add_genre.Items.Clear();
                update_film_title.Items.Clear();
                delete_film_title.Items.Clear();
                delete_film_person.Items.Clear();
                delete_film_genre.Items.Clear();
                while (films.Read())
                {
                    film_add_person.Items.Add(films.GetValue(0).ToString());
                    film_add_genre.Items.Add(films.GetValue(0).ToString());
                    update_film_title.Items.Add(films.GetValue(0).ToString());
                    delete_film_title.Items.Add(films.GetValue(0).ToString());
                    delete_film_person.Items.Add(films.GetValue(0).ToString());
                    delete_film_genre.Items.Add(films.GetValue(0).ToString());
                }
                film_add_person.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                film_add_person.AutoCompleteSource = AutoCompleteSource.ListItems;
                films.Close();
            }
        }

        public void update_item_lists()
        {
            add_genres_in_list();
            add_persons_in_list();
            add_films_in_list();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            connection_state.Text = conn.State.ToString();
            update_item_lists();
        }


        private void disconnect_button_Click(object sender, EventArgs e)
        {
            conn.Close();
            connection_state.Text = conn.State.ToString();
        }

        public string handle_options()
        {
            string options = " where ";
            if (choose_type.Text != "")
            {
                options += "type = '" + choose_type.Text + "' and ";
            }
            if (title_input.Text != "")
            {
                options += "title = '" + title_input.Text + "' and";
            }
            if (genre_input.Text != "")
            {
                options += "genres like '%" + genre_input.Text + "%' and";
            }
            options += "  rating >= " + rating_from_input.Text.Replace(',', '.') + " and rating <= " + rating_to_input.Text.Replace(',', '.') + " ";
            return options;
        }


        private void select_result_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                dataGridView1.DataSource = null;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                string options = handle_options();
                cmd.CommandText = "with films_persons as " +
                    "(\r\nselect film_work_id, STRING_AGG(CONCAT(per.full_name, ': ', films.role), ', ') as persons " +
                    "from \r\n(select * from content.person_film_work left join \"content\".film_work ON " +
                    "film_work.id = person_film_work.film_work_id) films\r\n" +
                    "left join content.person per on films.person_id = per.id\r\n" +
                    "group by film_work_id, title, films.description, rating, type),\r\n" +
                    "films_genres as (\r\nselect film_work_id, title, films.description, rating, type, STRING_AGG(gn.name, ', ') as genres " +
                    "from \r\n(select * from content.genre_film_work left join \"content\".film_work " +
                    "ON film_work.id = genre_film_work.film_work_id) films\r\n" +
                    "left join content.genre gn on films.genre_id = gn.id\r\n" +
                    "group by film_work_id, title, films.description, rating, type\r\n)\r\n" +
                    "select title, description, rating, type, genres, persons from films_genres\r\n" +
                    "left join films_persons\r\non films_genres.film_work_id = films_persons.film_work_id\r\n" + options +
                    "order by rating desc";
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }

        }

        private void insert_film_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (insert_film_title.Text != "" && insert_film_type.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into content.film_work (id, title, description, type, rating) values (gen_random_uuid(), '" +
                        insert_film_title.Text + "', '" + insert_film_description.Text + "', '" +
                        insert_film_type.Text + "', " + insert_film_rating.Text.Replace(',', '.') + ")";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Inserted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter title and type");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void delete_film_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (delete_film_title.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from content.film_work where title = '" + delete_film_title.Text + "'";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Deleted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter title");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void update_film_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (update_film_title.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update content.film_work set description = '" + update_film_description.Text + "', rating = " +
                        update_film_rating.Text.Replace(',', '.') +
                        " where title = '" + update_film_title.Text + "'";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Updated rows: " + dr.Rows.ToString());
                }
                else
                {
                    MessageBox.Show("Please, enter title");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void insert_person_film_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (film_add_person.Text != "" && person_add_film.Text != "" && person_role_add_film.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "select id from content.person where full_name = '" + person_add_film.Text + "'";
                    NpgsqlDataReader pers = cmd.ExecuteReader();
                    string person_id = "";
                    while (pers.Read())
                    {
                        person_id = pers.GetValue(0).ToString();
                    }
                    pers.Close();
                    cmd.CommandText = "select id from content.film_work where title = '" + film_add_person.Text + "'";
                    NpgsqlDataReader fl = cmd.ExecuteReader();
                    string film_id = "";
                    while (fl.Read())
                    {
                        film_id = fl.GetValue(0).ToString();
                    }
                    fl.Close();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into content.person_film_work (id, person_id, film_work_id, role) values (gen_random_uuid(), '" + person_id + "', '" + film_id + "', '" + person_role_add_film.Text + "')";

                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Inserted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter film title, person and role");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void insert_person_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (insert_person_name.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into content.person (id, full_name, gender) values (gen_random_uuid(), '" +
                        insert_person_name.Text + "', '" + insert_person_gender.Text + "')";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Inserted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter full name");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void insert_genre_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (insert_genre_name.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into content.genre (id, name, description) values (gen_random_uuid(), '" +
                        insert_genre_name.Text + "', '" + insert_genre_description.Text + "')";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Inserted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter genre name");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void insert_genre_film_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (film_add_genre.Text != "" && genre_add_film.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "select id from content.genre where name = '" + genre_add_film.Text + "'";
                    NpgsqlDataReader pers = cmd.ExecuteReader();
                    string genre_id = "";
                    while (pers.Read())
                    {
                        genre_id = pers.GetValue(0).ToString();
                    }
                    pers.Close();
                    cmd.CommandText = "select id from content.film_work where title = '" + film_add_genre.Text + "'";
                    NpgsqlDataReader fl = cmd.ExecuteReader();
                    string film_id = "";
                    while (fl.Read())
                    {
                        film_id = fl.GetValue(0).ToString();
                    }
                    fl.Close();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into content.genre_film_work (id, genre_id, film_work_id) values (gen_random_uuid(), '" + genre_id + "', '" + film_id + "')";

                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Inserted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter film title and genre name");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void delete_person_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (delete_person_name.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from content.person where full_name = '" + delete_person_name.Text + "'";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Deleted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter persons name");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void delete_genre_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (delete_genre_name.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from content.genre where name = '" + delete_genre_name.Text + "'";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Deleted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter genre name");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void delete_person_film_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (delete_person_film.Text != "" && delete_film_person.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "select id from content.person where full_name = '" + delete_person_film.Text + "'";
                    NpgsqlDataReader pers = cmd.ExecuteReader();
                    string person_id = "";
                    while (pers.Read())
                    {
                        person_id = pers.GetValue(0).ToString();
                    }
                    pers.Close();
                    cmd.CommandText = "select id from content.film_work where title = '" + delete_film_person.Text + "'";
                    NpgsqlDataReader fl = cmd.ExecuteReader();
                    string film_id = "";
                    while (fl.Read())
                    {
                        film_id = fl.GetValue(0).ToString();
                    }
                    fl.Close();

                    cmd.CommandText = "delete from content.person_film_work where person_id = '" + person_id + "' and film_work_id = '" + film_id + "'";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Deleted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter person and film");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }

        private void delete_genre_film_button_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                if (delete_genre_film.Text != "" && delete_film_genre.Text != "")
                {
                    dataGridView1.DataSource = null;
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "select id from content.genre where name = '" + delete_genre_film.Text + "'";
                    NpgsqlDataReader pers = cmd.ExecuteReader();
                    string genre_id = "";
                    while (pers.Read())
                    {
                        genre_id = pers.GetValue(0).ToString();
                    }
                    pers.Close();
                    cmd.CommandText = "select id from content.film_work where title = '" + delete_film_genre.Text + "'";
                    NpgsqlDataReader fl = cmd.ExecuteReader();
                    string film_id = "";
                    while (fl.Read())
                    {
                        film_id = fl.GetValue(0).ToString();
                    }
                    fl.Close();

                    cmd.CommandText = "delete from content.genre_film_work where genre_id = '" + genre_id + "' and film_work_id = '" + film_id + "'";
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Close();
                    MessageBox.Show("Deleted rows: " + dr.Rows.ToString());
                    update_item_lists();
                }
                else
                {
                    MessageBox.Show("Please, enter genre and film");
                }
            }
            else
            {
                MessageBox.Show("Please, connect to database");
            }
        }
    }
}