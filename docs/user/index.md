# User Manual

This library provide type-safe unit of measure aware quantity arithmetic, comparison and an extensive, but non-exhaustive, unit of measure catalog. Extension methods are provided to reduce the cognitive load associated with reading the code and are the preferred approach to interfacing with this library. Most examples you encounter will use these.

The intended audience for this library, and this manual, are software engineers who need or want to simplify some of the concerns surrounding unit of measure conversions, especially when dealing with non-SI/Metric units. For example converting from degrees Rankine (`°K = °R × 5/9`) to degrees Fahrenheit (`°C = (°F - 32) × 5/9`) or US Customary quarts (`946.352946 mL`) to Imperial quarts (`1136.5225 mL`).

## Table of Contents
- [Quick Start](quick-start.md)
- [Quick Facts](quick-facts.md)
- [Ch 1. Getting Started](ch1/index.md)
- [Ch 2. Basic Usage](ch2/index.md)
- [Ch 3. Advanced Usage](ch3/index.md)
- [Ch 4. Limitations and Performance Considerations](ch4/index.md)
- [Ch 5. Generating Code with `unit-gen.exe`](ch5/index.md)
- [Index 1 - Built-In Units of Measure](index1/index.md)
- [Mathematical Derivations For Selecting A Coefficient and Offset](mathematical-derivations.md)