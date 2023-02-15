using System;

namespace Jcd.Units;

public interface IUnitOfMeasure<TUnits> 
    : IComparable<TUnits>, 
      IComparable
{
    string Name { get; }
    string Abbreviation { get; }
    double Coefficient { get; }
    double Offset { get; }
}