using System;

namespace CalorieTracker {
    public interface IUnit {
        UnitName Name { get; }
        double GramsPerUnit { get; }
    }
}
