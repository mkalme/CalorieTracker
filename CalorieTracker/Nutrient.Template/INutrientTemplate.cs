using System;
using System.Collections.Generic;

namespace CalorieTracker {
    public interface INutrientTemplate {
        IEnumerable<INutrient> Nutrients { get; }
        INutrient this[string name] { get; }

        double CalculateCalories();
    }
}
