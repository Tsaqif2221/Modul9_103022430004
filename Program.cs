
using Modul9_103022430004;
using System.Runtime.ConstrainedExecution;

public class program
{
    public static void main(String[] args)
    {
        BankTransferConfig bank = new BankTransferConfig();
        
        if (bank.config.lang == "en")
        {
            Console.Write("Please insert the amount of money to transfer: ");   
        }
        else
        {
            Console.Write("Masukkan jumlah uang yang akan di transfer: ");
        }
        double uangtf = Convert.ToUInt32(Console.ReadLine());
        double tf = 0;
        if(uangtf <= bank.config.transfer.threshold)
        {
            tf = bank.config.transfer.low_fee;
        }else if(uangtf >= bank.config.transfer.threshold)
        {
            tf = bank.config.transfer.high_fee;
        }

    }
}