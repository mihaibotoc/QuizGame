using System;
using System.Windows.Forms;

namespace NewQuizGame
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        //timer
        static int seconds = 0;


        public Form1()
        {
            InitializeComponent();
            LevelNumber.Text = Form2.chosenLevel;

            askQuestion(questionNumber);

            if (LevelNumber.Text == "LevelOne")
            {
                totalQuestions = 10;
                seconds = 45;
                timer1.Start();
            }
            else if (LevelNumber.Text == "LevelTwo")
            {
                totalQuestions = 15;
                seconds = 90;
                timer1.Start();
            }
            else if (LevelNumber.Text == "LevelThree")
            {
                totalQuestions = 20;
                seconds = 180;
                timer1.Start();
            }
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            //MessageBox.Show(buttonTag.ToString());

            if (buttonTag == correctAnswer)
            {
                score++;
            }


            if (seconds > 0 && questionNumber == totalQuestions)
            {
                timer1.Stop();
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show("Quiz Ended!" + Environment.NewLine +
                                "Time left: " + seconds + " seconds." + Environment.NewLine +
                                "You have answered " + score + " questions correctly." + Environment.NewLine +
                                "Your total percentage is " + percentage + "%" + Environment.NewLine +
                                "Click OK to play again!");

                score = 0;
                questionNumber = 0;

                //askQuestion(questionNumber);

                this.Close();
            }

            questionNumber++;
            askQuestion(questionNumber);
        }


        //public static class LevelOneQuestions
        public static readonly string[,] LevelOneQuestions =
        {
            { "1356 + 300 = ?", "1656", "1666", "1566", "1665", "1" },
            { "5000 - 2555 = ?", "0", "2445", "2455", "2545", "2"},
            { "243 / 3 = ?", "91", "70", "81", "71", "3"},
            { "12 * 12 = ?", "154", "134", "140", "144", "4"},
            { "78 + 1574 = ?", "1650", "1642", "1662", "1652", "4"},
            { "76 / 4 = ?", "17", "19", "20", "18", "2"},
            { "1332 / 9 = ?", "140", "145", "148", "150", "3"},
            { "4 ^ 4 = ?", "64", "128", "124", "256", "4"},
            { "10 ^ 0 = ?", "1", "0", "10", "100", "1"},
            { "539 - 40 = ?", "500", "499", "498", "489", "2"},
            { "782 + 18 = ?", "810", "790", "800", "801", "3"},
            { "444 * 3 = ?", "1332", "1330", "1220", "1232", "1"},
            { "981 / 9 = ?", "108", "104", "110", "109", "4"},
            { "89 - 37 = ?", "50", "54", "52", "53", "3"},
            { "2 ^ 8 = ?", "128", "256", "512", "1024", "2"},
        };

        public static readonly string[,] LevelTwoQuestions =
        {
            { "Which is the most populated country in the world ?", "India", "Pakistan", "China", "France", "1"},
            { "What is the capital of Germany ?", "London", "Berlin", "Amsterdam", "Sofia", "2"},
            { "Who is the president of USA ?", "Donald Trump", "Barack Obama", "Joe Biden", "John F. Kennedy", "3"},
            { "What is the square root of 961 ?", "0", "29", "10", "31", "4"},
            { "What is the capital of Finland ?", "Moscow", "Oslo", "Helsinki", "Stockholm", "3"},
            { "Which countrybis brie chesse originally from ?", "Italy", "France", "Germany", "Poland", "2"},
            { "What is the capital of Iceland ?", "Reykjavik", "Dublin", "Brussels", "Minsk", "1"},
            { "What is the largest country in the world ?", "China", "India", "Canada", "Russia", "4"},
            { "Who played J. Robert Oppenhaimer in the Oppenheimer movie ?", "Tom Hardy", "Leonardo DiCaprio", "Christian Bale", "Cillian Murphy", "4"},
            { "How many days are in a leap year ?", "365", "364", "366", "376", "3"},
            { "Zagreb is the capital city of which country ?", "Slovenia", "Croatia", "Albania", "Slovakia", "2"},
            { "What is the capital of Brazil ?", "Brasilia", "Rio de Janeiro", "Salvador", "Sao Paulo", "1"},
            { "What is the biggest island in the world ?", "Santorini", "Mallorca", "Bali", "Greenland", "4"},
            { "Which fast food chain's slogan is 'finger lickin good' ?", "McDonald's", "Burger King", "KFC", "Taco Bell", "3"},
            { "What is the most consumed alcoholic drink in the world ?", "Whiskey", "Beer", "Vodka", "Wine", "2"},
            { "What does He stand for in the periodic table ?", "Helium", "Iron", "Nickel", "Carbon", "1"},
            { "How many sides does a heptadecagon have ?", "7", "107", "17", "1007", "3"},
            { "In American Football, how many points do you score for a touchdown ?", "Ten", "Five", "Seven", "Six", "4"},
            { "Who was the first president of the United States ?", "Grover Cleveland", "George Washington", "James Madison", "Theodore Roosevelt", "2"},
            { "Which animal has a fingerprint extremely similar to a human being ?", "Koala", "Chimpanzee", "Gorilla", "Tiger", "1"},
        };

        public static readonly string[,] LevelThreeQuestions =
        {
            { "In what year had Argentina won the World Cup ?", "2022", "2019", "2021", "2024", "1"},
            { "What is the period of the first World War ?", "1939 - 1945", "1914 - 1918", "1910 - 1918", "1916 - 1918", "2"},
            { "Which tennis player has won the most Grand Slam titles ?", "Rafael Nadal", "Roger Federer", "Novak Djokovic", "Rod Laver", "3"},
            { "In what year was 9/11 ?", "2009", "2002", "2000", "2001", "4"},
            { "Who came second in the FIFA Women's World Cup in 2019 ?", "USA", "Australia", "England", "Netherlands", "4"},
            { "Who painted the Mona Lisa ?", "Pablo Picasso", "Vincent van Gogh", "Leonardo da Vinci", "Rembrandtvan Rijn", "3"},
            { "Which planet is closest to the sun ?", "Venus", "Mars", "Mercury", "Earth", "3"},
            { "What vegetable is vodka traditionally made from ?", "Potato", "Tomato", "Apple", "Grape", "1"},
            { "Which renaissance sculptor is responsible for 'David' replaced in Florence ?", "Donatello", "Michelangelo", "Brancusi", "Bernini", "2"},
            { "What is the smallest country in the world ?", "Vatican City", "Malta", "Monaco", "Cyprus", "1"},
            { "Area 51 is located in which American State ?", "California", "Texas", "Nevada", "Florida", "3"},
            { "Which country has the longest coastline in the world ?", "Chile", "Mexico", "Argentina", "Canada", "4"},
            { "In which city would you find La Sagrada Familia ?", "Madrid", "Koln", "Milan", "Barcelona", "4"},
            { "What fruit takes the scientific name Mangifera indica ?", "Pineapple", "Mango", "Kiwi", "Passionfruit", "2"},
            { "Where was the mojito cocktail created ?", "Cuba", "Mexico", "Spain", "Italy", "1"},
            { "How many elements are therein the periodic table ?", "127", "111", "123", "118", "4"},
            { "How many bones are in the human body ?", "204", "210", "206", "207", "3"},
            { "Who discovered the concept of gravity ?", "Albert Einstein", "Sir Isaac Newton", "Paul Dirac", "Niels Bohr", "2"},
            { "Which country's rugby team is known as The Springboks ?", "Argentina", "New Zeeland", "Australia", "South Africa", "4"},
            { "How many minutes are in a game of rugby league ?", "60", "80", "45", "90", "2"},
            { "Who are the current Netball World Cup Champions ?", "New Zeeland", "Belgium", "Hungary", "France", "1"},
            { "In what year did the Berlin Wall fall ?", "1990", "1945", "1989", "1957", "3"},
            { "How old was Princess Diana when she died ?", "32", "36", "50", "38", "2"},
            { "How many years can a snail sleep for ?", "One", "Five", "Zero", "Three", "4"},
            { "In which continent would you find a poison dart frog ?", "South America", "North America", "Asia", "Africa", "1"},
        };

        public static string[,] Shuffle(Random random, string[,] arr)
        {
            int height = arr.GetUpperBound(0) + 1;
            int width = arr.GetUpperBound(1) + 1;

            for (int i = 0; i < height; ++i)
            {
                int randomRow = random.Next(i, height);
                for (int j = 0; j < width; ++j)
                {
                    string tmp = arr[i, j];
                    arr[i, j] = arr[randomRow, j];
                    arr[randomRow, j] = tmp;
                }
            }
            return arr;
        }

        static Random _randomOne = new Random();
        string[,] shuffledQ_One = Shuffle(_randomOne, LevelOneQuestions);

        static Random _randomTwo = new Random();
        string[,] shuffledQ_Two = Shuffle(_randomTwo, LevelTwoQuestions);

        static Random _randomThree = new Random();
        string[,] shuffledQ_Three = Shuffle(_randomThree, LevelThreeQuestions);
 
        private void askQuestion(int questionNumber)
        {
            if (LevelNumber.Text == "LevelOne")
            {
                switch (questionNumber)
                {

                    case 1:
                        Question.Text = shuffledQ_One[0, 0];
                        button1.Text = shuffledQ_One[0, 1];
                        button2.Text = shuffledQ_One[0, 2];
                        button3.Text = shuffledQ_One[0, 3];
                        button4.Text = (shuffledQ_One[0, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[0, 5]);

                        break;
                    case 2:
                        Question.Text = shuffledQ_One[1, 0];
                        button1.Text = shuffledQ_One[1, 1];
                        button2.Text = shuffledQ_One[1, 2];
                        button3.Text = shuffledQ_One[1, 3];
                        button4.Text = (shuffledQ_One[1, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[1, 5]);

                        break;
                    case 3:
                        Question.Text = shuffledQ_One[2, 0];
                        button1.Text = shuffledQ_One[2, 1];
                        button2.Text = shuffledQ_One[2, 2];
                        button3.Text = shuffledQ_One[2, 3];
                        button4.Text = (shuffledQ_One[2, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[2, 5]);

                        break;
                    case 4:
                        Question.Text = shuffledQ_One[3, 0];
                        button1.Text = shuffledQ_One[3, 1];
                        button2.Text = shuffledQ_One[3, 2];
                        button3.Text = shuffledQ_One[3, 3];
                        button4.Text = (shuffledQ_One[3, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[3, 5]);

                        break;
                    case 5:
                        Question.Text = shuffledQ_One[4, 0];
                        button1.Text = shuffledQ_One[4, 1];
                        button2.Text = shuffledQ_One[4, 2];
                        button3.Text = shuffledQ_One[4, 3];
                        button4.Text = (shuffledQ_One[4, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[4, 5]);

                        break;
                    case 6:
                        Question.Text = shuffledQ_One[5, 0];
                        button1.Text = shuffledQ_One[5, 1];
                        button2.Text = shuffledQ_One[5, 2];
                        button3.Text = shuffledQ_One[5, 3];
                        button4.Text = (shuffledQ_One[5, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[5, 5]);

                        break;
                    case 7:
                        Question.Text = shuffledQ_One[6, 0];
                        button1.Text = shuffledQ_One[6, 1];
                        button2.Text = shuffledQ_One[6, 2];
                        button3.Text = shuffledQ_One[6, 3];
                        button4.Text = (shuffledQ_One[6, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[6, 5]);

                        break;
                    case 8:
                        Question.Text = shuffledQ_One[7, 0];
                        button1.Text = shuffledQ_One[7, 1];
                        button2.Text = shuffledQ_One[7, 2];
                        button3.Text = shuffledQ_One[7, 3];
                        button4.Text = (shuffledQ_One[7, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[7, 5]);

                        break;
                    case 9:
                        Question.Text = shuffledQ_One[8, 0];
                        button1.Text = shuffledQ_One[8, 1];
                        button2.Text = shuffledQ_One[8, 2];
                        button3.Text = shuffledQ_One[8, 3];
                        button4.Text = (shuffledQ_One[8, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[8, 5]);

                        break;
                    case 10:
                        Question.Text = shuffledQ_One[9, 0];
                        button1.Text = shuffledQ_One[9, 1];
                        button2.Text = shuffledQ_One[9, 2];
                        button3.Text = shuffledQ_One[9, 3];
                        button4.Text = (shuffledQ_One[9, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[9, 5]);

                        break;
                    case 11:
                        Question.Text = shuffledQ_One[10, 0];
                        button1.Text = shuffledQ_One[10, 1];
                        button2.Text = shuffledQ_One[10, 2];
                        button3.Text = shuffledQ_One[10, 3];
                        button4.Text = (shuffledQ_One[10, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[10, 5]);

                        break;
                    case 12:
                        Question.Text = shuffledQ_One[11, 0];
                        button1.Text = shuffledQ_One[11, 1];
                        button2.Text = shuffledQ_One[11, 2];
                        button3.Text = shuffledQ_One[11, 3];
                        button4.Text = (shuffledQ_One[11, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[11, 5]);

                        break;
                    case 13:
                        Question.Text = shuffledQ_One[12, 0];
                        button1.Text = shuffledQ_One[12, 1];
                        button2.Text = shuffledQ_One[12, 2];
                        button3.Text = shuffledQ_One[12, 3];
                        button4.Text = (shuffledQ_One[12, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[12, 5]);

                        break;
                    case 14:
                        Question.Text = shuffledQ_One[13, 0];
                        button1.Text = shuffledQ_One[13, 1];
                        button2.Text = shuffledQ_One[13, 2];
                        button3.Text = shuffledQ_One[13, 3];
                        button4.Text = (shuffledQ_One[13, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[13, 5]);

                        break;
                    case 15:
                        Question.Text = shuffledQ_One[14, 0];
                        button1.Text = shuffledQ_One[14, 1];
                        button2.Text = shuffledQ_One[14, 2];
                        button3.Text = shuffledQ_One[14, 3];
                        button4.Text = (shuffledQ_One[14, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_One[14, 5]);

                        break;

                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }
            else if (LevelNumber.Text == "LevelTwo")
            {
                switch (questionNumber)
                {

                    case 1:
                        Question.Text = shuffledQ_Two[0, 0];
                        button1.Text = shuffledQ_Two[0, 1];
                        button2.Text = shuffledQ_Two[0, 2];
                        button3.Text = shuffledQ_Two[0, 3];
                        button4.Text = (shuffledQ_Two[0, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[0, 5]);

                        break;
                    case 2:
                        Question.Text = shuffledQ_Two[1, 0];
                        button1.Text = shuffledQ_Two[1, 1];
                        button2.Text = shuffledQ_Two[1, 2];
                        button3.Text = shuffledQ_Two[1, 3];
                        button4.Text = (shuffledQ_Two[1, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[1, 5]);

                        break;
                    case 3:
                        Question.Text = shuffledQ_Two[2, 0];
                        button1.Text = shuffledQ_Two[2, 1];
                        button2.Text = shuffledQ_Two[2, 2];
                        button3.Text = shuffledQ_Two[2, 3];
                        button4.Text = (shuffledQ_Two[2, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[2, 5]);

                        break;
                    case 4:
                        Question.Text = shuffledQ_Two[3, 0];
                        button1.Text = shuffledQ_Two[3, 1];
                        button2.Text = shuffledQ_Two[3, 2];
                        button3.Text = shuffledQ_Two[3, 3];
                        button4.Text = (shuffledQ_Two[3, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[3, 5]);

                        break;
                    case 5:
                        Question.Text = shuffledQ_Two[4, 0];
                        button1.Text = shuffledQ_Two[4, 1];
                        button2.Text = shuffledQ_Two[4, 2];
                        button3.Text = shuffledQ_Two[4, 3];
                        button4.Text = (shuffledQ_Two[4, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[4, 5]);

                        break;
                    case 6:
                        Question.Text = shuffledQ_Two[5, 0];
                        button1.Text = shuffledQ_Two[5, 1];
                        button2.Text = shuffledQ_Two[5, 2];
                        button3.Text = shuffledQ_Two[5, 3];
                        button4.Text = (shuffledQ_Two[5, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[5, 5]);

                        break;
                    case 7:
                        Question.Text = shuffledQ_Two[6, 0];
                        button1.Text = shuffledQ_Two[6, 1];
                        button2.Text = shuffledQ_Two[6, 2];
                        button3.Text = shuffledQ_Two[6, 3];
                        button4.Text = (shuffledQ_Two[6, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[6, 5]);

                        break;
                    case 8:
                        Question.Text = shuffledQ_Two[7, 0];
                        button1.Text = shuffledQ_Two[7, 1];
                        button2.Text = shuffledQ_Two[7, 2];
                        button3.Text = shuffledQ_Two[7, 3];
                        button4.Text = (shuffledQ_Two[7, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[7, 5]);

                        break;
                    case 9:
                        Question.Text = shuffledQ_Two[8, 0];
                        button1.Text = shuffledQ_Two[8, 1];
                        button2.Text = shuffledQ_Two[8, 2];
                        button3.Text = shuffledQ_Two[8, 3];
                        button4.Text = (shuffledQ_Two[8, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[8, 5]);

                        break;
                    case 10:
                        Question.Text = shuffledQ_Two[9, 0];
                        button1.Text = shuffledQ_Two[9, 1];
                        button2.Text = shuffledQ_Two[9, 2];
                        button3.Text = shuffledQ_Two[9, 3];
                        button4.Text = (shuffledQ_Two[9, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[9, 5]);

                        break;
                    case 11:
                        Question.Text = shuffledQ_Two[10, 0];
                        button1.Text = shuffledQ_Two[10, 1];
                        button2.Text = shuffledQ_Two[10, 2];
                        button3.Text = shuffledQ_Two[10, 3];
                        button4.Text = (shuffledQ_Two[10, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[10, 5]);

                        break;
                    case 12:
                        Question.Text = shuffledQ_Two[11, 0];
                        button1.Text = shuffledQ_Two[11, 1];
                        button2.Text = shuffledQ_Two[11, 2];
                        button3.Text = shuffledQ_Two[11, 3];
                        button4.Text = (shuffledQ_Two[11, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[11, 5]);

                        break;
                    case 13:
                        Question.Text = shuffledQ_Two[12, 0];
                        button1.Text = shuffledQ_Two[12, 1];
                        button2.Text = shuffledQ_Two[12, 2];
                        button3.Text = shuffledQ_Two[12, 3];
                        button4.Text = (shuffledQ_Two[12, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[12, 5]);

                        break;
                    case 14:
                        Question.Text = shuffledQ_Two[13, 0];
                        button1.Text = shuffledQ_Two[13, 1];
                        button2.Text = shuffledQ_Two[13, 2];
                        button3.Text = shuffledQ_Two[13, 3];
                        button4.Text = (shuffledQ_Two[13, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[13, 5]);

                        break;
                    case 15:
                        Question.Text = shuffledQ_Two[14, 0];
                        button1.Text = shuffledQ_Two[14, 1];
                        button2.Text = shuffledQ_Two[14, 2];
                        button3.Text = shuffledQ_Two[14, 3];
                        button4.Text = (shuffledQ_Two[14, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[14, 5]);

                        break;
                    case 16:
                        Question.Text = shuffledQ_Two[15, 0];
                        button1.Text = shuffledQ_Two[15, 1];
                        button2.Text = shuffledQ_Two[15, 2];
                        button3.Text = shuffledQ_Two[15, 3];
                        button4.Text = (shuffledQ_Two[15, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[15, 5]);

                        break;
                    case 17:
                        Question.Text = shuffledQ_Two[16, 0];
                        button1.Text = shuffledQ_Two[16, 1];
                        button2.Text = shuffledQ_Two[16, 2];
                        button3.Text = shuffledQ_Two[16, 3];
                        button4.Text = (shuffledQ_Two[16, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[16, 5]);

                        break;
                    case 18:
                        Question.Text = shuffledQ_Two[17, 0];
                        button1.Text = shuffledQ_Two[17, 1];
                        button2.Text = shuffledQ_Two[17, 2];
                        button3.Text = shuffledQ_Two[17, 3];
                        button4.Text = (shuffledQ_Two[17, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[17, 5]);

                        break;
                    case 19:
                        Question.Text = shuffledQ_Two[18, 0];
                        button1.Text = shuffledQ_Two[18, 1];
                        button2.Text = shuffledQ_Two[18, 2];
                        button3.Text = shuffledQ_Two[18, 3];
                        button4.Text = (shuffledQ_Two[18, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[18, 5]);

                        break;
                    case 20:
                        Question.Text = shuffledQ_Two[19, 0];
                        button1.Text = shuffledQ_Two[19, 1];
                        button2.Text = shuffledQ_Two[19, 2];
                        button3.Text = shuffledQ_Two[19, 3];
                        button4.Text = (shuffledQ_Two[19, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Two[19, 5]);

                        break;

                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }
            else if (LevelNumber.Text == "LevelThree")
            {
                switch (questionNumber)
                {

                    case 1:
                        Question.Text = shuffledQ_Three[0, 0];
                        button1.Text = shuffledQ_Three[0, 1];
                        button2.Text = shuffledQ_Three[0, 2];
                        button3.Text = shuffledQ_Three[0, 3];
                        button4.Text = (shuffledQ_Three[0, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[0, 5]);

                        break;
                    case 2:
                        Question.Text = shuffledQ_Three[1, 0];
                        button1.Text = shuffledQ_Three[1, 1];
                        button2.Text = shuffledQ_Three[1, 2];
                        button3.Text = shuffledQ_Three[1, 3];
                        button4.Text = (shuffledQ_Three[1, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[1, 5]);

                        break;
                    case 3:
                        Question.Text = shuffledQ_Three[2, 0];
                        button1.Text = shuffledQ_Three[2, 1];
                        button2.Text = shuffledQ_Three[2, 2];
                        button3.Text = shuffledQ_Three[2, 3];
                        button4.Text = (shuffledQ_Three[2, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[2, 5]);

                        break;
                    case 4:
                        Question.Text = shuffledQ_Three[3, 0];
                        button1.Text = shuffledQ_Three[3, 1];
                        button2.Text = shuffledQ_Three[3, 2];
                        button3.Text = shuffledQ_Three[3, 3];
                        button4.Text = (shuffledQ_Three[3, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[3, 5]);

                        break;
                    case 5:
                        Question.Text = shuffledQ_Three[4, 0];
                        button1.Text = shuffledQ_Three[4, 1];
                        button2.Text = shuffledQ_Three[4, 2];
                        button3.Text = shuffledQ_Three[4, 3];
                        button4.Text = (shuffledQ_Three[4, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[4, 5]);

                        break;
                    case 6:
                        Question.Text = shuffledQ_Three[5, 0];
                        button1.Text = shuffledQ_Three[5, 1];
                        button2.Text = shuffledQ_Three[5, 2];
                        button3.Text = shuffledQ_Three[5, 3];
                        button4.Text = (shuffledQ_Three[5, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[5, 5]);

                        break;
                    case 7:
                        Question.Text = shuffledQ_Three[6, 0];
                        button1.Text = shuffledQ_Three[6, 1];
                        button2.Text = shuffledQ_Three[6, 2];
                        button3.Text = shuffledQ_Three[6, 3];
                        button4.Text = (shuffledQ_Three[6, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[6, 5]);

                        break;
                    case 8:
                        Question.Text = shuffledQ_Three[7, 0];
                        button1.Text = shuffledQ_Three[7, 1];
                        button2.Text = shuffledQ_Three[7, 2];
                        button3.Text = shuffledQ_Three[7, 3];
                        button4.Text = (shuffledQ_Three[7, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[7, 5]);

                        break;
                    case 9:
                        Question.Text = shuffledQ_Three[8, 0];
                        button1.Text = shuffledQ_Three[8, 1];
                        button2.Text = shuffledQ_Three[8, 2];
                        button3.Text = shuffledQ_Three[8, 3];
                        button4.Text = (shuffledQ_Three[8, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[8, 5]);

                        break;
                    case 10:
                        Question.Text = shuffledQ_Three[9, 0];
                        button1.Text = shuffledQ_Three[9, 1];
                        button2.Text = shuffledQ_Three[9, 2];
                        button3.Text = shuffledQ_Three[9, 3];
                        button4.Text = (shuffledQ_Three[9, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[9, 5]);

                        break;
                    case 11:
                        Question.Text = shuffledQ_Three[10, 0];
                        button1.Text = shuffledQ_Three[10, 1];
                        button2.Text = shuffledQ_Three[10, 2];
                        button3.Text = shuffledQ_Three[10, 3];
                        button4.Text = (shuffledQ_Three[10, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[10, 5]);

                        break;
                    case 12:
                        Question.Text = shuffledQ_Three[11, 0];
                        button1.Text = shuffledQ_Three[11, 1];
                        button2.Text = shuffledQ_Three[11, 2];
                        button3.Text = shuffledQ_Three[11, 3];
                        button4.Text = (shuffledQ_Three[11, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[11, 5]);

                        break;
                    case 13:
                        Question.Text = shuffledQ_Three[12, 0];
                        button1.Text = shuffledQ_Three[12, 1];
                        button2.Text = shuffledQ_Three[12, 2];
                        button3.Text = shuffledQ_Three[12, 3];
                        button4.Text = (shuffledQ_Three[12, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[12, 5]);

                        break;
                    case 14:
                        Question.Text = shuffledQ_Three[13, 0];
                        button1.Text = shuffledQ_Three[13, 1];
                        button2.Text = shuffledQ_Three[13, 2];
                        button3.Text = shuffledQ_Three[13, 3];
                        button4.Text = (shuffledQ_Three[13, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[13, 5]);

                        break;
                    case 15:
                        Question.Text = shuffledQ_Three[14, 0];
                        button1.Text = shuffledQ_Three[14, 1];
                        button2.Text = shuffledQ_Three[14, 2];
                        button3.Text = shuffledQ_Three[14, 3];
                        button4.Text = (shuffledQ_Three[14, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[14, 5]);

                        break;
                    case 16:
                        Question.Text = shuffledQ_Three[15, 0];
                        button1.Text = shuffledQ_Three[15, 1];
                        button2.Text = shuffledQ_Three[15, 2];
                        button3.Text = shuffledQ_Three[15, 3];
                        button4.Text = (shuffledQ_Three[15, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[15, 5]);

                        break;
                    case 17:
                        Question.Text = shuffledQ_Three[16, 0];
                        button1.Text = shuffledQ_Three[16, 1];
                        button2.Text = shuffledQ_Three[16, 2];
                        button3.Text = shuffledQ_Three[16, 3];
                        button4.Text = (shuffledQ_Three[16, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[16, 5]);

                        break;
                    case 18:
                        Question.Text = shuffledQ_Three[17, 0];
                        button1.Text = shuffledQ_Three[17, 1];
                        button2.Text = shuffledQ_Three[17, 2];
                        button3.Text = shuffledQ_Three[17, 3];
                        button4.Text = (shuffledQ_Three[17, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[17, 5]);

                        break;
                    case 19:
                        Question.Text = shuffledQ_Three[18, 0];
                        button1.Text = shuffledQ_Three[18, 1];
                        button2.Text = shuffledQ_Three[18, 2];
                        button3.Text = shuffledQ_Three[18, 3];
                        button4.Text = (shuffledQ_Three[18, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[18, 5]);

                        break;
                    case 20:
                        Question.Text = shuffledQ_Three[19, 0];
                        button1.Text = shuffledQ_Three[19, 1];
                        button2.Text = shuffledQ_Three[19, 2];
                        button3.Text = shuffledQ_Three[19, 3];
                        button4.Text = (shuffledQ_Three[19, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[19, 5]);

                        break;
                    case 21:
                        Question.Text = shuffledQ_Three[20, 0];
                        button1.Text = shuffledQ_Three[20, 1];
                        button2.Text = shuffledQ_Three[20, 2];
                        button3.Text = shuffledQ_Three[20, 3];
                        button4.Text = (shuffledQ_Three[20, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[20, 5]);

                        break;
                    case 22:
                        Question.Text = shuffledQ_Three[21, 0];
                        button1.Text = shuffledQ_Three[21, 1];
                        button2.Text = shuffledQ_Three[21, 2];
                        button3.Text = shuffledQ_Three[21, 3];
                        button4.Text = (shuffledQ_Three[21, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[21, 5]);

                        break;
                    case 23:
                        Question.Text = shuffledQ_Three[22, 0];
                        button1.Text = shuffledQ_Three[22, 1];
                        button2.Text = shuffledQ_Three[22, 2];
                        button3.Text = shuffledQ_Three[22, 3];
                        button4.Text = (shuffledQ_Three[22, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[22, 5]);

                        break;
                    case 24:
                        Question.Text = shuffledQ_Three[23, 0];
                        button1.Text = shuffledQ_Three[23, 1];
                        button2.Text = shuffledQ_Three[23, 2];
                        button3.Text = shuffledQ_Three[23, 3];
                        button4.Text = (shuffledQ_Three[23, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[23, 5]);

                        break;
                    case 25:
                        Question.Text = shuffledQ_Three[24, 0];
                        button1.Text = shuffledQ_Three[24, 1];
                        button2.Text = shuffledQ_Three[24, 2];
                        button3.Text = shuffledQ_Three[24, 3];
                        button4.Text = (shuffledQ_Three[24, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ_Three[24, 5]);

                        break;

                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show("Quiz Ended!" + Environment.NewLine +
                                "You have answered" + score + " questions correctly." + Environment.NewLine +
                                "Your total percentage is " + percentage + "%" + Environment.NewLine +
                                "Click OK to play again!");

                score = 0;
                questionNumber = 0;
                this.Close();
            }
        }
    }
}
