using System;

namespace CalorieTracker {
    public readonly struct UnitName {
        public string Singular { get; }
        public string Plurar { get; }
        public string Abbreviation { get; }

        public UnitName(string singular, string plural, string abbreviation) {
            Singular = singular;
            Plurar = plural;
            Abbreviation = abbreviation;
        }
    }
}
