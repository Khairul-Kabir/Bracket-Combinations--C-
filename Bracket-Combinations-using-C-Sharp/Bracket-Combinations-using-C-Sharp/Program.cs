using System;

class MainClass {

  public static int BracketCombinations(int num) {

    // code goes here  
    if(num==0)
    {
      return 1;
    }

    int count = 0;

    for(int i=0;i<num;i++){
      count+= BracketCombinations(i)*BracketCombinations(num-i-1);

    }
    return count;

  }

  static void Main() {  

    // keep this function call here
    Console.WriteLine(BracketCombinations(Convert.ToInt32(Console.ReadLine())));
    
  } 

}