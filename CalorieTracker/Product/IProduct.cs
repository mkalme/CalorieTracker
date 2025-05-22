using System;

namespace CalorieTracker {
    public interface IProduct {
        string DisplayName { get; }
        IAmount Amount { get; set; }
        INutrientTemplate Nutrients { get; set; }
    }
}
