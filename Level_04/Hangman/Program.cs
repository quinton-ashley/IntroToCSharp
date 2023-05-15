string[] hangman = new string[]
{
    @"
  +---+
      |
      |
      |
      |
      |
=========",
    @"
  +---+
  |   |
      |
      |
      |
      |
=========",
    @"
  +---+
  |   |
  O   |
      |
      |
      |
=========",
    @"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========",
    @"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",
    @"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",
    @"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",
    @"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
};

string wordsList =
    "cool know over these about down large please they after drink learn put think again each little red this ago everything live right those all face location run three also far make same to always fast man sea together am father many seven try an find may shop turn and first meaning sit under any five men six until are fly mother sleep us as foot much small use from must smile want ask give never some we at go no sorry well away green not star what because has now stay when bed here ocean stop where black his of store which blue how old strong why bring in on tell will call into one thank with clean is only that yellow cold it or the yes color just our you come kind out there";

/* Part A: split the wordsList into a words array */

/* Part B: Make lines List for showing the user's guesses */

Console.WriteLine(hangman[0]);

Console.Write("Enter your guess: ");
char guess = Console.ReadLine()[0];
Console.WriteLine();
