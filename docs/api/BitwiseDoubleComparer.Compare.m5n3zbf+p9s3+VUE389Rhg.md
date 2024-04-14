#### [Jcd.Units](index.md 'index')

### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison.md 'Jcd.Units.DoubleComparison').[BitwiseDoubleComparer](BitwiseDoubleComparer.md 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer')

## BitwiseDoubleComparer.Compare(double, double) Method

Compares two doubles by the compiler provided default. This carries with it all the concerns
of doing raw double comparisons. This is provided as a default mechanism to kickstart
operations. You should really implement and use your own comparer as per your application's needs.

```csharp
public int Compare(double x, double y);
```

#### Parameters

<a name='Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double,double).x'></a>

`x` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The left hand operand

<a name='Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double,double).y'></a>

`y` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the right hand operand

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
-1 if [x](BitwiseDoubleComparer.Compare.m5n3zbf+p9s3+VUE389Rhg.md#Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double,double).x 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double, double).x') is less than [y](BitwiseDoubleComparer.Compare.m5n3zbf+p9s3+VUE389Rhg.md#Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double,double).y 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double, double).y'),
0 if they're equal
1 if [x](BitwiseDoubleComparer.Compare.m5n3zbf+p9s3+VUE389Rhg.md#Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double,double).x 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double, double).x') is greater than [y](BitwiseDoubleComparer.Compare.m5n3zbf+p9s3+VUE389Rhg.md#Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double,double).y 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double, double).y')

### Remarks

[
Comparing
Floating Point Numbers 2012 Edition
](https://randomascii.wordpress.com/2012/02/25/comparing-floating-point-numbers-2012-edition/ 'https://randomascii.wordpress.com/2012/02/25/comparing-floating-point-numbers-2012-edition/')
by Bruce Dawson for a summary of considerations when comparing doubles and why this really isn't the class
to use for production code.