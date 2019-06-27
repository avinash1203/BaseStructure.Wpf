using System.Collections.Generic;

namespace Structure.UIClass
{
    class CheckableItem
    {
        internal string Value { get; set; }
        internal bool IsChecked { get; set; }
        internal List<CheckableItem> Children { get; set; }
    }
}
