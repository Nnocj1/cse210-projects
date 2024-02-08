using System;
using System.IO;
using System.Collections.Generic;

class Reference
{
   private string _book;
   private int _chapter;
   private int _verse;
   private int _endVerse;

   
   public Reference(string book, int chapter, int verse)//Defining reference without an endVerse.
   { // Since there are different ways of referencing define the class variables in this situation.
        _book = book;
        _chapter = chapter;
        _verse = verse;
   }

   public Reference(string book, int chapter, int startVerse, int endVerse)// Defining reference with and endVerse.
   {//Since there are different ways of referencing define the class variables in this situation.
       _book = book;
       _chapter = chapter;
       _verse = startVerse;
       _endVerse = endVerse;

   }

   public string DisplayReference()// This constructs the full reference and displays it.
   {
      if (_endVerse == 0)
      {
        return $"{_book} {_chapter}: {_verse}. |";
      }

      else
      {
        return $"{_book} {_chapter}: {_verse} - {_endVerse}. |";
      }
   }
}