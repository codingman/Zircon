namespace Library.ChineseEnums;

public static class ItemTypeChinese
{
    public static string GetText(ItemType value)
    {
        switch (value)
        {
            case ItemType.Nothing:
                return "无";
            case ItemType.Consumable:
                return "消耗品";
            case ItemType.Weapon:
                return "武器";
            case ItemType.Armour:
                return "防具";
            case ItemType.Torch:
                return "照明物";
            case ItemType.Helmet:
                return "头盔";
            case ItemType.Necklace:
                return "项链";
            case ItemType.Bracelet:
                return "手镯";
            case ItemType.Ring:
                return "戒指";
            case ItemType.Shoes:
                return "鞋子";
            case ItemType.Poison:
                return "毒药";
            case ItemType.Amulet:
                return "护身符";
            case ItemType.Meat:
                return "肉类";
            case ItemType.Ore:
                return "矿石";
            case ItemType.Book:
                return "书籍";
            case ItemType.Scroll:
                return "卷轴";
            case ItemType.DarkStone:
                return "暗石";
            case ItemType.RefineSpecial:
                return "精炼特效";
            case ItemType.HorseArmour:
                return "马甲";
            case ItemType.Flower:
                return "花";
            case ItemType.CompanionFood:
                return "宠物食物";
            case ItemType.CompanionBag:
                return "宠物背包道具";
            case ItemType.CompanionHead:
                return "宠物头部道具";
            case ItemType.CompanionBack:
                return "宠物背部道具";
            case ItemType.System:
                return "系统物品";
            case ItemType.ItemPart:
                return "碎片";
            case ItemType.Emblem:
                return "徽章";
            case ItemType.Shield:
                return "盾牌";
            case ItemType.Costume:
                return "时装";
            case ItemType.Hook:
                return "钩子";
            case ItemType.Float:
                return "漂浮物";
            case ItemType.Bait:
                return "诱饵";
            case ItemType.Finder:
                return "查找器";
            case ItemType.Reel:
                return "卷轴";
            case ItemType.Currency:
                return "货币";
            case ItemType.Bundle:
                return "捆绑包";
            case ItemType.LootBox:
                return "宝箱";
            default:
                return value.ToString();
        }
    }
}