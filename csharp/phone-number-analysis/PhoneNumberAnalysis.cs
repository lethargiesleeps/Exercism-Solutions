using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        //Splitting phone#
        var digitSets = phoneNumber.Split('-');

        //Return values
        var isNewYork = digitSets[0].Equals("212");
        var isFake = digitSets[1].Equals("555");
        var localNumber = digitSets[2];

        return (isNewYork, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
