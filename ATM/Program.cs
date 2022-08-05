using System;
public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;
    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.balance = balance;
        this.lastName = lastName;
    }
    public String getNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }
    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options........");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Balance");
            Console.WriteLine("4. Exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your response. Your new balance is: " + currentUser.getBalance());

        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());
            //check if user has enough money for withdrawal
            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficiet balance");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You are good to go! Thank You!");
            }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());

        }
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("4567777775544478", 1234, "Gourav", "Chaudhary", 145.88));
        cardHolders.Add(new cardHolder("4567134365767688", 6758, "Tanmay", "Desai", 156.98));
        cardHolders.Add(new cardHolder("4567777773413468", 3451, "Ojesh", "Madhaavan", 456.2));
        cardHolders.Add(new cardHolder("4567777773434232", 4325, "Asha", "Rani", 671.7));
        cardHolders.Add(new cardHolder("4567772314314344", 1458, "Deepak", "Nandeshwar", 45.88));
        cardHolders.Add(new cardHolder("4567777775459822", 1267, "Raghav", "Lawerance", 192.81));

        
        //Prompt user
        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Please insert your Debit Card!");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check the db of the user
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null){ break;  }
                else{
                    Console.WriteLine("Card not recognised! Please try again!!");}
            }
            catch
            {
                Console.WriteLine("Card not recognised! Please try again!!");
            }
        }
        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;
        while (true)
        {
            try
            { 
              userPin = int.Parse(Console.ReadLine());
              if (currentUser.getPin() == userPin) { break; }
              else { Console.WriteLine("Incorrect Pin!! Please try again!!"); }
        }
            catch{
            Console.WriteLine("Incorrect Pin!! Please try again!!");}
    }
    Console.WriteLine("Welcome"+ currentUser.getFirstName() +":)");
        int option = 0;
       do
    {
             printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
    if (option == 1)
    {
        deposit(currentUser);
    }
    else if (option == 2)
    {
        withdraw(currentUser);
    }
    else if (option == 3)
    {
        balance(currentUser);
    }
    else if (option == 4)
    {
        break;
    }
    else
    {
        option = 0;
    }
}
while (option != 4);
Console.WriteLine("Thank You, have a nice day.....");

    }

        }

