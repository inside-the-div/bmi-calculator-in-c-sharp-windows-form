using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace BMIcalculator
{
    public partial class BMIcalculator : Form
    {
        SqlConnection DBconnection = new SqlConnection(Properties.Settings.Default.con);
        double Height, Weight, Result, Feet, Inch, Centimeter;
        public BMIcalculator()
        {
            InitializeComponent();
        }

        private void radioButtonFeet_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonFeet.Checked == true)
            {
                TextBoxFeet.Visible = true;
                TextBoxInch.Visible = true;
                TextBoxCentimeter.Visible = false;
            }
            else
            {
                TextBoxFeet.Visible = false;
                TextBoxInch.Visible = false;
                TextBoxCentimeter.Visible = true;
            }
        }

        private void BMIcalculator_Load(object sender, EventArgs e)
        {
            radioButtonFeet.Checked = true;
            radioButtonKg.Checked = true;
        }

        private void radioButtonKg_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKg.Checked == true)
            {
                TextBoxWeight.PlaceholderText = "Kg";
            }
            else
            {
                TextBoxWeight.PlaceholderText = "Pound";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBoxCentimeter.Clear();
            TextBoxFeet.Clear();
            TextBoxInch.Clear();
            TextBoxWeight.Clear();
            LabelResult.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            History history = new History();
            history.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Feet, Inch, Kg;
            bool valid = true;
            if(radioButtonFeet.Checked == true)
            {
                if (TextBoxFeet.Text == "")
                {
                    MessageBox.Show("Enter the height");
                    valid = false;
                }                
                else
                {
                    Feet = Convert.ToDouble(TextBoxFeet.Text);
                    if (TextBoxInch.Text == "")
                    {
                        Inch = 0;
                    }
                    else
                    {
                        Inch = Convert.ToDouble(TextBoxInch.Text);
                    }
                    Height = ((Feet * 12) + Inch) * 0.0254;
                }
            }
            else
            {                
                if (TextBoxCentimeter.Text == "")
                {
                    MessageBox.Show("Enter the height");
                    valid = false;
                }
                else
                {
                    Height = (Convert.ToDouble(TextBoxCentimeter.Text))/100;
                }
            }

            if (valid)
            {
                if(radioButtonKg.Checked == true)
                {
                    if (TextBoxWeight.Text == "")
                    {
                        MessageBox.Show("Enter the weight");
                        valid = false;
                    }
                    else
                    {
                        Weight = Convert.ToDouble(TextBoxWeight.Text);
                    }
                }
                else
                {
                    Weight = (Convert.ToDouble(TextBoxWeight.Text)) / 2.20462;
                }
            }

            if (valid)
            {
                string time = DateTime.Now.ToString();
                Result = (Weight / (Height * Height));
                LabelResult.Text = "Your BMI score is " + Result.ToString("N1");

                string HistorySaveQuery = "INSERT INTO bmi_calculator_history (height_cm, weight_kg, bmi_score, bmi_time) " +
                    "VALUES ("+Height+", "+Weight+", "+Result+", '"+time+"')";
                DBconnection.Open();
                SqlCommand command = new SqlCommand(HistorySaveQuery, DBconnection);
                command.ExecuteNonQuery();
                DBconnection.Close();
            }
        }

        private void TextBoxFeet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxInch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            int currentValue = 0;
            if (Int32.TryParse(TextBoxInch.Text + e.KeyChar, out currentValue))
            {
                if (currentValue > 13)
                {
                    e.Handled = true;
                }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBoxCentimeter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}