using System;

namespace CalorieTracker {
    public abstract class StandardProduct : IProduct {
        public virtual string DisplayName { get; }
        public abstract IAmount Amount { get; set; }
        public virtual INutrientTemplate Nutrients { get; set; } = new StandardNutrientTemplate();

        public static readonly IUnit DefaultUnit = Unit.Gram;
    }
}
