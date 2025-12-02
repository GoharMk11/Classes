//Տրված է n x m չափի ամբողջ թվերի մատրիցա և սկսնակ կոորդինատներ (startX, startY)։
//Պահանջվում է փոխել սկսնակ կետում գտնվող արժեքը նոր արժեքով newValue և բոլոր այն հարևան կետերում,
//որոնք ունեն նույն հին արժեքը (վեր, վար, ձախ, աջ): (Սա չի նշանակում միայն տրված կոորդինատի հարևանի,
//այլ նաև հարևանի հարևանների և այդպես շարունակ, քանի դեռ տրված կետում հին արժեք ունեն նաև հարևանները)
//Անհրաժեշտ է այն լուծել երկու տարբերակով 1. Առանց ռեկուսիա 1. Ռեկուսիա

using System;
namespace MatrixApp
{
    class Ex2
    {
        static void Main()
        {
            int[,] matrix = MatrixBuilder.CreateMatrix();
            Console.WriteLine();
            MatrixPrinter.Print(matrix, "Before:");
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int startX = ReadInt.ReadInRange("Enter startX: ", 0, rows - 1);
            int startY = ReadInt.ReadInRange("Enter startY: ", 0, cols - 1);
            int newValue = ReadInt.ReadPositiveInt("Enter new value: ");
            FloodFill.FillQueue(matrix, startX, startY, newValue);
            Console.WriteLine();
            MatrixPrinter.Print(matrix, "After:");
        }
    }
}