using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Avalonia.Interactivity;

namespace CalculatorQuest;

public class Calc : CalculatorScreen
{
    private string[] _signs = new string[] { "+", "-", "x", "/", "%" };

    public Calc()
    {
        
            
    }
        
    public string Operator(string input)
    {
        return $"{FirstInput} {Operand} {CurrentInput}";
    }
}