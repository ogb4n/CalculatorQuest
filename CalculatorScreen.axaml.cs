using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Avalonia.Interactivity;

namespace CalculatorQuest;

public partial class CalculatorScreen : Window
{
    public string CurrentInput = "";
    public string FirstInput = "";
    public string Operand = "";
    
    public CalculatorScreen()
    {
        this.Width = 300;
        this.Height = 600;
        InitializeComponent();
    }
    

    private void Number_OnClick(object? sender, RoutedEventArgs e)
    {
     Button btn = (Button)sender;
     CurrentInput += btn.Content.ToString();
     NumbersBox.Content = CurrentInput;
    }
    
    private void Operator_OnClick(object? sender, RoutedEventArgs e)
    {
        Button btn = (Button)sender;
        FirstInput = CurrentInput;
        SavedNumber.Content = FirstInput;
        CurrentInput = "";
        NumbersBox.Content = CurrentInput;
        
        if (btn == ButtonPlus)
        {
            OperatorBox.Content = "+";
        }
        else if (btn == ButtonMinus)
        {
            OperatorBox.Content = "-";
        }
        else if (btn == ButtonMultiply)
        {
            OperatorBox.Content = "x";
        }
        else if (btn == ButtonDivide)
        {
            OperatorBox.Content = "/";
        }
        else if (btn == ButtonModulo)
        {
            OperatorBox.Content = "%";
        }
        else if (btn == ButtonPlusMinus)
        {
            OperatorBox.Content = "+/-";
        }
        
    }
    
    private void Control_OnClick(object? sender, RoutedEventArgs e)
    {
        
        Button btn = (Button)sender;
        CurrentInput += btn.Content.ToString();
        if (btn  == ButtonC)
        {
            CurrentInput = "";
            NumbersBox.Content = CurrentInput;
        }
        else if (btn == ButtonBack)
        {
            var size = CurrentInput.Length;
            CurrentInput = CurrentInput.Remove(size - 2);
            NumbersBox.Content = CurrentInput;

        }
       
    }
}
