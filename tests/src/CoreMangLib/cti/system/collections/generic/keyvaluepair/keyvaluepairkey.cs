using System;
using System.Collections.Generic;
/// <summary>
///Key
/// </summary>
public class KeyValuePairKey
{
    public static int Main()
    {
        KeyValuePairKey KeyValuePairKey = new KeyValuePairKey();

        TestLibrary.TestFramework.BeginTestCase("KeyValuePairKey");
        if (KeyValuePairKey.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new instance of KeyValuePair.key is string and value is int");
        try
        {
            string ExpectValue1 = "HELLO";
            int ExpectValue2 = 1;
            KeyValuePair<string, int> myKeValuePair = new KeyValuePair<string, int>(ExpectValue1, ExpectValue2);
            if (myKeValuePair.Key != ExpectValue1)
            {
                TestLibrary.TestFramework.LogError("001.1", "the key of KeyValuePair should return " + ExpectValue1);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Create a new instance of KeyValuePair,key is int and value is string.");
        try
        {
            string ExpectValue1 = "HELLO";
            int ExpectValue2 = 1;
            KeyValuePair<int, string> myKeValuePair = new KeyValuePair<int, string>(ExpectValue2, ExpectValue1);
            if (myKeValuePair.Key != ExpectValue2)
            {
                TestLibrary.TestFramework.LogError("002.1", "the key of KeyValuePair should return " + ExpectValue2);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3: Create a new instance of KeyValuePair,key is 0 and value is null.");
        try
        {
            int ExpectValue2 = 0;
            KeyValuePair<int, string> myKeValuePair = new KeyValuePair<int, string>();
            if (myKeValuePair.Key != ExpectValue2)
            {
                TestLibrary.TestFramework.LogError("003.1", "the key of KeyValuePair should return " + ExpectValue2);
                retVal = false;
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }


    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest4()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest4: Create a new instance of KeyValuePair,key is null and value is 0.");
        try
        {
            string ExpectValue1 = null;
            KeyValuePair<string, int> myKeValuePair = new KeyValuePair<string, int>();
            if (myKeValuePair.Key != ExpectValue1)
            {
                TestLibrary.TestFramework.LogError("004.1", "the key of KeyValuePair should return null.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}
