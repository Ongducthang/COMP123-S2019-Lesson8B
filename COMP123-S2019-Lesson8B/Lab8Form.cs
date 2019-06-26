using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8B
{
    public partial class Lab8 : Form
    {
        //Class properties
        public  string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// This is the Constructor for Lab8Form
        /// </summary>
        public Lab8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the Event Handler for the SubmitButton Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            //float floatResult;
            //bool result;
            //result = float.TryParse(AgeTextBox.Text, out floatResult);
            //UserAge = floatResult;
            // OR Convert.ToSingle();
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;

            ClearForm();
 
        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            //other way:
            //NameTextBox.Text = string.Empty;
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// this is the event handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            //simple input validation
                try
                {
                    float.Parse(AgeTextBox.Text);
                    SubmitButton.Enabled = true;
                }
                catch
                {
                    SubmitButton.Enabled = false;
                }
        }
        /// <summary>
        /// this is the event handler for the Lab8form load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// this is the event handler for the name NameTextBox_TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
