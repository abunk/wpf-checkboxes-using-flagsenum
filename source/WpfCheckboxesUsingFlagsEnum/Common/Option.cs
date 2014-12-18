using System;

namespace WpfCheckboxesUsingFlagsEnum.Common
{
    [Flags]
    public enum Option
    {
        Option1 = 0x01,

        Option2 = 0x02,

        Option3 = 0x04,

        Option4 = 0x08,

        All = Option1 | Option2 | Option3 | Option4
    }
}