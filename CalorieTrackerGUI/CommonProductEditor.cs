using System;
using System.Linq;
using System.Windows.Forms;
using CalorieTracker;
using InteractiveGUI;

namespace CalorieTrackerGUI {
    public partial class CommonProductEditor : Form {
        public INutrientTemplate NutrientTemplate { get; set; }
        public IInputPanelCreator InputPanelCreator { get; set; }
        public ILayoutCreator LayoutCreator { get; set; }

        public CommonProductEditor(INutrientTemplate nutrientTemplate) {
            InitializeComponent();

            NutrientTemplate = nutrientTemplate;
            InputPanelCreator = new InputPanelCreator() {
                DisplayIcons = false
            };
            LayoutCreator = new NutrientTemplateLayoutCreator();

            Panel panel = InputPanelCreator.CreatePanel(LayoutCreator.CreateLayout(nutrientTemplate));
            panel.Dock = DockStyle.Top;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.Margin = new Padding(0);

            TableContainer.Controls.Add(panel, 0, 0);
        }
    }

    public class NutrientTemplateLayoutCreator : ILayoutCreator {
        public IInteractiveProperty[] CreateLayout(object source) {
            INutrientTemplate nutrientTemplate = source as INutrientTemplate;

            IInteractiveProperty[] properties = new IInteractiveProperty[nutrientTemplate.Nutrients.Count()];
            for (int i = 0; i < properties.Length; i++) {
                INutrient nutrient = nutrientTemplate.Nutrients.ElementAt(i);

                properties[i] = new InteractiveVariable() {
                    Owner = nutrient,
                    DisplayName = nutrient.DisplayName,
                    ControlInput = new NutrientInput()
                };
            }

            return properties;
        }
    }

    public class NutrientInput : InputAttribute {
        private INutrient _nutrient;
        private InteractiveVariable _property;

        public override Control CreateControl(IInteractiveProperty property) {
            INutrient nutrient = property.GetValue() as INutrient;

            double value = nutrient.Amount.Unit.GramsPerUnit * nutrient.Amount.Quantity;
            //value = 100 / value * value;

            InteractiveVariable variable = new InteractiveVariable() {
                Owner = value,
                ControlInput = new PrimitiveDataTypeInput()
            };

            variable.Control = variable.ControlInput.CreateControl(variable);
            variable.Control.Dock = DockStyle.Fill;

            _nutrient = nutrient;
            _property = variable;

            return variable.Control;
        }

        public override bool TryParse(IInteractiveProperty property, out object output) {
            throw new NotImplementedException();
        }
    }
}
