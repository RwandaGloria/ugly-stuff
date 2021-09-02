using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicCal
{

    public partial class CalculatorG : Form
    {

        public CalculatorG()
        {
            InitializeComponent();
            list = new List<string>();



            //get the length of the textbox text
            //then find the position of the string or so. 
            //after that, you will then subtract it from the length of the ext
            //display length-one - position of the symbol. 
        }
        // 
        // textBox1
        List<string> list;

        //this symbol changes for each function like add, subtract, etc. 
        //symbol=+, symbol= -, symbl = *
        public string Symbol;
       

        public class KeyEventArgs : EventArgs
        {

        }

        //declares the boolean instructions to know if each button like add was pressed
       

        private bool nonNumberEntered = false; //declares the boolean noNumber entered as false.
        public bool buttonAddClicked = false;
        public bool buttonSubClicked = false;
        public bool buttonEquClicked = false;
        public bool buttonDivClicked = false;
        public bool buttonMulClicked = false;
        public float result;
        public string textboxText;


        //This is the instruction that describes what would happen when a key is pressed 
        //and released once.

        public void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;    //sets to false when a key from keyboard is pressed.

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            else
            {
                textBox1.Focus();    //focuses the cursor to type on the textbox
    

            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }

            if (nonNumberEntered == true)
            {
                DialogResult dialogD = MessageBox.Show("Enter numeric characters only");

                if (dialogD == DialogResult.OK)
                {

                }
            }

        }

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
       
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }


        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.

        public void addButton_click(object sender, EventArgs g)

        {

           
            string a = textBox1.Text;
            Symbol = "+";     //symbol for add, gets concatenated with the existing textbox code. 
            textBox1.Text = a + Symbol;


            textBox1.Focus();


            buttonAddClicked = true;  //when the add button is clicked, bool instruction is true
            buttonSubClicked = false;  //bool instruction for sub is false.
        }

        public void subButton_click(object sender, EventArgs h)
        {
            buttonSubClicked = true;
            buttonAddClicked = false;
            buttonMulClicked = false;
            buttonDivClicked = false;

            string a = textBox1.Text;     //symbol here is -, and gets concatenated when the subtract is clicked.
            Symbol = "-";
            textBox1.Text = a + Symbol;

            textBox1.Focus();  //after clicking the button, focus the mouse cursor on the textbox.
            
           
            

        }
        public void multiplyButton_Click(object sender, EventArgs e)
        {
            buttonMulClicked = true;

            buttonSubClicked = false;
            buttonAddClicked = false;
            buttonDivClicked = false;

            string a = textBox1.Text;
            Symbol = "*";
            textBox1.Text = a + Symbol;

            textBox1.Focus();
            


        }

        public void divButton_Click(object sender, EventArgs d)
        {
            buttonDivClicked = true;

            string a = textBox1.Text;
            Symbol = "/";
            textBox1.Text = a + Symbol;

            textBox1.Focus();
            buttonSubClicked = false;
            buttonAddClicked = false;

        }
        public void equButton_Click(object sender, EventArgs j) //the equal to, = button
        {
            if (buttonAddClicked == true)  //if addButton was clicked
            {
                buttonSubClicked = false;  //this conditions should be false, and no other button 
                //should be clicked.
                buttonDivClicked = false;
                buttonMulClicked = false;

   //i divided up the textbox into two, where itll be separated by the symbol
   //for example, "555+234", since textbox only takes string it has to be this way. 
   //555 would be the string before the + or symbol

                //while 234 is the symbol after the symbol, or beforeSign.

               
                
                
                string afterSign = textBox1.Text.Substring((textBox1.Text.IndexOf("+")+1)); //checks or the string before the sign
                string beforeSign = textBox1.Text.Substring(0, textBox1.Text.IndexOf("+"));  //checks for the string

                Double afterSignF = Convert.ToDouble(afterSign); //then convert the afterSign to a double or float number. 

                //converts the beforeSign to a double as well
                Double beforeSignF = Convert.ToDouble(beforeSign);

                Double result = afterSignF + beforeSignF; //since this is the addButton clicked, then
                //execute the add instruction and then, since textbox takes only string Instruction

                //convert the double or float value back to string.
                textBox1.Text = result.ToString();

            }
            else if (buttonSubClicked == true ) //if buttonSub was clicked
            //execute the following instructions. 

            {
                /*this ensures that the other buttons are not clicked when
                the buttonSub is clicked.*/

                buttonAddClicked = false;
                buttonDivClicked = false;
                buttonMulClicked=false;
                
               

                string afterSign = textBox1.Text.Substring((textBox1.Text.IndexOf("-") + 1));
                string beforeSign = textBox1.Text.Substring(0, textBox1.Text.IndexOf("-"));


                Double afterSignF = Convert.ToDouble(afterSign);
                Double beforeSignF = Convert.ToDouble(beforeSign);

                Double result_sub = (beforeSignF - afterSignF);

                textBox1.Clear();  //clear the textbox
                textBox1.Text = result_sub.ToString();
            }
            else if(buttonDivClicked== true)
            {
                buttonAddClicked = false;
                buttonSubClicked = false;
                buttonMulClicked = false;

                string afterSign = textBox1.Text.Substring((textBox1.Text.IndexOf("/") + 1));
                string beforeSign = textBox1.Text.Substring(0, textBox1.Text.IndexOf("/"));


                Double afterSignF = Convert.ToDouble(afterSign);
                Double beforeSignF = Convert.ToDouble(beforeSign);

                Double result_div = (beforeSignF / afterSignF);

                textBox1.Clear();
                textBox1.Text = result_div.ToString();



            }
            else if (buttonMulClicked == true )
            {
                buttonAddClicked = false;
                buttonDivClicked = false;
                buttonSubClicked = false;
                



                string afterSign = textBox1.Text.Substring((textBox1.Text.IndexOf("*") + 1));
                string beforeSign = textBox1.Text.Substring(0, textBox1.Text.IndexOf("*"));


                Double afterSignF = Convert.ToDouble(afterSign);
                Double beforeSignF = Convert.ToDouble(beforeSign);

                Double result_mul = ((beforeSignF) * (afterSignF));

                textBox1.Clear();
                textBox1.Text = result_mul.ToString();
            }

        }

       
    }
}





