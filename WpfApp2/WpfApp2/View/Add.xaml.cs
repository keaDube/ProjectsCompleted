using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2.View
{
    public partial class Add : UserControl
    {

        public static List<int> RecipName = new List<int>();
        public static List<int> StepsNum = new List<int>();
        public static List<string> IngrName = new List<string>();
        public static List<int> IngrQuantity = new List<int>();
        public static List<string> IngrSteps = new List<string>();
        public static List<string> IngrUnits = new List<string>();
        public static List<string> Name = new List<string>();
        public static List<int> IngrCal = new List<int>();
        public static List<string> IngrGroup = new List<string>();

        public Add()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string recname = RecipeNameTextBox.Text;
            int num = Convert.ToInt32(NumIngredientsTextBox.Text);

            // Clear the existing lists
            IngrName.Clear();
            IngrQuantity.Clear();

            // Iterate through the TextBoxes and retrieve the values
            for (int i = 1; i <= num; i++)
            {
                TextBox ingredientTextBox = (TextBox)IngredientStackPanel.FindName($"IngredientTextBox{i}");
                TextBox quantityTextBox = (TextBox)IngredientStackPanel.FindName($"QuantityTextBox{i}");

                string ingredient = ingredientTextBox.Text;
                int quantity = int.Parse(quantityTextBox.Text);

                IngrName.Add(ingredient);
                IngrQuantity.Add(quantity);
            }

            // Add the values to the respective lists
            Name.Add(recname);
            RecipName.Add(num);

            // Clear the existing text boxes
            IngredientStackPanel.Children.Clear();

            // Create and add the required number of text boxes
            for (int i = 0; i < num; i++)
            {
                TextBlock ingredientLabel = new TextBlock
                {
                    Text = $"Ingredient {i + 1}:",
                    Margin = new Thickness(0, 10, 0, 0)
                };

                TextBox ingredientTextBox = new TextBox
                {
                    Name = $"IngredientTextBox{i + 1}",
                    Width = 255,
                    BorderThickness = new Thickness(0, 0, 0, 1),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Margin = new Thickness(0, 5, 0, 0)
                };

                TextBlock quantityLabel = new TextBlock
                {
                    Text = $"Quantity {i + 1}:",
                    Margin = new Thickness(0, 10, 0, 0)
                };

                TextBox quantityTextBox = new TextBox
                {
                    Name = $"QuantityTextBox{i + 1}",
                    Width = 255,
                    BorderThickness = new Thickness(0, 0, 0, 1),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Margin = new Thickness(0, 5, 0, 0)

                };

                IngredientStackPanel.Children.Add(ingredientLabel);
                IngredientStackPanel.Children.Add(ingredientTextBox);
                IngredientStackPanel.Children.Add(quantityLabel);
                IngredientStackPanel.Children.Add(quantityTextBox);
            }
        }


        private void RecipeNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Handle recipe name text changed event
        }

        private void NumIngredientsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Handle number of ingredients text changed event
        }


    }

}  


