using System;
using System.IO;
using System.Collections.Generic;


class Scripture
{
    private string _reference;
    List<Word>_words = new List<Word>();

    public Scripture(string reference, string text )//This is the scripture function, external codes will interact with.
    {
       _reference = reference;
       string[] words = text.Split(' ');// search for spaces before and after characters in the scripture text and break them into words.
       
       foreach (string word in words)
       {
          _words.Add(new Word(word));//Creates a new instance of Word list and add the words there. 
       }
    }

    public void HideRandomWords()
    {  //Random is an in-built class.
       Random random = new Random();
       int numberOfWordsToHide = random.Next(1, _words.Count + 1);

       for (int i = 0; i < numberOfWordsToHide; i++) //loop through all the words in the scripture text
       {
          int randomIndex = random.Next(0, _words.Count); // select random words from the list of words.
          _words[randomIndex].Hide();
       }
    }
    
    public string DisplayScripture()
    {
        string displayAllText = _reference;

        foreach (Word word in _words)
        {
           displayAllText += word.GetDisplayWord() + " "; // Here it will check each word to decide to reveal or hide based on the random.
           // then display a new version of the scripture with some underscores instead of words.
        }
        return displayAllText;
    }

    public bool IsCompletelyHiddden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())// if any of then is not hidden, it should rerturn false of this bool
            {
                return false;
            }
        }
        return true;//else returns true.
    }

   

}