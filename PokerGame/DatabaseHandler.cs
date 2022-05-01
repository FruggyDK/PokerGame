using Npgsql;
using PokerGame.Properties;
using System.Data;

namespace PokerGame
{
    internal static class DatabaseHandler
    {
        private static string connectionString =
            "Server="
            + Settings.Default.Server
            + ";Port="
            + Settings.Default.Port
            + ";Database="
            + Settings.Default.Database
            + ";User Id="
            + Settings.Default.UserId
            + ";Password="
            + Settings.Default.Password
            + ";";


        public static bool TestConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static long Login(
            string username,
            string password
        )
        {
            long user_id = -1;
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            //TODO: add dob parameter
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "select id from login where username = @1 and password = @2"
            };
            cmd.Parameters.AddWithValue("@1", username);
            cmd.Parameters.AddWithValue("@2", password);
            try
            {
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    user_id = (long)obj;
                }
            }
            catch (NpgsqlException E)
            {
                MessageBox.Show(E.Message);
            }
            cmd.Dispose();
            connection.Close();
            return user_id;
        }
        public static int GetUsersChipBalance(long user_id)
        {
            int chip_balance = -1;
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "select chip_balance from users "
                    + " where users.id = @1 "
            };
            cmd.Parameters.AddWithValue("@1", user_id);

            try
            {
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    chip_balance = (int)obj;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show(cmd.CommandText);
            }

            cmd.Dispose();
            connection.Close();
            return chip_balance;
        }

        public static void UpdateUsersChipBalance(long user_id, int new_bal)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText =
                    "update users set chip_balance = @1 "
                    + " where users.id = @2 "
            };
            cmd.Parameters.AddWithValue("@1", new_bal);
            cmd.Parameters.AddWithValue("@2", user_id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                MessageBox.Show(cmd.CommandText);
            }

            cmd.Dispose();
            connection.Close();
        }










        //
        // Methods for communicating with movie_genres table
        //
        public static bool AddGenreToMovie(int mov_id, int gen_id)
        {
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "insert into movie_genres (mov_id, gen_id) values($1, $2);"
            };
            cmd.Parameters.AddWithValue(mov_id);
            cmd.Parameters.AddWithValue(gen_id);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                return false;
            }

            cmd.Dispose();
            connection.Close();
            return true;
        }


    }

}

