using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    public class GestureActuator
    {
        public enum ControlToActuate
        {
            All=255,
            Image,
            TableView,
            ActivityIndicator,
            DatePicker,
            Editor,
            Entry,
            ProgressBar,
            SearchBar,
            Slider,
            Stepper,
            Switch,
            BoxView,
            Picker,
            TimePicker,
            WebView,
            Label
        }

        public static void Init(params ControlToActuate[] controlToActuate)
        {
            if (controlToActuate.Contains<ControlToActuate>(ControlToActuate.All))
            {
                GestureActuator.controlsToActuate = Enum.GetValues(typeof(ControlToActuate))
                    .Cast<ControlToActuate>().ToArray();
            }
            else
            {
                GestureActuator.controlsToActuate = controlToActuate;
            }
        }
        internal static ControlToActuate[] controlsToActuate;
    }
}
