namespace BankApp.Classes;

public class BankAccount
{
    private string? fullName; //only can be accessed in the class
    public string? FullName
     {
         get { return fullName; } //Read
         //same as get => fullName;

        set //Write
         { 
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Full name can not be empty", nameof(value)); 
                //if throw conducted it will jump out and won't operate the program bellow.
            }
            
            fullName = value;
         }
    } 

    //=====================================================================================================

    private decimal balance;
    public decimal Balance
    {
        get => balance; // same as get {return balance;}
        set
        {
            if (value < 0)
            {
                 throw new ArgumentOutOfRangeException("Balance can not be negative", nameof(value));
            }
            balance = value;
        }
    }

    //====================================================================================================

    public string AccountNumber { get; set; } //auto property

    //====================================================================================================

    public bool HasPositiveBalance => balance > 0; //read-only property
    // same as get {return balance > 0;}

    //================ Constructor Overloading + Chaining ================================================

// Constructor Overloading --> with 2 parameters
    public BankAccount(string? fn, decimal b)
    {
        //set --> Write only
        FullName = fn;
        Balance = b;
        AccountNumber = "Unknown";
    }

// Consructor Chaining --> ":this" will access the constructor with 2 parameters
    public BankAccount(): this ("Unknown", 0)  //1 parameter without any types
    {
        //set --> Write only

        //What it will operate automatically:
        //FullName = " Unknown";
        //Balance = 0;

        //And continue to process the next line of program
        AccountNumber = "0000";
    }

    //==================================================================================

        public void Deposit(decimal amount)
    {
        //balance = balance + amount;
        if (amount >= 0)
            balance += amount;
        else
            throw new ArgumentOutOfRangeException("Amount can not be negative", nameof(amount));
        
    }

    //===============================================================================================
    public void Withdraw(decimal amount)
    {
        if (amount >=0)
        {
            if (amount <= balance)
                balance -= amount;
            else
                throw new ArgumentOutOfRangeException("Amount can not be less than current balance", nameof(amount));
        }
        else
        {
            throw new ArgumentOutOfRangeException("Amount should be positive value.", nameof(amount));
        }
    }

}

