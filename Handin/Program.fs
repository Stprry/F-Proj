open System
open System.Threading
//type BankAcc = {AccNum:int; mutable  Balance:float} with

//    member this.Withdraw(amount,?withdrawal) =
//     let withdrawAmount = this.Balance * float amount
//     match withdrawal with
//      | None -> withdrawAmount
//      | Some deduct -> withdrawAmount - deduct
//let Account ={AccNum=123;Balance = 15.00}

//Account.Withdraw(25.00) // withdrawing 25 from a account with a balance of 15
//let test Balance withdrawAmount =
//  if Balance = withdrawAmount then 
//    Console.WriteLine("Equals")
//  elif Balance < withdrawAmount then 
//    Console.Write("Balance too low")
//  else withdrawAmount 
  
//  Account={AccNum =0001; Balance=0.00};
//  Account={AccNum =0002; Balance=51.00};
//  Account={AccNum =0003; Balance=5.00};
//  Account={AccNum =0004; Balance=75.00};
//  Account={AccNum =0005; Balance=50.00};
//  Account={AccNum =0006; Balance=105.00}  
    
//let CheckAccount Balance = 
//   if Balance < 10.00 then
//    Console.WriteLine("Balance is low") 
//   elif Balance >= 10.00 && Balance <= 100.00 then 
//    Console.WriteLine("Balance is ok") 
//   else 
//    Console.WriteLine("balance is high")


//let Sort Account Newlist =
//    Account
//    |> Seq.unfold(fun Balance -> if (Balance<50) then None else Newlist)

/////////////////////////////////////////////////////////////TASK 4////////////////////////////////////////////////////////////////////////////////

type Ticket = {seat:int;customer:string}
let mutable tickets = [for n in 1..10 ->{Ticket.seat = n; Ticket.customer =""}]

let func()=
    for n in 1..10 do 
        printfn "%A" tickets
let printy()=
    //assign to customer
    Console.WriteLine("ello Enter yer name ye")
let name = Console.ReadLine()
Console.WriteLine("Enter Seat num")
let Choice = Console.ReadLine()
List.map(fun customer seat -> name,Choice) tickets

let Functhread = new Thread (func)
Functhread.Start

let PrintThread = new Thread(printy)
PrintThread.Start