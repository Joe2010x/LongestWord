using System;

class MainClass {

  public static string LongestWord(string sen) {
    return GetLongestWord(RemoveSigns(sen));
  }

  public static string GetLongestWord(string sen) {
    var Length = 0;
    var TheLongestWord ="";
    var senArray = sen.Split(" ");
    foreach (var Word in senArray) {
      if (Word.Length > Length) {
        Length = Word.Length;
        TheLongestWord = Word;
      }
    }
    return TheLongestWord;
  }

  public static string RemoveSigns (string sen) {
    var result = "";
    for (var i = 0; i<sen.Length; i++) {
      if (char.IsDigit(sen[i]) || char.IsLetter(sen[i]) || sen[i] == ' ') {
        result += sen[i];
      }
    }
    return result;
  }

  static void Main() {  
    Console.WriteLine(LongestWord("I love dogs! Test"));
    Console.ReadLine();
  } 
}
