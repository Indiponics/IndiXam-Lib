// <copyright file="IndiGestureRecognizers.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Xamarin.Forms;

    /// <summary>
    /// Indi long press gesture recognizer.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed.")]
    public class IndiLongPressGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Indiponics.Forms.Controls.IndiGestureRecognizers.IndiLongPressGestureRecognizer"/> class.
        /// </summary>
        public IndiLongPressGestureRecognizer()
        {
        }
    }

 /// <summary>
 /// Used to respond to each tap in a doubletap event. This would only be useful in very rare situations. 
 /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed.")]
    public class IndiDoubleTapEventGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Indiponics.Forms.Controls.IndiGestureRecognizers.IndiDoubleTapEventGestureRecognizer"/> class.
        /// </summary>
        public IndiDoubleTapEventGestureRecognizer()
        {
        }
    }

    /// <summary>
    /// Indi single tap up gesture recognizer.
    /// </summary>
    public class IndiSingleTapUpGestureRecognizer : IndiGestureRecognizerBase
    {
       /// <summary>
       /// Initializes a new instance of the
       /// <see cref="Indiponics.Forms.Controls.IndiGestureRecognizers.IndiSingleTapUpGestureRecognizer"/> class.
       /// </summary>
        public IndiSingleTapUpGestureRecognizer()
        {
        }
    }

/// <summary>
/// Indi down gesture recognizer.
/// </summary>
    [SuppressMessage("Microsoft.StyleCop.CSharp.Maintainability", "SA1402:FileMayOnlyContainASingleClass", Justification = "Most Classes contain no Body and are easier to maintain in 1 file")] 
    public class IndiDownGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Indiponics.Forms.Controls.IndiGestureRecognizers.IndiDownGestureRecognizer"/> class.
        /// </summary>
        public IndiDownGestureRecognizer()
        {
        }
    }

    /// <summary>
    /// Indi show press gesture recognizer.
    /// </summary>
    [SuppressMessage("Microsoft.StyleCop.CSharp.Maintainability", "SA1402:FileMayOnlyContainASingleClass", Justification = "Most Classes contain no Body and are easier to maintain in 1 file")] 
    public class IndiShowPressGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Indiponics.Forms.Controls.IndiGestureRecognizers.IndiShowPressGestureRecognizer"/> class.
        /// </summary>
        public IndiShowPressGestureRecognizer()
        {
        }
    }

    /// <summary>
    /// Indi fling gesture recognizer.
    /// </summary>
    [SuppressMessage("Microsoft.StyleCop.CSharp.Maintainability", "SA1402:FileMayOnlyContainASingleClass", Justification = "Most Classes contain no Body and are easier to maintain in 1 file")] 
    public class IndiFlingGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Indiponics.Forms.Controls.IndiGestureRecognizers.IndiFlingGestureRecognizer"/> class.
        /// </summary>
        public IndiFlingGestureRecognizer()
        {
        }

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        public Point Start
        {
            get {return base.Location;} 
            set {Location = value;}
        }

        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        public Point End
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the velocity x.
        /// </summary>
        /// <value>The velocity x.</value>
        public double VelocityX
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the velocity y.
        /// </summary>
        /// <value>The velocity y.</value>
        public double VelocityY
        {
            get; 
            set;
        }
    }

    /// <summary>
    /// Indi scroll gesture recognizer.
    /// </summary>
    [SuppressMessage("Microsoft.StyleCop.CSharp.Maintainability", "SA1402:FileMayOnlyContainASingleClass", Justification = "Most Classes contain no Body and are easier to maintain in 1 file")] 
    public class IndiScrollGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Indiponics.Forms.Controls.IndiGestureRecognizers.IndiScrollGestureRecognizer"/> class.
        /// </summary>
        public IndiScrollGestureRecognizer()
        {
        }

        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        public Point Start
        {
            get {return base.Location;} 
            set {Location = value;}
        }


        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        public Point End
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the distance x.
        /// </summary>
        /// <value>The distance x.</value>
        public double DistanceX
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets the distance y.
        /// </summary>
        /// <value>The distance y.</value>
        public double DistanceY
        {
            get; 
            set;
        }
    }
}
