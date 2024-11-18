using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Individual_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            
                DateTime birthDate = default;

                //My variable na gagamitin for my code
                string newName = "";
                DateTime birthTime = DateTime.MinValue;
                int age = 0;
                int idNumber = 0;
                string course = "";
                string phoneNumber = "";
                string email = "";


                Console.WriteLine("Vacation Plan");
                Console.WriteLine();
                Console.WriteLine("I. Personal Information");
                Console.WriteLine();
                Console.WriteLine("Fill up all the Information needed");
                Console.WriteLine();

                //Name Input
                while (string.IsNullOrEmpty(newName)) //used to let the user input their name and prevent to proceed if it is null/empty
                {

                    Console.Write("Enter your name: ");
                    newName = Console.ReadLine();
                }
                Console.WriteLine();

                //Birthday Input
                while (birthDate == DateTime.MinValue)
                {
                    // get the year of birth
                    Console.WriteLine("Enter your Birthdate");
                    Console.Write("Year of Birth: "); //
                    int year = GetValidNumber(1900, 2024); //This will make sure that the inputs are just numbers and has a range of numbers to be used

                    //get the month of birth
                    Console.Write("Month of Birth: "); //use a write only to print it in one lane 
                    int month = GetValidNumber(1, 12);

                    // get the day of birth
                    Console.Write("Day of Birth: ");
                    int day = GetValidNumber(1, 31);

                    //make the data in date format
                    birthDate = new DateTime(year, month, day);
                    DateTime currentDate = DateTime.Now;

                    age = currentDate.Year - birthDate.Year; // used to easily compute their age as they enter their real birthdate

                    if (currentDate < birthDate.AddYears(age))
                    {
                        age--; // Adjust the age if the birthday hasn't occurred yet this year
                    }
                }

                Console.WriteLine();

                //School Id Number Input
                if (idNumber == 0)
                {

                    while (true)
                    {
                        Console.WriteLine("Enter your school ID number: ");
                        bool correctIdNumberInput = int.TryParse(Console.ReadLine(), out idNumber); //let numbers only

                        if (correctIdNumberInput && idNumber > 0) // the input should be greater than 0
                            break;

                        Console.WriteLine("You enter an INVALID ID Number");
                    }
                }
                Console.WriteLine(); // to let have a space between question being asked

                //Course Input
                if (string.IsNullOrEmpty(course))

                    while (true)
                    {
                        Console.WriteLine("Enter Your Course from the list bellow: ");
                        Console.WriteLine("BSBA");
                        Console.WriteLine("BSHM");
                        Console.WriteLine("BSIT");
                        Console.WriteLine("DHRT");

                        course = Console.ReadLine().ToUpper(); //make the input to uppercase

                        if (course == "BSBA" || course == "BSHM" || course == "BSIT" || course == "DHRT") // make sure that only the list from above are the only to be selected
                        {
                            Console.WriteLine($"You Selected: {course}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid. Please select a valid course from the list ");
                        }
                    }

                Console.WriteLine();

                //Phone Number Input

                if (string.IsNullOrEmpty(phoneNumber))
                {
                    const int phoneNumberLength = 10; // to make sure it only contains a 10 digit numbers

                    while (true)
                    {
                        Console.Write($"Enter your {phoneNumberLength}-digit Phone Number: +63");
                        phoneNumber = Console.ReadLine();


                        //cheking for the number that it should be 10 digits only and doesn't contains alphabet letters

                        if (phoneNumber.Length != phoneNumberLength)
                        {
                            Console.WriteLine($"Invalid. It must contain {phoneNumberLength} digits only");
                            continue;
                        }

                        bool correctNumber = true;
                        for (int i = 0; i < phoneNumber.Length; i++)
                        {
                            if (!char.IsDigit(phoneNumber[i]))
                            {
                                correctNumber = false;
                                break;
                            }
                        }
                        if (correctNumber)
                        {
                            Console.WriteLine($"Your Phone Number: +63{phoneNumber}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid. Please enter numbers only");
                        }
                    }
                }

                // Email input

                while (string.IsNullOrEmpty(email))
                {

                    Console.Write("Enter your Email Address: ");
                    email = Console.ReadLine();
                }


                //This will turn ALL the user's input to output and validate if it has any correction 
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + newName);
                    Console.WriteLine("Date of Birth: " + birthDate.ToString("MMMM dd, yyyy")); // tostring to convert numbers to letters
                    Console.WriteLine("Age: " + age);
                    Console.WriteLine("School ID number: " + idNumber);
                    Console.WriteLine("Course: " + course);
                    Console.WriteLine("Phone Number: " + phoneNumber);
                    Console.WriteLine("Email Address: " + email);
                    Console.WriteLine();

                    // question to confirm if any of the information needed to edit
                    Console.WriteLine("Do you want to edit any information? ( YES / NO )");
                    string editChoice = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    if (editChoice == "NO")
                    {
                        Console.WriteLine("Information saved successfully.");
                        break;
                    }
                    // FULL information of the data that you want to edit 

                    Console.WriteLine("Which information do you want to edit?");
                    Console.WriteLine("1. Name");
                    Console.WriteLine("2. Birthdate");
                    Console.WriteLine("3. School ID Number");
                    Console.WriteLine("4. Course");
                    Console.WriteLine("5. Phone Number");
                    Console.WriteLine("6. Email Address");
                    Console.WriteLine("Enter the number corresponding to the field you want to edit:");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.Write("Enter your name: ");
                            newName = Console.ReadLine();
                            break;

                        case "2":
                            Console.WriteLine("Enter your Birthdate:");
                            Console.Write("Year of Birth: ");
                            int year = GetValidNumber(1900, 2024);
                            Console.Write("Month of Birth: ");
                            int month = GetValidNumber(1, 12);
                            Console.Write("Day of Birth: ");
                            int day = GetValidNumber(1, 31);
                            birthDate = new DateTime(year, month, day);
                            DateTime currentDate = DateTime.Now;
                            age = currentDate.Year - birthDate.Year;
                            if (currentDate < birthDate.AddYears(age)) age--;
                            break;

                        case "3":
                            while (true)
                            {
                                Console.WriteLine("Enter your school ID number: ");
                                if (int.TryParse(Console.ReadLine(), out idNumber)) break;
                                Console.WriteLine("You entered an INVALID ID Number.");
                            }
                            break;

                        case "4":
                            while (true)
                            {
                                Console.WriteLine("Enter Your Course from the list below:");
                                Console.WriteLine("BSBA");
                                Console.WriteLine("BSHM");
                                Console.WriteLine("BSIT");
                                Console.WriteLine("DHRT");

                                course = Console.ReadLine().ToUpper();
                                if (course == "BSBA" || course == "BSHM" || course == "BSIT" || course == "DHRT")
                                {
                                    Console.WriteLine($"You Selected: {course}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid. Please select a valid course from the list.");
                                }
                            }
                            break;

                        case "5":
                            const int phoneNumberLength = 10;
                            while (true)
                            {
                                Console.Write($"Enter your {phoneNumberLength}-digit Phone Number: +63");
                                phoneNumber = Console.ReadLine();
                                if (phoneNumber.Length != phoneNumberLength)
                                {
                                    Console.WriteLine($"Invalid. It must contain {phoneNumberLength} digits only.");
                                    continue;
                                }

                                bool correctPhoneNumber = true;
                                for (int i = 0; i < phoneNumber.Length; i++)
                                {
                                    if (!char.IsDigit(phoneNumber[i]))
                                    {
                                        correctPhoneNumber = false;
                                        break;
                                    }
                                }

                                if (correctPhoneNumber)
                                {
                                    Console.WriteLine($"Your Phone Number: +63{phoneNumber}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid. Please enter numbers only.");
                                }
                            }
                            break;

                        case "6":
                            Console.Write("Enter your Email Address: ");
                            email = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                    Console.Write("Do you have any correction? (YES / NO): "); //to confirm again if there is another info to be edited
                    editChoice = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    if (editChoice == "NO")
                    {
                        Console.WriteLine("Information saved successfully.");
                        break;
                    }

                } while (true); // loop until no further edits needed

                // The `do-while` loop allows the user to review and edit their information if needed.

                // Final display of information
                Console.WriteLine("VACATION PLAN");
                Console.WriteLine();
                Console.WriteLine("Final Information:");
                Console.WriteLine();
                Console.WriteLine("Name: " + newName);
                Console.WriteLine("Date of Birth: " + birthDate.ToString("MMMM dd, yyyy"));
                Console.WriteLine("Age: " + age);
                Console.WriteLine("School ID number: " + idNumber);
                Console.WriteLine("Course: " + course);
                Console.WriteLine("Phone Number: " + phoneNumber);
                Console.WriteLine("Email Address: " + email);

                Console.WriteLine();
                Console.WriteLine("To proceed to the next step, please type and letter/number and hit the enter key");
                Console.ReadLine();

                bool exit = false; //to control the while loop 

                while (!exit)
                {
                    //Display the cafe details and the list of recommended places
                    Console.WriteLine();
                    Console.WriteLine("II. Cafe Food Details");
                    Console.WriteLine();
                    Console.WriteLine("Here are the lists of recommended CAFE to visit at Baguio City before 2024 ends");
                    Console.WriteLine("1. Slack Off Cafe");
                    Console.WriteLine("2. Foam Coffee");
                    Console.WriteLine("3. Hiraya Cafe");
                    Console.WriteLine("4. Itaewon Louge Cafe");
                    Console.WriteLine("5. Dabang Cafe");
                    Console.WriteLine("6. Perfect Blend Cafe");
                    Console.WriteLine();

                    //let the user select number that correspond to the place the want to
                    Console.Write("Enter the number corresponding to the Place you wanted to visit: ");

                    string plac = Console.ReadLine();
                    bool validChoice = false;
                    switch (plac)
                    {
                        // when user select one of the following list except Baguio, all the case 1,2,3,5,6 have the same conditions
                        case "1":
                        case "2":
                        case "3":
                        case "5":
                        case "6":
                            Console.Write("Do you have the money to go? (YES or NO): ");
                            string places = Console.ReadLine().ToUpper();
                            Console.WriteLine();

                            if (places == "NO")
                            {
                                Console.WriteLine("PLEASE SELECT NO. 4 INSTEAD.");
                                string placed = Console.ReadLine();
                                if (placed == "4") // if the select number 4 baguio city
                                {
                                    Console.WriteLine("Sorry you still do not have a budget to roam around Baguio City");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid response. Please enter a valid number."); //if they place an invalid input
                                }
                            }
                            else if (places == "YES")
                            {

                                Console.Write("Great! How much money do you have right now?: ");
                                int money = GetValidNumber(0, 999999);
                                Console.WriteLine();
                                Console.Write($"Is that true that you have {money} pesos? (YES or NO): ");
                                string falt = Console.ReadLine().ToUpper();
                                if (falt == "YES")
                                {
                                    Console.WriteLine();
                                    Console.Write("Are you serious? (YES or NO): ");
                                    string ser = Console.ReadLine().ToLower();
                                    if (ser == "YES")
                                    {
                                        Console.WriteLine(" NO, you are joking. Please select another place");
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You're a liar, you don't have that money.");
                                        Console.WriteLine("Please select another place.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid response. Please enter YES or NO.");
                            }
                            break;
                        case "4":
                            exit = true; //Set the exit to true to end the loop
                            Console.WriteLine();
                            Console.WriteLine("Sorry you still do not have budget to roam around Baguio City");
                            Console.WriteLine("Thank You for your time");
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please enter a number between 1 and 6.");
                            // to let them know they are only allowed to enter 1 to 6 only
                            break;
                    }
                }
                int GetValidNumber(int minValue, int maxValue)
                {
                    int number;
                    bool isValid;
                    do
                    {
                        isValid = int.TryParse(Console.ReadLine(), out number) && number >= minValue && number <= maxValue;
                        if (!isValid)
                        {
                            Console.WriteLine($"Invalid input. Please enter a number between {minValue} and {maxValue}.");
                        }
                    } while (!isValid);
                    return number;
                }
            }
        }
    }
    

