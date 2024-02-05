using System;
using System.IO;
using System.Collections.Generic;

class Word
{  //for the each word, its either hidden or not hidden.
   private string _text;
   private bool _isHidden;


   public Word(string text)
   {
      _text = text;
      _isHidden = false;//generally the text is not hidden
   }

   public void Hide()
   {
     _isHidden = true; //once the hide function is applied, it should be hidden
   }

   public void Show()
   {
     _isHidden = false; //once the show function is applied, it should reveal the text
   }

   public bool IsHidden()
   {
     return _isHidden; //once the program is asked if it's hidden or not, it should answer.
   }

   public string GetDisplayWord()
   {// if it's hidden, it should display _ _ _, else, it should display the text.
       return _isHidden ? "_ _ _ _ _" : _text;
   }
}