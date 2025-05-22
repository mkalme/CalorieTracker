using System;

namespace CalorieTracker {
    public class Amount : IAmount {
        public IUnit Unit { get; }
        public double Quantity { get; set; }

        public Amount(IUnit unit, double quantity) {
            Unit = unit;
            Quantity = quantity;
        }
    }
}
