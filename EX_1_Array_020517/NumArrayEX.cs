using System;

namespace EX_1_Array_020517
{
    class NumArray
    {
        private int[] NA;
        private int N, MAX;

        public NumArray(int iSize)
        {
            NA = new int[iSize];
            MAX = iSize;
            N = 0;
        }
        public int getItem(int iPos)
        {
            return NA[iPos];
        }

        public void setItem(int iPos, int iNum)
        {
            if (N == MAX)
            {
                Console.WriteLine("Array is full");
                return;
            }
            NA[iPos] = iNum;
            N = N + 1;
        }

        #region Insert item at Pos
        public void setItemAtPos(int iPos, int iNum)
        {
            if (N == MAX)
            {
                Console.WriteLine("Array is full.");
                Console.ReadKey();
                return;
            }

            int j = N;

            //insert new value
            N = N + 1;
            while (j >= iPos)
            {
                NA[j + 1] = NA[j];
                j = j - 1;
            }
            NA[iPos] = iNum;

            Console.WriteLine("Array after insertion: Insert " + iNum + " at positin " + iPos);
            displayItems();
        }
        #endregion

        #region Insert item before Pos
        #endregion

        #region Insert item after Pos
        #endregion

        #region Delete item
        public void deleteItem(int iPos)
        {
            if (iPos > N)
            {
                Console.WriteLine("Position <= Number of elements");
                Console.ReadKey();
                return;
            }

            int j = iPos;

            //delete item
            while (j < N)
            {
                NA[j] = NA[j + 1];
                j = j + 1;
            }

            N = N - 1;
            Console.WriteLine("Array after deletion: Delete item at position " + iPos);
            displayItems();
        }
        #endregion

        #region Search item
        public void searchItem(int iNum)
        {
            int j = 0; bool bFound = false;
            while (j < N && !bFound)
            {
                if (NA[j] == iNum)
                    bFound = true;
                else
                    j++;
            }
            if (bFound)
                Console.WriteLine("item " + iNum + " found at position " + j);
            else
                Console.WriteLine("item " + iNum + " not found in the array");
        }
        #endregion

        #region Update item
        public void updateItem(int iPos, int iNum)
        {
            if (iPos > N) return;
            NA[iPos] = iNum;

            Console.WriteLine("Array after updating at position " + iPos + " with value " + iNum);
            displayItems();
        }
        #endregion

        #region display items
        public void displayItems()
        {
            Console.WriteLine("N: " + N);
            for (int i = 0; i < N; i++)
                Console.Write(NA[i] + " ");
            Console.WriteLine();
        }
        #endregion
    }
    class NumArrayEX
    {
        static void Main(string[] args)
        {
            NumArray aryNum = new NumArray(10);

            //init & insert 5 items
            aryNum.setItem(0, 1);
            aryNum.setItem(1, 2);
            aryNum.setItem(2, 3);
            aryNum.setItem(3, 4);
            aryNum.setItem(4, 5);

            //display items
            Console.WriteLine("Elements in Array");
            aryNum.displayItems();

            //insert item at position 3 with value 7
            aryNum.setItemAtPos(3, 7);

            //delete item at position 3
            aryNum.deleteItem(3);

            //search item "5" in array
            aryNum.searchItem(7);

            //update item
            aryNum.updateItem(2, 20);

            Console.ReadKey();

            #region two-dimensional array testing
            /*
            Console.WriteLine("Two dimensional array testing");
            //two dimensional array test
            int[,] grades = new int[,] { { 1, 82, 74, 89, 100 }, { 2, 93, 96, 85, 86 }, { 3, 83, 72, 95, 89 }, { 4, 91, 98, 79, 88 } };
            int gradeCount = grades.GetUpperBound(1);
            double average = 0.0;
            int total;
            int studentCount = grades.GetUpperBound(0);
            for (int row = 0; row <= studentCount; row++)
            {
                total = 0;
                for (int col = 0; col <= gradeCount; col++)
                    total += grades[row, col];
                average = total / gradeCount;
                Console.WriteLine("Average: " + average);
            }
            Console.ReadKey();
            */
            #endregion
        }
    }
}
