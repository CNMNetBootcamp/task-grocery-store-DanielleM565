//A grocery store collects bottles for recycling. Write a program that takes in the number of bottles received each day and outputs the weekly total and the amount paid. (A bottle is worth 10 cents) You must use a loop. You must accumulate the number of bottles in the loop YOu do not need to care about the day of the week

//Setup
Single todaysBottleNumber; //how many bottles were recycled
Single weeksBottleNumber = 0; //how many times a values has been enterd for number of bottles up to 7 at 7 it resets (in theory)
Double tenCents = 0.1;
Single bottlesTotal; //Running total of todaysBottleNumber while the weeksBottleNumber is less than 7
Single recyclingCost; //total number of bottles for that week times tenCents
string continueResponse = "Y";

//input

    //loop asking for new days bottles adding the value to the running total of weeks bottle number and repeat until user has been asked 7 times
    for (int i = 0; i< 7; i++) 
    {
        do
	    {
            Console.WriteLine("How many bottle's were recycled today?");
            
	    } while (!Single.TryParse(Console.ReadLine(), out todaysBottleNumber));
        bottlesTotal = weeksBottleNumber  /*or bottlestotal*/ + todaysBottleNumber; //add the new number to the running total variable
    }  

//process

    recyclingCost = bottlesTotal * tenCents;
    
//output

    Console.WriteLine("This weeks recycling total is $" + recyclingCost);
