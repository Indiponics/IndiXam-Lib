// <copyright file="IIndiGestureRecognizer.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>
namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using Xamarin.Forms;

    /// <summary>
    /// Interface contract required on all GestureRecognizer to allow them to communicate with the listener.
    /// </summary>
    public interface IIndiGestureRecognizer : IGestureRecognizer
    {
        /// <summary>
        /// Gets or sets Location where the gesture Occurred in the case of motions this is equal to the start.
        /// </summary>
        /// <value>The location.</value>
        Point Location { get; set; }

        /// <summary>
        /// Method fired when the specified Gesture occurs.
        /// </summary>
        void OnActivated();
    }
}
