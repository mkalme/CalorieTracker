using System;
using System.Collections.Generic;

namespace CalorieTracker {
    public abstract class NutrientTemplate : INutrientTemplate {
        public virtual IEnumerable<INutrient> Nutrients => NutrientDictionary.Values;
        public virtual INutrient this[string name] => NutrientDictionary[name];

        protected abstract IDictionary<string, INutrient> NutrientDictionary { get; }

        public abstract double CalculateCalories();
    }
}
