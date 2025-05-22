using System;
using System.Collections.Generic;

namespace CalorieTracker {
    public class StandardNutrientTemplate : NutrientTemplate {
        protected override IDictionary<string, INutrient> NutrientDictionary { get; }
        public IUnit DefaultUnit { get; set; } = Unit.Gram;

        public StandardNutrientTemplate() {
            NutrientDictionary = new Dictionary<string, INutrient>(3);

            Add(new Nutrient("Fat", new Amount(DefaultUnit, 0)),
                new Nutrient("Carbohydrates", new Amount(DefaultUnit, 0)),
                new Nutrient("Protein", new Amount(DefaultUnit, 0)));
        }

        private void Add(params INutrient[] nutrients) {
            foreach (INutrient nutrient in nutrients) {
                NutrientDictionary.Add(nutrient.DisplayName, nutrient);
            }
        }

        public override double CalculateCalories() {
            return NutrientDictionary["Fat"].Amount.GetGrams() * 9 +
                   NutrientDictionary["Carbohydrates"].Amount.GetGrams() * 4 +
                   NutrientDictionary["Protein"].Amount.GetGrams() * 4; 
        }
    }
}
