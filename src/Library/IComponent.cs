using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    // The Component interface declares an `accept` method that should take the
    // base visitor interface as an argument.


    // Each Concrete Component must implement the `Accept` method in such a way
    // that it calls the visitor's method corresponding to the component's
    // class.
    public interface IComponent <T>
    {
        void Accept(IVisitor<T> visitor);
    }
}