using System;

namespace CalorieTracker {
    public class CommonProduct : StandardProduct {
        public override IAmount Amount { get; set; } = new Amount(DefaultUnit, 0);
    }
}
