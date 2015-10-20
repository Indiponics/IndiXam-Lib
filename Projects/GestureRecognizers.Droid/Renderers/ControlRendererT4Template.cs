// <copyright file="IIndiGestureRecognizer.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

using Xamarin.Forms;
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
using Xamarin.Forms.Platform.Android;
using Android.Views;
using System.Linq;
using System.Collections.Generic;

	public class IndiImageRenderer:  ImageRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Image)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiTableViewRenderer:  TableViewRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<TableView> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((TableView)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiActivityIndicatorRenderer:  ActivityIndicatorRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<ActivityIndicator> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((ActivityIndicator)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiDatePickerRenderer:  DatePickerRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<DatePicker> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((DatePicker)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiEditorRenderer:  EditorRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Editor)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiEntryRenderer:  EntryRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Entry)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiProgressBarRenderer:  ProgressBarRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<ProgressBar> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((ProgressBar)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiSearchBarRenderer:  SearchBarRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<SearchBar> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((SearchBar)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiSliderRenderer:  SliderRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Slider> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Slider)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiStepperRenderer:  StepperRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Stepper> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Stepper)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiSwitchRenderer:  SwitchRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Switch> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Switch)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiBoxViewRenderer:  BoxViewRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<BoxView> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((BoxView)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiPickerRenderer:  PickerRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Picker> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Picker)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiTimePickerRenderer:  TimePickerRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<TimePicker> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((TimePicker)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiWebViewRenderer:  WebViewRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((WebView)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
	public class IndiLabelRenderer:  LabelRenderer
	{

		private GestureDetector gestureDetector;
		private IndiGestureListener gestureListener;
		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);
			if (e.NewElement == null) {
				this.GenericMotion -= HandleGenericMotion;
				this.Touch -= HandleTouch;
			}
			if (e.OldElement == null&& e.NewElement!=null) {
				gestureListener = new IndiGestureListener((Label)e.NewElement);
				gestureDetector = new GestureDetector(gestureListener);
				this.GenericMotion += HandleGenericMotion;
				this.Touch += HandleTouch;
			}
		}
		void HandleTouch (object sender, TouchEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
		void HandleGenericMotion (object sender, GenericMotionEventArgs e)
		{
			gestureDetector.OnTouchEvent (e.Event);
		}
	}
}