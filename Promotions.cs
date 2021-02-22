using System;
using System.Collections.Generic;

namespace PromotionalEngine.Core
{
    public class Promotion
    {        
        public PromotionType Type { get; set; }
    }

    public enum PromotionType
    {
        PriceForQuantityPromotion = 1, 
        ComboPromotion = 2
    }
}