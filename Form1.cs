using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Alex Carney, Hoainam Duong
//Oct. 17, 2017
//Math adding game

namespace MathGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the addition game!" +
                            "\nBegin by entering the highest number you want added" +
                            " and the amount of questions you would like.");

        }

        // Field variables so that the buttons have a way to keep a running count of correct answers, rounds, and max rounds
        double ROUND_COUNT = 0,
               CORRECT_ANSWER = 0,
               MAX_ROUNDS = 0;

        public void CreateNumbers()
        {
            // first create variables to hold the two random ints

            int num1 = 0,
                num2 = 0,
                highestNum = 0;



            // create Random object(rand) to generate numbers
            Random rand = new Random();

            highestNum = int.Parse(highestNumTextbox.Text);

            // assigns the random number to int variables and adds 1
            // so you get numbers 1 - 10
            num1 = rand.Next(highestNum) + 1;
            num2 = rand.Next(highestNum) + 1;

            num1Label.Text = num1.ToString();
            num2Label.Text = num2.ToString();

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            int rounds;

            int highestNum;

            // Validation
            try
            {
                // checks if user has entered a name
                if (int.TryParse(highestNumTextbox.Text, out highestNum))
                {
                    // checks if user has enter an int for number of rounds
                    if (int.TryParse(roundsTextbox.Text, out rounds))
                    {
                        answerTextbox.Clear();
                        answerTextbox.Focus();

                        // If validation is good then this starts game
                        CreateNumbers();
                        mathGroupbox.Visible = true;
                        submitButton.Visible = true;
                        startButton.Visible = false;

                        // Reset field variables if user plays again
                        CORRECT_ANSWER = 0;
                        ROUND_COUNT = 0;
                        MAX_ROUNDS = int.Parse(roundsTextbox.Text);
                        

                    }

                    else
                    {
                        MessageBox.Show("Please enter in the amount of rounds you" +
                                        " would like to play!");
                        roundsTextbox.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("Please enter your highest number that you can add with.");
                    highestNumTextbox.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Please enter in your name and number of rounds to begin.");
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            CreateNumbers();

            answerTextbox.Clear();
            answerTextbox.Focus();

            nextQuestionButton.Visible = false;
            submitButton.Visible = true;


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int userNum = 0,
                answer = 0,
                num1 = 0,
                num2 = 0;

            double grade = 0;

            ROUND_COUNT += 1;


            submitButton.Visible = false;

            if (int.TryParse(answerTextbox.Text, out userNum))
            {
                num1 = int.Parse(num1Label.Text);
                num2 = int.Parse(num2Label.Text);

                answer = num1 + num2;

                // checks if the user entered the right number
                if (userNum == answer)
                {

                    CORRECT_ANSWER += 1;
                    MessageBox.Show("Correct!");
                }

                else
                {
                    MessageBox.Show("Incorrect " + num1.ToString() + " + " + num2.ToString()
                                      + " = " + answer.ToString());
                }

                nextQuestionButton.Visible = true;
            }


            else
            {
                MessageBox.Show("Please enter in your answer!");
                answerTextbox.Focus();
            }

            if (ROUND_COUNT == MAX_ROUNDS)
            {

                grade = (CORRECT_ANSWER / MAX_ROUNDS) * 100;

                MessageBox.Show("Finished!" +
                                "\nYou got " + CORRECT_ANSWER.ToString() +
                                " out of " + MAX_ROUNDS.ToString() + " questions correct" +
                                "\nYour grade is: " + grade.ToString("n2") + "%");

                mathGroupbox.Visible = false;
                startButton.Visible = true;
                submitButton.Visible = false;
                nextQuestionButton.Visible = false;
            }

        }

    }
}

