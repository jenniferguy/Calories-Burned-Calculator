using System;

namespace Calories_Burned
{
    class Program
    {
        static void Main(string[] args)
        {   
            //SHOW HEADING FOR TABLE
            Console.WriteLine(" Minutes\t Calories Burned");//WHAT DO I WANT TO SHOW THE USER
            Console.WriteLine("--------------------------------");//LINE TO SEPERATE THE OUTPUT FROM THE HEADING(OPTIONAL)
            //DECLARE VARIABLE(S)
            double caloriesPerMinute = 3.9;//3.9 WAS GIVEN INFORMATION IN THE PROJECT
            //SHOW TEST FOR LOOP
            for (double minutes = 10.0; minutes >= 10 && minutes <= 30; minutes += 5){//I USED A FOR LOOP BECAUSE THE DATA TO TEST WAS GIVEN
            //ABOVE-I DECLARED MINUTES AS A VARIABLE AND ASSIGNED IT 10 BECAUSE THAT IS THE TEST NUMBER I WILL START WITH
            //THE MINUTES THAT I AM TESTING IS BETWEEN 10 AND 30(GIVEN FROM THE PROJECT EXERCISE)SO I USED && BECAUSE I ONLY WANT TO SHOW DATA BETWEEN THOSE NUMBER
            //THE NUMBERS TO TEST WERE INCREASED BY 5 IN THE EXERCISE(10,15,20,25,30)SO I USE THE += OPERATOR SO THAT IS WILL DISPLAY THE NUMBERS IN ADDITIVES OF 5 AFTER THE STARTING TEST VALUE.
                //SHOW CALCULATIONS-I DECLARED THE VARIABLE caloriesBurned IN THE CALCULATION-I COULD HAVE DECLARED IT BEFORE THOUGH.
                double caloriesBurned = caloriesPerMinute * minutes;

                //SHOW OUTPUT-WHAT I WANT TO DISPLAY TO THE USER
                Console.WriteLine(" {0}\t\t\t{1}", minutes, caloriesBurned);
            }//END FOR
        }//END MAIN
    }//END CLASS
}//END NAMESPACE
