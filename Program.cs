string[] inputArray = {"hello", "2", "world", ":-)"};

for (int i =0; i< inputArray.Length; i++)
{
   var temp = inputArray[i];
   if (temp.Length<=3)
   {
    Console.Write($"[{String.Join(";", temp)}]");
   }
}

