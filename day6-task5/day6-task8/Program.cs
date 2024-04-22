﻿public class Program {
    public static int CircularBinarySearch(int[] arr, int target) {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;

            if (arr[mid] == target) {
                return mid;
            }

            if (arr[low] <= arr[mid]) {
                if (arr[low] <= target && target < arr[mid]) {
                    high = mid - 1;
                } else {
                    low = mid + 1;
                }
            } else {
                if (arr[mid] < target && target <= arr[high]) {
                    low = mid + 1;
                } else {
                    high = mid - 1;
                }
            }
        }

        return -1;
    }

    static void Main(string[] args) {
        int[] arr = { 4, 5, 6, 7, 8, 1, 2, 3 };
        int target = 6;
        
        int result = CircularBinarySearch(arr, target);

        if (result != -1) {
            Console.WriteLine("Element found at index: " + result);
        } else {
            Console.WriteLine("Element not found.");
        }
    }
}
