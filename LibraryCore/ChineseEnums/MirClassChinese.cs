namespace Library.ChineseEnums;

public static class MirClassChinese
{
    public static string GetText(MirClass value)
    {
        switch (value)
        {
            case MirClass.Warrior:
                return "战士";
            case MirClass.Wizard:
                return "法师";
            case MirClass.Taoist:
                return "道士";
            case MirClass.Assassin:
                return "刺客";
            default:
                return value.ToString();
        }
    }
}