# User Manual

This library provide type-safe unit of measure aware quantity arithmetic, comparison and an
extensive, but non-exhaustive, unit of measure catalog. Extension methods to reduce the cognitive
load associated with reading the code exist and are the preferred approach to interfacing with this
library.

The intended audience for this library, and this manual, are software engineers who need or want to
simplify some of the concerns surrounding unit of measure conversions, especially when dealing with
non SI or Metric units. For example converting from degrees Rankine (`°K = °R × 5/9`) to degrees Fahrenheit (`°C = (°F - 32) × 5/9`) or US Customary quarts (`946.352946 mL`) to British Imperial quarts (`1136.5225 mL`).

## Table of Contents
- [Quick Facts](quick-facts.md) - Covers some basic facts about the library.
- [Quick Start](quick-start.md) - Is essentially a cheat sheet for select use cases.
- [Mathematical Derivations For Selecting A Coefficient and Offset](mathematical-derivations.md) - Walks the reader through selecting a proper Coefficient and Offset when faced with a conversion formula belonging to one of several well known forms.