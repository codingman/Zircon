namespace Library.ChineseEnums;

public static class RequiredClassChinese
{
    public static string GetText(RequiredClass value)
    {
        switch (value)
        {
            case RequiredClass.None:
                return "无";
            case RequiredClass.Warrior:
                return "战士";
            case RequiredClass.Wizard:
                return "法师";
            case RequiredClass.Taoist:
                return "道士";
            case RequiredClass.Assassin:
                return "刺客";
            case RequiredClass.WarWizTao:
                return "战士、法师、道士";
            case RequiredClass.WizTao:
                return "法师、道士";
            case RequiredClass.AssWar:
                return "刺客、战士";
            case RequiredClass.All:
                return "任意职业";
            default:
                return value.ToString();
        }
    }
}