// <copyright file="IndiScrollGestureRecognizer.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>
[module: System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:FileHeaderFileNameDocumentationMustMatchTypeName", Justification = "Reviewed.")]

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Xamarin.Forms;

    /// <summary>
    /// Indi scroll gesture recognizer.
    /// </summary>
    [SuppressMessage("Microsoft.StyleCop.CSharp.Maintainability", "SA1402:FileMayOnlyContainASingleClass", Justification = "Most Classes contain no Body and are easier to maintain in 1 file")] 
    public class IndiScrollGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IndiXam.Forms.Controls.GestureRecognizers.IndiScrollGestureRecognizer"/> class.
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
            get 
            {
                return this.Location;
            }

            set 
            {
                this.Location = value;
            }
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
