using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Avalonia.Interactivity;

namespace CalculatorQuest;

public partial class CalculatorScreen : Window
{
    private string CurrentInput = "";
    private string FirstInput = "";
    private string Operand = "";
    private string ComposedOperation = "";

    
    public CalculatorScreen()
    {
        this.Width = 300;
        this.Height = 600;
        InitializeComponent();
    }
    

    // Handler pour les boutons de chiffres
    private void Number_OnClick(object? sender, RoutedEventArgs e)
    {
     Button btn = (Button)sender;
     CurrentInput += btn.Content.ToString();
     NumbersBox.Content = CurrentInput;

    }
    
    // Handler pour les boutons d'operateurs
    
    private void Operator_OnClick(object? sender, RoutedEventArgs e)
    {
        Button btn = (Button)sender;
        FirstInput = CurrentInput;
        SavedNumber.Content = FirstInput;
        CurrentInput = "";
        NumbersBox.Content = "";

        if (btn == ButtonPlus)
        {
            OperatorBox.Content = "+";
            Operand = "+";

        }
        else if (btn == ButtonMinus)
        {
            OperatorBox.Content = "-";
            Operand = "-";
        }
        else if (btn == ButtonMultiply)
        {
            OperatorBox.Content = "x";
            Operand = "x";
        }
        else if (btn == ButtonDivide)
        {
            OperatorBox.Content = "/";
            Operand = "/";
        }
        else if (btn == ButtonModulo)
        {
            OperatorBox.Content = "%";
            Operand = "%";
        }
        else if (btn == ButtonPlusMinus)
        {
            OperatorBox.Content = "+/-";
            Operand = "+/-";
        }
        
    }
    
    // Handler pour les boutons de controle
    private void Control_OnClick(object? sender, RoutedEventArgs e)
    {
        
        Button btn = (Button)sender;
        CurrentInput += btn.Content.ToString();
        if (btn  == ButtonC)
        {
            CurrentInput = "";
            Operand = "";
            FirstInput = "";
            ComposedOperation = "";
            NumbersBox.Content = CurrentInput;
            SavedNumber.Content = "";
        }
        else if (btn == ButtonBack)
        {
            var size = CurrentInput.Length;
            CurrentInput = CurrentInput.Remove(size - 2);
            NumbersBox.Content = CurrentInput;

        }
        else if (btn == ButtonEqual)
        {
            ComposedOperation = FirstInput + Operand + CurrentInput;
            var size = ComposedOperation.Length;
            ComposedOperation = ComposedOperation.Remove(size - 1);
            ComposedOperation = new Calc().Operator(ComposedOperation);
            NumbersBox.Content = ComposedOperation;
            //Console.Write(ComposedOperation);
            SavedNumber.Content = "";
            OperatorBox.Content = "";
            CurrentInput = ComposedOperation;
            Operand = "";
            FirstInput = "";
            ComposedOperation = "";
        }
        else if (btn == Button_CE)
        {
            NumbersBox.Content = "";
            CurrentInput = "";
        }
    }
}
