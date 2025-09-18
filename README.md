# Body Mass Index (IMC) Calculator

## Overview
This C# console application calculates and analyzes personal health metrics for multiple individuals, including Body Mass Index (IMC), age, and height.

## Key Features
- Input data for multiple people
- Validate personal information (name, height, weight, age)
- Find youngest person
- Identify tallest person
- Calculate Body Mass Index (IMC)
- Error handling for invalid inputs

## Input Validation
- Name must include a last name
- Height range: 0.4 - 2.3 meters
- Weight range: 2 - 250 kg
- Age range: 1 - 110 years
- Maximum 3 input attempts per person

## Method Workflow
1. Request number of people to process
2. Create parallel arrays for storing personal data
3. Collect individual information with validation
4. Calculate and display:
   - Youngest person
   - Tallest person
   - Person with highest Body Mass Index

## Code Structure
- Uses parallel arrays for data storage
- Implements nested error-handling loops
- Utilizes LINQ for min/max calculations
- Handles potential input errors gracefully

## Usage Example
```csharp
// Program will interactively prompt for:
// - Number of people
// - Individual details (name, height, weight, age)
```

## Performance Considerations
- O(n) time complexity
- Memory efficient with fixed-size arrays
- Simple error handling mechanism

## Potential Improvements
- Implement object-oriented approach
- Add more comprehensive input validation
- Create custom exception handling
- Support persistent data storage

## Health Metric Calculation
Body Mass Index (IMC) calculated using formula:
```
IMC = Weight (kg) / (Height (m))²
```

## Error Handling Strategy
- 3 attempts per data entry
- Skips entry if maximum errors exceeded
- Marks skipped entries as "No Capturo"
