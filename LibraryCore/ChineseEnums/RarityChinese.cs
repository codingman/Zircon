namespace Library.ChineseEnums;

public static class RarityChinese
{
    public static string GetText(Rarity value)
    {
        switch (value)
        {
            case Rarity.Common:
                return "普通";
            case Rarity.Superior:
                return "精英";
            case Rarity.Elite:
                return "史诗";
            default:
                return value.ToString();
        }
    }
}