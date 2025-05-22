using System;

namespace CalorieTracker {
    public class AmountUnit : IUnit {
        public UnitName Name { get; }
        public double GramsPerUnit => Amount.Unit.GramsPerUnit * Amount.Quantity;

        public IAmount Amount { get; set; }
    }
}
