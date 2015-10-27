// <copyright file="ControlRendererT4Template1.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

using GestureRecognizers.Droid.Renderers;
using IndiXam.Forms.Controls.GestureRecognizers;
using Xamarin.Forms;

[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed.")]

[assembly: ExportRenderer(typeof(Image), typeof(IndiImageRenderer))]
[assembly: ExportRenderer(typeof(TableView), typeof(IndiTableViewRenderer))]
[assembly: ExportRenderer(typeof(ActivityIndicator), typeof(IndiActivityIndicatorRenderer))]
[assembly: ExportRenderer(typeof(DatePicker), typeof(IndiDatePickerRenderer))]
[assembly: ExportRenderer(typeof(Editor), typeof(IndiEditorRenderer))]
[assembly: ExportRenderer(typeof(Entry), typeof(IndiEntryRenderer))]
[assembly: ExportRenderer(typeof(ProgressBar), typeof(IndiProgressBarRenderer))]
[assembly: ExportRenderer(typeof(SearchBar), typeof(IndiSearchBarRenderer))]
[assembly: ExportRenderer(typeof(Slider), typeof(IndiSliderRenderer))]
[assembly: ExportRenderer(typeof(Stepper), typeof(IndiStepperRenderer))]
[assembly: ExportRenderer(typeof(Switch), typeof(IndiSwitchRenderer))]
[assembly: ExportRenderer(typeof(BoxView), typeof(IndiBoxViewRenderer))]
[assembly: ExportRenderer(typeof(Picker), typeof(IndiPickerRenderer))]
[assembly: ExportRenderer(typeof(TimePicker), typeof(IndiTimePickerRenderer))]
[assembly: ExportRenderer(typeof(WebView), typeof(IndiWebViewRenderer))]
[assembly: ExportRenderer(typeof(Label), typeof(IndiLabelRenderer))]

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Android.Views;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    /// <summary>
    /// Wires up Gestures to the Image Control
    /// </summary>
    public class IndiImageRenderer : ImageRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Image))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Image)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the TableView Control
    /// </summary>
    public class IndiTableViewRenderer : TableViewRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.TableView))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((TableView)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the ActivityIndicator Control
    /// </summary>
    public class IndiActivityIndicatorRenderer : ActivityIndicatorRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<ActivityIndicator> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.ActivityIndicator))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((ActivityIndicator)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the DatePicker Control
    /// </summary>
    public class IndiDatePickerRenderer : DatePickerRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.DatePicker))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((DatePicker)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the Editor Control
    /// </summary>
    public class IndiEditorRenderer : EditorRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Editor))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Editor)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the Entry Control
    /// </summary>
    public class IndiEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Entry))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Entry)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the ProgressBar Control
    /// </summary>
    public class IndiProgressBarRenderer : ProgressBarRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.ProgressBar))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((ProgressBar)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the SearchBar Control
    /// </summary>
    public class IndiSearchBarRenderer : SearchBarRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.SearchBar))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((SearchBar)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the Slider Control
    /// </summary>
    public class IndiSliderRenderer : SliderRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Slider))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Slider)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the Stepper Control
    /// </summary>
    public class IndiStepperRenderer : StepperRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Stepper> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Stepper))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Stepper)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the Switch Control
    /// </summary>
    public class IndiSwitchRenderer : SwitchRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Switch> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Switch))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Switch)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the BoxView Control
    /// </summary>
    public class IndiBoxViewRenderer : BoxViewRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.BoxView))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((BoxView)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the Picker Control
    /// </summary>
    public class IndiPickerRenderer : PickerRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Picker))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Picker)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the TimePicker Control
    /// </summary>
    public class IndiTimePickerRenderer : TimePickerRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.TimePicker))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((TimePicker)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the WebView Control
    /// </summary>
    public class IndiWebViewRenderer : WebViewRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.WebView))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((WebView)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }

    /// <summary>
    /// Wires up Gestures to the Label Control
    /// </summary>
    public class IndiLabelRenderer : LabelRenderer
    {
        /// <summary>
        /// Gesture translates the events identified by the listener
        /// </summary>
        private GestureDetector gestureDetector;

        /// <summary>
        /// Contains the event handlers used by the platform control to notify the  VM of the events that are occurring.
        /// </summary>
        private IndiGestureListener gestureListener;

        /// <summary>
        /// Method called when the underlying ViewElement Changes.
        /// </summary>
        /// <param name="e">Passes information about the element that changed.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (GestureActuator.ControlsToActuate
            .Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Label))
            {
                if (e.NewElement == null) 
                {
                    this.GenericMotion -= this.HandleGenericMotion;
                    this.Touch -= this.HandleTouch;
                }

                if (e.OldElement == null && e.NewElement != null) 
                {
                    this.gestureListener = new IndiGestureListener((Label)e.NewElement);
                    this.gestureDetector = new GestureDetector(this.gestureListener);
                    this.GenericMotion += this.HandleGenericMotion;
                    this.Touch += this.HandleTouch;
                }
            }
        }

        /// <summary>
        /// Handles the Touch Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleTouch(object sender, TouchEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }

        /// <summary>
        /// Handles the Generic Motion Events that occur.
        /// </summary>
        /// <param name="sender">The object that raised the event</param>
        /// <param name="e">Information about the Touch event</param>
        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            this.gestureDetector.OnTouchEvent(e.Event);
        }
    }
}