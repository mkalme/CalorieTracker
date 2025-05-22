using System;

namespace CalorieTracker {
    public static class AmountExtensions {
        public static double GetGrams(this IAmount amount) {
            return amount.Quantity * amount.Unit.GramsPerUnit;
        }
    }
}
