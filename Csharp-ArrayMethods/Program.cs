



//Csharp-ArrayMethod-Hometask




//2) Method yazirsiz, Method stringden ibaret array ve char qebul edir. 
//    Method arrayin icerisinde gelen chardan ne qederdirse 
//    onlarin sayini geriye qaytarsin.



int CharCount(string[] arr, char c)
{
    int count = 0;

    foreach (var item in arr)
    {
        for (int i = 0; item.Length > i; i++ )
        {  
            if (item[i] == c)
            {
                count++;

            }
        }
    }

    return count;
}


string[] arr = { "Nurlan", "Huseyn", "Xan" };

Console.WriteLine(CharCount( arr, 'a'));




///////////////////////////////////////////////////////////////////////



//Hometask-Practise





//using System.Text;

//string BackWords(string text)
//{
//    string result = string.Empty;
//    for (var i = text.Length - 1; i >= 0; i--)
//    {
//        result += text[i];
//    }
//    return result;
//}
//Console.WriteLine(BackWords("Salam"));



//string BackNums(string nums)
//{
//    string resul1 = string.Empty;
//    for ( var i = nums.Length - 1; i>= 0; i--)
//    {
//        resul1 += nums[i];
//    }
//    return resul1;
//}

//Console.WriteLine(BackNums("345678"));



//string BackNums(string nums1)
//{
//    string res11 = string.Empty;
//    for(var i = nums1.Length - 1; i>= 0;i--)
//    {
//    res11 += nums1[i];
//    }
//    return res11;
//}

//Console.WriteLine(BackNums("24654652568"));

//Console.WriteLine(BackNums("2,3,4,5,5,6"));







////////////////////////////////////////////////////////////





//string name = "Reshad";
//name = "test";


//StringBuilder test = new("salam");

//test.Append("sagol");







//using System.Text;

//StringBuilder test = new("salam");
//test.Append(" sagol");
//Console.WriteLine(test);



//using System.Text;

//StringBuilder name = new("Pb-101");
//name.Append(" SAGOLUN");

//Console.WriteLine(name);






//using System.Text;

//StringBuilder str = new("name of student");
//str.Append(" - \"Sabuhi\"");


//Console.WriteLine(str);








//using System.Text;

//StringBuilder task = new(" Your hometask is array and methods.");
//task.Append(" Goodluck!!!");

//Console.WriteLine(task);








//using System.Text;

//StringBuilder nums = new("12345!=");
//nums.Append("123456789");
//Console.WriteLine(nums);







//string elem = Console.ReadLine();
////Console.WriteLine(elem);



//int resp;

// Data:  string elem = Console.ReadLine();

//bool isConvert = int.TryParse(elem, out resp);

//if (isConvert)
//{
//    Console.WriteLine("Response is --- " + resp);
//}
//else
//{
//    Console.WriteLine("Format is wrong, please add input again:");
//    goto Data;
//}






///////////////////////////////////







//string[] names = { "Hacixan", "Reshad", "Kamran", 
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };


//Console.WriteLine(names[names.Length-1]);









//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };



//Console.WriteLine(names[4]);










//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };


//for (int i = 0; i< names.Length; i++)
//{
//    Console.WriteLine(i);
//}











//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };



//for (int i = 0; i< names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}





////////////////////////////////////////////
///


//int[,] nums = { { 1, 2, 3 }, { 5, 6, 7 }, { 7, 8, 9 } };

//Console.WriteLine(nums.Rank);








//int[,] nums = { { 1, 2, 3 }, { 5, 6, 7 }, { 7, 8, 9 } };



//Console.WriteLine(nums[1,2]);





//////////////////////////////






//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };



//Console.WriteLine(names.Contains("Reshad"));








//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };



//var datas = names.Reverse().ToArray();
//Console.WriteLine(datas[datas.Length-1]);



//Console.WriteLine(datas[datas.Length - 3]);









//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };



//Array.Sort(names);


//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}







//int[] nums = { 5, 3, 2, 7, 8 };

//Array.Sort(nums);

//var datas = nums.Reverse().ToArray();

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}






//////////////////////










//int[] nums = { 5, 3, 2, 7, 8 };

//Array.Sort(nums);

//var datas = nums.Reverse().ToArray();

//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}











//int[] nums = { 5, 3, 2, 7, 8 };

//Array.Sort(nums);

