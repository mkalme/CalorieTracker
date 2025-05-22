using System;

namespace CalorieTracker {
    public interface IAmount {
        IUnit Unit { get; }
        double Quantity { get; set; }
    }
}
