// <copyright file="GestureActuator.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Used to initialize gestures and enable them on specific controls
    /// </summary>
    public class GestureActuator
    {
        /// <summary>
        /// Lists the controls that can be wired up for gestures.
        /// </summary>
        public enum ControlToActuate
        {
            /// <summary>
            /// Enables all controls
            /// </summary>
            All = 255,

            /// <summary>
            /// Enables Gestures on the Image Control
            /// <see cref="IndiXam.Forms.Image"/>
            /// </summary>
            Image,

            /// <summary>
            /// Enables Gestures on the TableView Control
            /// <see cref="IndiXam.Forms.TableView"/>
            /// </summary>
            TableView,

            /// <summary>
            /// Enables Gestures on the ActivityIndicator Control
            /// <see cref="IndiXam.Forms.ActivityIndicator"/>
            /// </summary>
            ActivityIndicator,

            /// <summary>
            /// Enables Gestures on the DatePicker Control
            /// <see cref="IndiXam.Forms.DatePicker"/>
            /// </summary>
            DatePicker,

            /// <summary>
            /// Enables Gestures on the Editor Control
            /// <see cref="IndiXam.Forms.Editor"/>
            /// </summary>
            Editor,

            /// <summary>
            /// Enables Gestures on the Entry Control
            /// <see cref="IndiXam.Forms.Entry"/>
            /// </summary>
            Entry,

            /// <summary>
            /// Enables Gestures on the ProgressBar Control
            /// <see cref="IndiXam.Forms.ProgressBar"/>
            /// </summary>
            ProgressBar,

            /// <summary>
            /// Enables Gestures on the SearchBar Control
            /// <see cref="IndiXam.Forms.SearchBar"/>
            /// </summary>
            SearchBar,

            /// <summary>
            /// Enables Gestures on the Slider Control
            /// <see cref="IndiXam.Forms.Slider"/>
            /// </summary>
            Slider,

            /// <summary>
            /// Enables Gestures on the Stepper Control
            /// <see cref="IndiXam.Forms.Stepper"/>
            /// </summary>
            Stepper,

            /// <summary>
            /// Enables Gestures on the Switch Control
            /// <see cref="IndiXam.Forms.Switch"/>
            /// </summary>
            Switch,

            /// <summary>
            /// Enables Gestures on the BoxView Control
            /// <see cref="IndiXam.Forms.BoxView"/>
            /// </summary>
            BoxView,

            /// <summary>
            /// Enables Gestures on the Picker Control
            /// <see cref="IndiXam.Forms.Picker"/>
            /// </summary>
            Picker,

            /// <summary>
            /// Enables Gestures on the TimePicker Control
            /// <see cref="IndiXam.Forms.TimePicker"/>
            /// </summary>
            TimePicker,

            /// <summary>
            /// Enables Gestures on the WebView Control
            /// <see cref="IndiXam.Forms.WebView"/>
            /// </summary>
            WebView,

            /// <summary>
            /// Enables Gestures on the Label Control
            /// <see cref="IndiXam.Forms.Label"/>
            /// </summary>
            Label
        }
        
        /// <summary>
        /// Gets or sets list of controls to wire gestures to.
        /// </summary>
        internal static ControlToActuate[] ControlsToActuate
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes the GesturesLibrary by setting a static list of controls to wire to gestures.
        /// </summary>
        /// <param name="controlToActuate">List of controls to wire gestures on.</param>
        public static void Init(params ControlToActuate[] controlToActuate)
        {
            if (controlToActuate.Contains<ControlToActuate>(ControlToActuate.All))
            {
                GestureActuator.ControlsToActuate = Enum.GetValues(typeof(ControlToActuate))
                    .Cast<ControlToActuate>().ToArray();
            }
            else
            {
                GestureActuator.ControlsToActuate = controlToActuate;
            }
        }
    }
}
