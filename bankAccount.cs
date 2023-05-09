public class bankAccount {

    public double balance = 0;

    //constructor

    public bankAccount(double newBalance){
        if (newBalance < 0) {
            throw new Exception("No negative Values");
        }
    }

    //method to get the balance

    public double getBalance() {
        return balance;
    }

    public double withdraw(double amount){
        balance = balance - amount;
        //balance -= amount;
        return balance;
    }

    public double deposit(double amount){
        balance = balance + amount;
        //balance -= amount;
        return balance;
    }
}

//created a new checkingAccount that inherits from the background "parent" class
public class checkingAccount : bankAccount {
    
    public checkingAccount(double initialBalance) : base(initialBalance) {

    }
   
 }

public class savingsAccount : bankAccount {
    
    public savingsAccount(double initialBalance) : base(initialBalance) {
        this.deposit(100); // All new savings account
    }
   
 }



