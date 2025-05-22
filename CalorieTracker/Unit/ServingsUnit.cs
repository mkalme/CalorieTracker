using System;

namespace CalorieTracker {
    public class ServingsUnit : IUnit {
        public virtual UnitName Name { get; } = new UnitName("Serving", "Servings", "serv");
        public virtual double GramsPerUnit { get; set; }
    }
}
