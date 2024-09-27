using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agenda_Telefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=agenda");
                conn.Open(); MySqlCommand comando = new MySqlCommand("INSERT INTO `contatos` (`nome`, `telefone`) VALUES (@nome, @telefone);", conn);

                comando.Parameters.AddWithValue("@nome", txb1.Text);
                comando.Parameters.AddWithValue("@telefone", txb2.Text);

                comando.ExecuteNonQuery();
                conn.Close();

                txb1.Text = "";
                txb2.Text = "";

            }
            catch (Exception erro)
            {
                MessageBox.Show("algo está errado.\n" + erro.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=agenda");
                conn.Open();

                if (txb3.Text == "")
                {
                    MySqlCommand comandos = new MySqlCommand("SELECT `nome`, `telefone` FROM `contatos`;'", conn);
                    var reader = comandos.ExecuteReader();

                    while (reader.Read())
                    {
                        richTextBox1.Text = "Nome: " + reader.GetString(1) + "telefone: " + reader.GetString(2);
                    }
                }
                else
                {
                    MySqlCommand comandos = new MySqlCommand("SELECT * FROM `contatos` WHERE `nome` LIKE '%"+ txb3.Text+"%'; ", conn);
                    //comandos.Parameters.AddWithValue("@nome", txb1.Text);

                    var reader = comandos.ExecuteReader();

                    while (reader.Read())
                    {
                        richTextBox1.Text = richTextBox1.Text + "Nome: " + reader.GetString(1) + " telefone: " + reader.GetString(2) + "\n";
                    }

                    }
                if (conn.State.ToString() != "Close")
                {
                    conn.Close();
                }
            }
            catch (Exception erro)
            {

            }
            finally
            {
                txb1.Text = "";
                txb2.Text = "";
            }
        }
    }
}
