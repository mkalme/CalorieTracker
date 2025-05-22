using System;

namespace CalorieTracker {
    public class Nutrient : INutrient {
        public string DisplayName { get; }
        public IAmount Amount { get; set; }

        public Nutrient(string displayName, IAmount amount) {
            DisplayName = displayName;
            Amount = amount;
        }
    }
}
