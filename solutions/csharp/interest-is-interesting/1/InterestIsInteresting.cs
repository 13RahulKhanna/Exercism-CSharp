static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0m) return 3.213f;
        if(balance < 1000m) return 0.5f;
        if(balance < 5000m) return 1.621f;
        return 2.475f;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.InterestRate() method");
    }

    public static decimal Interest(decimal balance)
    {
        return balance / 100m * (decimal)InterestRate(balance);
        throw new NotImplementedException("Please implement the (static) SavingsAccount.Interest() method");
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
        
        throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int cnt = 0;
        while(balance < targetBalance){
            balance = AnnualBalanceUpdate(balance);
            cnt++;
        }
        return cnt;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}
