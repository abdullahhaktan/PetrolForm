using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetrolForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string benzinTur = ""; // Selected fuel type
        private int litre1; // Selected fuel amount in liters

        // Load and display all fuel information from database
        void listele()
        {
            // Load Unleaded 95 information
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_BENZIN WHERE PETROL_TUR='Kursunsuz95'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblKursunsuz95.Text = dr[3].ToString(); // Price per liter
                progressBar1.Value = int.Parse(dr[4].ToString()); // Stock level
                lblKursunsuz95Depo.Text = dr[4].ToString() + " Litre"; // Stock amount
            }
            conn.Close();

            // Load Unleaded 97 information
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM TBL_BENZIN WHERE PETROL_TUR='Kursunsuz97'", conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                lblKursunsuz97.Text = dr1[3].ToString();
                progressBar2.Value = int.Parse(dr1[4].ToString());
                lblKursunsuz97Depo.Text = dr1[4].ToString() + " Litre";
            }
            conn.Close();

            // Load Euro Diesel 10 information
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBL_BENZIN WHERE PETROL_TUR='EuroDisel10'", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblEuroDizel10.Text = dr2[3].ToString();
                progressBar3.Value = int.Parse(dr2[4].ToString());
                lblEuroDizel10Depo.Text = dr2[4].ToString() + " Litre";
            }
            conn.Close();

            // Load New Pro Diesel information
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM TBL_BENZIN WHERE PETROL_TUR='YeniProDizel'", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblYeniProDizel.Text = dr3[3].ToString();
                progressBar4.Value = int.Parse(dr3[4].ToString());
                lblYeniProDizelDepo.Text = dr3[4].ToString() + " Litre";
            }
            conn.Close();

            // Load Gas information
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT * FROM TBL_BENZIN WHERE PETROL_TUR='Gaz'", conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblGaz.Text = dr4[3].ToString();
                progressBar5.Value = int.Parse(dr4[4].ToString());
                lblGazDepo.Text = dr4[4].ToString() + " Litre";
            }
            conn.Close();

            // Load cash register amount
            conn.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT * FROM TBL_KASA", conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            if (dr5.Read())
            {
                lblKasa.Text = dr5[0].ToString() + " ₺"; // Total cash amount
            }
            conn.Close();
        }

        // Database connection for petrol station system
        SqlConnection conn = new SqlConnection("Data Source=ABDULLAH;Initial Catalog=DbPetrol;Integrated Security=True;Encrypt=False;");

        private void Form1_Load(object sender, EventArgs e)
        {
            listele(); // Load data on form initialization
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            // Group box enter event handler
        }

        // Unleaded 95 numeric up/down value changed
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            benzinTur = "Kursunsuz95";

            double kursunsuz95, litre, tutar;
            kursunsuz95 = double.Parse(lblKursunsuz95.Text);
            litre = Convert.ToInt16(numericUpDown1.Value);
            litre1 = (int)litre;
            tutar = kursunsuz95 * litre;
            lblTutar.Text = tutar.ToString(); // Display total price

            // Disable other fuel type controls
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            txtKursunsuz95Tutar.Text = tutar.ToString(); // Display price for this fuel type
        }

        // Unleaded 97 numeric up/down value changed
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            benzinTur = "Kursunsuz97";

            double kursunsuz97, litre, tutar;
            kursunsuz97 = double.Parse(lblKursunsuz97.Text);
            litre = Convert.ToInt16(numericUpDown2.Value);
            litre1 = (int)litre;
            tutar = kursunsuz97 * litre;
            lblTutar.Text = tutar.ToString();

            // Disable other fuel type controls
            numericUpDown1.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            txtKursunsuz97Tutar.Text = tutar.ToString();
        }

        // Euro Diesel 10 numeric up/down value changed
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            benzinTur = "EuroDisel10";

            double eurodisel10, litre, tutar;
            eurodisel10 = double.Parse(lblEuroDizel10.Text);
            litre = Convert.ToInt16(numericUpDown3.Value);
            tutar = eurodisel10 * litre;
            litre1 = (int)litre;
            lblTutar.Text = tutar.ToString();

            // Disable other fuel type controls
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            txtEuroDizelTutar.Text = tutar.ToString();
        }

        // New Pro Diesel numeric up/down value changed
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            benzinTur = "YeniProDizel";

            double yeniProDizel, litre, tutar;
            yeniProDizel = double.Parse(lblYeniProDizel.Text);
            litre = Convert.ToInt16(numericUpDown4.Value);
            tutar = yeniProDizel * litre;
            litre1 = (int)litre;
            lblTutar.Text = tutar.ToString();

            // Disable other fuel type controls
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown5.Enabled = false;

            txtYeniProDizelTutar.Text = tutar.ToString();
        }

        // Gas numeric up/down value changed
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            benzinTur = "Gaz";

            double gaz, litre, tutar;
            gaz = double.Parse(lblGaz.Text);
            litre = Convert.ToInt16(numericUpDown5.Value);
            tutar = gaz * litre;
            litre1 = (int)litre;
            lblTutar.Text = tutar.ToString();

            // Disable other fuel type controls
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;

            txtGazTutar.Text = tutar.ToString();
        }

        // Complete sale button click
        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            // Record transaction in movements table
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBL_HAREKET SET PLAKA=@P1,BENZIN_TURU=@P2,LITRE=@P3,FIYAT=@P4 WHERE 1=1", conn);
            cmd.Parameters.AddWithValue("@P1", txtPlaka.Text); // Vehicle plate
            cmd.Parameters.AddWithValue("@P2", benzinTur); // Fuel type
            cmd.Parameters.AddWithValue("@P3", (decimal)(litre1)); // Liters
            cmd.Parameters.AddWithValue("@P4", decimal.Parse(lblTutar.Text)); // Total price
            cmd.ExecuteNonQuery();
            conn.Close();

            // Update fuel stock
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("UPDATE TBL_BENZIN SET STOK=STOK-@P1 WHERE PETROL_TUR=@P2", conn);
            cmd2.Parameters.AddWithValue("@P1", (decimal)(litre1));
            cmd2.Parameters.AddWithValue("@P2", benzinTur);
            cmd2.ExecuteNonQuery();
            conn.Close();

            // Update cash register
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("UPDATE TBL_KASA SET MIKTAR=MIKTAR+@P1 WHERE 1=1", conn);
            cmd3.Parameters.AddWithValue("@P1", decimal.Parse(lblTutar.Text));
            cmd3.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele(); // Refresh display
        }

        // Reset Unleaded 95 selection
        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            txtKursunsuz95Tutar.Clear();
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
        }

        // Reset Unleaded 97 selection
        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 0;
            txtKursunsuz97Tutar.Clear();
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
        }

        // Reset Euro Diesel 10 selection
        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = 0;
            txtEuroDizelTutar.Clear();
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
        }

        // Reset New Pro Diesel selection
        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown4.Value = 0;
            txtYeniProDizelTutar.Clear();
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
        }

        // Reset Gas selection
        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown5.Value = 0;
            txtGazTutar.Clear();
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;
        }
    }
}