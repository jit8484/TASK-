using System;

class AmstrongNumber{
static void Main(){

Console.Write("Enter a number to count:");
int num =int.Parse(Console.ReadLine());
int sum=0, temp=num;

while(temp!=0)
{
  int digit=temp%10;
  sum+=digit*digit*digit;

   temp/=10; 
}

if(sum==num)
{

Console.WriteLine(num+"is an armstrong number.");


}

else{
  
 Console.WriteLine(num+"is not an Armstrong Number.");

} 

} }