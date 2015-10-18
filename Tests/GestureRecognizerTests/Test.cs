// // <copyright file="" company="David Strickland">
// //     Copyright (c) David Strickland. The MIT License (MIT)
// // </copyright>
using NUnit.Framework;
using System;
using IndiXam.Forms.Controls.GestureRecognizers;
using Xamarin.Forms;

namespace IndiXam.Forms.Controls.GestureRecognizerTests
{
	class baseClassFake:IndiGestureRecognizerBase
	{
	}
	[TestFixture ()]
	public class GestureRecognizerTest
	{
		bool activated = false;
		[Test ()]
		public void GestureRecognizerTestActivate ()
		{
			testActivated <baseClassFake>();
		}
		[Test()]
		public void IndiDownGestureRecognizerTestActivate()
		{
			testActivated<IndiXam.Forms.Controls.GestureRecognizers.IndiDownGestureRecognizer>();
		}
		[Test()]
		public void IndiDoubleTapEventGestureRecognizerTestActivate()
		{
			testActivated<IndiXam.Forms.Controls.GestureRecognizers.IndiDoubleTapEventGestureRecognizer>();
		}
		[Test()]
		public void IndiFlingGestureRecognizerTestActivate()
		{
			testActivated<IndiXam.Forms.Controls.GestureRecognizers.IndiFlingGestureRecognizer>();
		}
		[Test()]
		public void IndiLongPressGestureRecognizerTestActivate()
		{
			testActivated<IndiXam.Forms.Controls.GestureRecognizers.IndiLongPressGestureRecognizer>();
		}
		[Test()]
		public void IndiScrollGestureRecognizerTestActivate()
		{
			testActivated<IndiXam.Forms.Controls.GestureRecognizers.IndiScrollGestureRecognizer>();
		}
		[Test()]
		public void IndiShowPressGestureRecognizerTestActivate()
		{
			testActivated<IndiXam.Forms.Controls.GestureRecognizers.IndiShowPressGestureRecognizer>();
		}
		[Test()]
		public void IndiSingleTapUpGestureRecognizerTestActivate()
		{
			testActivated<IndiXam.Forms.Controls.GestureRecognizers.IndiSingleTapUpGestureRecognizer>();
		}


		[Test()]
		public void TestNullActivate()
		{
			activated = false;
			var dc = new baseClassFake();
			dc.OnActivated();
			Assert.IsFalse(activated);
		}


		private void testActivated<T>() where T : IndiGestureRecognizerBase, new()
		{
			activated = false;
			var dc = new T();
			dc.Activated += (sender, e) =>
			{
				activated = true;
			};
			dc.OnActivated();
			Assert.IsTrue(activated);
		}

		[Test()]
		public void IndiDownGestureRecognizerTestLocation()
		{
			testLocation<IndiXam.Forms.Controls.GestureRecognizers.IndiDownGestureRecognizer>();
		}
		[Test()]
		public void IndiDoubleTapEventGestureRecognizerTestLocation()
		{
			testLocation<IndiXam.Forms.Controls.GestureRecognizers.IndiDoubleTapEventGestureRecognizer>();
		}
		[Test()]
		public void IndiFlingGestureRecognizerTestLocation()
		{
			testLocation<IndiXam.Forms.Controls.GestureRecognizers.IndiFlingGestureRecognizer>();
		}
		[Test()]
		public void IndiLongPressGestureRecognizerTestLocation()
		{
			testLocation<IndiXam.Forms.Controls.GestureRecognizers.IndiLongPressGestureRecognizer>();
		}
		[Test()]
		public void IndiScrollGestureRecognizerTestLocation()
		{
			testLocation<IndiXam.Forms.Controls.GestureRecognizers.IndiScrollGestureRecognizer>();
		}
		[Test()]
		public void IndiShowPressGestureRecognizerTestLocation()
		{
			testLocation<IndiXam.Forms.Controls.GestureRecognizers.IndiShowPressGestureRecognizer>();
		}
		[Test()]
		public void IndiSingleTapUpGestureRecognizerTestLocation()
		{
			testLocation<IndiXam.Forms.Controls.GestureRecognizers.IndiSingleTapUpGestureRecognizer>();
		}
		private void testLocation<T>() where T : IndiGestureRecognizerBase, new()
		{
			var dc = new T();
			dc.Location = new Point(1, 2);
			Assert.AreEqual(1,dc.Location.X);
			Assert.AreEqual(2, dc.Location.Y);
		}



