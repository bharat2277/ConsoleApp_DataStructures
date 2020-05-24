using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Arrays
    {

        //Given a binary array, find the maximum number of consecutive 1s in this array.

        //Example 1:
        //Input: [1,1,0,1,1,1]
        //        Output: 3
        //Explanation: The first two digits or the last three digits are consecutive 1s.
        //    The maximum number of consecutive 1s is 3.
        //Note:

        //The input array will only contain 0 and 1.
        //The length
        public static int FindMaxConsecutiveOnes(int[] nums)
        {

            //int[] nums = { 1,1,1,1,0,0,1 };

            int finalmax = 0;
            int maxnum = 0;
            int j = nums.Length;
            int i = 0;
            for (i = 0; i < j; i++)
            {
                int x = nums[i];
                if (x == 1)
                {

                    maxnum = maxnum + 1;
                    if (maxnum > finalmax)
                    {
                        finalmax = maxnum;
                    }
                }
                else
                {
                    maxnum = 0;
                }
            }

            return finalmax;
        }


        //Given an array nums of integers, return how many of them contain an even number of digits.
        //Example 1:

        //Input: nums = [12, 345, 2, 6, 7896]
        //Output: 2
        //Explanation: 
        //12 contains 2 digits (even number of digits). 
        //345 contains 3 digits(odd number of digits). 
        //2 contains 1 digit(odd number of digits). 
        //6 contains 1 digit(odd number of digits). 
        //7896 contains 4 digits(even number of digits). 
        //Therefore only 12 and 7896 contain an even number of digits.
        //Example 2:

        //Input: nums = [555, 901, 482, 1771]
        //Output: 1 
        //Explanation: 
        //Only 1771 contains an even number of digits.
        public static int FindNumbers(int[] nums)
        {
            int i;

            int totalEvenNums = 0;

            int len = nums.Length;

            for (i = 0; i < len; i++)
            {
                int x = nums[i];
                if ((x.ToString().Length) % 2 == 0)
                {
                    totalEvenNums++;
                }
            }

            return totalEvenNums;
        }


        //Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.

        //Example 1:

        //Input: [-4,-1,0,3,10]
        //Output: [0,1,9,16,100]
        //Example 2:

        //Input: [-7,-3,2,3,11]
        //Output: [4,9,9,49,121]


        // need to improve performance 
        public static int[] SortedSquares(int[] A)
        {


            int maxCount = A.Length;
            double[] returnVal = new double[maxCount];
            int i;
            for (i = 0; i < maxCount; i++)
            {
                double a = (double)A[i];
                double b = (double)2;
                returnVal[i] = Math.Pow(a, b);
            }

            Array.Sort(returnVal);

            return returnVal.Select(Convert.ToInt32).ToArray();
        }



        //Given a fixed length array arr of integers, duplicate each occurrence of zero, shifting the remaining elements to the right.

        //Note that elements beyond the length of the original array are not written.

        //Do the above modifications to the input array in place, do not return anything from your function.

        //Example 1:

        //Input: [1,0,2,3,0,4,5,0]
        //        Output: null
        //Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
        //        Example 2:

        //Input: [1,2,3]
        //        Output: null
        //Explanation: After calling your function, the input array is modified to: [1,2,3]


        public static void DuplicateZeros(int[] arr)
        {
            int OrgLen = arr.Length;

            for (int i = 0; i < OrgLen; i++)
            {
                var x = arr[i];
                if (x == 0)
                {
                    for (int j = OrgLen - 1; j > i + 1; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    if (i != OrgLen - 1)
                    {
                        arr[i + 1] = 0;
                        i++;
                    }
                }
            }
        }


        //Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

        //Note:

        //The number of elements initialized in nums1 and nums2 are m and n respectively.
        //You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2.
        //Example:

        //Input:
        //nums1 = [1, 2, 3, 0, 0, 0], m = 3
        //nums2 = [2, 5, 6], n = 3

        //Output: [1,2,2,3,5,6]

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int j = 0;

            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[j];
                j++;
            }

            Array.Sort(nums1);

        }





//        Given an array nums and a value val, remove all instances of that value in-place and return the new length.

//Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

//The order of elements can be changed. It doesn't matter what you leave beyond the new length.

//Example 1:

//Given nums = [3, 2, 2, 3], val = 3,

//Your function should return length = 2, with the first two elements of nums being 2.

//It doesn't matter what you leave beyond the returned length.
//Example 2:

//Given nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2,

//Your function should return length = 5, with the first five elements of nums containing 0, 1, 3, 0, and 4.

//Note that the order of those five elements can be arbitrary.

//It doesn't matter what values are set beyond the returned length.
//Clarification:

