using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class Arrays
    {
        int[] numbers = new int[5];
        int[,] twoDimensionalArray = new int[2, 3];
        public void ArrayExample()
        {
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void ArrayExample2Dimension()
        {
            twoDimensionalArray[0, 0] = 1;
            twoDimensionalArray[0, 1] = 2;
            twoDimensionalArray[0, 2] = 3;
            twoDimensionalArray[1, 0] = 4;
            twoDimensionalArray[1, 1] = 5;
            twoDimensionalArray[1, 2] = 6;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(twoDimensionalArray[i, j]);
                }
            }
        }

        // Create Instance metodu ile dizileri dinamik olarak oluşturabiliriz.
        private Array dynamicArray = (int[])Array.CreateInstance(typeof(int), 5);
        public void DynamicArrayExample()
        {
            dynamicArray.SetValue(1, 0);
            dynamicArray.SetValue(2, 1);
            dynamicArray.SetValue(3, 2);
            dynamicArray.SetValue(4, 3);
            dynamicArray.SetValue(5, 4);

            for (int i = 0; i < dynamicArray.Length; i++)
            {
                Console.WriteLine(dynamicArray.GetValue(i));
            }
        }

        // burada cast ettiğimiz için tip güvenliği sağlamış oluyoruz. ve de orada 2 boyutlu olduğunu belli etmemiz lazım
        private Array TwoDimensionaldynamicArray = (int[,])Array.CreateInstance(typeof(int), 2, 2);

        public void TwoDimensionaldynamicArrayExample() {



            TwoDimensionaldynamicArray.SetValue(1, 0, 0);
            TwoDimensionaldynamicArray.SetValue(2, 0, 1);
            TwoDimensionaldynamicArray.SetValue(3, 1, 0);
            TwoDimensionaldynamicArray.SetValue(4, 1, 1);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(TwoDimensionaldynamicArray.GetValue(i, j));
                }
            }
        }

        private (int a, string b)[] newTypeArray = new (int a, string b)[]
            {
                (1, "Bir"),
                (2, "İki"),
                (3, "Üç"),
                (4, "Dört"),
                (5, "Beş")
            };

        public void NewTypeArrayExample()
            {
            for (int i = 0; i < newTypeArray.Length; i++)
            {
                Console.WriteLine(newTypeArray[i].a + " " + newTypeArray[i].b);
            }
        }
            
            










    }
}
