using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedLevelHomeWork2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "" && passwordTextBox.Text != "")
            {
                string connectionString = ConfigurationManager.ConnectionStrings["appConnection"].ConnectionString; ;
                var stringBuilder = new SqlConnectionStringBuilder
                {
                    ConnectionString = connectionString,
                    UserID = loginTextBox.Text,
                    Password = passwordTextBox.Text
                };

                using (var connection = new SqlConnection(stringBuilder.ConnectionString))
                {
                    MessageBox.Show("Сonnection established!");
                }
            }
        }
    }
}