//Confused why the returned value is an integer but your answer is an array?

//Note that the input array is passed in by reference, which means modification to the input array will be known to the caller as well.

//Internally you can think of this:

//// nums is passed in by reference. (i.e., without making a copy)
//int len = removeElement(nums, val);

//// any modification to nums in your function would be known by the caller.
//// using the length returned by your function, it prints the first len elements.
//for (int i = 0; i<len; i++) {
//    print(nums[i]);
//    }


    public static int RemoveElement(int[] nums, int val)
        {

            int returnVal = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {

                    //for(int j= returnVal; j > 0; j-- )
                    //{
                    //    if(nums[j] != val)
                    //    {
                    //        nums[i] = nums[j];

                    //    }

                    //    break;


                    //}
                    //nums[nums.Length] = nums[i];
                    nums[i] = 0;
                    returnVal--;
                }
            }

            Array.Sort(nums);
            Array.Reverse(nums);



            return returnVal;

        }


        //        Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.

        //        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

        //        Example 1:

        //Given nums = [1, 1, 2],

        //        Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.

        //        It doesn't matter what you leave beyond the returned length.
        //Example 2:


        //        Given nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4],

        //        Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively.

        //        It doesn't matter what values are set beyond the returned length.
        //Clarification:


        //        Confused why the returned value is an integer but your answer is an array?


        //        Note that the input array is passed in by reference, which means modification to the input array will be known to the caller as well.

        //        Internally you can think of this:


        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return nums.Length;
            }

            int i = 0;

            int length = nums.Length;

            for (int j = 1; j < nums.Length; j++)
            {

                if (nums[j] != nums[i])
                {
                    nums[++i] = nums[j];
                }
            }

            return i + 1;
        }


        /*
         * Given an array arr of integers, check if there exists two integers N and M such that N is the double of M ( i.e. N = 2 * M).

        More formally check if there exists two indices i and j such that :

        i != j
        0 <= i, j < arr.length
        arr[i] == 2 * arr[j]
 

        Example 1:

        Input: arr = [10,2,5,3]
        Output: true
        Explanation: N = 10 is the double of M = 5,that is, 10 = 2 * 5.
        Example 2:

        Input: arr = [7,1,14,11]
        Output: true
        Explanation: N = 14 is the double of M = 7,that is, 14 = 2 * 7.
        Example 3:

        Input: arr = [3,1,7,11]
        Output: false
        Explanation: In this case does not exist N and M, such that N = 2 * M.
 

        Constraints:

        2 <= arr.length <= 500
        -10^3 <= arr[i] <= 10^3
         */

        public static bool CheckIfExist(int[] arr)
        {

            if (arr == null || arr.Length <= 1)
            {
                return false;
            }

            int zerosInArr = 0;

            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] == 0)
                {
                    zerosInArr++;
                }
            }

            if (zerosInArr > 1)
            {
                return true;
            }


            for (int i = 0; i < arr.Length; i++)
            {
                var x = arr[i];
                if (x != 0)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {

                        if (x == 2 * arr[j])
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /*
         Given an array A of integers, return true if and only if it is a valid mountain array.

        Recall that A is a mountain array if and only if:

        A.length >= 3
        There exists some i with 0 < i < A.length - 1 such that:
        A[0] < A[1] < ... A[i-1] < A[i]
        A[i] > A[i+1] > ... > A[A.length - 1]


 

        Example 1:

        Input: [2,1]
        Output: false
        Example 2:

        Input: [3,5,5]
        Output: false
        Example 3:

        Input: [0,3,2,1]
        Output: true 
         */

        public static bool ValidMountainArray(int[] A)
        {
            bool isDownStart = false;
            bool isUpEverReached = false;

            int trackingVariable;

            if (A.Length < 3)
            {
                return false;
            }
            else
            {
                trackingVariable = A[0];
            }

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == trackingVariable)
                {
                    return false;
                }
                if (isDownStart == false)
                {
                    if (A[i] > trackingVariable)
                    {
                        isUpEverReached = true;
                    }
                    else
                    {
                        isDownStart = true;
                        if (A.Length - 1 == i)
                        {
                            return true;
                        }
                    }
                    trackingVariable = A[i];
                }
                else if (isUpEverReached == true)
                {
                    if (trackingVariable < A[i])
                    {
                        return false;
                    }
                    trackingVariable = A[i];
                }

            }

            if (isDownStart == false || isUpEverReached == false) return false;

            return true;
        }

        /*
         Replace Elements with Greatest Element on Right Side
        Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.

        After doing so, return the array.

 

        Example 1:

        Input: arr = [17,18,5,4,6,1]
        Output: [18,6,6,6,1,-1]
        */

        public static int[] ReplaceElements(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int greatestElement = arr[i + 1];

                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    if (arr[j] > greatestElement)
                    {
                        greatestElement = arr[j];
                    };
                }

                arr[index] = greatestElement;
                index++;
            }

            arr[arr.Length - 1] = -1;

            return arr;

        }

        /*
         Move Zeroes
            Solution
            Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

            Example:

            Input: [0,1,0,3,12]
            Output: [1,3,12,0,0]
            Note:

            You must do this in-place without making a copy of the array.
            Minimize the total number of operations.
         * */

        public static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            nums[i] = nums[j];
                            nums[j] = 0;
                            break;

                        }
                    }
                }
            }
        }

        //        Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

        //You may return any answer array that satisfies this condition.



        //Example 1:

        //Input: [3,1,2,4]
        //Output: [2,4,3,1]
        //The outputs [4,2,3,1], [2,4,1,3], and[4, 2, 1, 3] would also be accepted.



        public static int[] SortArrayByParity(int[] A)
        {

            if (A.Length == 0 || A.Length == 1)
            {
                return A;
            }

            if (A.Length == 2)
            {
                if (A[0] % 2 == 0)
                {
                    return A;
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] % 2 == 0)
                        {
                            int x = A[i];
                            A[i] = A[j];
                            A[j] = x;
                            break;
                        }
                    }
                }
            }
            return A;
        }


        /*
         Squares of a Sorted Array
            Solution
            Given an array of integers A sorted in non-decreasing order, return an array of the squares of each number, also in sorted non-decreasing order.

 

            Example 1:

            Input: [-4,-1,0,3,10]
            Output: [0,1,9,16,100]
            Example 2:

            Input: [-7,-3,2,3,11]
            Output: [4,9,9,49,121]
         */

        public static int[] SortedSquares1(int[] A)
        {
            if (A.Length == 0)
            {
                return A;
            }

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * A[i];
            }

            Array.Sort(A);

            return A;
        }

        /*
         Height Checker
        Students are asked to stand in non-decreasing order of heights for an annual photo.

        Return the minimum number of students that must move in order for all students to be standing in non-decreasing order of height.

        Notice that when a group of students is selected they can reorder in any possible way between themselves and the non selected students remain on their seats.

 

        Example 1:

        Input: heights = [1,1,4,2,1,3]
        Output: 3
        Explanation: 
        Current array : [1,1,4,2,1,3]
        Target array  : [1,1,1,2,3,4]
        On index 2 (0-based) we have 4 vs 1 so we have to move this student.
        On index 4 (0-based) we have 1 vs 3 so we have to move this student.
        On index 5 (0-based) we have 3 vs 4 so we have to move this student.
        Example 2:

        Input: heights = [5,1,2,3,4]
        Output: 5
        Example 3:

        Input: heights = [1,2,3,4,5]
        Output: 0
         */

        public static int HeightChecker(int[] heights)
        {
            if (heights.Length == 0 || heights.Length == 1)
            {
                return 0;
            }

            int[] nHeights = new int[heights.Length];
            Array.Copy(heights, nHeights, heights.Length);
            Array.Sort(nHeights);

            int x = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != nHeights[i])
                {
                    x++;
                }
            }

            return x;

        }


        /*
         *Third Maximum Number
            Solution
            Given a non-empty array of integers, return the third maximum number in this array. If it does not exist, return the maximum number. The time complexity must be in O(n).

            Example 1:
            Input: [3, 2, 1]

            Output: 1

            Explanation: The third maximum is 1.
            Example 2:
            Input: [1, 2]

            Output: 2

            Explanation: The third maximum does not exist, so the maximum (2) is returned instead.
            Example 3:
            Input: [2, 2, 3, 1]

            Output: 1

            Explanation: Note that the third maximum here means the third maximum distinct number.
            Both numbers with value 2 are both considered as second maximum.
         * */

        public static int ThirdMax(int[] nums)
        {

            if (nums.Length == 1)
            {
                return nums[0];
            }

            Array.Sort(nums);
            Array.Reverse(nums);

            int thirdMaxNum = nums[0];
            int cou = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    thirdMaxNum = nums[i];
                    cou++;
                }

                if (cou == 2) return thirdMaxNum;
            }

            if (cou < 2) return nums[0];

            return 0;

        }


        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> x = new List<int>();
            if (nums.Length == 0)
            {
                return x;
            }
            int len = nums.Length;
            HashSet<int> y = new HashSet<int>();
            for (int i = 1; i <= len; i++)
            {
                y.Add(i);
            }

            foreach (int num in nums)
            {
                y.Remove(num);
            }
            return y.ToList();
        }




    }
}
