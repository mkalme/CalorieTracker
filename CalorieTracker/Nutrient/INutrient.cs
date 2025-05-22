using System;

namespace CalorieTracker {
    public interface INutrient {
        string DisplayName { get; }
        IAmount Amount { get; set; }
    }
}
