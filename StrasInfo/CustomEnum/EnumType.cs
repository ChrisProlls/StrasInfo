using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrasInfo.CustomEnum
{
    using StrasInfo.ViewModels;

    public class EnumType
    {
        

        /// <summary>
        /// Gets the trace.
        /// </summary>
        public static EnumType HomeView
        {
            get
            {
                return new EnumType(typeof(HomeViewModel));
            }
        }

        /// <summary>
        /// Gets the trafic view.
        /// </summary>
        public static EnumType TraficView
        {
            get
            {
                return new EnumType(typeof(TraficViewModel));
            }
        }

        /// <summary>
        /// Gets the favoris view.
        /// </summary>
        public static EnumType TransportView
        {
            get
            {
                return new EnumType(typeof(TransportViewModel));
            }
        }

        /// <summary>
        /// Gets the categories view.
        /// </summary>
        public static EnumType CategoriesView
        {
            get
            {
                return new EnumType(typeof(FakeType));
            }
        }

        /// <summary>
        /// Gets the a propos view.
        /// </summary>
        public static EnumType AProposView
        {
            get
            {
                return new EnumType(typeof(FakeType));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumType"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        private EnumType(Type value)
        {
            Value = value;
        }

        public EnumType() { }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public Type Value { get; private set; }
    }

    internal class FakeType
    {
    }
}
