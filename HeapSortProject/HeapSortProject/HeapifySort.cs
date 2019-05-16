using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSortProject
{
    public static class Heap
    {
       
        //Public Class Methods
        public int Remove(ref int[] heapArray)
        {
            //take the top value on the array, and store in temp
            //set the last value in the arrray to parent
            //call trickle down
            int temp = heapArray[0];
            heapArray[0] = heapArray[currentIndex - 1];
            heapArray[currentIndex - 1] = EMPTY;
            TrickleDown(int[] heapArray);
            currentIndex--;
            return temp;
        }
        
        //this will compare the root to its children
        public static void TrickleDown(ref int[] heapArray)
        {
            //while the current index value is not greater than or equal to array size AND the current value is not EMPTY
            //compare the parent to its left and right child
            //switch the parent with the largest of the children
            //set the current index to the selected child
            bool noLongerTrue = true;
            for (int i = 0; i < heapArray.Length; i++)
            {
                int index = i; //sets index to be used
                while (noLongerTrue)
                {
                    int temp;
                    int parent;
                    int leftChild;
                    int rightChild;
                    if(!(Right(index) >= heapArray.Length && Left(index) >= heapArray.Length)) //checks to see if current element is leaf
                    {
                        parent = heapArray[index];
                        leftChild = heapArray[Left(index)];
                        rightChild = heapArray[Right(index)];
                        if (rightChild > parent && leftChild < rightChild)
                        {
                            temp = parent;
                            parent = rightChild;
                            rightChild = temp;
                            index = Right(index);
                        }
                        else if (leftChild > parent && leftChild > rightChild)
                        {
                            temp = parent;
                            parent = leftChild;
                            leftChild = temp;
                            index = Left(index);
                        }
                    }
                    else
                    {
                        noLongerTrue = false;
                    }
                }
                //noLongerTrue = true; //resets the counter for while loop
            }
        }



        /*
        //this will rearrange the tree if a large value is a leaf, returns no values
        private static void BubbleUp(ref int[] heapArray, int index)
        {
            //if value that was just added is larger than the parent
            //swap the parent with the child
            //repeat process until child is less than parent or parent is null (AKA root)
            bool isFinished = false;
            while (isFinished == false)
            {
                //this block deals with swapping
                if (heapArray[index] > heapArray[Parent(index)] && index != 0)
                {
                    int temp = heapArray[Parent(index)];
                    heapArray[Parent(index)] = heapArray[index];
                    heapArray[index] = temp;
                    index = Parent(index);
                }
                else
                {
                    isFinished = true;
                }
            }
        }*/

        //adds a value to the heap, takes and index and returns no values
        private static void AddValue(ref int[] heapArray, int index, int value)
        {
            heapArray[index] = value;
        }

        private static int Left(int index)
        {
            //this will return the value of a left index
            return 2 * index + 1;
        }

        private static int Right(int index)
        {
            //this will return the value of a right index
            return 2 * index + 2;
        }

        private static int Parent(int index)
        {
            return index = (index - 1) / 2;
        }
    } 
}
