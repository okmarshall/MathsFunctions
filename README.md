
# MathsFunctions

## Functionality

### Arithmetic Mean
Calculates the mean of an array of doubles

    var numbers = new double[] { ... }
    var functions = new Functions();            
    var mean = functions.Mean(numbers);

### Standard Deviation
Calculates the standard deviation of an array of doubles

	var numbers = new double[] { ... }
    var functions = new Functions();
    var standardDeviation = functions.StandardDeviation(numbers);

### Frequency Distribution
Calculates the frequency distribution of an array of doubles

    var numbers = new double[] { ... };
    var functions = new Functions();
    var frequencyBins = functions.CalculateFrequencyBins(numbers);
