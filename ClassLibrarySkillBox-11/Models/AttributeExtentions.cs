using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_11.Models
{
    public static class AttributeExtentions
    {
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
        {
            var memberInfo = enumValue.GetType()
                                .GetMember(enumValue.ToString())
                                .FirstOrDefault();

            if (memberInfo != null)
                return (TAttribute)memberInfo.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault();
            return null;
        }
    }
}
