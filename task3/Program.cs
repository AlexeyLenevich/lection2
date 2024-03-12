// int n = 10;
int[] arr  = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int i = 1;
// bool IsChet(int[] arr)
// {
//     if ((arr[i]) % 2 == 0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

while (i < arr.Length)

{
    if ((arr[i]) % 2 == 0)
        // System.Console.WriteLine(arr [i]);
        // System.Console.WriteLine(" ");
        System.Console.Write($"{arr[i]} "); 
    i = i + 1;    
}
