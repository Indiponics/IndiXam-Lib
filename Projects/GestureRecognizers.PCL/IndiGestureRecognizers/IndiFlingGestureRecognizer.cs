// <copyright file="IndiFlingGestureRecognizer.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using IndiXam.Forms.Controls.GestureRecognizers;
    using Xamarin.Forms;
    
    /// <summary>
    /// Indi fling gesture recognizer.
    /// </summary>
    public class IndiFlingGestureRecognizer : IndiGestureRecognizerBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IndiXam.Forms.Controls.GestureRecognizers.IndiFlingGestureRecognizer"/> class.
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
}
