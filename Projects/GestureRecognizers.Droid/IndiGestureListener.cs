// <copyright file="IndiGestureListener.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Android.Runtime;
    using Android.Views;
    using IndiXam.Forms.Controls.GestureRecognizers;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    /// <summary>
    /// Indi gesture listener.
    /// </summary>
    public class IndiGestureListener : GestureDetector.SimpleOnGestureListener 
    {
        /// <summary>
        /// The Forms Object that contains the GestureRecognizers to Invoke.
        /// </summary>
        private Xamarin.Forms.View target;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IndiXam.Forms.Controls.GestureRecognizers.IndiGestureListener"/> class.
        /// </summary>
        /// <param name="control">Control that will raise the events from gestures performed on it.</param>
        public IndiGestureListener(Xamarin.Forms.View control)
        {
            this.target = control;
        }

        /// <summary>
        /// Raises the long press event.
        /// </summary>
        /// <param name="e">Source of Gesture.</param>
        public override void OnLongPress(MotionEvent e)
        {
            this.SendActivated<IndiLongPressGestureRecognizer>(e);
        }

        /// <summary>
        /// Raises the double tap event. Because windows phone fires both a tap and double tap event 
        /// OnDoubleTap this functionality was emulated here for consistency.
        /// </summary>
        /// <param name="e">Source of Gesture.</param>
        /// <returns>result of activation</returns>  
        public override bool OnDoubleTap(MotionEvent e)
        {
            return this.OnTap(1) && this.OnTap(2);
        }

        /// <summary>
        /// Raises the fling event.
        /// </summary>
        /// <param name="e1">Location Gesture Started.</param>
        /// <param name="e2">Location Gesture Ended.</param>
        /// <param name="velocityX">Velocity on Horizontal</param>
        /// <param name="velocityY">Velocity on Vertical</param>
        /// <returns>result of activation</returns>  
        public override bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
        {
            if (this.target == null || this.target.GestureRecognizers == null 
                || this.target.GestureRecognizers.Count == 0) 
            {
            return false;
            }

            IEnumerable<IndiFlingGestureRecognizer> tfrList = this.target.GestureRecognizers.OfType<IndiFlingGestureRecognizer>();
            bool result = false;
            using (IEnumerator<IndiFlingGestureRecognizer> enumerator = tfrList.GetEnumerator()) 
            {
                while (enumerator.MoveNext()) 
                {
                    enumerator.Current.Location = new Point(e1.RawX, e1.RawY);
                    enumerator.Current.Start = new Point(e1.RawX, e1.RawY);
                    enumerator.Current.End = new Point(e2.RawX, e2.RawY);
                    enumerator.Current.VelocityX = velocityX;
                    enumerator.Current.VelocityY = velocityY;
                    enumerator.Current.OnActivated();
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Raises the scroll event.
        /// </summary>
        /// <param name="e1">Location Gesture Started.</param>
        /// <param name="e2">Location Gesture Ended.</param>
        /// <param name="distanceX">Distance x.</param>
        /// <param name="distanceY">Distance y.</param>
        /// <returns>result of activation</returns>  
        public override bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
        {
            if (this.target == null || this.target.GestureRecognizers == null 
                || this.target.GestureRecognizers.Count == 0) 
            {
                return false;
            }

            IEnumerable<IndiScrollGestureRecognizer> tfrList = this.target.GestureRecognizers.OfType<IndiScrollGestureRecognizer>();
            bool result = false;
            using (IEnumerator<IndiScrollGestureRecognizer> enumerator = tfrList.GetEnumerator()) 
            {
                while (enumerator.MoveNext()) 
                {
                    enumerator.Current.Location = new Point(e1.RawX, e1.RawY);
                    enumerator.Current.Start = new Point(e1.RawX, e1.RawY);
                    enumerator.Current.End = new Point(e2.RawX, e2.RawY);
                    enumerator.Current.DistanceX = distanceX;
                    enumerator.Current.DistanceY = distanceY;
                    enumerator.Current.OnActivated();
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Raises the single tap confirmed event.
        /// </summary>
        /// <param name="e">Source of Gesture..</param>
        /// <returns>result of activation</returns>  
        public override bool OnSingleTapConfirmed(MotionEvent e)
        {
            return this.OnTap(1);
        }

        /// <summary>
        /// Sends the activated.
        /// </summary>
        /// <returns><c>true</c>, if activated was sent, <c>false</c> otherwise.</returns>
        /// <param name="e">Source of Gesture..</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        /// <returns>result of activation</returns>  
        private bool SendActivated<T>(MotionEvent e) where T : IIndiGestureRecognizer
        {
            if (this.target == null || this.target.GestureRecognizers == null 
                || this.target.GestureRecognizers.Count == 0)
            {
                return false;
            }

            IEnumerable<T> tfrList = this.target.GestureRecognizers.OfType<T>();
            bool result = false;
            using (IEnumerator<T> enumerator = tfrList.GetEnumerator())    
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.Location = new Point(e.RawX, e.RawY);
                    enumerator.Current.OnActivated();
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Raises the tap event.
        /// </summary>
        /// <param name="tapCount">Tap count.</param>
        /// <returns>result of activation</returns>  
        private bool OnTap(int tapCount)
        {
            if (this.target == null) 
            {
            return false;
            }

            IEnumerable<TapGestureRecognizer> tfrList = this.target.GestureRecognizers.OfType<TapGestureRecognizer>().Where((tgr) => ((TapGestureRecognizer)tgr).NumberOfTapsRequired == tapCount);
            bool result = false;
            using (IEnumerator<TapGestureRecognizer> enumerator = tfrList.GetEnumerator()) 
            {
            while (enumerator.MoveNext()) 
                {
                 // --
                // BAD SCARY CODE BUT REQUIRED DUE TO THE XAMARIN IMPLEMENTATION
               // --
                    MethodInfo sendTapped = typeof(TapGestureRecognizer).GetMethod("SendTapped", BindingFlags.NonPublic | BindingFlags.Instance);
                    if (sendTapped != null) 
                    {
                        sendTapped.Invoke(enumerator.Current, new object[] { this.target });
                    } 

                result = true;
               }
            }

            return result;
        }
    }
}
