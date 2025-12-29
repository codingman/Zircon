namespace Library.ChineseEnums;

public static class MagicSchoolChinese
{
    public static string GetText(MagicSchool value)
    {
        switch (value)
        {
            case MagicSchool.None:
                return "无";
            case MagicSchool.Passive:
                return "被动";
            case MagicSchool.Active:
                return "主动";
            case MagicSchool.Toggle:
                return "切换";
            case MagicSchool.Fire:
                return "火";
            case MagicSchool.Ice:
                return "冰";
            case MagicSchool.Lightning:
                return "闪电";
            case MagicSchool.Wind:
                return "风";
            case MagicSchool.Holy:
                return "神圣";
            case MagicSchool.Dark:
                return "黑暗";
            case MagicSchool.Phantom:
                return "幻影";
            case MagicSchool.Physical:
                return "物理";
            case MagicSchool.Atrocity:
                return "暴行";
            case MagicSchool.Kill:
                return "杀戮";
            case MagicSchool.Assassination:
                return "刺杀";
            case MagicSchool.Horse:
                return "马";
            case MagicSchool.Discipline:
                return "修炼";
            default:
                return value.ToString();
        }
    }
}