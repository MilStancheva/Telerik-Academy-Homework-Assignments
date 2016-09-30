//Problem 11. Version attribute
//Create a[Version] attribute that can be applied to structures, classes, interfaces, 
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.

using System;

namespace Matrices
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | 
                    AttributeTargets.Interface |AttributeTargets.Method | 
                    AttributeTargets.Enum)]

    public class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public override string ToString()
        {
            return string.Format("Version {0}.{1}", this.Major, this.Minor);
        }
    }

}
