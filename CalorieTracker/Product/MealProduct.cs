using System;
using System.Collections.Generic;

namespace CalorieTracker {
    public class MealProduct : StandardProduct {
        public override IAmount Amount { get; set; }

        public IList<IProduct> Products { get; set; }

        public MealProduct() {
            Amount = new Amount(new MealServingsUnit(Products), 0);
        }
    }
}
