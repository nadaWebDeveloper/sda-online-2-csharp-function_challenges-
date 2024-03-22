class SwapObjectClass
{
    public static void SwapObjects()
    {
        try
        {
            string inputObj;
            

            Console.WriteLine($"\tEnter Two Number Or Two String To Swapper:");
            inputObj = Console.ReadLine() ?? "";
            string[] inputArray = inputObj.Split(" ");

            ConditionSwapObj(ref inputArray);


        }
        catch (Exception error)
        {
            Console.WriteLine($"Error: {error.Message}");
        }
    }

    public static void ConditionSwapObj(ref string[] inputArray)
    {
        try
        {
            object obj1, obj2, temp;

            if (inputArray.Length != 2)
            {
                throw new Exception("Invalid Input, Please Enter Two Numbers or Two String");
            }
            else
            {

                if (double.TryParse(inputArray[0], out double number1) && double.TryParse(inputArray[1], out double number2))
                {
                    obj1 = number1;
                    obj2 = number2;
                    if (obj1 is double && obj2 is double)
                    {
                        if ((double)obj1 > 18 && (double)obj2 > 18)
                        {
                            temp = obj1;
                            obj1 = obj2;
                            obj2 = temp;
                            Console.WriteLine($"{obj1} {obj2}");
                        }
                        else
                        {
                            if ((double)obj1 > 18)
                            {
                                throw new Exception($"Invalid Input '{obj2}' ,Value Numbers must be more than 18");
                            }
                            else if ((double)obj2 > 18)
                            {
                                throw new Exception($"Invalid Input '{obj1}' ,Value Numbers must be more than 18");
                            }
                            throw new Exception($"Invalid Input '{obj1}' '{obj2}' ,Value Numbers must be more than 18");


                        }
                    }
                }
                else if (inputArray[0] is string && inputArray[1] is string && !double.TryParse(inputArray[1], out double number0) && !double.TryParse(inputArray[0], out double number) && !bool.TryParse(inputArray[0], out bool resu70lt) && !bool.TryParse(inputArray[1], out bool resu500lt))
                {
                    obj1 = inputArray[0];
                    obj2 = inputArray[1];

                    if (((string)obj1).Length > 5 && ((string)obj2).Length > 5)
                    {
                        temp = obj1;
                        obj1 = obj2;
                        obj2 = temp;
                        Console.WriteLine($"{obj1} {obj2}");
                    }
                    else
                    {
                        if (((string)obj2).Length > 5)
                        {
                            throw new Exception($"Invalid Input '{obj1}',Value String Length must be more than 5");
                        }
                        else if (((string)obj1).Length > 5)
                        {
                            throw new Exception($"Invalid Input '{obj2}',Value String Length must be more than 5");
                        }
                        throw new Exception($"Invalid Input '{obj1}' '{obj2}',Value String Length must be more than 5");

                    }
                }
                else if ((double.TryParse(inputArray[0], out double number3) && (inputArray[1] is string)) || double.TryParse(inputArray[1], out double number90) && (inputArray[0] is string) && !bool.TryParse(inputArray[0], out bool resu700lt) && !bool.TryParse(inputArray[1], out bool resu5800lt))
                {
                    throw new Exception("Objects must be of the same type (string or number)");
                }
                else if (bool.TryParse(inputArray[0], out bool resu09lt) || bool.TryParse(inputArray[1], out bool resu090lt))
                {
                    throw new Exception($"Invalid Input, Unsupported Type Only (Numbers or String)");
                }
            }

        }
        catch (Exception error)
        {
            Console.WriteLine($"Error: {error.Message}");
        }
    }
}