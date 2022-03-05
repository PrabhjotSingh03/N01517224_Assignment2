using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01517224.Controllers
{
    public class Assignment2Controller : ApiController
    {


        //J1. program for counting calories based on food selected by the user 

        [HttpGet]  //method for http get 
        [Route("api/Assignment2/Menu/{burger}/{drink}/{side}/{dessert}")]
        //example: GET /api/Assignment2/Menu/{burger}/{drink}/{side}/{dessert} , values in curly brackets{} indicated id which user entered in the url
        public int Menu(int burger, int drink, int side, int dessert)
        {
            // if user enter some value as a id in url based on the choice if else statment works and give results

            //choices for burger starts from here

            if (burger == 1)
            {
                burger = 461;
            }
            else if (burger == 2)
            {
                burger = 431;
            }
            else if (burger == 3)
            {
                burger = 420;
            }
            else
            {
                burger = 0;
            }

            //choices of burgers ends here

            //choices for drink starts from here

            if (drink == 1)
            {
                drink = 130;
            }
            else if (drink == 2)
            {
                drink = 160;
            }
            else if (drink == 3)
            {
                drink = 118;
            }
            else
            {
                drink = 0;
            }

            //choices of drink ends here

            //choices for side starts from here

            if (side == 1)
            {
                side = 100;
            }
            else if (side == 2)
            {
                side = 57;
            }
            else if (side == 3)
            {
                side = 70;
            }
            else
            {
                side = 0;
            }

            //choices of side ends here

            //choices for dessert starts from here

            if (dessert == 1)
            {
                dessert = 167;
            }
            else if (dessert == 2)
            {
                dessert = 266;
            }
            else if (dessert == 3)
            {
                dessert = 75;
            }
            else
            {
                dessert = 0;
            }

            //choices of dessert ends here

            //total of calories are calculated here based on choice of id's user entered in url
            int total = burger + drink + side + dessert;
            return total;    //total result is shown to the user 

        }

        //J2. program for determines how many ways she can roll the value of 10.

        [HttpGet]   //method for http get 
        [Route("api/Assignment2/Dice/{m}/{n}")]
        //example: GET /api/Assignment2/DiceGame/6/8  values in curly brackets{} indicated id which user entered in the url

        public string Dice(int m, int n)
        {
            int ways = 0;

            for (int i = 1; i <= m; i++)   //first dice of m sides
            {
                for (int j = 1; j <= n; j++)    //second dice of n sides
                {
                    if ((i + j) == 10)      //checks if total of both dices is equal to 10 or not
                    {
                        ways = ways + 1;   //number of ways
                    }
                }
            }
            return "There are " + ways + " total ways to get the sum 10."; //outputing the result 
        }

        //J3. Cell-Phone Messaging

        /*[HttpGet]  //method for http get 
        [Route("api/Assignment2/Text/{word}")]

        public string Text(string word)
        {
            int text;
            }
            if (word == "halt") {
                return word ;
            }
            else if index("adgjmptw")
             {
            text = text + 1;
            }
             else if index("behknqux")
            {
            text = text + 2;
            }
            else if index("cfilorvy")
            {
           text = text + 3;
            }
            else if index("sz")
            {
           text = text + 4;
            }
        return text;
        }*/
    }
}
