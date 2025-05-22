using System;
using System.Collections.Generic;

namespace CalorieTracker {
    public class MealServingsUnit : ServingsUnit {
        public override double GramsPerUnit {
            get {
                double grams = 0;

                foreach (IProduct product in Products) {
                    grams += product.Amount.Unit.GramsPerUnit * product.Amount.Quantity;
                }

                return grams;
            }
        }

        public IEnumerable<IProduct> Products { get; set; }

        public MealServingsUnit(IEnumerable<IProduct> products) {
            Products = products;
        }
    }
}
