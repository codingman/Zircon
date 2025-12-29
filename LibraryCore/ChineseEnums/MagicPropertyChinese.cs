namespace Library.ChineseEnums;

public static class MagicPropertyChinese
{
    public static string GetText(MagicProperty value)
    {
        switch (value)
        {
            case MagicProperty.None:
                return "无";
            case MagicProperty.Passive:
                return "被动";
            case MagicProperty.Augmentation:
                return "增幅";
            case MagicProperty.Active:
                return "主动";
            case MagicProperty.Toggle:
                return "切换";
            case MagicProperty.Charge:
                return "充能";
            default:
                return value.ToString();
        }
    }
}