using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ClassLibrary1.Ext;

public static class EnumExt
{
    public static string GetDisplayName(this System.Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName() ?? "Неопределен";
    }
}