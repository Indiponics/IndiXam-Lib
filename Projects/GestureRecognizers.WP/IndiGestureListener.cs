using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Input;
using Xamarin.Forms;




namespace IndiXam.Forms.Controls.GestureRecognizers
{
    public class IndiGestureListener
    {
        Xamarin.Forms.View xamarinControl;
        System.Windows.FrameworkElement phoneControl;
        public IndiGestureListener(System.Windows.FrameworkElement phoneControl, Xamarin.Forms.View xamarinControl)
        {
            this.xamarinControl = xamarinControl;

            this.phoneControl = phoneControl;
            this.phoneControl.DoubleTap += uiElement_DoubleTap;
            this.phoneControl.Hold += uiElement_Hold;

            this.phoneControl.Tap += uiElement_Tap;
            this.phoneControl.ManipulationStarted += uiElement_ManipulationStarted;
            this.phoneControl.ManipulationCompleted += uiElement_ManipulationCompleted; 
        }

        List<System.Windows.Point> ManipulationEnds = new List<System.Windows.Point>();
        void uiElement_ManipulationCompleted(object sender, System.Windows.Input.ManipulationCompletedEventArgs e)
        {
            ManipulationEnds.Add(e.ManipulationOrigin);
            if(ManipulationStarts.Count == ManipulationEnds.Count)
            {
                if (ManipulationStarts.Count > 1)
                {
                    int startDistance = 0;
                    int endDistance = 0;

                    //todo:get distance between first two start points.                
                    //todo:get distance between first two end points.

                    if (startDistance > endDistance)
                    {
                        //todo:Pinch
                    }
                    else
                    {
                        //todo:Expand
                    }

                }

            }
        }

        List<System.Windows.Point> ManipulationStarts = new List<System.Windows.Point>();
        void uiElement_ManipulationStarted(object sender, System.Windows.Input.ManipulationStartedEventArgs e)
        {
            ManipulationStarts.Add(e.ManipulationOrigin);
            //Todo: Add Timer if manipulation doesnt complete in x secs reset;
        }

        void uiElement_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //this.OnTap(1);
        }

        void uiElement_Hold(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.SendActivated<IndiLongPressGestureRecognizer>(e.GetPosition(null));
        }

        void uiElement_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {

            //this.OnTap(2);
        }
        /// <summary>
        /// Sends the activated.
        /// </summary>
        /// <returns><c>true</c>, if activated was sent, <c>false</c> otherwise.</returns>
        /// <param name="e">Source of Gesture..</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        /// <returns>result of activation</returns>  
        private bool SendActivated<T>(System.Windows.Point point) where T : IIndiGestureRecognizer
        {
            if (this.xamarinControl == null || this.xamarinControl.GestureRecognizers == null
                || this.xamarinControl.GestureRecognizers.Count == 0)
            {
                return false;
            }

            IEnumerable<T> tfrList = this.xamarinControl.GestureRecognizers.OfType<T>();
            bool result = false;
            using (IEnumerator<T> enumerator = tfrList.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    enumerator.Current.Location = new Point(point.X, point.Y);
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
            if (this.xamarinControl == null)
            {
                return false;
            }

            IEnumerable<TapGestureRecognizer> tfrList = this.xamarinControl.GestureRecognizers.OfType<TapGestureRecognizer>().Where((tgr) => ((TapGestureRecognizer)tgr).NumberOfTapsRequired == tapCount);
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
                        sendTapped.Invoke(enumerator.Current, new object[] { this.xamarinControl });
                    }

                    result = true;
                }
            }

            return result;
        }
    }
}
