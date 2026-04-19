public class Player
{
   
    public int RollDie()
    {     var rand = new Random();       
        return rand.Next(1,19);
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
         var rand = new Random();
        return rand.NextDouble() * 100;
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
