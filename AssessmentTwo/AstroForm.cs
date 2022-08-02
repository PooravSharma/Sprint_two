using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Team - Karma 
// Scrum master - Jimba Thai 
// Team mate - Poorav Sharma 
// This GUI application displays the data in a list box and uses text boxes and buttons for processing the data. 
namespace AssessmentTwo
{
    public partial class AstroForm : Form
    {

        public AstroForm()
        {
            InitializeComponent();
        }

        int minData = 10;
        int maxData = 99;
        static int max = 24; // The array has 24 elements to reflect the number of hours per day. 
        int[] hours = new int[max]; // The array is of type integer. 
        int nextEmptyTask = 0;
        bool sorted = false;
        #region Buttons

        private void buttonAdd_Click(object sender, EventArgs e) // Adds interger to the array
        {
            if (!string.IsNullOrEmpty(textBox.Text)) // The program must generate an error message if the text box is empty. 
            {
                int no = int.Parse(textBox.Text);

                if (no >= minData && no <= maxData)
                {

                    hours[nextEmptyTask] = int.Parse(textBox.Text);
                    nextEmptyTask++;

                    Display();
                    textBox.Clear();
                }
                else
                {
                    MessageBox.Show("Enter value between 10 - 99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Text Box is empty. Enter an interger", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void buttonDelete_Click(object sender, EventArgs e) // removes intgers from an array
        {
            if (listBox.SelectedIndex != -1 )
            {

                int key = int.Parse(textBox.Text);
                for (int j = 0; j < max; j++)
                {
                    if (hours[j] == key)
                    {
                        hours[j] = 0;
                        nextEmptyTask--;
                        break;
                    }
                }
                textBox.Clear();
                Display();
            }
       
            else
            {
                MessageBox.Show("Value is not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e) // edit the integer in an array 
        {
            if (!string.IsNullOrEmpty(textBox.Text)) // The program must generate an error message if the text box is empty. 
            {
                string currentItem = listBox.SelectedItem.ToString();
                int taskIndex = listBox.FindString(currentItem);
                hours[taskIndex] = int.Parse(textBox.Text);
            }
            else
            {
                MessageBox.Show("Cannot Edit: Please select a task from the list", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Display();
            textBox.Clear();
        }
        private void buttonFill_Click(object sender, EventArgs e) // fill the array with random intger from 10 to 99
        {
            Autofill();

        }


        private void buttonSearch_Click(object sender, EventArgs e) // The search method must be coded using the Binary Search algorithm. 
        {
            
            if (!string.IsNullOrEmpty(textBox.Text) && (sorted == true))
            {
                int target = int.Parse(textBox.Text);
                int minNo =0;
                int maxNo = hours.Length - 1;
                int mid=0;
                bool found = false;

                while (minNo <= maxNo)
                {
                    mid = (minNo + maxNo) / 2;
                    if (target == hours[mid])
                    {
                        found = true;
                        break;
                    }
                    else if (target < hours[mid])
                    {
                        maxNo = mid - 1;
                    }
                    else
                    {
                        minNo = mid + 1;
                    }
                }
                if (found) // The program must generate a message if the search is successful. 
                {
                    MessageBox.Show("The target was Found at element[" + mid + "]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    textBox.Clear();

                }
                else
                {
                    MessageBox.Show("The target was Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // The program must generate an error message if the search is not successful. 
                }
            }
            else
                MessageBox.Show("Please sort the list and enter text into text box", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void buttonSort_Click(object sender, EventArgs e) // Sorts the array in an assending order
        {
            Sort();
            sorted = true;
        }
        private void buttonRange_Click(object sender, EventArgs e)
        {                       
           int Range = MaxValue(hours) - MinValue(hours);
           MessageBox.Show("The Range is " + Range, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxRange.Text = Range.ToString();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            if (sorted == true)
            {

                int middle = hours.Length / 2;
                if (hours.Length % 2 != 0)
                {
                    MessageBox.Show("The Medium of array is " + hours[middle], "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMedium.Text = hours[middle].ToString();
                }
                else
                {
                    double mid = (hours[middle - 1] + hours[middle]) / 2.0;
                    double midexe = Math.Round(mid, 2);
                    MessageBox.Show("The Medium of array is " + midexe, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxMedium.Text = midexe.ToString();
                }
            }
            else
            {
                MessageBox.Show("Sort the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            int element;
            int frequency = 1;
            int mode = 0;
            int counter;
            for (int i =0; i < hours.Length;i++)
            {
                counter = 0;
                element = hours[i];
                for (int j = 0; j < hours.Length; j++)
                {
                    if (element == hours[j])
                    {
                        counter++;

                    }
                }
                if (counter >= frequency)
                {
                    frequency = counter;
                    mode = element;
                }
            }
            MessageBox.Show("The Mode is " + mode, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxMode.Text = mode.ToString();
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i =0; i < hours.Length; i++)
            {
                sum += hours[i];
            }
            double average = sum / hours.Length;
            double rounded = Math.Round(average, 2);
            MessageBox.Show("The Average of the list is " + rounded, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxAverage.Text= rounded.ToString();
        }

        private void buttonSequentialSearch_Click(object sender, EventArgs e)
        {
            int target = int.Parse(textBox.Text);
            bool found = false;
            for (int i = 0; i < hours.Length; i++)
            {
                if (target == hours[i])
                {
                    found = true;                  
                    break;
                }                
            }
            if (found == true)
            {
                MessageBox.Show("The value "+target+" is found", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Value not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        #endregion

        #region Methods


        private void Autofill() // The array is filled with random integers to simulate the data stream (numbers between 10 and 99). 
        {
            Random randNum = new Random();
            for (int i = 0; i < hours.Length; i++)
            {
                hours[i] = randNum.Next(minData, maxData);
                nextEmptyTask++;
            }
           
            
            Display();
        } 

        private void Display() // method displayes the intgers in the listbox 
        {
            listBox.Items.Clear();
            for (int x = 0; x < max; x++)
            {
                if(hours [x] != 0)
                {
                    listBox.Items.Add(hours[x]);
                }

                
            }
        }
        private void Sort() // The sort method must be coded using the Bubble Sort algorithm. 
        {
            for (int i = 0; i < max ; i++)
            {
                for (int j = 1; j < (max - i); j++)
                {
                    if (hours[j-1 ] > hours[j])
                    {
                        int temp = hours[j -1];
                        hours[j -1] = hours[j];
                        hours[j ] = temp;
                    }
                }
            }

            Display();

        }                   


        #endregion

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (listBox.SelectedIndex != -1)
            {
                string dataItem = listBox.SelectedItem.ToString();
                int dataItemIndex = listBox.FindString(dataItem);
                textBox.Text = hours[dataItemIndex].ToString();
                textBox.Focus();
            }
            else
            {
                MessageBox.Show("Please select from the List Box", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #region Value
        static private int MaxValue(int[] hours)
        {
            int maxValue = 0;
            for (int x = 0; x < hours.Length; x++)
            {
                if (hours[x] >= maxValue)
                    maxValue = hours[x];
            }
            return maxValue;
        }
        static private int MinValue(int[] hours)
        {
            int minValue = 100;
            for (int x = 0; x < hours.Length; x++)
            {
                if (hours[x] <= minValue)
                    minValue = hours[x];
            }
            return minValue;
        }
          
        #endregion

    }

}
