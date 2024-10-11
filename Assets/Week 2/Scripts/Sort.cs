using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1
        //Bubble Sort
    // Sort Algorithm 2
        //Insertion Sort
    // Sort Algorithm 3
        //Quick Sort
    // Sort Algorithm 4
        //Merge Sort
    // Sort Algorithm 5
        //Counting Sort
    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        //Insert Algorithm here : Bubble Sort
        for (int i = 0; i < randomNumbers.Length - 1; i++) // for1 check list.
        {
            for (int j = 0; j < randomNumbers.Length - i - 1; j++) // for2 swap
            {
                if (randomNumbers[j] > randomNumbers[j + 1])
                {
                    int temp = randomNumbers[j];
                    randomNumbers[j] = randomNumbers[j + 1];
                    randomNumbers[j + 1] = temp;  // done swap j <-> j+1
                }
            }
        }
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