//var datas = nums.Reverse().ToArray();

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}













//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5 };

//arr1.CopyTo(arr2, 2);




//int[] arr = { 1, 2, 3 };

//Array.Resize(ref arr, 5);


//arr[3] = 200;

//Console.WriteLine(arr[3]);








//string[] arr = { "sd", "sd" };
//Array.Resize(ref arr, 3);

//Console.WriteLine(arr[2]);







//string[] arr = { "sd", "sd" };
//Array.Resize(ref arr, 3);

//Console.WriteLine(arr[1]);









//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5 };

////arr1.CopyTo(arr2, 2);


//Array.Resize(ref arr2, 5);

//foreach ( var item in arr2)
//{
//    Console.WriteLine(item);
//}








///////////////////////






//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide", "Fexriyye" };



//var data = Array.Find(names, m => m == "Reshad");

//Console.WriteLine(data);








//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = Array.FindAll(names, m => m == "Reshad");



//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}











//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = Array.FindIndex(names, m => m == "Reshad");

//Console.WriteLine(data);










//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = Array.FindLastIndex(names, m => m == "Reshad");

//Console.WriteLine(data);











//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = names.LastOrDefault();

//Console.WriteLine(data);










//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = names.FirstOrDefault();

//Console.WriteLine(data);










//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = names.FirstOrDefault();

//Console.WriteLine(data);










//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = names.Last();

//Console.WriteLine(data);














//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = names.FirstOrDefault(m=> m == "Kamran");

//Console.WriteLine(data);








//string[] names = { "Hacixan", "Reshad", "Kaamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = names.Any(m=> m == "Kamran");

//Console.WriteLine(data);













//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = names.All(m => m == "Kamran");

//Console.WriteLine(data);
















//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var data = Array.Exists(names,m => m == "Kamran");

//Console.WriteLine(data);













//?????


//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var datas = names.Where(m => m == "Reshad").ToArray();

//foreach (var name in names)
//{
//    Console.WriteLine(datas);
//}







// ????????????????

//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var datas = names.OrderBy(m => m);
//foreach (var item in datas)
//{
//    Console.WriteLine(datas);
//}






// ????????????????????????


//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };



//var datas = names.OrderByDescending(m => m);
//foreach (var item in datas)
//{
//    Console.WriteLine(datas);
//}







//string[] names = { "Hacixan", "Reshad", "Kamran",
//    "Ilqar", "Fatime", "Afide","Reshad", "Fexriyye" };


////var datas = names.All(m => m == "Reshad");


//bool CheckAllDatas(string[] datas, string str)
//{
//      int count = 0;

//    for (int i = 0; names.Length > i; i++)
//    {
//        if (names[i] == str)
//        {
//            count++;
//        }
//    }

//    if ( count == names.Length)
//    {
//        return true;
//    }
//    else 
//    {
//        return false;
//    }


//}


//Console.WriteLine(CheckAllDatas(names, "Reshad"));












////////////////////////////////////////////////////





//DateTime date = DateTime.Now.AddDays(1);

//Console.WriteLine(date);











//DateTime date = DateTime.Now;

//Console.WriteLine(date);








//DateTime date = DateTime.Now.AddDays(8);
//Console.WriteLine(date);









//DateTime date = DateTime.Now.AddYears(8);
//Console.WriteLine(date);



//DateTime birthday = new DateTime(2002, 05, 25);

//Console.WriteLine(birthday);











//DateTime birthday = new DateTime(2002, 05, 25);

//Console.WriteLine(birthday.Day);







//DateTime birthday = new DateTime(2002, 05, 25);

//Console.WriteLine(birthday.Year);






//var date = DateTime.Now;

//Console.WriteLine(date.ToString("dddd-mm-yyyy"));







//var currentYear = DateTime.Now.Year;
//DateTime birthday = new DateTime(2001, 05, 25);

//var birthdayYear = birthday.Year;

//Console.WriteLine(currentYear - birthdayYear);





//var thisYear = DateTime.Now.Year;

//DateTime birthday = new DateTime(2002, 12, 31);

//var birthdayYear = birthday.Year;

//Console.WriteLine(thisYear - birthdayYear);











//var currentYear = DateTime.Now.Year;

//DateTime birthday = new DateTime(2000, 9, 12);

//var birtday1 = birthday.Year;

//Console.WriteLine(currentYear - birtday1);

