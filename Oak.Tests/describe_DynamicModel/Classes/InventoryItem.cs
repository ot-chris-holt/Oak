using System;

namespace Oak.Tests.describe_DynamicModel.Classes
{
    public class InventoryItem : DynamicModel
    {
        public InventoryItem(dynamic dto)
        {
            Init(dto);
        }
    }
}
