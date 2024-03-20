class SwapObjectClass
{
    public static string SwapObjects(ref string[] inputs)
    {
        try
        {
            object obj1, obj2, temp;
            if (double.TryParse(inputs[0], out double number1) && double.TryParse(inputs[1], out double number2))
            {
                obj1 = number1;
                obj2 = number2;
            }
            else
            {
                obj1 = inputs[0];
                obj2 = inputs[1];
            }

            // if(!(obj1 is double) || !(obj2 is double) || !(obj1 is string) || !(obj2 is string)){
            // throw new Exception($"Invalid Input, Unsupported Type Only (Numbers or String)");
            // }
            
            if (inputs.Length != 2)
            {
                throw new Exception("Invalid Input, Please Enter Two Numbers or Two String");
            }
            else
            {
                if (obj1 is double && obj2 is double)
                {
                    if ((double)obj1 > 18 && (double)obj2 > 18)
                    {
                        temp = obj1;
                        obj1 = obj2;
                        obj2 = temp;
                        return $"{obj1} {obj2}";
                    }
                    else
                    {
                        throw new Exception("Invalid Input,Value Numbers must be more than 18");
                    }
                }
                else if ((obj1 is string) && (obj2 is string))
                {
                    if (((string)obj1).Length > 5 && ((string)obj2).Length > 5)
                    {
                        temp = obj1;
                        obj1 = obj2;
                        obj2 = temp;
                        return $"{obj1} {obj2}";
                    }
                    else
                    {
                        throw new Exception("Invalid Input,Value String Length must be more than 5");
                    }
                }
                else
                {
                    throw new Exception("Invalid Input, Objects must be of same types (Numbers or String)");
                }
            }


        }
        catch (Exception error)
        {
            return $"Error: {error.Message}";
        }
    }
}