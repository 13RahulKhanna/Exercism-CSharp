public static class LineUp
{
    public static string Format(string name, int number)
    {
        string x = name + ", you are the " + number.ToString() ;
        if(number % 10 == 1 && number%100 != 11) x +=  "st";
        else if(number % 10 == 2 && number%100 != 12) x += "nd";
        else if(number % 10 == 3 && number%100 != 13) x += "rd";
        else{
            x += "th";
        }
        x += " customer we serve today. Thank you!";
        return x;
        throw new NotImplementedException("You need to implement this method.");
    }
}
