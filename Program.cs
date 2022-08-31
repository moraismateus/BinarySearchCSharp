var myArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var myTarget = 111;

//Console.WriteLine(BinarySearch(myArray, myTarget));
Console.WriteLine(RecursiveBinarySearch(myArray, myTarget, 0, myArray.Length - 1));

int BinarySearch(int[] array, int target)
{
    var first = 0; //array position
    var last = array.Length - 1; //lenght is the total size, but array positions start with 0

    while (first <= last)
    {
        var midPoint = (first + last) / 2; //start from middle point

        if (array[midPoint] == target)//returns if found it
            return midPoint;
        else if (array[midPoint] < target)//check if value in the position is smaller than target, if positive then it will move the search right, now first is midpoint + 1
            first = midPoint + 1;
        else //if negative then moves the search left, now last is midpoint -1
            last = midPoint - 1;
    }

    return -1;
}

int RecursiveBinarySearch(int[] array, int target, int start, int end)
{
    if (start > end || array.Length == 0)//start can't be bigger than end and array can't be empty
        return -1;

    var mid = (start + end) / 2;//the value the function is trying to verify, always the middle point of the list

    if (target == array[mid])
        return mid;
    else if (target < array[mid])//if target it smaller search the left portion of the list
        return RecursiveBinarySearch(array, target, start, mid - 1);
    else //If Target is bigger, search the right portion of the list
        return RecursiveBinarySearch(array, target, mid + 1, end);
}
