Dictionary<int, string> English = new Dictionary<int, string> {
  {1, "One"},
  {2, "Two"},
  {3, "Three"},
  {4, "Four"},
  {5, "Five"},
  {6, "Six"},
  {7, "Seven"},
  {8, "Eight"},
  {9, "Nine"},
  {10, "Ten"}
};
Dictionary<int, string> Spanish = new Dictionary<int, string> {
  {1, "Uno"},
  {2, "Dos"},
  {3, "Tres"},
  {4, "Cuatro"},
  {5, "Cinco"},
  {6, "Seis"},
  {7, "Siete"},
  {8, "Ocho"},
  {9, "Nueve"},
  {10, "Diez"}
};
string choice;
while (true) {
  Console.WriteLine("Count 1 - 10 (ENGLISH/SPANISH)");
  Console.WriteLine("Choose between English and Spanish, type E for English and S for Spanish Leave it blank to exit: ");
  choice = Console.ReadLine().ToUpper();
  if (string.IsNullOrEmpty(choice)) break;
  while (true) {
  if (!string.IsNullOrEmpty(choice) && choice != "E" || choice != "S") {
    Console.WriteLine("Please Enter a valid character: E or S only!");
    break;
  }

  }
  
  switch(choice) {
    case "E":
      CountLanguage(English);
      break;
    case "S":
      CountLanguage(Spanish);
      break;
    default:
      break;
  }

}

void CountLanguage(Dictionary<int, string> lang) {
  for (int i = 1; i <= lang.Count; i++) {
    Console.WriteLine(lang[i]);
  }
}

// void CountSpanish() {
//   for (int i = 1; i <= Spanish.Count; i++) {
//     Console.Write
//   }
// }