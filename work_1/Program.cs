// string Method4 (int count,string text)
// {
//     string result = string.Empty;
//     for (int i=0; i<count;i++)
//     {
//         result = result+text;
//     } 
//     return result;
// }
// string res = Method4 (10, "asdf");
// Console.WriteLine (res);



// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// int[]arr = {1,4,2,1,2};
// for(int i=0; i< arr.Length/2;i++ )
// {
//     (arr[i], arr[arr.Length - (i+1)]) = (arr[arr.Length - (i+1)], arr[i]);
// }
// Console.WriteLine (string.Join (" ", arr));
// Console.WriteLine ("НЕТ");




// int[]arr = {1,2,8,2,1};
// for(int i=0; i< arr.Length/2;i++ )
// {
//     (arr[i], arr[arr.Length - (i+1)]) = (arr[arr.Length - (i+1)], arr[i]);
// }
// Console.WriteLine (string.Join (" ", arr));
// Console.WriteLine ("ДА");



int[]arr = {2,3,4,3,2};
for(int i=0; i< arr.Length/2;i++ )
{
    (arr[i], arr[arr.Length - (i+1)]) = (arr[arr.Length - (i+1)], arr[i]);
}
Console.WriteLine (string.Join (" ", arr));
Console.WriteLine ("ДА");