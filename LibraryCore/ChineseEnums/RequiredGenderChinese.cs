namespace Library.ChineseEnums;

public static class RequiredGenderChinese
{
    public static string GetText(RequiredGender value)
    {
        switch (value)
        {
            case RequiredGender.Male:
                return "男";
            case RequiredGender.Female:
                return "女";
            case RequiredGender.None:
                return "无";
            default:
                return value.ToString();
        }
    }
}