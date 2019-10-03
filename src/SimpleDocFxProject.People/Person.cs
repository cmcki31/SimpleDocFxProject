using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDocFxProject.People
{
    /// <summary>
    /// Person
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Last Name
        /// </summary>
        public string LastName { get; set; }
    }
}
