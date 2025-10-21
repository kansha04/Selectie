// The 8 Ball Program //

//= Variables =//

string name, question, answer;

//= Input =//

Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("What is your question?");
question = Console.ReadLine();

//= Random Number  =//

Random rnd = new Random();
int randomNumber = rnd.Next(1, 9);
//Console.WriteLine(randomNumber); //

//= Control Flow =//
// switch statement to determine answer //
switch (randomNumber)
{
    case 1:
        answer = "Yes - Definitely";
        break;
    case 2:
        answer = "It is decidedly so";
        break;
    case 3:
        answer = "Without a doubt";
        break;
    case 4:
        answer = "Reply hazy, try again";
        break;
    case 5:
        answer = "Ask again later";
        break;
    case 6:
        answer = "Better not tell you now";
        break;
    case 7:
        answer = "My sources say no";
        break;
    case 8:
        answer = "Outlook not so good";
        break;
    case 9:
        answer = "Very doubtful";
        break;
    default:
        answer = "Error";
        break;
}

//= Output =//

// if/else in the case that user leaves name empty //
if (name == "")
{
    Console.WriteLine("Question: "+question);
}
else
{
    Console.WriteLine(name + " asked: " + question);
}
// if/else in the case that the user doesnt ask a question //
if (question == "")
{
    Console.WriteLine("User did not ask a question.");
}
else
{
    Console.WriteLine("8 Ball Answer: " +answer);
}