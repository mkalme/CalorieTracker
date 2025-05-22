using System;

namespace CalorieTracker {
    public struct Unit : IUnit {
        public UnitName Name { get; }
        public double GramsPerUnit { get; }

        public static readonly Unit Gram = new Unit("Gram", "Grams", "g", 1);
        public static readonly Unit Kilogram = new Unit("Kilogram", "Kilograms", "kg", 1000);
        public static readonly Unit Ounce = new Unit("Ounce", "Ounces", "oz", 28.3495231);
        public static readonly Unit Pound = new Unit("Pound", "Pounds", "lb", 453.59237);

        public Unit(string singular, string plural, string abbreviation, double gramsPerUnit) {
            Name = new UnitName(singular, plural, abbreviation);
            GramsPerUnit = gramsPerUnit;
        }

        public static Unit FromProduct(IProduct product) {
            return new Unit(product.DisplayName, product.DisplayName, product.DisplayName, product.Amount.Unit.GramsPerUnit * product.Amount.Quantity);
        }
        public static double ConvertAmount(IAmount from, IAmount to) {
            return from.Unit.GramsPerUnit * (to.Unit.GramsPerUnit / from.Unit.GramsPerUnit) * from.Quantity;
        }
    }
}