		[Test()]
		public void IndiDownGestureRecognizerTestPropertyChanged()
		{
			testPropertyChanged<IndiXam.Forms.Controls.GestureRecognizers.IndiDownGestureRecognizer>();
		}
		[Test()]
		public void IndiDoubleTapEventGestureRecognizerTestPropertyChanged()
		{
			testPropertyChanged<IndiXam.Forms.Controls.GestureRecognizers.IndiDoubleTapEventGestureRecognizer>();
		}
		[Test()]
		public void IndiFlingGestureRecognizerTestPropertyChanged()
		{
			testPropertyChanged<IndiXam.Forms.Controls.GestureRecognizers.IndiFlingGestureRecognizer>();
		}
		[Test()]
		public void IndiLongPressGestureRecognizerTestPropertyChanged()
		{
			testPropertyChanged<IndiXam.Forms.Controls.GestureRecognizers.IndiLongPressGestureRecognizer>();
		}
		[Test()]
		public void IndiScrollGestureRecognizerTestPropertyChanged()
		{
			testPropertyChanged<IndiXam.Forms.Controls.GestureRecognizers.IndiScrollGestureRecognizer>();
		}
		[Test()]
		public void IndiShowPressGestureRecognizerTestPropertyChanged()
		{
			testPropertyChanged<IndiXam.Forms.Controls.GestureRecognizers.IndiShowPressGestureRecognizer>();
		}
		[Test()]
		public void IndiSingleTapUpGestureRecognizerTestPropertyChanged()
		{
			testPropertyChanged<IndiXam.Forms.Controls.GestureRecognizers.IndiSingleTapUpGestureRecognizer>();
		}

		string propertyName;
		private void testPropertyChanged<T>() where T : IndiGestureRecognizerBase, new()
		{
			propertyName = string.Empty;
			activated = false;
			var dc = new T();
			dc.PropertyChanged += (sender, e) =>
			{
				propertyName=e.PropertyName;
			};
			dc.Location=new Point(4,5);
			Assert.AreEqual("Location",propertyName);
		}        

		[Test]
		public void PropTestsIndiFlingGestureRecognizer()
		{
			var point1 = new Point (1, 1);
			var point2 = new Point (2, 2);
			float float1 = 1;
			float float2 = 2;

			IndiFlingGestureRecognizer ifgr = new IndiFlingGestureRecognizer ();

			ifgr.Start = point1;
			ifgr.End = point2;
			ifgr.VelocityX = 1;
			ifgr.VelocityY = 2;

			Assert.AreEqual (ifgr.Location,ifgr.Start);
			Assert.AreEqual (ifgr.Start, point1);
			Assert.AreEqual (ifgr.End, point2);
			Assert.AreEqual (ifgr.VelocityX, float1);
			Assert.AreEqual (ifgr.VelocityY, float2);

		}
		[Test]
		public void PropTestsIndiScrollGestureRecognizer()
		{
			var point1 = new Point (1, 1);
			var point2 = new Point (2, 2);
			float float1 = 1;
			float float2 = 2;

			IndiScrollGestureRecognizer ifgr = new IndiScrollGestureRecognizer ();

			ifgr.Start = point1;
			ifgr.End = point2;
			ifgr.DistanceX = float1;
			ifgr.DistanceY = float2;

			Assert.AreEqual (ifgr.Location,ifgr.Start);
			Assert.AreEqual (ifgr.Start, point1);
			Assert.AreEqual (ifgr.End, point2);
			Assert.AreEqual (ifgr.DistanceX, float1);
			Assert.AreEqual (ifgr.DistanceY, float2);

		}
	}
}

