// <copyright file="IIndiGestureRecognizer.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

using Xamarin.Forms;
using IndiXam.Forms.Controls.GestureRecognizers;
 [assembly: ExportRenderer (typeof(Label), typeof(IndiLabelRenderer))]
 [assembly: ExportRenderer (typeof(Image), typeof(IndiImageRenderer))]
namespace IndiXam.Forms.Controls.GestureRecognizers
{
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using System.Linq;
using System.Collections.Generic;

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
}