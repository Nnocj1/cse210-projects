using System;

public class Fraction
{
   //variables
   private int _top;
   private int _bottom;

   //methods.
   public Fraction(){
      //make the fraction 1/1
       _top = 1;
       _bottom = 1;
   }

   public Fraction(int wholeNumber){
      //in this case, the numerator get a custom value
       _top = wholeNumber;
       _bottom = 1;
   }
   
   public Fraction(int top, int bottom){
      //in this senario we have both the numerator and denominator present. So it will be fully custom.
      _top = top ;
      _bottom = bottom;
   }

   public string GetStringFraction(){
      string fraction = $"{_top}/{_bottom}";
      return fraction;
   }

   public double GetDecimalFraction(){
      return (double)_top / (double)_bottom;
    
   }
}