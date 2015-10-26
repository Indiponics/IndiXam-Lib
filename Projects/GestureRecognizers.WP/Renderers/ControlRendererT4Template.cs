// <copyright file="IIndiGestureRecognizer.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

using Xamarin.Forms;
using IndiXam.Forms.Controls;
using IndiXam.Forms.Controls.GestureRecognizers;
using GestureRecognizers.Droid.Renderers;

 [assembly: ExportRenderer (typeof(Image), typeof(IndiImageRenderer))]
 [assembly: ExportRenderer (typeof(TableView), typeof(IndiTableViewRenderer))]
 [assembly: ExportRenderer (typeof(ActivityIndicator), typeof(IndiActivityIndicatorRenderer))]
 [assembly: ExportRenderer (typeof(DatePicker), typeof(IndiDatePickerRenderer))]
 [assembly: ExportRenderer (typeof(Editor), typeof(IndiEditorRenderer))]
 [assembly: ExportRenderer (typeof(Entry), typeof(IndiEntryRenderer))]
 [assembly: ExportRenderer (typeof(ProgressBar), typeof(IndiProgressBarRenderer))]
 [assembly: ExportRenderer (typeof(SearchBar), typeof(IndiSearchBarRenderer))]
 [assembly: ExportRenderer (typeof(Slider), typeof(IndiSliderRenderer))]
 [assembly: ExportRenderer (typeof(Stepper), typeof(IndiStepperRenderer))]
 [assembly: ExportRenderer (typeof(Switch), typeof(IndiSwitchRenderer))]
 [assembly: ExportRenderer (typeof(BoxView), typeof(IndiBoxViewRenderer))]
 [assembly: ExportRenderer (typeof(Picker), typeof(IndiPickerRenderer))]
 [assembly: ExportRenderer (typeof(TimePicker), typeof(IndiTimePickerRenderer))]
 [assembly: ExportRenderer (typeof(WebView), typeof(IndiWebViewRenderer))]
 [assembly: ExportRenderer (typeof(Label), typeof(IndiLabelRenderer))]
namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using Xamarin.Forms;
    using System.Linq;
    using System.Collections.Generic;
    using Xamarin.Forms.Platform.WinPhone;

	public class IndiImageRenderer:  ImageRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Image> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Image))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiTableViewRenderer:  TableViewRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.TableView> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.TableView))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiActivityIndicatorRenderer:  ActivityIndicatorRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ActivityIndicator> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.ActivityIndicator))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiDatePickerRenderer:  DatePickerRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.DatePicker))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiEditorRenderer:  EditorRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Editor> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Editor))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiEntryRenderer:  EntryRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Entry))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiProgressBarRenderer:  ProgressBarRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.ProgressBar))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiSearchBarRenderer:  SearchBarRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.SearchBar> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.SearchBar))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiSliderRenderer:  SliderRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Slider> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Slider))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiStepperRenderer:  StepperRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Stepper> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Stepper))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiSwitchRenderer:  SwitchRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Switch> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Switch))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiBoxViewRenderer:  BoxViewRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.BoxView> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.BoxView))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiPickerRenderer:  PickerRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Picker> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Picker))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiTimePickerRenderer:  TimePickerRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.TimePicker> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.TimePicker))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiWebViewRenderer:  WebViewRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.WebView> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.WebView))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
	public class IndiLabelRenderer:  LabelRenderer
	{
        IndiGestureListener gestureListener; 
		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged (e);
			if(GestureActuator.controlsToActuate
			.Contains<GestureActuator.ControlToActuate>(GestureActuator.ControlToActuate.Label))
			{
				if (e.NewElement == null) {
					gestureListener = null;
				}
				if (e.OldElement == null&& e.NewElement!=null) {

					gestureListener = new IndiGestureListener(this.Control, e.NewElement);
				}
			}
		}
	}
}